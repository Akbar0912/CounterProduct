﻿using CounterProduct.View;
using CounterProduct.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CounterProduct.Presenter
{
    public class CounterPresenter
    {
        private readonly IHomeView _homeView;
        private int _counter = 0; // This is the number of 20-second cycles that have passed
        private int _elapsedTime = 0; // The elapsed time in seconds
        private System.Windows.Forms.Timer _timer;
        private int _currentRowIndex = 0;
        private int _countdownTime;
        private List<PlanModel> _plans;

        public CounterPresenter(IHomeView view, List<PlanModel> plans)
        {
            _homeView = view;
            _plans = plans;
            _homeView.SetPlanBindingSource(new BindingSource { DataSource = _plans });

            // Initialize the countdown time for the first plan
            if (_plans.Count > 0)
            {
                _countdownTime = (int)_plans[_currentRowIndex].Time.TotalSeconds;
            }

            updateTotalPlan();

            InitializeTimer();
        }

        private void updateTotalPlan()
        {
            int totalPlan = _plans.Sum(p => p.Plan);
            _homeView.TotalPlan = totalPlan.ToString();
        }

        private void InitializeTimer()
        {
            _timer = new System.Windows.Forms.Timer();
            _timer.Interval = 1000; // 1 second
            _timer.Tick += Timer_Tick;
            _timer.Start();
        }


        private void Timer_Tick(object sender, EventArgs e)
        {
            _elapsedTime++;
            _countdownTime--;

            _homeView.CurrentTime = DateTime.Now.ToLongTimeString();
            _homeView.CurrentDate = DateTime.Now.ToLongDateString();
            _homeView.Countdown = TimeSpan.FromSeconds(_countdownTime).ToString(@"hh\:mm\:ss");

            if (_countdownTime <= 0)
            {
                _counter++;
                _homeView.Counter = _counter.ToString();
                UpdateTargetColumn();
            }
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
                    // Move to the next plan sequence
                    _currentRowIndex++;
                    if (_currentRowIndex < _plans.Count)
                    {
                        _countdownTime = (int)_plans[_currentRowIndex].Time.TotalSeconds;
                        _plans[_currentRowIndex].Target++;
                    }
                }

                // Reset the countdown time for the current plan's cycle
                if (_currentRowIndex < _plans.Count)
                {
                    _countdownTime = (int)_plans[_currentRowIndex].Time.TotalSeconds;
                }
            }

            // Reset bindings to refresh the DataGridView
            var bindingSource = (BindingSource)_homeView.GetPlanBindingSource();
            bindingSource.ResetBindings(false);

            updateTotalPlan();
        }
    }
}