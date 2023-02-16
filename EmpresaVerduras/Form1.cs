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


namespace EmpresaVerduras
{
    public partial class Form1 : Form
    {
        OpenFileDialog Ofd = new OpenFileDialog();
        LogarInfos lgi = new LogarInfos();
        public Form1()
        {
            InitializeComponent();
        }
      
        private string PegarCaminho()
        {
            Ofd.Filter = "Arquivo txt (*.txt)|*.txt";
            string caminho = Ofd.FileName;
            string texto;
            if (Ofd.ShowDialog() != DialogResult.OK) return null;

            try { texto = File.ReadAllText(caminho); return texto; }
            catch (Exception) { return null; }
        }
        private void QuebrarLinha()
        {
            int i = 0;int CNPJ = 0;
            string texto;
            string caminho = Ofd.FileName;
            double mediaEstoque = 0;double valor= 0;double result = 0;double resultCNPJ = 0;int posi4 = 0; int valorNulo = 0;
            texto = File.ReadAllText(caminho);
            foreach (var linha in texto.Split('\n'))
            {
                if (linha == "" || linha == "\r") break;
                if (i != 0)
                {
                    string[] posicao = linha.Split(';');

                    lboNormal.Items.Add(posicao[0]);
                    lboCNPJ.Items.Add(posicao[3]);
                    lboMediaEstoque.Items.Add(result);

                    mediaEstoque = double.Parse(posicao[2]);  
                    valor = double.Parse(posicao[1]);
                   
                    posi4 = posicao[3].Count();
                    if (posicao[3] == "true")
                    {
                        CNPJ++;
                        resultCNPJ = valor / CNPJ;
                        lboMediaCNPJ.Items.Add(resultCNPJ);
                    }
                    else { lboMediaCNPJ.Items.Add(valorNulo); }

                    
                    
                    
                    result = (valor * mediaEstoque) / mediaEstoque;
                }
                i++;               
               
            }
        }
        public void Selecionar(object sender)
        {
            ListBox l = sender as ListBox;
            if (lboCNPJ.SelectedIndex != -1)
            {
                lboNormal.SelectedIndex = l.SelectedIndex;
                lboCNPJ.SelectedIndex = l.SelectedIndex;
                lboMediaCNPJ.SelectedIndex = l.SelectedIndex;
                lboMediaEstoque.SelectedIndex = l.SelectedIndex;

            }
        }

        private void btnDados_Click(object sender, EventArgs e)
        {
            lgi.logando(0,"info");
            PegarCaminho();
            QuebrarLinha();
     
        }

        private void lboNormal_SelectedIndexChanged(object sender, EventArgs e)
        {
            Selecionar(sender);
        }

        private void lboCNPJ_SelectedIndexChanged(object sender, EventArgs e)
        {
            Selecionar(sender);
        }

        private void lboMediaCNPJ_SelectedIndexChanged(object sender, EventArgs e)
        {
            Selecionar(sender);
        }

        private void lboMediaEstoque_SelectedIndexChanged(object sender, EventArgs e)
        {
            Selecionar(sender);
        }
    }
}
