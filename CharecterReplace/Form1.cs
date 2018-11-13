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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        string FilePath;
        string FileName;
        List<string> oldValues = new List<string>();
        List<string> newValues = new List<string>();

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
                 FilePath = ofdDosyaAc.FileName;
                 FileName = ofdDosyaAc.SafeFileName;
                 MessageBox.Show("Dosya Seçildi.");
            }
        }

        private void btnAddValue_Click(object sender, EventArgs e)
        {
            lbxOldValue.Items.Add(txtOldValue.Text);
            oldValues.Add(txtOldValue.Text);
            lbxNewValue.Items.Add(txtNewValue.Text);
            newValues.Add(txtNewValue.Text);
            txtNewValue.Clear();
            txtOldValue.Clear();
          
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            FileOperation.ReadAndReplace(FilePath,oldValues,newValues);
            MessageBox.Show("İşlem Başarı İle Gerçekleştirildi!");
            lbxNewValue.Items.Clear();
            lbxOldValue.Items.Clear();
        }
    }
}
