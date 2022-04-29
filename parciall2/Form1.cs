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

        public string d;
        

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

            if (seleccionado != "")
            {
                String m = monto_textBox.Text;
                if (m != "" && m.All(char.IsDigit))
                {
                    float monto = float.Parse(monto_textBox.Text);
                    if (monto > 0)
                    {
                        formulario2.Monedaseleccionada = seleccionado;
                        formulario2.Monedas = monedas;
                        formulario2.Monto = monto;
                        formulario2.ShowDialog();
                        Conversiones_grp.Controls.Clear();
                        foreach (string item in formulario2.Monedas)
                        {
                            Console.WriteLine(item);
                        }

                        List<String> cambio = new List<String>();
                        switch (formulario2.Monedaseleccionada)
                        {
                            case "USD-Dolar estadounidense":
                                foreach (String divisa in formulario2.Conversion)
                                {
                                    switch (divisa)
                                    {
                                        case "USD-Dolar estadounidense":
                                            break;
                                        case "MXN-Peso Mexicano":
                                            cambio.Add("$" + (formulario2.Monto * 21.23).ToString());
                                            break;
                                        case "CAD-Dolar Canadiense":
                                            cambio.Add("$" + (formulario2.Monto * 1.28).ToString());
                                            break;
                                        case "EUR-Euro":
                                            cambio.Add("€" + (formulario2.Monto * 0.89).ToString());
                                            break;
                                        case "JPY-Yen Japones":
                                            cambio.Add("¥" + (formulario2.Monto * 113.05).ToString());
                                            break;
                                    }

                                }
                                break;
                            case "MXN-Peso Mexicano":
                                foreach (String divisa in formulario2.Conversion)
                                {
                                    switch (divisa)
                                    {
                                        case "USD-Dolar estadounidense":
                                            cambio.Add("$" + (formulario2.Monto * 0.05).ToString());
                                            break;

                                        case "CAD-Dolar Canadiense":
                                            cambio.Add("$" + (formulario2.Monto * 0.06).ToString());
                                            break;
                                        case "EUR-Euro":
                                            cambio.Add("€" + (formulario2.Monto * 0.04).ToString());
                                            break;
                                        case "JPY-Yen Japones":
                                            cambio.Add("¥" + (formulario2.Monto * 5.32).ToString());
                                            break;
                                    }
                                }
                                break;
                            case "CAD-Dolar Canadiense":
                                foreach (String divisa in formulario2.Conversion)
                                {
                                    switch (divisa)
                                    {
                                        case "USD-Dolar estadounidense":
                                            cambio.Add("$" + (formulario2.Monto * 0.78).ToString());
                                            break;
                                        case "MXN-Peso Mexicano":
                                            cambio.Add("$" + (formulario2.Monto * 16.55).ToString());
                                            break;

                                        case "EUR-Euro":
                                            cambio.Add("€" + (formulario2.Monto * 0.69).ToString());
                                            break;
                                        case "JPY-Yen Japones":
                                            cambio.Add("¥" + (formulario2.Monto * 88.12).ToString());
                                            break;
                                    }

                                }
                                break;
                            case "EUR-Euro":
                                foreach (String divisa in formulario2.Conversion)
                                {
                                    switch (divisa)
                                    {
                                        case "USD-Dolar estadounidense":
                                            cambio.Add("$" + (formulario2.Monto * 1.13).ToString());
                                            break;
                                        case "MXN-Peso Mexicano":
                                            cambio.Add("$" + (formulario2.Monto * 23.96).ToString());
                                            break;
                                        case "CAD-Dolar Canadiense":
                                            cambio.Add("$" + (formulario2.Monto * 1.45).ToString());
                                            break;
                                        case "JPY-Yen Japones":
                                            cambio.Add("¥" + (formulario2.Monto * 127.56).ToString());
                                            break;
                                    }

                                }
                                break;
                            case "JPY-Yen Japones":
                                foreach (String divisa in formulario2.Conversion)
                                {
                                    switch (divisa)
                                    {
                                        case "USD-Dolar estadounidense":
                                            cambio.Add("$" + (formulario2.Monto * 0.0088).ToString());
                                            break;
                                        case "MXN-Peso Mexicano":
                                            cambio.Add("$" + (formulario2.Monto * 0.1878).ToString());
                                            break;
                                        case "CAD-Dolar Canadiense":
                                            cambio.Add("$" + (formulario2.Monto * 0.0113).ToString());
                                            break;
                                        case "EUR-Euro":
                                            cambio.Add("€" + (formulario2.Monto * 0.0078).ToString());
                                            break;

                                    }

                                }
                                break;

                        }
                        Console.WriteLine("...............");
                        Console.WriteLine(formulario2.Monedaseleccionada);
                        int x1 = 10;
                        int x2 = 150;
                        int y = 30;
                        for (int i = 0; i < cambio.Count; i++)
                        {
                            Console.WriteLine(formulario2.Conversion[i] + "  " + cambio[i]);
                            Label etiqueta = new Label();
                            TextBox caja = new TextBox();
                            etiqueta.Text = formulario2.Conversion[i].ToString();
                            caja.Text = cambio[i].ToString();
                            caja.Size = new Size(120, 30);
                            etiqueta.Size = new Size(140, 30);
                            Conversiones_grp.Controls.Add(etiqueta);
                            Conversiones_grp.Controls.Add(caja);
                            etiqueta.Location = new Point(x1, y);
                            caja.Location = new Point(x2, y);

                            y = y + 30;
                        }



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
        /*
        public void mostrarDivisas(List<string> divisas, float montoo, String monedaseleccionada)
        {
           
            List<String> cambio = new List<String>();
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
                                cambio.Add("$"+(montoo * 21.23).ToString());
                                break;
                            case "CAD-Dolar Canadiense":
                                cambio.Add("$" + (montoo * 1.28).ToString());
                                break;
                            case "EUR-Euro":
                                cambio.Add("€"+(montoo * 0.89).ToString());
                                break;
                            case "JPY-Yen Japones":
                                cambio.Add("¥"+(montoo * 113.05).ToString());
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
                                cambio.Add("$"+(montoo * 0.05).ToString());
                                break;

                            case "CAD-Dolar Canadiense":
                                cambio.Add("$"+(montoo * 0.06).ToString());
                                break;
                            case "EUR-Euro":
                                cambio.Add("€"+(montoo * 0.04).ToString());
                                break;
                            case "JPY-Yen Japones":
                                cambio.Add("¥"+(montoo * 5.32).ToString());
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
                                cambio.Add("$"+(montoo * 0.78).ToString());
                                break;
                            case "MXN-Peso Mexicano":
                                cambio.Add("$"+(montoo * 16.55).ToString());
                                break;

                            case "EUR-Euro":
                                cambio.Add("€"+(montoo * 0.69).ToString());
                                break;
                            case "JPY-Yen Japones":
                                cambio.Add("¥"+(montoo * 88.12).ToString());
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
                                cambio.Add("$"+(montoo * 1.13).ToString());
                                break;
                            case "MXN-Peso Mexicano":
                                cambio.Add("$"+(montoo * 23.96).ToString());
                                break;
                            case "CAD-Dolar Canadiense":
                                cambio.Add("$"+(montoo * 1.45).ToString());
                                break;
                            case "JPY-Yen Japones":
                                cambio.Add("¥"+(montoo * 127.56).ToString());
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
                                cambio.Add("$"+(montoo * 0.0088).ToString());
                                break;
                            case "MXN-Peso Mexicano":
                                cambio.Add("$"+(montoo * 0.1878).ToString());
                                break;
                            case "CAD-Dolar Canadiense":
                                cambio.Add("$"+(montoo * 0.0113).ToString());
                                break;
                            case "EUR-Euro":
                                cambio.Add("€"+(montoo * 0.0078).ToString());
                                break;

                        }

                    }
                    break;

            }
            Console.WriteLine("...............");
            Console.WriteLine(monedaseleccionada);
            int x1 = 10;
            int x2 = 150;
            int y = 30;
            for (int i = 0; i < cambio.Count; i++)
            {
                Console.WriteLine(divisas[i] + "  " + cambio[i]);
                Label etiqueta = new Label();
                TextBox caja = new TextBox();
                etiqueta.Text = divisas[i].ToString();
                caja.Text = cambio[i].ToString();
                caja.Size = new Size(120, 30);
                etiqueta.Size = new Size(50, 30);
                Conversiones_grp.Controls.Add(etiqueta);
                Conversiones_grp.Controls.Add(caja);
                etiqueta.Location = new Point(x1, y);
                caja.Location = new Point(x2, y);
            
                y = y + 30;
            }
           


        }
        */
         
        private void alerta(String mensaje)
        {
            
            MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void monto_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        
        
    }
}
