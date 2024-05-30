using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CounterProduct.Models
{
    public class PlanModel
    {
        public int id;
        public DateOnly date;
        public int sequence;
        public string modelCode;
        public int plan;
        public int target;
        public int balancing;
        public int actual;
        private TimeSpan time;

        [Browsable(false)]
        public int Id 
        { 
            get => id; 
            set => id = value; 
        }

        [DisplayName("Date")]
        public DateOnly Date 
        { 
            get => date; 
            set => date = value; 
        }

        [Browsable(false)]
        public int Sequence 
        { 
            get => sequence; 
            set => sequence = value; 
        }

        [DisplayName("Model Code")]
        public string ModelCode 
        { 
            get => modelCode; 
            set => modelCode = value; 
        }

        [DisplayName("Plan")]
        public int Plan 
        { 
            get => plan; 
            set => plan = value; 
        }

        [DisplayName("Target")]
        public int Target 
        { 
            get => target; 
            set => target = value; 
        }

        [Browsable(false)]
        public int Balancing 
        { 
            get => balancing; 
            set => balancing = value; 
        }

        [DisplayName("Actual")]
        public int Actual 
        { 
            get => actual; 
            set => actual = value; 
        }

        [DisplayName("Time")]
        public TimeSpan Time 
        { 
            get => time; 
            set => time = value; 
        }
    }
}
