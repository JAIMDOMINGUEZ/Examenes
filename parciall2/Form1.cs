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
                        alerta("Ingrese un monto valido ");
                    }
                   
                }
                else {
                    alerta("Ingrese un monto valido ");
                }
            }
            else
            {
                alerta("Selecione un tipo de moneda");
            }
            



        }
        public void mostrarDivisas(List<string> divisas, float montoo,String monedaseleccionada)
        {
            List<float> cambio=new List<float>();
            switch (monedaseleccionada)
            {
                case "USD-Dolar estadounidense":
                    foreach (String divisa in divisas)
                    {
                        switch (divisa)
                        {
                            case "USD-Dolar estadounidense":
                                break;
                            case "MXN-Peso Mexicano":
                                cambio.Add((float)(montoo * 21.23));
                                break;
                            case "CAD-Dolar Canadiense":
                                cambio.Add((float)(montoo * 1.28));
                                break;
                            case "EUR-Euro":
                                cambio.Add((float)(montoo * 0.89));
                                break;
                            case "JPY-Yen Japones":
                                cambio.Add((float)(montoo * 113.05));
                                break;
                        }
                        
                    }
                    break;
                case "MXN-Peso Mexicano":
                    foreach (String divisa in divisas)
                    {
                        switch (divisa)
                        {
                            case "USD-Dolar estadounidense":
                                cambio.Add((float)(montoo * 0.05));
                                break;
                            
                            case "CAD-Dolar Canadiense":
                                cambio.Add((float)(montoo * 0.06));
                                break;
                            case "EUR-Euro":
                                cambio.Add((float)(montoo * 0.04));
                                break;
                            case "JPY-Yen Japones":
                                cambio.Add((float)(montoo * 5.32));
                                break;
                        }  
                    }
                    break;
                case "CAD-Dolar Canadiense":
                    foreach (String divisa in divisas)
                    {
                        switch (divisa)
                        {
                            case "USD-Dolar estadounidense":
                                cambio.Add((float)(montoo * 0.78));
                                break;
                            case "MXN-Peso Mexicano":
                                cambio.Add((float)(montoo * 16.55));
                                break;
                           
                            case "EUR-Euro":
                                cambio.Add((float)(montoo * 0.69));
                                break;
                            case "JPY-Yen Japones":
                                cambio.Add((float)(montoo * 88.12));
                                break;
                        }
                        
                    }
                    break;
                case "EUR-Euro":
                    foreach (String divisa in divisas)
                    {
                        switch (divisa)
                        {
                            case "USD-Dolar estadounidense":
                                cambio.Add((float)(montoo * 1.13));
                                break;
                            case "MXN-Peso Mexicano":
                                cambio.Add((float)(montoo * 23.96));
                                break;
                            case "CAD-Dolar Canadiense":
                                cambio.Add((float)(montoo * 1.45));
                                break;
                            case "JPY-Yen Japones":
                                cambio.Add((float)(montoo * 127.56));
                                break;
                        }
                        
                    }
                    break;
                case "JPY-Yen Japones":
                    foreach (String divisa in divisas)
                    {
                        switch (divisa)
                        {
                            case "USD-Dolar estadounidense":
                                cambio.Add((float)(montoo * 0.0088));
                                break;
                            case "MXN-Peso Mexicano":
                                cambio.Add((float)(montoo * 0.1878));
                                break;
                            case "CAD-Dolar Canadiense":
                                cambio.Add((float)(montoo * 0.0113));
                                break;
                            case "EUR-Euro":
                                cambio.Add((float)(montoo * 0.0078));
                                break;
                         
                        }
                        
                    }
                    break;

            }
            Console.WriteLine("...............");
            Console.WriteLine(monedaseleccionada);
            for (int i = 0; i < cambio.Count; i++)
            {
                Console.WriteLine(divisas[i]+"  "+cambio[i]);
                /*
                Label etiqueta = new Label();
                TextBox caja = new TextBox();
                etiqueta.Text = divisas[i].ToString();
                
                caja.Text = cambio[i].ToString();
                caja.Location = new Point(10, 50);
                etiqueta.Location = new Point(10, 50);
                conversiones_grp.Controls.Add(etiqueta);
                conversiones_grp.Controls.Add(caja);
                */
            }
            Label etiqueta = new Label();
            TextBox caja = new TextBox();
            etiqueta.Text = "divisa";
            caja.Text = "cantidad";
            caja.Size = new Size(30, 30);
            etiqueta.Size = new Size(30, 30);
            caja.Location = new Point(10, 0);
            etiqueta.Location = new Point(10, 40);
            this.Controls.Add(etiqueta);
            this.Controls.Add(caja);


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
