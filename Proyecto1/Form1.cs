using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;


namespace Proyecto1
{
    public partial class Form1 : Form
    {
        string connectionString =
        @"Server=JOALEXS;Database=Calculadora;TrustServerCertificate=True;Integrated Security=True;";

        double valor1, valor2, resultado, operacion;
        bool nuevaOperacion = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (nuevaOperacion && operacion == 0)
            {
                txt_pantalla.Clear();
                txt_ref.Clear();
                valor1 = 0;
                valor2 = 0;
                nuevaOperacion = false;
            }
            txt_pantalla.Text = txt_pantalla.Text + "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (nuevaOperacion && operacion == 0)
            {
                txt_pantalla.Clear();
                txt_ref.Clear();
                valor1 = 0;
                valor2 = 0;
                nuevaOperacion = false;
            }
            txt_pantalla.Text = txt_pantalla.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (nuevaOperacion && operacion == 0)
            {
                txt_pantalla.Clear();
                txt_ref.Clear();
                valor1 = 0;
                valor2 = 0;
                nuevaOperacion = false;
            }
            txt_pantalla.Text = txt_pantalla.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (nuevaOperacion && operacion == 0)
            {
                txt_pantalla.Clear();
                txt_ref.Clear();
                valor1 = 0;
                valor2 = 0;
                nuevaOperacion = false;
            }
            txt_pantalla.Text = txt_pantalla.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (nuevaOperacion && operacion == 0)
            {
                txt_pantalla.Clear();
                txt_ref.Clear();
                valor1 = 0;
                valor2 = 0;
                nuevaOperacion = false;
            }
            txt_pantalla.Text = txt_pantalla.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (nuevaOperacion && operacion == 0)
            {
                txt_pantalla.Clear();
                txt_ref.Clear();
                valor1 = 0;
                valor2 = 0;
                nuevaOperacion = false;
            }
            txt_pantalla.Text = txt_pantalla.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (nuevaOperacion && operacion == 0)
            {
                txt_pantalla.Clear();
                txt_ref.Clear();
                valor1 = 0;
                valor2 = 0;
                nuevaOperacion = false;
            }
            txt_pantalla.Text = txt_pantalla.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (nuevaOperacion && operacion == 0)
            {
                txt_pantalla.Clear();
                txt_ref.Clear();
                valor1 = 0;
                valor2 = 0;
                nuevaOperacion = false;
            }
            txt_pantalla.Text = txt_pantalla.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (nuevaOperacion && operacion == 0)
            {
                txt_pantalla.Clear();
                txt_ref.Clear();
                valor1 = 0;
                valor2 = 0;
                nuevaOperacion = false;
            }
            txt_pantalla.Text = txt_pantalla.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (nuevaOperacion && operacion == 0)
            {
                txt_pantalla.Clear();
                txt_ref.Clear();
                valor1 = 0;
                valor2 = 0;
                nuevaOperacion = false;
            }
            txt_pantalla.Text = txt_pantalla.Text + "9";
        }

        private void btnP_Click(object sender, EventArgs e)
        {
            if (nuevaOperacion && operacion == 0)
            {
                txt_pantalla.Clear();
                txt_ref.Clear();
                valor1 = 0;
                valor2 = 0;
                nuevaOperacion = false;
            }
            if (!txt_pantalla.Text.Contains("."))
            {
                txt_pantalla.Text = txt_pantalla.Text + ".";
            }
        }

        private void btn_suma_Click(object sender, EventArgs e)
        {
            ProcesarOperacion(1, "+");
        }

        private void btn_resta_Click(object sender, EventArgs e)
        {
            ProcesarOperacion(2, "-");
        }

        private void btn_multiplicacion_Click(object sender, EventArgs e)
        {
            ProcesarOperacion(3, "×");
        }

        private void btn_division_Click(object sender, EventArgs e)
        {
            ProcesarOperacion(4, "÷");
        }

        private void btn_elevar_Click(object sender, EventArgs e)
        {
            if (txt_pantalla.Text == "") return;
            double numero = double.Parse(txt_pantalla.Text);
            numero = Math.Pow(numero, 2);
            txt_pantalla.Text = numero.ToString();
            txt_ref.Text += "sqr(" + numero + ")";
            if (valor1 != 0 && operacion != 0)
                valor2 = numero;
            else
                valor1 = numero;
            nuevaOperacion = true;
        }

        private void btn_raiz_Click(object sender, EventArgs e)
        {
            if (txt_pantalla.Text == "") return;
            double numero = double.Parse(txt_pantalla.Text);
            double numero1 = double.Parse(txt_pantalla.Text);
            if (numero < 0)
            {
                MessageBox.Show("No se puede calcular la raíz de un número negativo");
                return;
            }
            numero = Math.Sqrt(numero);
            txt_pantalla.Text = numero.ToString();
            txt_ref.Text += "√(" + numero1 + ")";
            if (valor1 != 0 && operacion != 0)
                valor2 = numero;
            else
                valor1 = numero;
            nuevaOperacion = true;
        }

        private void ProcesarOperacion(int tipoOperacion, string simbolo)
        {
            if (txt_pantalla.Text == "") return;
            double valorActual = double.Parse(txt_pantalla.Text);
            if (valor1 != 0 && !nuevaOperacion)
            {
                valor2 = valorActual;
                RealizarOperacion();
                txt_pantalla.Text = resultado.ToString();
                valor1 = resultado;
            }
            else
            {
                valor1 = valorActual;
            }
            operacion = tipoOperacion;
            txt_ref.Text = valor1.ToString() + simbolo;
            txt_pantalla.Clear();
            nuevaOperacion = false;
        }

        private void RealizarOperacion()
        {
            switch (operacion)
            {
                case 1:
                    resultado = valor1 + valor2;
                    break;
                case 2:
                    resultado = valor1 - valor2;
                    break;
                case 3:
                    resultado = valor1 * valor2;
                    break;
                case 4:
                    if (valor2 == 0)
                    {
                        MessageBox.Show("No se puede dividir entre cero");
                        resultado = 0;
                    }
                    else
                    {
                        resultado = valor1 / valor2;
                    }
                    break;
            }
        }

        // --- MODIFICACIÓN: Guardar operación en base de datos ---
        private void GuardarOperacion(string operacionTexto, double resultado)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string sql = "INSERT INTO Historial (Operacion, Resultado) VALUES (@operacion, @resultado)";
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@operacion", operacionTexto);
                        cmd.Parameters.AddWithValue("@resultado", resultado.ToString());
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar operación: " + ex.Message);
            }
        }

        private void btn_igual_Click(object sender, EventArgs e)
        {
            if (txt_pantalla.Text == "" && valor2 == 0) return;
            if (!nuevaOperacion)
                valor2 = double.Parse(txt_pantalla.Text);
            RealizarOperacion();
            txt_pantalla.Text = resultado.ToString();
            if (!nuevaOperacion)
                txt_ref.Text += valor2.ToString() + "=";

            // --- NUEVO: Guardar en la base de datos ---
            GuardarOperacion(txt_ref.Text, resultado);

            valor1 = resultado;
            valor2 = 0;
            operacion = 0;
            nuevaOperacion = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void Form1_Load(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_pantalla.Clear();
            txt_ref.Clear();
            valor1 = 0;
            valor2 = 0;
            resultado = 0;
            operacion = 0;
            nuevaOperacion = false;
        }

        private void btn_clearE_Click(object sender, EventArgs e)
        {
            txt_pantalla.Clear();
        }

        // --- NUEVO: Mostrar historial ---
        private void mostrarCalculos_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string sql = "SELECT * FROM Historial ORDER BY Fecha DESC";
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            string historial = "";
                            while (reader.Read())
                            {
                                historial += $"{reader["Fecha"]}: {reader["Operacion"]}{reader["Resultado"]}\n";
                            }
                            MessageBox.Show(historial == "" ? "No hay operaciones guardadas" : historial, "Historial de operaciones");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar historial: " + ex.Message);
            }
        }
    }
}
