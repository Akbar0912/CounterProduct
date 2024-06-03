using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CounterProduct.Models;
using CounterProduct.Presenters;
using CounterProduct.Repository;
using CounterProduct.View;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using static CounterProduct.View.IHomeView;

namespace CounterProduct.Presenter
{
    public class CounterPresenter
    {
        private readonly IHomeView _homeView;
        private readonly IAddData _addRepo;
        private readonly List<PlanModel> _plans;

        private System.Windows.Forms.Timer _timer;
        private TCPConnection _connection;

        private int _counter = 0; // The number of 20-second cycles that have passed
        private int _elapsedTime = 0; // The elapsed time in seconds
        private int _currentRowIndex;
        private int _countdownTime;

        public CounterPresenter(IHomeView view, List<PlanModel> plans)
        {
            _homeView = view;
            _plans = plans;
            _addRepo = new AddData();

            _homeView.CellClicked += CellClicked;

            InitializeHomeView();
            InitializeTimer();
            InitializeTCPConnectionAsync();
        }

        private void InitializeHomeView()
        {
            _homeView.SetPlanBindingSource(new BindingSource { DataSource = _plans });

            // Initialize the countdown time for the first plan
            if (_plans.Count > 0)
            {
                _countdownTime = (int)_plans[_currentRowIndex].Time.TotalSeconds;
            }

            UpdateTotalPlan();
        }

        private async Task InitializeTCPConnectionAsync()
        {
            _connection = new TCPConnection(GetModelCode, GetSerial);
            await _connection.ConnectToServerAsync();
        }

        private void InitializeTimer()
        {
            _timer = new System.Windows.Forms.Timer();
            _timer.Interval = 1000; // Interval 1 detik
            _timer.Tick += Timer_Tick;
            _timer.Start();
        }

        private bool CheckTimeAndStartTimer()
        {
            var currentTime = DateTime.Now;
            var startTime = new TimeSpan(08, 27, 0); // 2:00 PM

            if (currentTime.TimeOfDay >= startTime)
            {

                return true;
            }
            else
            {
                return false;
            }
        }

        public void RefreshTCP()
        {
            MessageBox.Show("refresh");
            InitializeTCPConnectionAsync();
        }

        private void GetModelCode(string data)
        {
            // Handle the data received for model code
            string getModelCode = data;
        }

        private void GetSerial(string data)
        {
            // Handle the data received for serial
            string getSerial = data;
        }

        private void UpdateTotalPlan()
        {
            int totalPlan = _plans.Sum(p => p.Plan);
            _homeView.TotalPlan = totalPlan.ToString();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            var currentTime = DateTime.Now;
            _homeView.CurrentTime = currentTime.ToLongTimeString();
            _homeView.CurrentDate = currentTime.ToLongDateString();
            _homeView.Countdown = TimeSpan.FromSeconds(_countdownTime).ToString(@"hh\:mm\:ss");

            if (CheckTimeAndStartTimer())
            {
                if (HandleTimerStopping(currentTime))
                {
                    _elapsedTime++;
                    _countdownTime--;

                    if (_countdownTime <= 0)
                    {
                        _counter++;
                        _homeView.Counter = _counter.ToString();
                        UpdateTargetColumn();
                    }
                }
            }
        }

        private bool HandleTimerStopping(DateTime currentTime)
        {
            if ((currentTime.Hour == 9 && currentTime.Minute == 0) || (currentTime.Hour == 9 && currentTime.Minute < 2))
            {
                return false;
            }

            // Jika tidak memenuhi kedua kondisi di atas
            return true;
        }

        private void UpdateTargetColumn()
        {
            if (_currentRowIndex < _plans.Count)
            {
                var currentPlan = _plans[_currentRowIndex];

                if (currentPlan.Target < currentPlan.Plan)
                {
                    currentPlan.Target++;
                }
                else
                {
                    MoveToNextPlan();
                }

                ResetCountdownTime();
                AddCurrentPlanToRepository(currentPlan);
            }

            // Reset bindings to refresh the DataGridView
            ((BindingSource)_homeView.GetPlanBindingSource()).ResetBindings(false);

            UpdateTotalPlan();
        }

        private void CellClicked(object sender, CellClickedEventArgs e)
        {
            DataGridViewRow selectedRow = e.SelectedRow;
            DialogResult result = MessageBox.Show("Apakah Anda yakin ingin mengganti ke plan ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // User clicked Yes
                //MessageBox.Show("Anda memilih Yes");
                _currentRowIndex = selectedRow.Index;
                _countdownTime = (int)_plans[_currentRowIndex].Time.TotalSeconds;
            }
            else if (result == DialogResult.No)
            {
                // User clicked No
                MessageBox.Show("Anda memilih No");
            }
        }

        private void MoveToNextPlan()
        {
            _currentRowIndex++;
            if (_currentRowIndex < _plans.Count)
            {
                _countdownTime = (int)_plans[_currentRowIndex].Time.TotalSeconds;
                _plans[_currentRowIndex].Target++;
            }
        }

        private void ResetCountdownTime()
        {
            if (_currentRowIndex < _plans.Count)
            {
                _countdownTime = (int)_plans[_currentRowIndex].Time.TotalSeconds;
            }
        }

        private void AddCurrentPlanToRepository(PlanModel currentPlan)
        {
            var model = new PlanModel
            {
                Id = currentPlan.Id,
                Date = currentPlan.Date,
                Sequence = currentPlan.Sequence,
                ModelCode = currentPlan.ModelCode,
                Plan = currentPlan.Plan,
                Target = currentPlan.Target,
                Balancing = currentPlan.Balancing,
                Actual = currentPlan.Actual
            };

            _addRepo.Add(model);
        }
    }
}
