using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CalcuNET
{
    public partial class _default : System.Web.UI.Page
    {
        static double num1, num2, nums;
        static char signo;
        static bool bandera = false;

        //*Botones Numeros*//
        protected void Button2_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "+" || TextBox1.Text == "-" || TextBox1.Text == "/" || TextBox1.Text == "*")
            {
                TextBox1.Text = "";
                TextBox1.Text += Button2.Text;
            }
            else
            {
                TextBox1.Text += Button2.Text;

            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "+" || TextBox1.Text == "-" || TextBox1.Text == "/" || TextBox1.Text == "*")
            {
                TextBox1.Text = "";
                TextBox1.Text += Button3.Text;
            }
            else
            {
                TextBox1.Text += Button3.Text;

            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "+" || TextBox1.Text == "-" || TextBox1.Text == "/" || TextBox1.Text == "*")
            {
                TextBox1.Text = "";
                TextBox1.Text += Button4.Text;
            }
            else
            {
                TextBox1.Text += Button4.Text;

            }
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "+" || TextBox1.Text == "-" || TextBox1.Text == "/" || TextBox1.Text == "*")
            {
                TextBox1.Text = "";
                TextBox1.Text += Button5.Text;
            }
            else
            {
                TextBox1.Text += Button5.Text;

            }
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "+" || TextBox1.Text == "-" || TextBox1.Text == "/" || TextBox1.Text == "*")
            {
                TextBox1.Text = "";
                TextBox1.Text += Button6.Text;
            }
            else
            {
                TextBox1.Text += Button6.Text;

            }
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "+" || TextBox1.Text == "-" || TextBox1.Text == "/" || TextBox1.Text == "*")
            {
                TextBox1.Text = "";
                TextBox1.Text += Button7.Text;
            }
            else
            {
                TextBox1.Text += Button7.Text;

            }
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "+" || TextBox1.Text == "-" || TextBox1.Text == "/" || TextBox1.Text == "*")
            {
                TextBox1.Text = "";
                TextBox1.Text += Button8.Text;
            }
            else
            {
                TextBox1.Text += Button8.Text;

            }
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "+" || TextBox1.Text == "-" || TextBox1.Text == "/" || TextBox1.Text == "*")
            {
                TextBox1.Text = "";
                TextBox1.Text += Button9.Text;
            }
            else
            {
                TextBox1.Text += Button9.Text;

            }
        }

        protected void Button0_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "+" || TextBox1.Text == "-" || TextBox1.Text == "/" || TextBox1.Text == "*")
            {
                TextBox1.Text = "";
                TextBox1.Text += Button0.Text;
            }
            else
            {
                TextBox1.Text += Button0.Text;

            }
        }

        protected void ButtonPunto_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "+" || TextBox1.Text == "-" || TextBox1.Text == "/" || TextBox1.Text == "*")
            {
                TextBox1.Text = "";
                TextBox1.Text += ButtonPunto.Text;
            }
            else
            {
                TextBox1.Text += ButtonPunto.Text;

            }
        }
        //*Operaciones*//
        protected void ButtonSuma_Click(object sender, EventArgs e)
        {
            /*
            if (bandera)
            {
                num1 = Convert.ToDouble(TextBox1.Text);
                TextBox1.Text = "";
                signo = '+';
                bandera = false;
            }
            else
            {
                num2 = Convert.ToDouble(TextBox1.Text);
                TextBox1.Text = "";
            }
            */
            num1 = Convert.ToDouble(TextBox1.Text);
            TextBox1.Text = "";
            signo = '+';
        }

        protected void ButtonResta_Click(object sender, EventArgs e)
        {
            /*
            if (bandera)
            {
                num1 = Convert.ToDouble(TextBox1.Text);
                TextBox1.Text = "";
                signo = '-';
                bandera = false;
            }
            else
            {
                num2 = Convert.ToDouble(TextBox1.Text);
                TextBox1.Text = "";
            }
            */
            num1 = Convert.ToDouble(TextBox1.Text);
            TextBox1.Text = "";
            signo = '-';
        }

        protected void ButtonMultiplicacion_Click(object sender, EventArgs e)
        {
            /*
            if (bandera)
            {
                num1 = Convert.ToDouble(TextBox1.Text);
            TextBox1.Text = "";
            signo = '*';
                bandera = false;
            }
            else
            {
                num2 = Convert.ToDouble(TextBox1.Text);
                TextBox1.Text = "";
            }
            */
            num1 = Convert.ToDouble(TextBox1.Text);
            TextBox1.Text = "";
            signo = '*';
        }

        protected void ButtonDividir_Click(object sender, EventArgs e)
        {
            /*
            if (bandera)
            {
            num1 = Convert.ToDouble(TextBox1.Text);
            TextBox1.Text = "";
            signo = '/';
                bandera = false;
            }
            else
            {
                num2 = Convert.ToDouble(TextBox1.Text);
                TextBox1.Text = "";
            }
            */
            num1 = Convert.ToDouble(TextBox1.Text);
            TextBox1.Text = "";
            signo = '/';
        }

        protected void ButtonResult_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToDouble(TextBox1.Text);
            bandera = true;
            try
            {
                switch (signo)
                {
                    case '+':
                        nums = SumaO(num1, num2);
                        Clear();
                        TextBox1.Text = Convert.ToString(nums);
                        break;
                    case '-':
                        nums = RestaO(num1, num2);
                        Clear();
                        TextBox1.Text = Convert.ToString(nums);
                        break;
                    case '*':
                        nums = MultiplicacionO(num1, num2);
                        Clear();
                        TextBox1.Text = Convert.ToString(nums);
                        break;
                    case '/':
                        nums = DivisionO(num1, num2);
                        Clear();
                        TextBox1.Text = Convert.ToString(nums);
                        break;
                }
            }
            catch (Exception) { }
        }

        /*Metodos*/
        public double SumaO(double num1, double num2)
        {
            return num1 + num2;
        }

        public double RestaO(double num1, double num2)
        {
            return num1 - num2;
        }
        public double MultiplicacionO(double num1, double num2)
        {
            return num1 * num2;
        }
        public double DivisionO(double num1, double num2)
        {
            return num1 / num2;
        }

        public void Clear()
        {
            TextBox1.Text = "";
        }

        protected void ButtonBorrar_Click(object sender, EventArgs e)
        {
            string texto = TextBox1.Text;
            if (texto != "")
            {
                texto = texto.Substring(0, texto.Length - 1);
                TextBox1.Text = texto;
            }
        }

        protected void ButtonMM_Click(object sender, EventArgs e)
        {
            /*
            if (!bandera)
            {
                TextBox1.Text += "-";
                TextBox1.Text = "";
            }
            else
            {
                TextBox1.Text += "-";
            }
            */
        }

        protected void ButtonFrac_Click(object sender, EventArgs e)
        {
            try
            {
                num1 = 1 / Convert.ToDouble(TextBox1.Text);
                TextBox1.Text = Convert.ToString(num1);
            }
            catch (Exception)
            {

            }
        }

        protected void ButtonPotencia_Click(object sender, EventArgs e)
        {
            try
            {
                num1 = Math.Pow(Convert.ToDouble(TextBox1.Text), 2);
                TextBox1.Text = Convert.ToString(num1);
            }
            catch (Exception) { }
        }

        protected void ButtonRaiz_Click(object sender, EventArgs e)
        {
            try
            {
                num1 = Math.Sqrt(Convert.ToDouble(TextBox1.Text));
                TextBox1.Text = Convert.ToString(num1);
            }
            catch (Exception) { }
        }

        protected void ButtonC_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
            num1 = 0;
            num2 = 0;
            nums = 0;
        }

        protected void ButtonCE_Click(object sender, EventArgs e)
        {
            Clear();
        }

        protected void ButtonPorcentaje_Click(object sender, EventArgs e)
        {

        }

        /*Load*/
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        //*Botones Numeros*//
        protected void Button1_Click(object sender, EventArgs e)
        {
            if(TextBox1.Text == "+" || TextBox1.Text == "-" || TextBox1.Text == "/" || TextBox1.Text == "*")
            {
                TextBox1.Text = "";
                TextBox1.Text += Button1.Text;
            }
            else
            {
                TextBox1.Text += Button1.Text;

            }
        }
    }
}