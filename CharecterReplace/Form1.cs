using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharecterReplace
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFindPath_Click(object sender, EventArgs e)
        {
            //ofdDosyaAc.InitialDirectory = "C:\\Users\\HasanBerkErgun\\Desktop"; // 1.Yol
            ofdDosyaAc.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop); //SpecialFolder'lar İçin
            ofdDosyaAc.Filter = "Text Dosyası |*.txt"; //ofd'nin propertisinden de yapılabilirdi.
            ofdDosyaAc.RestoreDirectory = true; //En Son Bakılan Path'i Aç Defualt False'dur
            ofdDosyaAc.Title = "Please Select Your Text File";
            //ofdDosyaAc.ShowDialog();

            if (ofdDosyaAc.ShowDialog() == DialogResult.OK)
            {
                string FilePath = ofdDosyaAc.FileName;
                MessageBox.Show(FilePath);
                string FileName = ofdDosyaAc.SafeFileName;
                MessageBox.Show(FileName);
            }


        }
    }
}
