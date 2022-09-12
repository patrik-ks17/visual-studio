using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sikidomok
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_szamol_Click(object sender, EventArgs e)
        {
            decimal a = num_a_oldal.Value;
            decimal b = num_b_oldal.Value;
            decimal K = 2 * a + 2 * b;
            decimal T = a * b;
            num_k.Value = K;
            num_t.Value = T;
        }

        private void btn_kor_szamol_Click(object sender, EventArgs e)
        {

        }

        private void btn_har_szamol_Click(object sender, EventArgs e)
        {
            decimal a = num_har_a.Value;
            decimal b = num_har_b.Value;
            decimal c = num_har_c.Value;
            decimal s = (a + b + c) / 2;
            decimal K = a + b + c;
            decimal T = (decimal)Math.Sqrt((double)(s * (s - a) * (s - b) * (s - c)));
            num_har_k.Value = K;
            num_har_t.Value = T;
        }

        private void btn_negy_szamol_Click(object sender, EventArgs e)
        {
            decimal a = num_negy_a.Value;
            decimal K = 4 * a;
            decimal T = a * a;
            num_negy_k.Value = K;
            num_negy_t.Value = T;
        }

        private void btn_hat_szamol_Click(object sender, EventArgs e)
        {
            decimal a = num_hat_a.Value;
            decimal K = 6 * a;
            decimal T = (decimal)(3 * Math.Sqrt(3) / 2 * Math.Pow((double)a, 2));
            num_hat_k.Value = K;
            num_hat_t.Value = T;
        }

        private void num_kor_r_ValueChanged(object sender, EventArgs e)
        {
            decimal r = num_kor_r.Value;
            decimal K = 2 * r * (decimal)Math.PI;
            decimal T = r * r * (decimal)Math.PI;
            num_kor_k.Value = K;
            num_kor_t.Value = T;
        }

        private void num_kor_k_ValueChanged(object sender, EventArgs e)
        {
            decimal k = num_kor_k.Value;
            decimal r = k / 2 / (decimal)Math.PI;
            decimal t = r * r * (decimal)Math.PI;
            num_kor_r.Value = r;
            num_kor_t.Value = t;
        }

        private void num_kor_t_ValueChanged(object sender, EventArgs e)
        {
            decimal t = num_kor_t.Value;
        }
    }
}
