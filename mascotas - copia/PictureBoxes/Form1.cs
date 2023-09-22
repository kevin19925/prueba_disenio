using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using PictureBoxes;

namespace PictureBoxes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pbFoto_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //Creacion de Automoviles
            Mascota A1 = new Mascota( "Maz", "steeven", "Boxer", 100,Properties.Resources.Boxer);
            Mascota A2 = new Mascota( "Bella", "steeven", "Bulldog", 50, Properties.Resources.Bulldo);
            Mascota A3 = new Mascota( "Bella","steeven", "Chihuahua", 330, Properties.Resources.Chihuahua);
            Mascota A4 = new Mascota( "Luna", "kevin", "Boxer", 436, Properties.Resources.Boxer);
            Mascota A5 = new Mascota( "Cooper", "kevin", "Chihuahua", 900, Properties.Resources.Chihuahua);
            Mascota A6 = new Mascota("Lucy", "kevin", "Boxer", 50, Properties.Resources.Boxer);
            Mascota A7 = new Mascota("Buddy", "kevin", "Bulldog", 19, Properties.Resources.Bulldo);
            Mascota A8 = new Mascota("Buddy", "steeven", "Dalmata", 1, Properties.Resources.Dalmata);

            //Creacion de Lista con Array
            ArrayList ListA = new ArrayList();
            ListA.Add(A1);  // como ibjecto.. nunca como un string
            ListA.Add(A2);
            ListA.Add(A3);
            ListA.Add(A4);
            ListA.Add(A5);
            ListA.Add(A6);
            ListA.Add(A7);
            ListA.Add(A8);

            //Creación de Lista con Clase
            ListaMascotas ListB = new ListaMascotas();
            ListB.AgregarMascota(A1);
            ListB.AgregarMascota(A2);
            ListB.AgregarMascota(A3);
            ListB.AgregarMascota(A4);
            ListB.AgregarMascota(A5);
            ListB.AgregarMascota(A6);
            ListB.AgregarMascota(A7);
            ListB.AgregarMascota(A8);
            lbAutos.DataSource = ListB.getListA();

            // Treeview tiene nodos
            tvParametros.Nodes.Add("Filtros");
            tvParametros.Nodes[0].Nodes.Add("Característica");
            tvParametros.Nodes[0].Nodes[0].Nodes.Add("Razas");
            tvParametros.Nodes[0].Nodes[0].Nodes[0].Nodes.Add(RazasEnum.Boxer .ToString());
            tvParametros.Nodes[0].Nodes[0].Nodes[0].Nodes.Add(RazasEnum.Bulldog.ToString());
            tvParametros.Nodes[0].Nodes[0].Nodes[0].Nodes.Add(RazasEnum.Chihuahua.ToString());
            tvParametros.Nodes[0].Nodes[0].Nodes[0].Nodes.Add(RazasEnum.Dalmata.ToString()) ;



            tvParametros.Nodes[0].Nodes.Add("Función");
            tvParametros.Nodes[0].Nodes[1].Nodes.Add("Menos rapides");
            tvParametros.Nodes[0].Nodes[1].Nodes[0].Nodes.Add("20");
            tvParametros.Nodes[0].Nodes[1].Nodes[0].Nodes.Add("50");
            tvParametros.Nodes[0].Nodes[1].Nodes[0].Nodes.Add("100");


            tvParametros.Nodes[0].Nodes[1].Nodes.Add("Mas rapidez");
            tvParametros.Nodes[0].Nodes[1].Nodes[1].Nodes.Add("20");
            tvParametros.Nodes[0].Nodes[1].Nodes[1].Nodes.Add("50");
            tvParametros.Nodes[0].Nodes[1].Nodes[1].Nodes.Add("100");
            tvParametros.ExpandAll();
            tvParametros.SelectedNode = tvParametros.Nodes[0];
        
            



        }

        private void lbAutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            pbFoto.Image = ((Mascota)lbAutos.SelectedItem).getFoto(); 
        }

        private void tvParametros_AfterSelect(object sender, TreeViewEventArgs e)
        {

            //raza Boxer
            if (tvParametros.SelectedNode == tvParametros.Nodes[0].Nodes[0].Nodes[0].Nodes[0])
            {

                ListaMascotas lbAux = new ListaMascotas();
                lbAux.setListaMascota((ArrayList)lbAutos.DataSource);
                ArrayList modelos = lbAux.mostrarRazas(RazasEnum.Boxer.ToString());
                lbResultado.DataSource = modelos;
            }
            //raza  Chihuahua
            else if (tvParametros.SelectedNode == tvParametros.Nodes[0].Nodes[0].Nodes[0].Nodes[1])
            {
                ListaMascotas lbAux = new ListaMascotas();
                lbAux.setListaMascota((ArrayList)lbAutos.DataSource);
                ArrayList modelos = lbAux.mostrarRazas(RazasEnum.Chihuahua.ToString());
                lbResultado.DataSource = modelos;
            }
            //raza Bulldog
            else if (tvParametros.SelectedNode == tvParametros.Nodes[0].Nodes[0].Nodes[0].Nodes[2])
            {
                ListaMascotas lbAux = new ListaMascotas();
                lbAux.setListaMascota((ArrayList)lbAutos.DataSource);
                ArrayList modelos = lbAux.mostrarRazas(RazasEnum.Bulldog.ToString());
                lbResultado.DataSource = modelos;
            }
            //raza Dalmata
            else if (tvParametros.SelectedNode == tvParametros.Nodes[0].Nodes[0].Nodes[0].Nodes[3])
            {
                ListaMascotas lbAux = new ListaMascotas();
                lbAux.setListaMascota((ArrayList)lbAutos.DataSource);
                ArrayList modelos = lbAux.mostrarRazas(RazasEnum.Dalmata.ToString());
                lbResultado.DataSource = modelos;
            }
           
            // Menos 20 km
            else if (tvParametros.SelectedNode == tvParametros.Nodes[0].Nodes[1].Nodes[0].Nodes[0])
            {
                ListaMascotas lbAux = new ListaMascotas();
                lbAux.setListaMascota((ArrayList)lbAutos.DataSource);
                ArrayList lentos = lbAux.mostrarlento(int.Parse(Properties.Resources.VIENTECONSTANTE));
                lbResultado.DataSource = lentos;
            }
            // Menos 50 km
            else if (tvParametros.SelectedNode == tvParametros.Nodes[0].Nodes[1].Nodes[0].Nodes[1])
            {
                ListaMascotas lbAux = new ListaMascotas();
                lbAux.setListaMascota((ArrayList)lbAutos.DataSource);
                ArrayList lentos = lbAux.mostrarlento(int.Parse(Properties.Resources.CINCUENTACONSTANTE));
                lbResultado.DataSource = lentos;
            }
            // Menos 100 km
            else if (tvParametros.SelectedNode == tvParametros.Nodes[0].Nodes[1].Nodes[0].Nodes[2])
            {
                ListaMascotas lbAux = new ListaMascotas();
                lbAux.setListaMascota((ArrayList)lbAutos.DataSource);
                ArrayList lentos = lbAux.mostrarlento(int.Parse(Properties.Resources.CIENCCONSTANTE));
                lbResultado.DataSource = lentos;
            }

            // mas 20 km
            else if (tvParametros.SelectedNode == tvParametros.Nodes[0].Nodes[1].Nodes[1].Nodes[0])
            {
                ListaMascotas lbAux = new ListaMascotas();
                lbAux.setListaMascota((ArrayList)lbAutos.DataSource);
                ArrayList rapidos = lbAux.mayorRapidez(int.Parse(Properties.Resources.VIENTECONSTANTE));
                lbResultado.DataSource = rapidos;
            }
            // mas 50 km
            else if (tvParametros.SelectedNode == tvParametros.Nodes[0].Nodes[1].Nodes[1].Nodes[1])
            {
                ListaMascotas lbAux = new ListaMascotas();
                lbAux.setListaMascota((ArrayList)lbAutos.DataSource);
                ArrayList rapidos = lbAux.mayorRapidez(int.Parse(Properties.Resources.CINCUENTACONSTANTE));
                lbResultado.DataSource = rapidos;
            }
            // mas 1000 km
            else if (tvParametros.SelectedNode == tvParametros.Nodes[0].Nodes[1].Nodes[1].Nodes[2])
            {
                ListaMascotas lbAux = new ListaMascotas();
                lbAux.setListaMascota((ArrayList)lbAutos.DataSource);
                ArrayList rapidos = lbAux.mayorRapidez(int.Parse(Properties.Resources.CIENCCONSTANTE));
                lbResultado.DataSource = rapidos;
            }
            //Los demas no hacen nada
            else
            {
            }
           
        }

        private void colorearBlancoTreeView() {
            tvParametros.Nodes[0].BackColor = Color.White;
            tvParametros.Nodes[0].Nodes[0].BackColor = Color.White;
            tvParametros.Nodes[0].Nodes[1].BackColor = Color.White;

        }

        private void tbTransparencia_Scroll(object sender, EventArgs e)
        {

           // pbFoto.Size = new Size(227, 164);
            int trackvalue =tbTransparencia.Value;
            Size s = new Size(pbFoto.Width/ trackvalue, pbFoto.Height /trackvalue);
            pbFoto.Size = s;
            
        }

       
    }
}
