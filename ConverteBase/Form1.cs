using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConverteBase
{
    public partial class JanelaConverte : Form
    {
        public JanelaConverte()
        {
            InitializeComponent();
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            String valor = valorInserido.Text;
            //int tamanho = valor.Length;
            if (opcDecimal.Checked)
            {
                double d = Convert.ToDouble(valor);
                String db = DecimalParaBinario(d);
                String dO = DecimalParaOctal(d);
                String dh = DecimalParaHexadecimal(d);
                MessageBox.Show("Valor Inserido: "+valor+"\nBinário: "+db+"\nOctal: "+dO+"\nHexadecimal: "+dh);
            }else if(opcBinario.Checked){
                double bd = BinarioParaDecimal(valor);
                String dO = DecimalParaOctal(bd);
                String dh = DecimalParaHexadecimal(bd);
                MessageBox.Show("Valor Inserido: " + valor + "\nDecimal: " + bd + "\nOctal: " + dO + "\nHexadecimal: " + dh);
            }else if(opcOctal.Checked){
                double oD = OctalParaDecimal(valor);
                String dh = DecimalParaHexadecimal(oD);
                String db = DecimalParaBinario(oD);
                MessageBox.Show("Valor Inserido: " + valor + "\nDecimal: " + oD + "\nBinário: " + db + "\nHexadecimal: " + dh);
            }else if(opcHexa.Checked){
                double hd = HexadecimalParaDecimal(valor);
                String dO = DecimalParaOctal(hd);
                String db = DecimalParaBinario(hd);
                MessageBox.Show("Valor Inserido: " + valor + "\nDecimal: " + hd + "\nBinario: " + db + "\nOctal: " + dO);
            }
            else
            {
                MessageBox.Show("Nenhum tipo de base foi selecionado!");

            }
        }

        private string inverterString(string Word)
        {
            char[] arrChar = Word.ToCharArray();
            Array.Reverse(arrChar);
            string invertida = new String(arrChar);

            return invertida;
        }

        public String DecimalParaBinario(double d)
        {
            List<int> binarios = new List<int>();
            double r;

            while (d != 0)
            {
                r = d % 2;
                d = (int)d / 2;
                binarios.Add(Convert.ToInt32(r));
            }
            binarios.Reverse();

            StringBuilder builder = new StringBuilder();

            foreach (int n in binarios)
            {
                builder.Append(n);
            }
            string result = builder.ToString();

            return result;
        }


        public String DecimalParaOctal(double d)
        {
            List<int> octal = new List<int>();
            double r;

            do
            {
                r = d % 8;
                d = (int)d / 8;
                octal.Add(Convert.ToInt32(r));
                if (d < 8)
                {
                    octal.Add(Convert.ToInt32(d));
                }
            } while (d >= 8);

            octal.Reverse();

            StringBuilder builder = new StringBuilder();
            foreach (int n in octal)
            {
                builder.Append(n);
            }
            string result = builder.ToString();
            return result;
        }

        public String DecimalParaHexadecimal(double d)
        {
            List<int> hexa = new List<int>();
            double r;

            do
            {
                r = d % 16;
                d = (int)d / 16;
                hexa.Add((int)r);
            } while (d >= 16);

            List<string> listaHexa = new List<string>();

            listaHexa = ConverterEmHexadecimal(hexa);
            listaHexa.Reverse();
            StringBuilder builder = new StringBuilder();
            foreach(string s in listaHexa)
            {
                builder.Append(s);
            }
            String result = builder.ToString();
            return result;
        }

        public string InverterString(string Word)
        {
            char[] arrChar = Word.ToCharArray();
            Array.Reverse(arrChar);
            string invertida = new String(arrChar);

            return invertida;
        }

        public List<string> ConverterEmHexadecimal(List<int> valorDecimal)
        {

            List<string> listaHexa = new List<string>();

            foreach (int valor in valorDecimal)
            {
                if (valor == 10)
                {
                    listaHexa.Add("A");
                }
                else if (valor == 11)
                {
                    listaHexa.Add("B");
                }
                else if (valor == 12)
                {
                    listaHexa.Add("C");
                }
                else if (valor == 13)
                {
                    listaHexa.Add("D");
                }
                else if (valor == 14)
                {
                    listaHexa.Add("E");
                }
                else if (valor == 15)
                {
                    listaHexa.Add("F");
                }
                else
                {
                    listaHexa.Add(valor + string.Empty);
                }
            }

            return listaHexa;

        }

        public double HexadecimalParaDecimal(String s)
        {
            int tamanho = s.Count();
            s = s.ToUpper();
            s = inverterString(s);
            double d = 0;

            for (int i = 0; i < tamanho; i++)
            {
                if (s.Substring(i, 1).Equals("A"))
                {
                    d = d + Convert.ToInt32(10 * Math.Pow(16, i));
                }
                else if (s.Substring(i, 1).Equals("B"))
                {
                    d = d + Convert.ToInt32(11 * Math.Pow(16, i));
                }
                else if (s.Substring(i, 1).Equals("C"))
                {
                    d = d + Convert.ToInt32(12 * Math.Pow(16, i));
                }
                else if (s.Substring(i, 1).Equals("D"))
                {
                    d = d + Convert.ToInt32(13 * Math.Pow(16, i));
                }
                else if (s.Substring(i, 1).Equals("E"))
                {
                    d = d + Convert.ToInt32(14 * Math.Pow(16, i));
                }
                else if (s.Substring(i, 1).Equals("F"))
                {
                    d = d + Convert.ToInt32(15 * Math.Pow(16, i));
                }
                else
                {
                    double a = Convert.ToInt32(s.Substring(i, 1));
                    d = d + Convert.ToInt32(a * Math.Pow(16, i));
                }
            }

            return d;
        }

        public double OctalParaDecimal(String o)
        {
            double d = 0;
            o = inverterString(o);

            for (int i = 0; i < o.Length; i++)
            {
                double a = Convert.ToInt32(o.Substring(i, 1));
                d = d + Convert.ToInt32(a * Math.Pow(8, i));

            }
            return d;
        }

        public double BinarioParaDecimal(String binario)
        {

            decimal dividendo = Convert.ToDecimal(binario);
            double d = 0;
       
            string binarioInvertido = inverterString(binario);

            for (int i = 0; i < binarioInvertido.Length; i++)
            {
                d = d + (Convert.ToInt32((binarioInvertido.Substring(i, 1))) * Math.Pow(2, i));
            }

            return d;
        }
    }
}
