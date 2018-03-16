namespace Sistema_de_ventas
{
    partial class ClientesRegistrado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cod_client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomb_client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direc_client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apodo_client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ciudad_client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.provincia_client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codpost_client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tell_client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email_client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faxn_client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notas_client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtBuscar);
            this.groupBox1.Location = new System.Drawing.Point(14, 22);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Size = new System.Drawing.Size(340, 59);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(27, 23);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(277, 24);
            this.txtBuscar.TabIndex = 0;
            this.txtBuscar.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(604, 34);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox2.Size = new System.Drawing.Size(265, 59);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(75, 19);
            this.button1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "Exportar Excel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cod_client,
            this.nomb_client,
            this.direc_client,
            this.apodo_client,
            this.ciudad_client,
            this.provincia_client,
            this.codpost_client,
            this.tell_client,
            this.email_client,
            this.faxn_client,
            this.notas_client});
            this.dataGridView1.Location = new System.Drawing.Point(14, 101);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1146, 395);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // cod_client
            // 
            this.cod_client.Frozen = true;
            this.cod_client.HeaderText = "Codigo";
            this.cod_client.Name = "cod_client";
            this.cod_client.ReadOnly = true;
            // 
            // nomb_client
            // 
            this.nomb_client.Frozen = true;
            this.nomb_client.HeaderText = "Nombre";
            this.nomb_client.Name = "nomb_client";
            this.nomb_client.ReadOnly = true;
            // 
            // direc_client
            // 
            this.direc_client.Frozen = true;
            this.direc_client.HeaderText = "Direccion";
            this.direc_client.Name = "direc_client";
            this.direc_client.ReadOnly = true;
            // 
            // apodo_client
            // 
            this.apodo_client.Frozen = true;
            this.apodo_client.HeaderText = "Apodo";
            this.apodo_client.Name = "apodo_client";
            this.apodo_client.ReadOnly = true;
            // 
            // ciudad_client
            // 
            this.ciudad_client.Frozen = true;
            this.ciudad_client.HeaderText = "Ciudad";
            this.ciudad_client.Name = "ciudad_client";
            this.ciudad_client.ReadOnly = true;
            // 
            // provincia_client
            // 
            this.provincia_client.Frozen = true;
            this.provincia_client.HeaderText = "Provincia";
            this.provincia_client.Name = "provincia_client";
            this.provincia_client.ReadOnly = true;
            // 
            // codpost_client
            // 
            this.codpost_client.Frozen = true;
            this.codpost_client.HeaderText = "CodPostal";
            this.codpost_client.Name = "codpost_client";
            this.codpost_client.ReadOnly = true;
            // 
            // tell_client
            // 
            this.tell_client.Frozen = true;
            this.tell_client.HeaderText = "Telefono";
            this.tell_client.Name = "tell_client";
            this.tell_client.ReadOnly = true;
            // 
            // email_client
            // 
            this.email_client.Frozen = true;
            this.email_client.HeaderText = "Email";
            this.email_client.Name = "email_client";
            this.email_client.ReadOnly = true;
            // 
            // faxn_client
            // 
            this.faxn_client.Frozen = true;
            this.faxn_client.HeaderText = "Fax";
            this.faxn_client.Name = "faxn_client";
            this.faxn_client.ReadOnly = true;
            // 
            // notas_client
            // 
            this.notas_client.Frozen = true;
            this.notas_client.HeaderText = "Notas";
            this.notas_client.Name = "notas_client";
            this.notas_client.ReadOnly = true;
            // 
            // ClientesRegistrado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1183, 583);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "ClientesRegistrado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClientesRegistrado";
            this.Load += new System.EventHandler(this.ClientesRegistrado_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_client;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomb_client;
        private System.Windows.Forms.DataGridViewTextBoxColumn direc_client;
        private System.Windows.Forms.DataGridViewTextBoxColumn apodo_client;
        private System.Windows.Forms.DataGridViewTextBoxColumn ciudad_client;
        private System.Windows.Forms.DataGridViewTextBoxColumn provincia_client;
        private System.Windows.Forms.DataGridViewTextBoxColumn codpost_client;
        private System.Windows.Forms.DataGridViewTextBoxColumn tell_client;
        private System.Windows.Forms.DataGridViewTextBoxColumn email_client;
        private System.Windows.Forms.DataGridViewTextBoxColumn faxn_client;
        private System.Windows.Forms.DataGridViewTextBoxColumn notas_client;
        public System.Windows.Forms.TextBox txtBuscar;
    }
}