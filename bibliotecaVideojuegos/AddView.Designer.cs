
namespace bibliotecaVideojuegos
{
    partial class AddView
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
            this.bt_add = new System.Windows.Forms.Button();
            this.bt_cancel = new System.Windows.Forms.Button();
            this.tb_ImagePath = new System.Windows.Forms.TextBox();
            this.bt_imagePath = new System.Windows.Forms.Button();
            this.pb_image = new System.Windows.Forms.PictureBox();
            this.bt_executablePath = new System.Windows.Forms.Button();
            this.tb_GamePath = new System.Windows.Forms.TextBox();
            this.lb_gameName = new System.Windows.Forms.Label();
            this.tb_Args = new System.Windows.Forms.TextBox();
            this.lb_args = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_image)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_add
            // 
            this.bt_add.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(72)))), ((int)(((byte)(83)))));
            this.bt_add.Location = new System.Drawing.Point(472, 353);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(75, 23);
            this.bt_add.TabIndex = 0;
            this.bt_add.Text = "Añadir";
            this.bt_add.UseVisualStyleBackColor = false;
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // bt_cancel
            // 
            this.bt_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(72)))), ((int)(((byte)(83)))));
            this.bt_cancel.Location = new System.Drawing.Point(391, 353);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(75, 23);
            this.bt_cancel.TabIndex = 1;
            this.bt_cancel.Text = "Cancelar";
            this.bt_cancel.UseVisualStyleBackColor = false;
            this.bt_cancel.Click += new System.EventHandler(this.bt_cancel_Click);
            // 
            // tb_ImagePath
            // 
            this.tb_ImagePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tb_ImagePath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(72)))), ((int)(((byte)(83)))));
            this.tb_ImagePath.ForeColor = System.Drawing.SystemColors.Control;
            this.tb_ImagePath.Location = new System.Drawing.Point(32, 273);
            this.tb_ImagePath.Name = "tb_ImagePath";
            this.tb_ImagePath.Size = new System.Drawing.Size(380, 20);
            this.tb_ImagePath.TabIndex = 2;
            // 
            // bt_imagePath
            // 
            this.bt_imagePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_imagePath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(72)))), ((int)(((byte)(83)))));
            this.bt_imagePath.Location = new System.Drawing.Point(418, 271);
            this.bt_imagePath.Name = "bt_imagePath";
            this.bt_imagePath.Size = new System.Drawing.Size(129, 23);
            this.bt_imagePath.TabIndex = 3;
            this.bt_imagePath.Text = "Ruta de la Imagen";
            this.bt_imagePath.UseVisualStyleBackColor = false;
            this.bt_imagePath.Click += new System.EventHandler(this.bt_imagePath_Click);
            // 
            // pb_image
            // 
            this.pb_image.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_image.Location = new System.Drawing.Point(32, 12);
            this.pb_image.Name = "pb_image";
            this.pb_image.Size = new System.Drawing.Size(135, 228);
            this.pb_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_image.TabIndex = 4;
            this.pb_image.TabStop = false;
            // 
            // bt_executablePath
            // 
            this.bt_executablePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_executablePath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(72)))), ((int)(((byte)(83)))));
            this.bt_executablePath.ForeColor = System.Drawing.SystemColors.Control;
            this.bt_executablePath.Location = new System.Drawing.Point(418, 245);
            this.bt_executablePath.Name = "bt_executablePath";
            this.bt_executablePath.Size = new System.Drawing.Size(129, 23);
            this.bt_executablePath.TabIndex = 6;
            this.bt_executablePath.Text = "Ruta del Ejecutable";
            this.bt_executablePath.UseVisualStyleBackColor = false;
            this.bt_executablePath.Click += new System.EventHandler(this.bt_executablePath_Click);
            // 
            // tb_GamePath
            // 
            this.tb_GamePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tb_GamePath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(72)))), ((int)(((byte)(83)))));
            this.tb_GamePath.ForeColor = System.Drawing.SystemColors.Control;
            this.tb_GamePath.Location = new System.Drawing.Point(32, 247);
            this.tb_GamePath.Name = "tb_GamePath";
            this.tb_GamePath.Size = new System.Drawing.Size(380, 20);
            this.tb_GamePath.TabIndex = 5;
            // 
            // lb_gameName
            // 
            this.lb_gameName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_gameName.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_gameName.Location = new System.Drawing.Point(173, 12);
            this.lb_gameName.Name = "lb_gameName";
            this.lb_gameName.Size = new System.Drawing.Size(374, 228);
            this.lb_gameName.TabIndex = 7;
            this.lb_gameName.Text = "Videojuego";
            this.lb_gameName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Args
            // 
            this.tb_Args.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tb_Args.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(72)))), ((int)(((byte)(83)))));
            this.tb_Args.ForeColor = System.Drawing.SystemColors.Control;
            this.tb_Args.Location = new System.Drawing.Point(32, 299);
            this.tb_Args.Name = "tb_Args";
            this.tb_Args.Size = new System.Drawing.Size(380, 20);
            this.tb_Args.TabIndex = 8;
            // 
            // lb_args
            // 
            this.lb_args.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_args.Location = new System.Drawing.Point(419, 299);
            this.lb_args.Name = "lb_args";
            this.lb_args.Size = new System.Drawing.Size(128, 23);
            this.lb_args.TabIndex = 9;
            this.lb_args.Text = "Argumentos";
            this.lb_args.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(559, 388);
            this.Controls.Add(this.lb_args);
            this.Controls.Add(this.tb_Args);
            this.Controls.Add(this.lb_gameName);
            this.Controls.Add(this.bt_executablePath);
            this.Controls.Add(this.tb_GamePath);
            this.Controls.Add(this.pb_image);
            this.Controls.Add(this.bt_imagePath);
            this.Controls.Add(this.tb_ImagePath);
            this.Controls.Add(this.bt_cancel);
            this.Controls.Add(this.bt_add);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(575, 427);
            this.MinimumSize = new System.Drawing.Size(575, 427);
            this.Name = "AddView";
            this.Opacity = 0.95D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Añadir Videojuego";
            ((System.ComponentModel.ISupportInitialize)(this.pb_image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_add;
        private System.Windows.Forms.Button bt_cancel;
        private System.Windows.Forms.TextBox tb_ImagePath;
        private System.Windows.Forms.Button bt_imagePath;
        private System.Windows.Forms.PictureBox pb_image;
        private System.Windows.Forms.Button bt_executablePath;
        private System.Windows.Forms.TextBox tb_GamePath;
        private System.Windows.Forms.Label lb_gameName;
        private System.Windows.Forms.TextBox tb_Args;
        private System.Windows.Forms.Label lb_args;
    }
}