﻿using PrintGaransi._Repositories;
using PrintGaransi.Model;
using PrintGaransi.Presenter;
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

namespace PrintGaransi.View
{
    public partial class SettingView : Form, ISettingView
    {
        private bool isInitializing;
        public SettingView()
        {
            InitializeComponent();
            InitializeEventHandler();
        }

        public List<string> JenisProdukNames
        {
            get => JPComboBox.DataSource as List<string>;
            set => JPComboBox.DataSource = value;
        }

        public List<string> LocationNames
        {
            get => locationBox.DataSource as List<string>;
            set => locationBox.DataSource = value;
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

        public event EventHandler SelectedIndexChanged;
        public event EventHandler SaveIPSettings;
        public event EventHandler SavePortSettings;
        public event EventHandler LoadIP;
        public event EventHandler LoadPort;
        public event EventHandler LoadLocation;
        public event EventHandler LoadProductName;
        public event EventHandler SelectedProductType;

        public void DisplayName(string JPName)
        {
            JPComboBox.Text = JPName;
        }

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
            JPComboBox.SelectedIndexChanged += (sender, e) =>
            {
                if (!isInitializing)
                {
                    SelectedProductType?.Invoke(sender, e);
                }
            };

            locationBox.SelectedIndexChanged += (sender, e) =>
            {
                if (!isInitializing)
                {
                    SelectedIndexChanged?.Invoke(sender, e);
                }
            };

            textBoxIP.TextChanged += (sender, e) =>
            {
                SaveIPSettings?.Invoke(this, EventArgs.Empty);
            };

            textBoxPort.TextChanged += (sender, e) =>
            {
                SavePortSettings?.Invoke(this, EventArgs.Empty);
            };

            btnConnect.Click += delegate
            {
                ILoginView loginView = new LoginView();
                LoginPresenter loginPresenter = new LoginPresenter(loginView, new LoginRepository());
                (loginView as Form)?.Show();
            };
        }

        public void DisplaySetting(string locationName)
        {
            locationBox.Text = locationName;
        }

        //Singeleton pattern (open a single  from instance)
        private static SettingView instance;
        public static SettingView GetInstance()
        {
            if (instance == null || instance.IsDisposed)
                instance = new SettingView();
            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                    instance.WindowState = FormWindowState.Normal;
                instance.BringToFront();
            }
            return instance;
        }

        private void SettingView_Load(object sender, EventArgs e)
        {
            isInitializing = true;
            LoadProductName?.Invoke(this, EventArgs.Empty);
            LoadLocation?.Invoke(this, EventArgs.Empty);
            LoadIP?.Invoke(this, EventArgs.Empty);
            LoadPort?.Invoke(this, EventArgs.Empty);
            isInitializing = false;
        }
    }
}