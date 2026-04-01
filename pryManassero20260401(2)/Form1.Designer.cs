namespace pryManassero20260401_2_
{
    partial class Form1
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
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNOmbre = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.txbCodigo = new System.Windows.Forms.TextBox();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.lblCat = new System.Windows.Forms.Label();
            this.cbxCat = new System.Windows.Forms.ComboBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblDato = new System.Windows.Forms.Label();
            this.mtxPrecio = new System.Windows.Forms.MaskedTextBox();
            this.mxtStock = new System.Windows.Forms.MaskedTextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCanc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.BackColor = System.Drawing.Color.NavajoWhite;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(26, 147);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(51, 17);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Codigo";
            // 
            // lblNOmbre
            // 
            this.lblNOmbre.AutoSize = true;
            this.lblNOmbre.BackColor = System.Drawing.Color.NavajoWhite;
            this.lblNOmbre.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNOmbre.Location = new System.Drawing.Point(282, 147);
            this.lblNOmbre.Name = "lblNOmbre";
            this.lblNOmbre.Size = new System.Drawing.Size(57, 17);
            this.lblNOmbre.TabIndex = 2;
            this.lblNOmbre.Text = "Nombre";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.BackColor = System.Drawing.Color.NavajoWhite;
            this.lblDesc.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.Location = new System.Drawing.Point(51, 392);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(76, 17);
            this.lblDesc.TabIndex = 4;
            this.lblDesc.Text = "Descripción";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.BackColor = System.Drawing.Color.NavajoWhite;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(282, 223);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(44, 17);
            this.lblPrecio.TabIndex = 5;
            this.lblPrecio.Text = "Precio";
            this.lblPrecio.Click += new System.EventHandler(this.lblPrecio_Click);
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.BackColor = System.Drawing.Color.NavajoWhite;
            this.lblStock.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.Location = new System.Drawing.Point(26, 223);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(40, 17);
            this.lblStock.TabIndex = 8;
            this.lblStock.Text = "Stock";
            // 
            // txbCodigo
            // 
            this.txbCodigo.BackColor = System.Drawing.Color.NavajoWhite;
            this.txbCodigo.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCodigo.Location = new System.Drawing.Point(122, 144);
            this.txbCodigo.Name = "txbCodigo";
            this.txbCodigo.Size = new System.Drawing.Size(100, 23);
            this.txbCodigo.TabIndex = 9;
            // 
            // txbNombre
            // 
            this.txbNombre.BackColor = System.Drawing.Color.NavajoWhite;
            this.txbNombre.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNombre.Location = new System.Drawing.Point(370, 141);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(102, 23);
            this.txbNombre.TabIndex = 10;
            // 
            // txtDesc
            // 
            this.txtDesc.BackColor = System.Drawing.Color.NavajoWhite;
            this.txtDesc.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesc.Location = new System.Drawing.Point(180, 389);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(159, 71);
            this.txtDesc.TabIndex = 11;
            // 
            // lblCat
            // 
            this.lblCat.AutoSize = true;
            this.lblCat.BackColor = System.Drawing.Color.NavajoWhite;
            this.lblCat.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCat.Location = new System.Drawing.Point(51, 300);
            this.lblCat.Name = "lblCat";
            this.lblCat.Size = new System.Drawing.Size(65, 17);
            this.lblCat.TabIndex = 13;
            this.lblCat.Text = "Categoria";
            // 
            // cbxCat
            // 
            this.cbxCat.BackColor = System.Drawing.Color.NavajoWhite;
            this.cbxCat.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCat.FormattingEnabled = true;
            this.cbxCat.Items.AddRange(new object[] {
            "Media",
            "Remera",
            "Pantalon ",
            "Buzo"});
            this.cbxCat.Location = new System.Drawing.Point(180, 300);
            this.cbxCat.Name = "cbxCat";
            this.cbxCat.Size = new System.Drawing.Size(159, 25);
            this.cbxCat.TabIndex = 14;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(148, 27);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(212, 28);
            this.lblTitulo.TabIndex = 16;
            this.lblTitulo.Text = "Gestion de inventario";
            // 
            // lblDato
            // 
            this.lblDato.AutoSize = true;
            this.lblDato.BackColor = System.Drawing.Color.NavajoWhite;
            this.lblDato.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDato.ForeColor = System.Drawing.Color.Black;
            this.lblDato.Location = new System.Drawing.Point(51, 74);
            this.lblDato.Name = "lblDato";
            this.lblDato.Size = new System.Drawing.Size(111, 16);
            this.lblDato.TabIndex = 17;
            this.lblDato.Text = "Datos del producto:";
            // 
            // mtxPrecio
            // 
            this.mtxPrecio.BackColor = System.Drawing.Color.NavajoWhite;
            this.mtxPrecio.Location = new System.Drawing.Point(372, 220);
            this.mtxPrecio.Name = "mtxPrecio";
            this.mtxPrecio.Size = new System.Drawing.Size(100, 20);
            this.mtxPrecio.TabIndex = 19;
            // 
            // mxtStock
            // 
            this.mxtStock.BackColor = System.Drawing.Color.NavajoWhite;
            this.mxtStock.Location = new System.Drawing.Point(122, 223);
            this.mxtStock.Name = "mxtStock";
            this.mxtStock.Size = new System.Drawing.Size(100, 20);
            this.mxtStock.TabIndex = 20;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAgregar.Location = new System.Drawing.Point(387, 498);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 21;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            // 
            // btnCanc
            // 
            this.btnCanc.BackColor = System.Drawing.Color.Crimson;
            this.btnCanc.Location = new System.Drawing.Point(285, 498);
            this.btnCanc.Name = "btnCanc";
            this.btnCanc.Size = new System.Drawing.Size(75, 23);
            this.btnCanc.TabIndex = 22;
            this.btnCanc.Text = "Cancelar";
            this.btnCanc.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(484, 550);
            this.Controls.Add(this.btnCanc);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.mxtStock);
            this.Controls.Add(this.mtxPrecio);
            this.Controls.Add(this.lblDato);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.cbxCat);
            this.Controls.Add(this.lblCat);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.txbNombre);
            this.Controls.Add(this.txbCodigo);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblNOmbre);
            this.Controls.Add(this.lblCodigo);
            this.Name = "Form1";
            this.Text = "Gestón de negocio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNOmbre;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.TextBox txbCodigo;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label lblCat;
        private System.Windows.Forms.ComboBox cbxCat;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblDato;
        private System.Windows.Forms.MaskedTextBox mtxPrecio;
        private System.Windows.Forms.MaskedTextBox mxtStock;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCanc;
    }
}

