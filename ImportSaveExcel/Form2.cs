﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImportSaveExcel
{
    public partial class Form2 : Form
    {
        public string customQuery = string.Empty;
        private string[] _starr = new string[0];

        public Form2(string[] starr)
        {
            InitializeComponent();
            btnOk.Click += btnOk_Click;
            btnCancle.Click += btnCancle_Click;
            _starr = starr;
            txtCustom.Text = "SELECT {0} FROM DUAL;";
        }

        private void btnOk_Click(object sender , EventArgs e)
        {
            if(txtCustom.Text.IndexOf("{0}")  < 0 )
            {
                MessageBox.Show("입력형태를 맞춰야합니다 {0} 포함");
                return;
            }

            for(int i = 0; i < _starr.Length; i++)
            {
                if (_starr[i] != null && _starr[i].Trim().Length > 0)
                {
                    customQuery += string.Format(txtCustom.Text, "'" +  _starr[i] + "'");
                    customQuery += Environment.NewLine + Environment.NewLine;
                }
            }
            this.Close();
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            customQuery = "";
            this.Close();
        }
    }
}
