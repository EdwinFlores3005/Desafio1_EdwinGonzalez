using System.Windows.Forms;
using System.Xml.Linq;

namespace Desafio1_EdwinGonzalez
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        ArbolSistemaArchivos sistema = new ArbolSistemaArchivos();


        private void AgregarNodosTreeView(TreeNode treeNode, NodoArchivo nodo)
        {
            foreach (var hijo in nodo.hijos)
            {
                TreeNode nuevo = new TreeNode(hijo.nombre);
                nuevo.Tag = hijo;
                treeNode.Nodes.Add(nuevo);

                if (hijo.carpeta())
                {
                    AgregarNodosTreeView(nuevo, hijo);
                }
            }
        }

        private void RefrescarTreeView()
        {
            ArchivoView.Nodes.Clear();

            TreeNode rootNode = new TreeNode(sistema.Root.nombre);
            rootNode.Tag = sistema.Root;
            ArchivoView.Nodes.Add(rootNode);


            AgregarNodosTreeView(rootNode, sistema.Root);

            ArchivoView.ExpandAll();
        }

        private void fldrBtn_Click(object sender, EventArgs e)
        {
            NewFolder newFolder = new NewFolder();
            DialogResult result = newFolder.ShowDialog();

            if (result == DialogResult.OK)
            {
                string name = newFolder.nombreFolder;

                if (ArchivoView.SelectedNode != null)
                {
                    NodoArchivo temp = ArchivoView.SelectedNode.Tag as NodoArchivo;
                    if (temp != null && temp.carpeta())
                    {
                        
                        sistema.AgregarNodo(temp, name, "carpeta");
                    }
                    else
                    {
                        MessageBox.Show("Debe seleccionar una carpeta.");
                        return;
                    }
                }
                else
                {
                    
                    sistema.AgregarNodo(sistema.Root, name, "carpeta");
                }

                RefrescarTreeView();
            }
            else if (result == DialogResult.Cancel)
            {
                MessageBox.Show("Carpeta no agregada");
            }
        }

        private void fileBtn_Click(object sender, EventArgs e)
        {
            NewFIle newFIle = new NewFIle();
            DialogResult result = newFIle.ShowDialog();
            

                if (result == DialogResult.OK)
            {
                string name = newFIle.nombreFile;
                var archivo = new NodoArchivo(name, "archivo");

                if (ArchivoView.SelectedNode != null)
                {
                    NodoArchivo temp = ArchivoView.SelectedNode.Tag as NodoArchivo;
                    if (temp != null && temp.carpeta())
                    {
                        
                        sistema.AgregarNodo(temp, name, "archivo");
                    }
                    else
                    {
                        MessageBox.Show("No se puede agregar una carpeta un archivo.");
                        return;
                    }
                }
                else
                {
                    
                    sistema.AgregarNodo(sistema.Root, name, "archivo");
                }

                RefrescarTreeView();
            }
            else if (result == DialogResult.Cancel)
            {
                MessageBox.Show("Archivo no agregado");
            }
        }

        private void routeBtn_Click(object sender, EventArgs e)
        {

            if (ArchivoView.SelectedNode == null)
            {
                MessageBox.Show("Selecciona un archivo");
                return;
            }
            NodoArchivo temp = ArchivoView.SelectedNode.Tag as NodoArchivo;
            if (temp != null)
            {
                string route = sistema.Ruta(temp);
                MessageBox.Show(route);
            }
        }

        private void srchBtn_Click(object sender, EventArgs e)
        {
            NodoArchivo found = sistema.BuscarNodo(sistema.Root, srchBox.Text);
            if (found != null)
            {
                string message = "Nombre: " + found.nombre + Environment.NewLine + "Tipo: " + found.tipo;
                MessageBox.Show(message,"Encontrado");
            }
            else
            {
                MessageBox.Show("Nodo no encontrado", "Error");
            }
        }
    }

}
