namespace Pry_BD_Clientes_Franco
{
    partial class frmClientes
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btnConect = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.clm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clm,
            this.clm2,
            this.clm3,
            this.clm4,
            this.clm5,
            this.clm6,
            this.clm7,
            this.clm8,
            this.clm9,
            this.clm10,
            this.Fax});
            this.dgv.Location = new System.Drawing.Point(12, 76);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(776, 362);
            this.dgv.TabIndex = 0;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnConect
            // 
            this.btnConect.Location = new System.Drawing.Point(4, 1);
            this.btnConect.Name = "btnConect";
            this.btnConect.Size = new System.Drawing.Size(795, 10);
            this.btnConect.TabIndex = 1;
            this.btnConect.UseVisualStyleBackColor = true;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(713, 17);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(75, 23);
            this.btnMostrar.TabIndex = 2;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.clientes_Click);
            // 
            // clm
            // 
            this.clm.HeaderText = "ID";
            this.clm.Name = "clm";
            // 
            // clm2
            // 
            this.clm2.HeaderText = "Nombre de compañia";
            this.clm2.Name = "clm2";
            // 
            // clm3
            // 
            this.clm3.HeaderText = "Nombre de contacto";
            this.clm3.Name = "clm3";
            // 
            // clm4
            // 
            this.clm4.HeaderText = "Cargo de contacto";
            this.clm4.Name = "clm4";
            // 
            // clm5
            // 
            this.clm5.HeaderText = "Direccion";
            this.clm5.Name = "clm5";
            // 
            // clm6
            // 
            this.clm6.HeaderText = "Ciudad";
            this.clm6.Name = "clm6";
            // 
            // clm7
            // 
            this.clm7.HeaderText = "Region";
            this.clm7.Name = "clm7";
            // 
            // clm8
            // 
            this.clm8.HeaderText = "Codigo postal";
            this.clm8.Name = "clm8";
            // 
            // clm9
            // 
            this.clm9.HeaderText = "Pais";
            this.clm9.Name = "clm9";
            // 
            // clm10
            // 
            this.clm10.HeaderText = "Telefono";
            this.clm10.Name = "clm10";
            // 
            // Fax
            // 
            this.Fax.HeaderText = "Fax";
            this.Fax.Name = "Fax";
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnConect);
            this.Controls.Add(this.dgv);
            this.Name = "frmClientes";
            this.Text = "clientes ";
            this.Load += new System.EventHandler(this.frmClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btnConect;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm3;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm4;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm5;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm6;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm7;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm8;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm9;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fax;
    }
}