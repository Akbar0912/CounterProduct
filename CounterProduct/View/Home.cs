using CounterProduct.Models;
using CounterProduct.Presenter;
using CounterProduct.Presenters;
using CounterProduct.Repository;
using CounterProduct.View;
using static CounterProduct.View.IHomeView;

namespace CounterProduct
{
    public partial class Home : Form, IHomeView
    {
        private CounterPresenter _presenter;
        private loadData _dataPresenter;
        private BindingSource planBindingSource = new BindingSource();
        public Home()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();

            IPlanRepository planRepository = new GetData();
            _dataPresenter = new loadData(this, planRepository);

            var plans = (List<PlanModel>)planBindingSource.DataSource;
            _presenter = new CounterPresenter(this, plans);
        }

        public string CurrentTime
        {
            set { Time.Text = value; }
        }
        public string CurrentDate
        {
            set { Date.Text = value; }
        }
        public string Counter
        {
            set { labelCounter.Text = value; }
        }

        public string Countdown 
        {
            set { LabelCountdown.Text = value; }
        }

        public string TotalPlan 
        {
            set { labelPlan.Text = value; }
        }

        public event EventHandler<CellClickedEventArgs> CellClicked;

        public BindingSource GetPlanBindingSource()
        {
            return planBindingSource;
        }

        public void SetPlanBindingSource(BindingSource model)
        {
            planBindingSource = model;
            dataGridView1.DataSource = model;
        }

        private void AssociateAndRaiseViewEvents()
        {
            btnSetting.Click += delegate
            {
                ISettingView settingView = Setting.GetInstance();
                SettingPresenter settingPresenter = new SettingPresenter(settingView, new SettingModel());
                (settingView as Form)?.Show();
            };

            dataGridView1.CellContentClick += (sender, e) =>
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                CellClicked?.Invoke(this, new CellClickedEventArgs(selectedRow));
            };
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
