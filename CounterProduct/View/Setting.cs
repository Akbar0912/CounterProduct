using CounterProduct.Models;
using CounterProduct.Presenter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CounterProduct.View
{
    public partial class Setting : Form, ISettingView
    {
        public Setting()
        {
            InitializeComponent();
            InitializeEventHandler();
        }

        public string ipaddress
        {
            get => textBoxIP.Text;
            set => textBoxIP.Text = value;
        }
        public string portaddress
        {
            get { return textBoxPort.Text; }
            set { textBoxPort.Text = value; }
        }

        public event EventHandler SaveIPSettings;
        public event EventHandler SavePortSettings;
        public event EventHandler LoadIP;
        public event EventHandler LoadPort;

        public void DisplayIP(string IPaddress)
        {
            textBoxIP.Text = IPaddress;
        }

        public void DisplayPort(int Port)
        {
            textBoxPort.Text = Port.ToString();
        }

        public void InitializeEventHandler()
        {
            textBoxIP.TextChanged += (sender, e) =>
            {
                SaveIPSettings?.Invoke(this, EventArgs.Empty);
            };

            textBoxPort.TextChanged += (sender, e) =>
            {
                SavePortSettings?.Invoke(this, EventArgs.Empty);
            };

            
            btnRefresh.Click += delegate
            {
                IHomeView homeView = new Home();
                CounterPresenter counterPresenter = new CounterPresenter(homeView, new List<PlanModel>());
                counterPresenter.refreshTCP();
                this.Close();
            };
            
        }

        //Singeleton pattern (open a single  from instance)
        private static Setting instance;
        public static Setting GetInstance()
        {
            if (instance == null || instance.IsDisposed)
                instance = new Setting();
            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                    instance.WindowState = FormWindowState.Normal;
                instance.BringToFront();
            }
            return instance;
        }

        private void Setting_Load(object sender, EventArgs e)
        {
            LoadIP?.Invoke(this, EventArgs.Empty);
            LoadPort?.Invoke(this, EventArgs.Empty);
        }
    }
}
