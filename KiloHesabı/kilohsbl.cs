using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace KiloHesabı
{
    public partial class kilohsbl : MetroForm
    {
        public kilohsbl()
        {
            InitializeComponent();
        }
        List<double> deger = new List<double>();
        private void kilohsbl_Load(object sender, EventArgs e)
        {
            webBrowser1.Hide();
        }
        private void metroButton1_Click(object sender, EventArgs e)
        {
            deger.Add(Convert.ToDouble(txt_boy.Text));deger.Add(Convert.ToDouble(txt_kilo.Text));
            deger.Add(deger[1]/(deger[0]*deger[0]));
            label3.Text= deger[2].ToString().Substring(4,2);
            deger.Clear();
        }
    }
}
