using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _Encript
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        String[] Abecedario = new string[27] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "Ñ", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
        int posB = 0;
        int posEnc = 0;
        int j = 0;
        string cadena = "";
        private void Button1_Click(object sender, EventArgs e)
        {
            String caracteres = TxtPalabras.Text;
            String PalabraClave = txtPalabraC.Text;
            TxtCifrado.Text = null;

            for (int i = 0; i < caracteres.Length; i++)
            {
                if ((PalabraClave.Length - 1) < j)
                {
                    j = 0;
                }
                posB = buscarPos(PalabraClave[j].ToString(), Abecedario);
                newCadena(caracteres[i].ToString(), Abecedario, posB);
                j++;
            }
            TxtCifrado.Items.Add(cadena);
            posB = 0;
            posEnc = 0;
            j = 0;
            cadena = "";
        }

        public int buscarPos(String caracter, String[] abc)
        {
            for (int i = 0; i < Abecedario.Length; i++)
            {
                if (caracter == Abecedario[i].ToString())
                {
                    posEnc = i;
                    break;
                }
            }
            return posEnc;
        }

        public void newCadena(String caracter, String[] abc, int pos)
        {
            int posF = Math.Abs(buscarPos(caracter, abc) + pos);

            for (int i = 0; i < Abecedario.Length; i++)
            {
                if (i == posF)
                {
                    cadena += Abecedario[i].ToString();
                    break;
                }
                else if (posF > 27)
                {
                    int begin = Math.Abs(27 - posF);
                    cadena += Abecedario[begin].ToString();
                    break;
                }
            }
        }

        public void cadenaDesci(String caracter, String[] abc, int pos)
        {
            int posF = Math.Abs(buscarPos(caracter, abc) - pos)+27;

               MessageBox.Show(posF.ToString());

            for (int i = 0; i < Abecedario.Length; i++)
            {
                if (i == posF)
                {
                              MessageBox.Show(Abecedario[i].ToString());
                    cadena += Abecedario[i].ToString();
                    break;
                }
                else if (posF > 27)
                {
                    int begin = Math.Abs(27 - posF);
                            MessageBox.Show(Abecedario[begin].ToString());
                    cadena += Abecedario[begin].ToString();
                    break;
                }

            }
        }

        private void TxtCifrado_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            String caracteres = TxtPalabras.Text;
            String PalabraClave = txtPalabraC.Text;
            TxtCifrado.Text = null;

            for (int i = 0; i < caracteres.Length; i++)
            {
                if ((PalabraClave.Length - 1) < j)
                {
                    j = 0;
                }
                posB = buscarPos(PalabraClave[j].ToString(), Abecedario);
                MessageBox.Show("B: " + posB);
                
                cadenaDesci(caracteres[i].ToString(), Abecedario, posB);
                j++;
            }
            TxtCifrado.Items.Add(cadena);
            posB = 0;
            posEnc = 0;
            j = 0;
            cadena = "";
        }
    }
}
