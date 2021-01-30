﻿namespace CustomControlsProject
{
    partial class Videojuego
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

        #region Código generado por el Diseñador de componentes

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Videojuego));
            this.pb_Image = new System.Windows.Forms.PictureBox();
            this.lb_name = new System.Windows.Forms.Label();
            this.cms_properties = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmi_run = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_properties = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_delete = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Image)).BeginInit();
            this.cms_properties.SuspendLayout();
            this.SuspendLayout();
            // 
            // pb_Image
            // 
            this.pb_Image.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pb_Image.Image = ((System.Drawing.Image)(resources.GetObject("pb_Image.Image")));
            this.pb_Image.InitialImage = ((System.Drawing.Image)(resources.GetObject("pb_Image.InitialImage")));
            this.pb_Image.Location = new System.Drawing.Point(0, 0);
            this.pb_Image.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pb_Image.Name = "pb_Image";
            this.pb_Image.Size = new System.Drawing.Size(180, 280);
            this.pb_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Image.TabIndex = 0;
            this.pb_Image.TabStop = false;
            this.pb_Image.Click += new System.EventHandler(this.pb_Image_Click);
            // 
            // lb_name
            // 
            this.lb_name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lb_name.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_name.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_name.Location = new System.Drawing.Point(0, 190);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(180, 90);
            this.lb_name.TabIndex = 1;
            this.lb_name.Text = "Untitled Game";
            this.lb_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_name.Click += new System.EventHandler(this.pb_Image_Click);
            // 
            // cms_properties
            // 
            this.cms_properties.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_run,
            this.tsmi_properties,
            this.tsmi_delete});
            this.cms_properties.Name = "cms_properties";
            this.cms_properties.Size = new System.Drawing.Size(181, 92);
            // 
            // tsmi_run
            // 
            this.tsmi_run.Name = "tsmi_run";
            this.tsmi_run.Size = new System.Drawing.Size(180, 22);
            this.tsmi_run.Text = "Ejecutar";
            this.tsmi_run.Click += new System.EventHandler(this.tsmi_run_Click);
            // 
            // tsmi_properties
            // 
            this.tsmi_properties.Name = "tsmi_properties";
            this.tsmi_properties.Size = new System.Drawing.Size(180, 22);
            this.tsmi_properties.Text = "Propiedades";
            this.tsmi_properties.Click += new System.EventHandler(this.tsmi_properties_Click);
            // 
            // tsmi_delete
            // 
            this.tsmi_delete.Name = "tsmi_delete";
            this.tsmi_delete.Size = new System.Drawing.Size(180, 22);
            this.tsmi_delete.Text = "Eliminar";
            this.tsmi_delete.Click += new System.EventHandler(this.tsmi_delete_Click);
            // 
            // Videojuego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lb_name);
            this.Controls.Add(this.pb_Image);
            this.Name = "Videojuego";
            this.Size = new System.Drawing.Size(180, 280);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Image)).EndInit();
            this.cms_properties.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_Image;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.ContextMenuStrip cms_properties;
        private System.Windows.Forms.ToolStripMenuItem tsmi_run;
        private System.Windows.Forms.ToolStripMenuItem tsmi_properties;
        private System.Windows.Forms.ToolStripMenuItem tsmi_delete;
    }
}
