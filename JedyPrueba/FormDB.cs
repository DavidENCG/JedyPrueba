using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JedyPrueba
{
    public partial class FormDB : Form
    {
        public FormDB()
        {
            InitializeComponent();
        }

        private void FormDB_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dbpruebajedyDataSet1.datos' Puede moverla o quitarla según sea necesario.
            this.datosTableAdapter.Fill(this.dbpruebajedyDataSet1.datos);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
