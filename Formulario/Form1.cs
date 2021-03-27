using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EstructurasArboles;

namespace Formulario
{
    public partial class Form1 : Form
    {
        ArbolBinarioBusqueda miArbol = new ArbolBinarioBusqueda();
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Boton Insertar
        /// su funcion es recoger todos los datos ingresados por el usuario
        /// y posteriormente llamar a la funcion insertar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (!(nombreTarea.Text == "" || duracion.Text == "" || avanceTarea.Text == "" || desarrolladorAsignado.Text == ""))
            {
            EquipoDesarrollo desarrollador = new EquipoDesarrollo();
            desarrollador.nombreTarea = nombreTarea.Text;
            desarrollador.duracion = duracion.Text;
            desarrollador.porcentajeAvance = avanceTarea.Text;
            desarrollador.NombreDesarrollador = desarrolladorAsignado.Text;
            miArbol.insertar(desarrollador);
            limpiarTextBox();
            }
            else
            {
                MessageBox.Show("Todos los campos son obligatorios!");
            }
        }
        /// <summary>
        /// Metodo para limpiar los textbox
        /// </summary>
        public void limpiarTextBox()
        {
            nombreTarea.Clear();
            duracion.Clear();
            avanceTarea.Clear();
            desarrolladorAsignado.Clear();
            nombreTarea.Clear();
        }
        /// <summary>
        /// Metodo combobox
        /// Obtener el valor seleccionado por parte del usuario para eventualmente recorrerlo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBox1.SelectedIndex;
            switch (index)
            {
                case 0:
                    listBox1.Items.Clear();
                    listBox1.Items.Add(ArbolBinarioBusqueda.preorden(miArbol.raizArbol()));
                    break;
                case 1:
                    listBox1.Items.Clear();
                    listBox1.Items.Add(ArbolBinarioBusqueda.inorden(miArbol.raizArbol()));
                    break;
                case 2:
                    listBox1.Items.Clear();
                    listBox1.Items.Add(ArbolBinarioBusqueda.postorden(miArbol.raizArbol()));
                    break;
            }
        }
        /// <summary>
        /// Boton salir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        /// <summary>
        /// Boton Eliminar
        /// Eliminara un nodo, y limpiara los demas campos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            if (!(buscarTarea.Text == ""))
            {
            EquipoDesarrollo desarrollador = new EquipoDesarrollo();
            desarrollador.nombreTarea= buscarTarea.Text;

            miArbol.eliminar(desarrollador);
            listBox1.Items.Clear();
            comboBox1.Text = String.Empty;
            buscarTarea.Clear();
            }
            else
            {
                MessageBox.Show("Ingrese nombre de la tarea");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buscar_Click(object sender, EventArgs e)
        {
            if (!(buscarTarea.Text == ""))
            {
                EquipoDesarrollo desarrollador = new EquipoDesarrollo();
                desarrollador.nombreTarea = buscarTarea.Text;

                Nodo c1 = miArbol.buscar(desarrollador); 
                    desarrollador = (EquipoDesarrollo)c1.dato;
                
                listBox1.Items.Clear();
                listBox1.Items.Add(c1.dato.ToString());
                comboBox1.Text = String.Empty;
            }
            else
            {
                MessageBox.Show("Ingrese nombre de la tarea");
            }
        }
    }
}
