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

        // Se crea el sistema de archivos

        ArbolSistemaArchivos sistema = new ArbolSistemaArchivos();


        private void AgregarNodosTreeView(TreeNode treeNode, NodoArchivo nodo)
        {
            //Funcion para agregar nodos al TreeView usado en el Form
            foreach (var hijo in nodo.hijos)
            {
                TreeNode nuevo = new TreeNode(hijo.nombre);
                //Se le asignal el tag del nodo que se pasa
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
            //Al agregar un nuevo nodo se refresca el TreeView
            ArchivoView.Nodes.Clear();

            TreeNode rootNode = new TreeNode(sistema.Root.nombre);
            rootNode.Tag = sistema.Root;
            ArchivoView.Nodes.Add(rootNode);


            AgregarNodosTreeView(rootNode, sistema.Root);

            ArchivoView.ExpandAll();
        }

        //Se manejan dos botones para agregar carpeta o archivo
        private void fldrBtn_Click(object sender, EventArgs e)
        {
            //Se creo una form aparte que se abrira a manera de dialogo para obtener el nombre de la carpeta
            NewFolder newFolder = new NewFolder();
            DialogResult result = newFolder.ShowDialog();

            //Dependiendo del resultado del dialogo de la nueva form se agregara o no la carpeta
            if (result == DialogResult.OK)
            {
                //Se obtiene el nombre de la carpeta. Esta es una variable dentro de la form NewFolder
                string name = newFolder.nombreFolder;

                //Dependiendo si un nodo ha sido seleccionado, se agregara la carpeta en el nodo seleccionado
                if (ArchivoView.SelectedNode != null)
                {
                    //Se obtiene el tag del nodo seleccionado del TreeView y se pasa como NodoArchivo
                    NodoArchivo temp = ArchivoView.SelectedNode.Tag as NodoArchivo;
                    if (temp != null && temp.carpeta()) //Se valida si es una carpeta y si es valido
                    {
                        //Se agrega la carpeta dentro del nodo seleccionado
                        sistema.AgregarNodo(temp, name, "carpeta");
                    }
                    else
                    {//Si es un archivo no se agrega
                        MessageBox.Show("Debe seleccionar una carpeta.");
                        return;
                    }
                }
                else
                {
                    //Si no se selecciono ningun nodo se agrega a la Raiz
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
            //Se creo una form aparte que se abrira a manera de dialogo para obtener el nombre del archivo
            //La logica de este boton es igual al de agregar carpeta, con la diferencia que aqui solo se agregan archivos
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
                        
                        sistema.AgregarNodo(temp, name, "archivo");//Se agrega como archivo
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

        //Mostrar Ruta al presionar el boton
        private void routeBtn_Click(object sender, EventArgs e)
        {

            if (ArchivoView.SelectedNode == null)
            {
                MessageBox.Show("Selecciona un archivo");
                return;
            }
            //Se obtiene el tag del nodo seleccionado del TreeView y se pasa como NodoArchivo
            NodoArchivo temp = ArchivoView.SelectedNode.Tag as NodoArchivo;
            if (temp != null)
            {//Se llama la funcion de ArbolSistemaArchivo
                string route = sistema.Ruta(temp);
                MessageBox.Show(route);
            }
        }

        //Buscar en el arbol al presionar el boton
        private void srchBtn_Click(object sender, EventArgs e)
        {
            NodoArchivo found = sistema.BuscarNodo(sistema.Root, srchBox.Text);//Se pasa el string del searchBox como nombre del nodo a buscar
            if (found != null)
            {
                //Si existe el nodo se muestran las propiedades del nodo a traves de un MessageBox
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
