﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintGaransi.Model
{
    public interface IGaransiRepository
    {
        void Add(dynamic model);
        IEnumerable<GaransiModel> GetData(string model);
        IEnumerable<GaransiModel> GetAll();
        IEnumerable<GaransiModel> GetFilter(string globalCodeId);
        List<string> JenisProduk();

        bool Exists(string noSeri, string modelCode);
    }
}