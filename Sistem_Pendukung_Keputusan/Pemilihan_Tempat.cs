﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistem_Pendukung_Keputusan
{
    public partial class Pemilihan_Tempat : Form
    {
        public Pemilihan_Tempat()
        {
            InitializeComponent();
        }

        private void btnCentang_Click(object sender, EventArgs e)
        { 
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, true);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, false);
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (i == true)
            //{

            //}
        }

        private void Pemilihan_Tempat_Load(object sender, EventArgs e)
        {

        }
    }
}
