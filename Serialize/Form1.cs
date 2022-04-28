using System;
using System.IO;
using System.Windows.Forms;

namespace Serialize
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSerializar_Click(object sender, EventArgs e)
        {
            var dados = new Dados();
            dados.Nome = txbNome.Text;
            dados.DataNascimento = txbDataNascimento.Text;
            dados.Proficao = txbProficao.Text;

            try
            {
                using (StreamWriter sw = new StreamWriter(@"c:\dados\aquivo.json"))
                {
                    sw.Write(dados.JsonSerializar(dados));
                }

                MessageBox.Show("Arquivo Gravado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void btnDesserializar_Click(object sender, EventArgs e)
        {
            try
            {
                var strJson = "";
                using (StreamReader sr = new StreamReader(@"c:\dados\aquivo.json"))
                {
                    strJson = sr.ReadToEnd();
                }

                var dados = Dados.JsonDesserializar(strJson);
                txbNome.Text = dados.Nome;
                txbDataNascimento.Text = dados.DataNascimento;
                txbProficao.Text = dados.Proficao;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message);
            }
        }
    }
}
