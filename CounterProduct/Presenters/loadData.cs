using CounterProduct.Models;
using CounterProduct.Repository;
using CounterProduct.View;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CounterProduct.Presenter
{
    public class loadData
    {
        private readonly IHomeView _homeView;
        private BindingSource dataBindingSource = new BindingSource();
        private IPlanRepository PlanRepository;
        private IEnumerable<PlanModel> _model;
        public TimeSpan CycleTime { get; private set; }
        public loadData(IHomeView view, IPlanRepository planRepository)
        {
            this._homeView = view;
            PlanRepository = planRepository;
            this._homeView.SetPlanBindingSource(dataBindingSource);
            LoadAllDefectList();
        }

        private void LoadAllDefectList()
        {
            _model = PlanRepository.GetAll();
            dataBindingSource.DataSource = _model;

            if (_model.Any())
            {
                // Ambil cycletime dari item pertama sebagai contoh
                CycleTime = _model.First().Time;
            }
        }
    }
}
