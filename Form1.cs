using System.Diagnostics;
using System.IO;
namespace SS_TOOL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
   
          
        private void button1_Click(object sender, EventArgs e)
        {
            string filePath = "-f C:\\Users\\micke\\Downloads\\krypton.exe";

     
            Process process = new Process();
            process.StartInfo.FileName = "C:\\Users\\micke\\Source\\Repos\\SS TOOL\\bin\\Debug\\net6.0-windows\\bstrings.exe"; // Substitua pelo nome do executável bstrings
            process.StartInfo.Arguments = filePath;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;


            process.Start();

       
            string output = process.StandardOutput.ReadToEnd();

          
            process.WaitForExit();

            
            File.WriteAllText("arquivoBStrings.txt", output);

        }
    }
}