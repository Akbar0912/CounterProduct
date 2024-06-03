using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CounterProduct.View
{
    public interface IHomeView
    {
        string CurrentTime { set; }
        string CurrentDate { set; }
        string Counter { set; }
        string Countdown { set; }
        string TotalPlan { set; }

        event EventHandler<CellClickedEventArgs> CellClicked;

        void SetPlanBindingSource(BindingSource model);
        BindingSource GetPlanBindingSource();

        public class CellClickedEventArgs : EventArgs
        {
            public DataGridViewRow SelectedRow { get; }

            public CellClickedEventArgs(DataGridViewRow selectedRow)
            {
                SelectedRow = selectedRow;
            }
        }

    }
}
