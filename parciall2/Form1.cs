﻿using System;
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
    public partial class Form1 : Form
    {
        List<string> monedas = new List<string>(){
        "USD-Dolar estadounidense",
        "MXN-Peso Mexicano",
        "CAD-Dolar Canadiense",
        "EUR-Euro",
        "JPY-Yen Japones"
        };
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var mon in monedas)
            {
                Moneda_comboBox.Items.Add(mon);
            }


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void calcular_btn_Click(object sender, EventArgs e)
        {
            Form2 formulario2 = new Form2();
            string seleccionado = Moneda_comboBox.GetItemText(Moneda_comboBox.SelectedItem);
            
            if (seleccionado!="")
            {
                if (monto_textBox.Text != "")
                {
                    float monto = float.Parse(monto_textBox.Text);
                    if (monto>0)
                    {
                        formulario2.Monedaseleccionada = seleccionado;
                        formulario2.Monedas = monedas;
                        formulario2.Monto = monto;
                        formulario2.Show();
                    }
                    else
                    {
                        alerta("Ingrese un monto valido");
                    }
                   
                }
                else {
                    alerta("Ingrese un monto valido");
                }
            }
            else
            {
                alerta("Selecione un tipo de moneda");
            }
            



        }
        private void alerta(String mensaje)
        {
            

            MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void monto_textBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}