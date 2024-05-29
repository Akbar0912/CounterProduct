﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrintGaransi.Model;
using PrintGaransi.View;


namespace PrintGaransi.Presenter
{
    public class SettingPresenter
    {
        private readonly ISettingView _view;
        private readonly SettingModel _model;
        private readonly LocationModel _smodel;
        private readonly ProductTypeModel _productType;

        public SettingPresenter(ISettingView view, SettingModel model) 
        {
            _view = view;
            _model = model;
            _productType = new ProductTypeModel();
            _smodel = new LocationModel();

            _view.SelectedIndexChanged += View_SelectedIndexChanged;
            _view.SaveIPSettings += SaveIPSettings;
            _view.SavePortSettings += SavePortSettings;
            _view.LoadIP += View_LoadIP;
            _view.LoadPort += View_LoadPort;
            _view.LoadLocation += View_LoadSettings;
            _view.LoadProductName += LoadProductTypeName;
            _view.SelectedProductType += SelectedProductType;
        }

        private void SelectedProductType(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            string location = comboBox?.SelectedItem as string;

            if (comboBox?.SelectedItem != null)
            {
                string selectedName = comboBox.SelectedItem.ToString();
                _productType.SaveProductTypeName(selectedName);
                MessageBox.Show(selectedName);
            }
        }

        private void LoadProductTypeName(object sender, EventArgs e)
        {
            List<string> productTypeNames = _productType.GetProductTypeNames();
            _view.JenisProdukNames = productTypeNames;
            string loadedProductName = _productType.LoadProductType();
            _view.DisplayName(loadedProductName);
        }

        private void View_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            string location = comboBox?.SelectedItem as string;

            if (comboBox?.SelectedItem != null)
            {
                string selectedLocationName = comboBox.SelectedItem.ToString();
                _model.SaveLocationName(selectedLocationName);

                // Memeriksa apakah selectedLocationName memiliki nilai sebelum memanggil repo
                if (!string.IsNullOrEmpty(selectedLocationName))
                {
                    // Panggil metode repo di sini dengan selectedLocationName sebagai parameter
                    int locationId = _smodel.GetLocationId(selectedLocationName);
                    _model.SaveLocationID(locationId);
                }
            }
        }

        private void View_LoadSettings(object sender, EventArgs e)
        {
            LoadLocationNames();
        }
        private void View_LoadIP(object sender, EventArgs e)
        {
            string loadedIP = _model.LoadIP();
            _view.DisplayIP(loadedIP);
        }

        private void View_LoadPort(object sender, EventArgs e)
        {
            int loadedPort = _model.LoadPort();
            _view.DisplayPort(loadedPort);
        }

        private void SaveIPSettings(object sender, EventArgs e)
        {
            _model.SaveSettingIP(_view.ipaddress);
        }

        private void SavePortSettings(object sender, EventArgs e)
        {
            _model.SaveSettingPort(_view.portaddress);
        }
        private void LoadLocationNames()
        {
            List<string> locationNames = _smodel.GetLocationNames();
            _view.LocationNames = locationNames;
            string loadedSetting = _model.LoadLocation();
            _view.DisplaySetting(loadedSetting);
        }

    }
}
