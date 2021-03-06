﻿namespace bibliotecaVideojuegos
{
    partial class MainScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.flp_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bt_add = new System.Windows.Forms.ToolStripMenuItem();
            this.bt_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferenciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.steamConnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lb_library = new System.Windows.Forms.Label();
            this.lb_empty = new System.Windows.Forms.Label();
            this.lb_addGame = new System.Windows.Forms.LinkLabel();
            this.pb_empty = new System.Windows.Forms.PictureBox();
            this.cms_properties = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmi_run = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_properties = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_delete = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_empty)).BeginInit();
            this.cms_properties.SuspendLayout();
            this.SuspendLayout();
            // 
            // flp_panel
            // 
            this.flp_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flp_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flp_panel.Location = new System.Drawing.Point(12, 65);
            this.flp_panel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flp_panel.Name = "flp_panel";
            this.flp_panel.Size = new System.Drawing.Size(778, 376);
            this.flp_panel.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(804, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bt_add,
            this.bt_exit});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // bt_add
            // 
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(217, 26);
            this.bt_add.Text = "Añadir Videojuego";
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // bt_exit
            // 
            this.bt_exit.Name = "bt_exit";
            this.bt_exit.Size = new System.Drawing.Size(217, 26);
            this.bt_exit.Text = "Salir";
            this.bt_exit.Click += new System.EventHandler(this.bt_exit_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.preferenciasToolStripMenuItem,
            this.steamConnToolStripMenuItem});
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.editarToolStripMenuItem.Text = "Editar";
            // 
            // preferenciasToolStripMenuItem
            // 
            this.preferenciasToolStripMenuItem.Enabled = false;
            this.preferenciasToolStripMenuItem.Name = "preferenciasToolStripMenuItem";
            this.preferenciasToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.preferenciasToolStripMenuItem.Text = "Preferencias";
            // 
            // steamConnToolStripMenuItem
            // 
            this.steamConnToolStripMenuItem.Enabled = false;
            this.steamConnToolStripMenuItem.Name = "steamConnToolStripMenuItem";
            this.steamConnToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.steamConnToolStripMenuItem.Text = "Conectar con Steam";
            // 
            // lb_library
            // 
            this.lb_library.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb_library.AutoSize = true;
            this.lb_library.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_library.ForeColor = System.Drawing.SystemColors.Window;
            this.lb_library.Location = new System.Drawing.Point(300, 30);
            this.lb_library.Name = "lb_library";
            this.lb_library.Size = new System.Drawing.Size(175, 36);
            this.lb_library.TabIndex = 2;
            this.lb_library.Text = "Biblioteca";
            this.lb_library.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_empty
            // 
            this.lb_empty.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_empty.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_empty.ForeColor = System.Drawing.Color.DimGray;
            this.lb_empty.Location = new System.Drawing.Point(245, 254);
            this.lb_empty.Name = "lb_empty";
            this.lb_empty.Size = new System.Drawing.Size(291, 100);
            this.lb_empty.TabIndex = 3;
            this.lb_empty.Text = "Parece que la biblioteca está vacía";
            this.lb_empty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_addGame
            // 
            this.lb_addGame.ActiveLinkColor = System.Drawing.Color.Silver;
            this.lb_addGame.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lb_addGame.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_addGame.LinkColor = System.Drawing.Color.Gray;
            this.lb_addGame.Location = new System.Drawing.Point(283, 336);
            this.lb_addGame.Name = "lb_addGame";
            this.lb_addGame.Size = new System.Drawing.Size(220, 17);
            this.lb_addGame.TabIndex = 4;
            this.lb_addGame.TabStop = true;
            this.lb_addGame.Text = "Añade tu Primer Videojuego";
            this.lb_addGame.VisitedLinkColor = System.Drawing.Color.Gray;
            this.lb_addGame.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lb_addGame_LinkClicked);
            // 
            // pb_empty
            // 
            this.pb_empty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pb_empty.Image = ((System.Drawing.Image)(resources.GetObject("pb_empty.Image")));
            this.pb_empty.Location = new System.Drawing.Point(283, 82);
            this.pb_empty.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pb_empty.MaximumSize = new System.Drawing.Size(220, 170);
            this.pb_empty.MinimumSize = new System.Drawing.Size(220, 170);
            this.pb_empty.Name = "pb_empty";
            this.pb_empty.Size = new System.Drawing.Size(220, 170);
            this.pb_empty.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_empty.TabIndex = 5;
            this.pb_empty.TabStop = false;
            // 
            // cms_properties
            // 
            this.cms_properties.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cms_properties.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_run,
            this.tsmi_properties,
            this.tsmi_delete});
            this.cms_properties.Name = "cms_properties";
            this.cms_properties.Size = new System.Drawing.Size(162, 76);
            // 
            // tsmi_run
            // 
            this.tsmi_run.Name = "tsmi_run";
            this.tsmi_run.Size = new System.Drawing.Size(161, 24);
            this.tsmi_run.Text = "Ejecutar";
            this.tsmi_run.Click += new System.EventHandler(this.tsmi_run_Click);
            // 
            // tsmi_properties
            // 
            this.tsmi_properties.Name = "tsmi_properties";
            this.tsmi_properties.Size = new System.Drawing.Size(161, 24);
            this.tsmi_properties.Text = "Propiedades";
            this.tsmi_properties.Click += new System.EventHandler(this.tsmi_properties_Click);
            // 
            // tsmi_delete
            // 
            this.tsmi_delete.Name = "tsmi_delete";
            this.tsmi_delete.Size = new System.Drawing.Size(161, 24);
            this.tsmi_delete.Text = "Eliminar";
            this.tsmi_delete.Click += new System.EventHandler(this.tsmi_delete_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            this.ayudaToolStripMenuItem.Click += new System.EventHandler(this.ayudaToolStripMenuItem_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(804, 462);
            this.Controls.Add(this.pb_empty);
            this.Controls.Add(this.lb_addGame);
            this.Controls.Add(this.lb_empty);
            this.Controls.Add(this.lb_library);
            this.Controls.Add(this.flp_panel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "MainScreen";
            this.Text = "Biblioteca";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_empty)).EndInit();
            this.cms_properties.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flp_panel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.Label lb_library;
        private System.Windows.Forms.ToolStripMenuItem bt_add;
        private System.Windows.Forms.ToolStripMenuItem bt_exit;
        private System.Windows.Forms.ToolStripMenuItem preferenciasToolStripMenuItem;
        private System.Windows.Forms.Label lb_empty;
        private System.Windows.Forms.LinkLabel lb_addGame;
        private System.Windows.Forms.PictureBox pb_empty;
        private System.Windows.Forms.ContextMenuStrip cms_properties;
        private System.Windows.Forms.ToolStripMenuItem tsmi_run;
        private System.Windows.Forms.ToolStripMenuItem tsmi_properties;
        private System.Windows.Forms.ToolStripMenuItem tsmi_delete;
        private System.Windows.Forms.ToolStripMenuItem steamConnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
    }
}

