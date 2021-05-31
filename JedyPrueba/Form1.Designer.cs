
namespace JedyPrueba
{
    partial class JedySystem
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JedySystem));
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtlastn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnsend = new System.Windows.Forms.Button();
            this.btncerrar = new System.Windows.Forms.PictureBox();
            this.btnminimizar = new System.Windows.Forms.PictureBox();
            this.txtage = new System.Windows.Forms.TextBox();
            this.dbpruebajedyDataSet = new JedyPrueba.dbpruebajedyDataSet();
            this.datosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datosTableAdapter = new JedyPrueba.dbpruebajedyDataSetTableAdapters.datosTableAdapter();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnminimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbpruebajedyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape3,
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(780, 330);
            this.shapeContainer1.TabIndex = 1;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape3
            // 
            this.lineShape3.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.lineShape3.Enabled = false;
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.SelectionColor = System.Drawing.SystemColors.MenuHighlight;
            this.lineShape3.X1 = 306;
            this.lineShape3.X2 = 726;
            this.lineShape3.Y1 = 203;
            this.lineShape3.Y2 = 203;
            this.lineShape3.Click += new System.EventHandler(this.lineShape2_Click);
            // 
            // lineShape2
            // 
            this.lineShape2.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.lineShape2.Enabled = false;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.SelectionColor = System.Drawing.SystemColors.MenuHighlight;
            this.lineShape2.X1 = 305;
            this.lineShape2.X2 = 725;
            this.lineShape2.Y1 = 150;
            this.lineShape2.Y2 = 150;
            this.lineShape2.Click += new System.EventHandler(this.lineShape2_Click);
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.lineShape1.Enabled = false;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.SelectionColor = System.Drawing.SystemColors.MenuHighlight;
            this.lineShape1.X1 = 306;
            this.lineShape1.X2 = 726;
            this.lineShape1.Y1 = 98;
            this.lineShape1.Y2 = 98;
            // 
            // txtname
            // 
            this.txtname.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtname.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtname.Location = new System.Drawing.Point(308, 77);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(421, 19);
            this.txtname.TabIndex = 1;
            this.txtname.Text = "Nombre";
            this.txtname.TextChanged += new System.EventHandler(this.txtname_TextChanged);
            this.txtname.Enter += new System.EventHandler(this.txtname_Enter);
            this.txtname.Leave += new System.EventHandler(this.txtname_Leave);
            // 
            // txtlastn
            // 
            this.txtlastn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtlastn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtlastn.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlastn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtlastn.Location = new System.Drawing.Point(308, 129);
            this.txtlastn.Name = "txtlastn";
            this.txtlastn.Size = new System.Drawing.Size(421, 19);
            this.txtlastn.TabIndex = 2;
            this.txtlastn.Text = "Apellido";
            this.txtlastn.TextChanged += new System.EventHandler(this.txtlastn_TextChanged);
            this.txtlastn.Enter += new System.EventHandler(this.txtlastn_Enter);
            this.txtlastn.Leave += new System.EventHandler(this.txtlastn_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(356, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 34);
            this.label1.TabIndex = 4;
            this.label1.Text = "FORMULARIO DE INGRESO";
            // 
            // btnsend
            // 
            this.btnsend.BackColor = System.Drawing.Color.DimGray;
            this.btnsend.FlatAppearance.BorderSize = 0;
            this.btnsend.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnsend.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnsend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsend.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsend.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnsend.Location = new System.Drawing.Point(306, 232);
            this.btnsend.Name = "btnsend";
            this.btnsend.Size = new System.Drawing.Size(421, 30);
            this.btnsend.TabIndex = 1;
            this.btnsend.Text = "ENVIAR";
            this.btnsend.UseVisualStyleBackColor = false;
            this.btnsend.Click += new System.EventHandler(this.btnsend_Click);
            // 
            // btncerrar
            // 
            this.btncerrar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btncerrar.Image = ((System.Drawing.Image)(resources.GetObject("btncerrar.Image")));
            this.btncerrar.Location = new System.Drawing.Point(748, 14);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(20, 14);
            this.btncerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btncerrar.TabIndex = 6;
            this.btncerrar.TabStop = false;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // btnminimizar
            // 
            this.btnminimizar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnminimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnminimizar.Image")));
            this.btnminimizar.Location = new System.Drawing.Point(714, 6);
            this.btnminimizar.Name = "btnminimizar";
            this.btnminimizar.Size = new System.Drawing.Size(35, 31);
            this.btnminimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnminimizar.TabIndex = 7;
            this.btnminimizar.TabStop = false;
            this.btnminimizar.Click += new System.EventHandler(this.btnminimizar_Click);
            // 
            // txtage
            // 
            this.txtage.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtage.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtage.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtage.Location = new System.Drawing.Point(305, 182);
            this.txtage.Name = "txtage";
            this.txtage.Size = new System.Drawing.Size(421, 19);
            this.txtage.TabIndex = 3;
            this.txtage.Text = "Edad";
            this.txtage.TextChanged += new System.EventHandler(this.txtage_TextChanged);
            this.txtage.Enter += new System.EventHandler(this.txtage_Enter);
            this.txtage.Leave += new System.EventHandler(this.txtage_Leave);
            // 
            // dbpruebajedyDataSet
            // 
            this.dbpruebajedyDataSet.DataSetName = "dbpruebajedyDataSet";
            this.dbpruebajedyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // datosBindingSource
            // 
            this.datosBindingSource.DataMember = "datos";
            this.datosBindingSource.DataSource = this.dbpruebajedyDataSet;
            // 
            // datosTableAdapter
            // 
            this.datosTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(8, 77);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(229, 176);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 330);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(305, 275);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(421, 30);
            this.button1.TabIndex = 8;
            this.button1.Text = "MOSTRAR DB";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // JedySystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(780, 330);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtage);
            this.Controls.Add(this.btnminimizar);
            this.Controls.Add(this.btncerrar);
            this.Controls.Add(this.btnsend);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtlastn);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.shapeContainer1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "JedySystem";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JedySistem - Formulario";
            this.Load += new System.EventHandler(this.JedySystem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnminimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbpruebajedyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtlastn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnsend;
        private System.Windows.Forms.PictureBox btncerrar;
        private System.Windows.Forms.PictureBox btnminimizar;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private System.Windows.Forms.TextBox txtage;
        private dbpruebajedyDataSet dbpruebajedyDataSet;
        private System.Windows.Forms.BindingSource datosBindingSource;
        private dbpruebajedyDataSetTableAdapters.datosTableAdapter datosTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
    }
}

