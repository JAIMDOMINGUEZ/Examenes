using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace parciall2
{
    
    public partial class Form2 : Form
    {
        private String monedaseleccionada;
        private List<string> monedas = new List<string>();
        public Form2()
        {
            InitializeComponent();
            
        }

        public string Monedaseleccionada { get => monedaseleccionada; set => monedaseleccionada = value; }
        public List<string> Monedas { get => monedas; set => monedas = value; }

        private void cancelar_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            foreach (string mon in monedas)
            {
                if (mon != monedaseleccionada) { 
                monedas_clb.Items.Add(mon);
                }
            }
        }
    }
}
