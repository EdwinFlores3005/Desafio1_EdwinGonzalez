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
    public partial class NewFolder : Form
    {
        public NewFolder()
        {
            InitializeComponent();

        }
        //String para obtener el nombre de la carpeta

        public string nombreFolder;

        private void okayBtn_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(nameFolder.Text))//Se valida si el textBox esta vacio
            {
                MessageBox.Show("Ingresa un nombre válido", "Error", MessageBoxButtons.OK);
          
            }
            else
            {
                //Se asignal el texto al string del nombre del archivo. La accion da OK y se cierra la form
                nombreFolder = nameFolder.Text;
                this.DialogResult = DialogResult.OK; 
                this.Close();
            }
        }
    }
}
