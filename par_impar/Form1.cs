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

namespace par_impar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numeroJogador = 0, numeroComputador = 0, total;
            StreamWriter arquivo;
            System.IO.Directory.CreateDirectory("C:\\Banco De Dados\\parimpar");
            String caminho = @"C:\\Banco De Dados\\parimpar\\placar.txt";            
            arquivo = File.AppendText(caminho);
            string nome = txtNome.Text;
            Random dado = new Random();
            numeroComputador = dado.Next(0, 11);

            numeroJogador = Convert.ToInt32(txtValor.Text);
            total = (numeroComputador + numeroJogador);
            MessageBox.Show("Seu Número: " + txtValor.Text + "\nNúmero do computador: " + numeroComputador.ToString() + "\nTotal: " + total.ToString());

            if(rdbImpar.Checked == true)
            {
                if(total % 2 != 0)
                {
                    MessageBox.Show("Voce Escolheu Impar " + nome + ", voce ganhou ");
                    arquivo.WriteLine("");
                    arquivo.Write("Nome: "+txtNome.Text );
                    arquivo.WriteLine("");
                    arquivo.Write("Valor Escolhido do "+nome+": " + txtValor.Text);
                    arquivo.WriteLine("");
                    arquivo.Write("Valor Escolhido do computador: " + numeroComputador);
                    arquivo.WriteLine("");
                    arquivo.Write("Total: " + total);
                    arquivo.WriteLine("");
                    arquivo.WriteLine("VENCEDOR ");
                    arquivo.WriteLine("");
                    arquivo.WriteLine("________________________________________________");
                    arquivo.Close();
                }
                else
                {
                    MessageBox.Show("Voce Escolheu Impar " + nome + ", voce perdeu ");
                    arquivo.WriteLine("");
                    arquivo.Write("Nome: " + txtNome.Text);
                    arquivo.WriteLine("");
                    arquivo.Write("Valor Escolhido do " + nome + ": " + txtValor.Text);
                    arquivo.WriteLine("");
                    arquivo.Write("Valor Escolhido do computador: " + numeroComputador);
                    arquivo.WriteLine("");
                    arquivo.Write("Total: " + total);
                    arquivo.WriteLine("");
                    arquivo.WriteLine("PERDEDOR ");
                    arquivo.WriteLine("");
                    arquivo.WriteLine("________________________________________________");
                    arquivo.Close();
                }
            }
            else
            {
                if (total % 2 == 0)
                {
                    MessageBox.Show("Voce Escolheu Par " + nome + ", voce ganhou ");
                    arquivo.WriteLine("");
                    arquivo.Write("Nome: " + txtNome.Text);
                    arquivo.WriteLine("");
                    arquivo.Write("Valor Escolhido do " + nome + ": " + txtValor.Text);
                    arquivo.WriteLine("");
                    arquivo.Write("Valor Escolhido do computador: " + numeroComputador);
                    arquivo.WriteLine("");
                    arquivo.Write("Total: " + total);
                    arquivo.WriteLine("");
                    arquivo.WriteLine("VENCEDOR ");
                    arquivo.WriteLine("");
                    arquivo.WriteLine("________________________________________________");
                    arquivo.Close();
                }
                else
                {
                    MessageBox.Show("Voce Escolheu Par " + nome + ", voce perdeu ");
                    arquivo.WriteLine("");
                    arquivo.Write("Nome: " + txtNome.Text);
                    arquivo.WriteLine("");
                    arquivo.Write("Valor Escolhido do " + nome + ": " + txtValor.Text);
                    arquivo.WriteLine("");
                    arquivo.Write("Valor Escolhido do computador: " + numeroComputador);
                    arquivo.WriteLine("");
                    arquivo.Write("Total: " + total);
                    arquivo.WriteLine("");
                    arquivo.WriteLine("PERDEDOR ");
                    arquivo.WriteLine("");
                    arquivo.WriteLine("________________________________________________");
                    arquivo.Close();
                }
                
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string caminho = "C:\\Banco De Dados\\parimpar\\placar.txt";
            System.Diagnostics.Process.Start("NOTEPAD", caminho);
        }
        
    }
}
