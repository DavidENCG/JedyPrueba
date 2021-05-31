using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;



namespace JedyPrueba
{
    public partial class JedySystem : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=192.168.43.12;Initial Catalog=dbpruebajedy;Integrated Security=True");
        public JedySystem()
        {
            InitializeComponent();
        }

        


        private void lineShape2_Click(object sender, EventArgs e)
        {

        }

        private void txtname_Enter(object sender, EventArgs e)
        {
            if (txtname.Text == "Nombre")
            {
                txtname.Text = "";
                txtname.ForeColor = Color.LightGray;
            }
        }

        private void txtname_Leave(object sender, EventArgs e)
        {
            if (txtname.Text=="")
            {
                txtname.Text = "Nombre";
                txtname.ForeColor = Color.DimGray;
            }
        }

        private void txtlastn_Enter(object sender, EventArgs e)
        {
            if (txtlastn.Text=="Apellido")
            {
                txtlastn.Text = "";
                txtlastn.ForeColor = Color.LightGray;
            }
        }

        private void txtlastn_Leave(object sender, EventArgs e)
        {
            if (txtlastn.Text=="")
            {
                txtlastn.Text = "Apellido";
                txtlastn.ForeColor = Color.DimGray;
            }
        }

        private void txtage_Enter(object sender, EventArgs e)
        {
            if (txtage.Text == "Edad")
            {
                txtage.Text = "";
                txtage.ForeColor = Color.LightGray;
            }

        }

        private void txtage_Leave(object sender, EventArgs e)
        {
            if (txtage.Text == "")
            {
                txtage.Text = "Edad";
                txtage.ForeColor = Color.DimGray;
            }
        }

        private void txtlastn_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtage_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnsend_Click(object sender, EventArgs e)
        {
            conn.Open();
            string name = txtname.Text;
            string lastn = txtlastn.Text;
            string age = txtage.Text;


            SqlCommand query = new SqlCommand("INSERT INTO datos VALUES('"+name+ "', '"+lastn+ "', '"+age+"')",conn);
            int r = query.ExecuteNonQuery();

            if (r > 0)
            {
                MessageBox.Show("Datos guardados con éxito", "Datos guardados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error al guardar los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();





            //Mensaje de conexion a la BD

            /*if (conn.State == ConnectionState.Open)
            {
                MessageBox.Show("Conectado con el Servidor", "Conectado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Ocurrio un error");
            }*/
           

        }

        private void JedySystem_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dbpruebajedyDataSet.datos' Puede moverla o quitarla según sea necesario.
            this.datosTableAdapter.Fill(this.dbpruebajedyDataSet.datos);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form formulariodb = new FormDB();
            formulariodb.Show();
        }
    }
}
