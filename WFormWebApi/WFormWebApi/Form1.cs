using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFormWebApi.Assets;
using WFormWebApi.Classes;

namespace WFormWebApi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            ConexionApi con = new ConexionApi();
            List<MarcaCLS> lista = new List<MarcaCLS>();

            lista = await con.ObtenerTodo<MarcaCLS>("api/marca");

            foreach (var item in lista)
            {
                listBox1.Items.Add(item.nombre.Trim());

            }

        }

        private async void button2_Click(object sender, EventArgs e)
        {
            ConexionApi con = new ConexionApi();
            MarcaCLS oMarca = new MarcaCLS
            {
                iidMarca = 0,
                descripcion ="prueba form",
                nombre = "Windows Form"

            };

            int a = await con.AgregarActualizar("api/Marca",oMarca);

        }

        private async void button3_Click(object sender, EventArgs e)
        {
            ConexionApi con = new ConexionApi();
            int a = await con.Eliminar("api/Marca/12");
        }
    }
}
