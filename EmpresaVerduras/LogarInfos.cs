using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace EmpresaVerduras
{
    class LogarInfos
    {



        const string info = "info";
        const string error = "error";
        const string warn = "warn";
        const string fatal = "fatal";
        string caminho;
        public LogarInfos()
        {
            caminho = "C:\\Users\\FelipeDev\\Documents\\";
            //string temp = Path.GetTempPath();
            //temp = temp.Replace("\\", "\\\\");
            caminho += "Log do dia " + DateTime.Today.ToString().Substring(0, 10).Replace("/", ".") + ".log";
            MessageBox.Show(caminho);
        }
        
        public void logando(int tipo, string log)
        {
            string logando = "";
            switch(tipo)
            {
                case 0:
                    logando += LogarInfos.info +" "+ log;
                    break;
                case 1:
                    logando += LogarInfos.error + " " + log;
                    break;
                case 2:
                    logando += LogarInfos.warn + " " + log;
                    break;
                case 3:
                    logando += LogarInfos.fatal + " " + log;
                    break;
            }
            salvarArquivo(logando);
        }



        public void salvarArquivo(string txt)
        {
            
            if (File.Exists(caminho))
            {
                StreamWriter salvarArquivo = new StreamWriter(caminho);
                string logAntigo = File.ReadAllText(caminho);
                logAntigo += txt;
                salvarArquivo.WriteLine(logAntigo);
                salvarArquivo.Close();
            }
            else
            {
                StreamWriter salvarArquivo = new StreamWriter(caminho);                
                salvarArquivo.WriteLine(IniciandoLog());
                salvarArquivo.Close();
            }
        }


        private string IniciandoLog()
        {
            return "Log Criado as " + DateTime.Now;
        }



    }
}
