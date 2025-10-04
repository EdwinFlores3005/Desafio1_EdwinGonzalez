using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafio1_EdwinGonzalez
{
    public partial class NewFIle : Form
    {
        public NewFIle()
        {
            InitializeComponent();
        }

        public string nombreFile;

        private void okayBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nameFile.Text))
            {
                MessageBox.Show("Ingresa un nombre válido", "Error", MessageBoxButtons.OK);

            }
            else
            {
                nombreFile = nameFile.Text;
                this.DialogResult = DialogResult.OK; 
                this.Close();
            }
        }
    }
}
