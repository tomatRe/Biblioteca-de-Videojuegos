namespace bibliotecaVideojuegos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.flp_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importarVideojuegoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferenciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lb_library = new System.Windows.Forms.Label();
            this.lb_empty = new System.Windows.Forms.Label();
            this.lb_addGame = new System.Windows.Forms.LinkLabel();
            this.pb_empty = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_empty)).BeginInit();
            this.SuspendLayout();
            // 
            // flp_panel
            // 
            this.flp_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flp_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flp_panel.Location = new System.Drawing.Point(9, 53);
            this.flp_panel.Margin = new System.Windows.Forms.Padding(2);
            this.flp_panel.Name = "flp_panel";
            this.flp_panel.Size = new System.Drawing.Size(584, 306);
            this.flp_panel.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.editarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(603, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importarVideojuegoToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // importarVideojuegoToolStripMenuItem
            // 
            this.importarVideojuegoToolStripMenuItem.Name = "importarVideojuegoToolStripMenuItem";
            this.importarVideojuegoToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.importarVideojuegoToolStripMenuItem.Text = "Importar Videojuego";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.preferenciasToolStripMenuItem});
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.editarToolStripMenuItem.Text = "Editar";
            // 
            // preferenciasToolStripMenuItem
            // 
            this.preferenciasToolStripMenuItem.Name = "preferenciasToolStripMenuItem";
            this.preferenciasToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.preferenciasToolStripMenuItem.Text = "Preferencias";
            // 
            // lb_library
            // 
            this.lb_library.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb_library.AutoSize = true;
            this.lb_library.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_library.ForeColor = System.Drawing.SystemColors.Window;
            this.lb_library.Location = new System.Drawing.Point(248, 31);
            this.lb_library.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_library.Name = "lb_library";
            this.lb_library.Size = new System.Drawing.Size(88, 20);
            this.lb_library.TabIndex = 2;
            this.lb_library.Text = "Biblioteca";
            this.lb_library.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_empty
            // 
            this.lb_empty.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_empty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_empty.ForeColor = System.Drawing.Color.DimGray;
            this.lb_empty.Location = new System.Drawing.Point(184, 206);
            this.lb_empty.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_empty.Name = "lb_empty";
            this.lb_empty.Size = new System.Drawing.Size(218, 81);
            this.lb_empty.TabIndex = 3;
            this.lb_empty.Text = "Parece que la biblioteca está vacía";
            this.lb_empty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_addGame
            // 
            this.lb_addGame.ActiveLinkColor = System.Drawing.Color.Silver;
            this.lb_addGame.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lb_addGame.LinkColor = System.Drawing.Color.Gray;
            this.lb_addGame.Location = new System.Drawing.Point(227, 273);
            this.lb_addGame.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_addGame.Name = "lb_addGame";
            this.lb_addGame.Size = new System.Drawing.Size(139, 14);
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
            this.pb_empty.Location = new System.Drawing.Point(212, 67);
            this.pb_empty.Margin = new System.Windows.Forms.Padding(2);
            this.pb_empty.MaximumSize = new System.Drawing.Size(165, 138);
            this.pb_empty.MinimumSize = new System.Drawing.Size(165, 138);
            this.pb_empty.Name = "pb_empty";
            this.pb_empty.Size = new System.Drawing.Size(165, 138);
            this.pb_empty.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_empty.TabIndex = 5;
            this.pb_empty.TabStop = false;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(603, 375);
            this.Controls.Add(this.pb_empty);
            this.Controls.Add(this.lb_addGame);
            this.Controls.Add(this.lb_empty);
            this.Controls.Add(this.lb_library);
            this.Controls.Add(this.flp_panel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(619, 414);
            this.Name = "MainScreen";
            this.Text = "Biblioteca";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_empty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flp_panel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.Label lb_library;
        private System.Windows.Forms.ToolStripMenuItem importarVideojuegoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preferenciasToolStripMenuItem;
        private System.Windows.Forms.Label lb_empty;
        private System.Windows.Forms.LinkLabel lb_addGame;
        private System.Windows.Forms.PictureBox pb_empty;
    }
}

