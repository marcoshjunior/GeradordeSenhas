using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeradordeSenhas
{
    public partial class Form1 : Form
    {
        int numSenhas = 10;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            string caracteres = "abcdefghijklmnopkrstuvxwyz";
            if (checkMaiusculas.Checked)
                caracteres += "ABCDEFGHIJKLMNOPKRSTUVXWYZ";
            if (checkAlgarismos.Checked)
                caracteres += "1234567890";
            if (checkSimbolos.Checked)
                caracteres += "#/$!?=-";

            lbxSenhas.Items.Clear();
            Random rnd = new Random();

            //cria senhas ate o numero definido pelo numSenhas
            for (int n = 1; n <= numSenhas; n++)
            {
                //objeto para acrescentar caracteres
                StringBuilder str = new StringBuilder();
                //acrescenta ate o numero pedido
                for (int m = 1; m <= numCaracteres.Value; m++)
                {
                    //escolhe aleatoriamente os caracteres
                    int posicao = rnd.Next(0, caracteres.Length);
                    //acrescenta um caractere aleatorio em uma posicao na string caracteres
                    str.Append(caracteres[posicao].ToString());
                }
                //apos senha feita, insere na listbox
                lbxSenhas.Items.Add(str.ToString());
            }
        }
    }
}
