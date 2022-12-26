namespace PrimerEjemplo_aso_net
{
    partial class frmAltaPokemon
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
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txbNumero = new System.Windows.Forms.TextBox();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.txbDescripcion = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblDebilidad = new System.Windows.Forms.Label();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.cboDebilidad = new System.Windows.Forms.ComboBox();
            this.txbUrlImagen = new System.Windows.Forms.TextBox();
            this.lblUrlImagen = new System.Windows.Forms.Label();
            this.pbxPokemons = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPokemons)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(134, 65);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(44, 13);
            this.lblNumero.TabIndex = 0;
            this.lblNumero.Text = "Numero";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(134, 101);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(134, 136);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 2;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // txbNumero
            // 
            this.txbNumero.Location = new System.Drawing.Point(213, 57);
            this.txbNumero.Name = "txbNumero";
            this.txbNumero.Size = new System.Drawing.Size(121, 20);
            this.txbNumero.TabIndex = 0;
            // 
            // txbNombre
            // 
            this.txbNombre.Location = new System.Drawing.Point(213, 93);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(121, 20);
            this.txbNombre.TabIndex = 1;
            // 
            // txbDescripcion
            // 
            this.txbDescripcion.Location = new System.Drawing.Point(213, 128);
            this.txbDescripcion.Name = "txbDescripcion";
            this.txbDescripcion.Size = new System.Drawing.Size(121, 20);
            this.txbDescripcion.TabIndex = 2;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(137, 350);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(238, 350);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(134, 233);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(28, 13);
            this.lblTipo.TabIndex = 8;
            this.lblTipo.Text = "Tipo";
            // 
            // lblDebilidad
            // 
            this.lblDebilidad.AutoSize = true;
            this.lblDebilidad.Location = new System.Drawing.Point(137, 272);
            this.lblDebilidad.Name = "lblDebilidad";
            this.lblDebilidad.Size = new System.Drawing.Size(51, 13);
            this.lblDebilidad.TabIndex = 9;
            this.lblDebilidad.Text = "Debilidad";
            // 
            // cboTipo
            // 
            this.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Location = new System.Drawing.Point(213, 225);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(121, 21);
            this.cboTipo.TabIndex = 4;
            // 
            // cboDebilidad
            // 
            this.cboDebilidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDebilidad.FormattingEnabled = true;
            this.cboDebilidad.Location = new System.Drawing.Point(213, 264);
            this.cboDebilidad.Name = "cboDebilidad";
            this.cboDebilidad.Size = new System.Drawing.Size(121, 21);
            this.cboDebilidad.TabIndex = 5;
            // 
            // txbUrlImagen
            // 
            this.txbUrlImagen.Location = new System.Drawing.Point(213, 169);
            this.txbUrlImagen.Name = "txbUrlImagen";
            this.txbUrlImagen.Size = new System.Drawing.Size(121, 20);
            this.txbUrlImagen.TabIndex = 3;
            this.txbUrlImagen.Leave += new System.EventHandler(this.txbUrlImagen_Leave);
            // 
            // lblUrlImagen
            // 
            this.lblUrlImagen.AutoSize = true;
            this.lblUrlImagen.Location = new System.Drawing.Point(134, 177);
            this.lblUrlImagen.Name = "lblUrlImagen";
            this.lblUrlImagen.Size = new System.Drawing.Size(58, 13);
            this.lblUrlImagen.TabIndex = 12;
            this.lblUrlImagen.Text = "Url Imagen";
            // 
            // pbxPokemons
            // 
            this.pbxPokemons.Location = new System.Drawing.Point(361, 57);
            this.pbxPokemons.Name = "pbxPokemons";
            this.pbxPokemons.Size = new System.Drawing.Size(343, 316);
            this.pbxPokemons.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxPokemons.TabIndex = 14;
            this.pbxPokemons.TabStop = false;
            // 
            // frmAltaPokemon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 540);
            this.Controls.Add(this.pbxPokemons);
            this.Controls.Add(this.txbUrlImagen);
            this.Controls.Add(this.lblUrlImagen);
            this.Controls.Add(this.cboDebilidad);
            this.Controls.Add(this.cboTipo);
            this.Controls.Add(this.lblDebilidad);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txbDescripcion);
            this.Controls.Add(this.txbNombre);
            this.Controls.Add(this.txbNumero);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblNumero);
            this.Name = "frmAltaPokemon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Pokemon";
            this.Load += new System.EventHandler(this.frmAltaPokemon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxPokemons)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txbNumero;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.TextBox txbDescripcion;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblDebilidad;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.ComboBox cboDebilidad;
        private System.Windows.Forms.TextBox txbUrlImagen;
        private System.Windows.Forms.Label lblUrlImagen;
        private System.Windows.Forms.PictureBox pbxPokemons;
    }
}