﻿namespace PryTomasProyecto
{
    partial class FrmInventario
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
            this.MrcProducto = new System.Windows.Forms.GroupBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.LblNombre = new System.Windows.Forms.Label();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.LblCodigo = new System.Windows.Forms.Label();
            this.TxtDesc = new System.Windows.Forms.TextBox();
            this.LblDesc = new System.Windows.Forms.Label();
            this.TxtPrecio = new System.Windows.Forms.TextBox();
            this.LblPrecio = new System.Windows.Forms.Label();
            this.LblStock = new System.Windows.Forms.Label();
            this.NumStock = new System.Windows.Forms.NumericUpDown();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.LblCategoria = new System.Windows.Forms.Label();
            this.CmbCategoria = new System.Windows.Forms.ComboBox();
            this.DgvGrilla = new System.Windows.Forms.DataGridView();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.MrcProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvGrilla)).BeginInit();
            this.SuspendLayout();
            // 
            // MrcProducto
            // 
            this.MrcProducto.Controls.Add(this.BtnEliminar);
            this.MrcProducto.Controls.Add(this.BtnModificar);
            this.MrcProducto.Controls.Add(this.CmbCategoria);
            this.MrcProducto.Controls.Add(this.LblCategoria);
            this.MrcProducto.Controls.Add(this.BtnAgregar);
            this.MrcProducto.Controls.Add(this.NumStock);
            this.MrcProducto.Controls.Add(this.LblStock);
            this.MrcProducto.Controls.Add(this.TxtPrecio);
            this.MrcProducto.Controls.Add(this.LblPrecio);
            this.MrcProducto.Controls.Add(this.TxtDesc);
            this.MrcProducto.Controls.Add(this.LblDesc);
            this.MrcProducto.Controls.Add(this.TxtNombre);
            this.MrcProducto.Controls.Add(this.LblNombre);
            this.MrcProducto.Controls.Add(this.TxtCodigo);
            this.MrcProducto.Controls.Add(this.LblCodigo);
            this.MrcProducto.Location = new System.Drawing.Point(12, 34);
            this.MrcProducto.Name = "MrcProducto";
            this.MrcProducto.Size = new System.Drawing.Size(206, 388);
            this.MrcProducto.TabIndex = 0;
            this.MrcProducto.TabStop = false;
            this.MrcProducto.Text = "Producto";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(78, 84);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(112, 20);
            this.TxtNombre.TabIndex = 4;
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Location = new System.Drawing.Point(6, 87);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(47, 13);
            this.LblNombre.TabIndex = 3;
            this.LblNombre.Text = "Nombre:";
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Location = new System.Drawing.Point(78, 42);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(112, 20);
            this.TxtCodigo.TabIndex = 2;
            // 
            // LblCodigo
            // 
            this.LblCodigo.AutoSize = true;
            this.LblCodigo.Location = new System.Drawing.Point(6, 45);
            this.LblCodigo.Name = "LblCodigo";
            this.LblCodigo.Size = new System.Drawing.Size(43, 13);
            this.LblCodigo.TabIndex = 1;
            this.LblCodigo.Text = "Código:";
            // 
            // TxtDesc
            // 
            this.TxtDesc.Location = new System.Drawing.Point(78, 123);
            this.TxtDesc.Name = "TxtDesc";
            this.TxtDesc.Size = new System.Drawing.Size(112, 20);
            this.TxtDesc.TabIndex = 6;
            // 
            // LblDesc
            // 
            this.LblDesc.AutoSize = true;
            this.LblDesc.Location = new System.Drawing.Point(6, 126);
            this.LblDesc.Name = "LblDesc";
            this.LblDesc.Size = new System.Drawing.Size(66, 13);
            this.LblDesc.TabIndex = 5;
            this.LblDesc.Text = "Descripción:";
            // 
            // TxtPrecio
            // 
            this.TxtPrecio.Location = new System.Drawing.Point(78, 199);
            this.TxtPrecio.Name = "TxtPrecio";
            this.TxtPrecio.Size = new System.Drawing.Size(112, 20);
            this.TxtPrecio.TabIndex = 8;
            // 
            // LblPrecio
            // 
            this.LblPrecio.AutoSize = true;
            this.LblPrecio.Location = new System.Drawing.Point(6, 202);
            this.LblPrecio.Name = "LblPrecio";
            this.LblPrecio.Size = new System.Drawing.Size(40, 13);
            this.LblPrecio.TabIndex = 7;
            this.LblPrecio.Text = "Precio:";
            // 
            // LblStock
            // 
            this.LblStock.AutoSize = true;
            this.LblStock.Location = new System.Drawing.Point(6, 242);
            this.LblStock.Name = "LblStock";
            this.LblStock.Size = new System.Drawing.Size(38, 13);
            this.LblStock.TabIndex = 9;
            this.LblStock.Text = "Stock:";
            // 
            // NumStock
            // 
            this.NumStock.Location = new System.Drawing.Point(78, 240);
            this.NumStock.Name = "NumStock";
            this.NumStock.Size = new System.Drawing.Size(112, 20);
            this.NumStock.TabIndex = 1;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(9, 308);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(181, 23);
            this.BtnAgregar.TabIndex = 1;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            // 
            // LblCategoria
            // 
            this.LblCategoria.AutoSize = true;
            this.LblCategoria.Location = new System.Drawing.Point(6, 166);
            this.LblCategoria.Name = "LblCategoria";
            this.LblCategoria.Size = new System.Drawing.Size(55, 13);
            this.LblCategoria.TabIndex = 10;
            this.LblCategoria.Text = "Categoria:";
            // 
            // CmbCategoria
            // 
            this.CmbCategoria.FormattingEnabled = true;
            this.CmbCategoria.Location = new System.Drawing.Point(78, 163);
            this.CmbCategoria.Name = "CmbCategoria";
            this.CmbCategoria.Size = new System.Drawing.Size(112, 21);
            this.CmbCategoria.TabIndex = 1;
            // 
            // DgvGrilla
            // 
            this.DgvGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvGrilla.Location = new System.Drawing.Point(235, 34);
            this.DgvGrilla.Name = "DgvGrilla";
            this.DgvGrilla.Size = new System.Drawing.Size(402, 388);
            this.DgvGrilla.TabIndex = 1;
            // 
            // BtnModificar
            // 
            this.BtnModificar.Location = new System.Drawing.Point(9, 347);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(84, 23);
            this.BtnModificar.TabIndex = 11;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = true;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(106, 347);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(84, 23);
            this.BtnEliminar.TabIndex = 12;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            // 
            // FrmInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 440);
            this.Controls.Add(this.DgvGrilla);
            this.Controls.Add(this.MrcProducto);
            this.Name = "FrmInventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Inventario";
            this.MrcProducto.ResumeLayout(false);
            this.MrcProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvGrilla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox MrcProducto;
        private System.Windows.Forms.Label LblCodigo;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.NumericUpDown NumStock;
        private System.Windows.Forms.Label LblStock;
        private System.Windows.Forms.TextBox TxtPrecio;
        private System.Windows.Forms.Label LblPrecio;
        private System.Windows.Forms.TextBox TxtDesc;
        private System.Windows.Forms.Label LblDesc;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.ComboBox CmbCategoria;
        private System.Windows.Forms.Label LblCategoria;
        private System.Windows.Forms.DataGridView DgvGrilla;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnEliminar;
    }
}

