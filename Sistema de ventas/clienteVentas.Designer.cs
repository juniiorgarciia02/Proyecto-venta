namespace Sistema_de_ventas
{
    partial class clienteVentas
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            this.dataGridView1.Location = new System.Drawing.Point(14, 96);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1146, 395);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(656, 29);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox2.Size = new System.Drawing.Size(265, 59);
            this.groupBox2.TabIndex = 6;
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
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtBuscar);
            this.groupBox1.Location = new System.Drawing.Point(74, 29);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Size = new System.Drawing.Size(340, 59);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(27, 23);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(277, 20);
            this.txtBuscar.TabIndex = 0;
            this.txtBuscar.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // clienteVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 484);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "clienteVentas";
            this.Text = "clienteVentas";
            this.Load += new System.EventHandler(this.clienteVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

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
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBuscar;
    }
}