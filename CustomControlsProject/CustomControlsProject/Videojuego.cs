using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace CustomControlsProject
{
    public partial class Videojuego: UserControl
    {
        //Properties

        string name;
        string path;
        Image image;

        //Constructors

        public Videojuego()
        {
            InitializeComponent();
            lb_name.Parent = pb_Image;
            lb_name.BackColor = Color.Transparent;
            path = "";
        }

        public Videojuego(string path)
        {
            InitializeComponent();
            lb_name.Parent = pb_Image;
            lb_name.BackColor = Color.Transparent;
            this.path = path;
        }

        public Videojuego(string path, string name)
        {
            InitializeComponent();
            lb_name.Parent = pb_Image;
            lb_name.BackColor = Color.Transparent;
            this.path = path;
            this.name = name;

            lb_name.Text = name;
        }

        public Videojuego(string path, string name, Image image)
        {
            InitializeComponent();
            lb_name.Parent = pb_Image;
            lb_name.BackColor = Color.Transparent;

            this.path = path;
            this.name = name;
            this.image = image;

            lb_name.Text = name;
            pb_Image.Image = image;
        }

        //Actions

        private void pb_Image_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(path);
            }
            catch(Exception exception)
            {
                MessageBox.Show("Error al abrir el elemento", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                Console.WriteLine(exception.StackTrace);
            }
        }

        //Getters

        public string GetName()
        {
            return name;
        }

        public string GetPath()
        {
            return path;
        }

        public Image GetImage()
        {
            return image;
        }

        //Setters

        public void SetName(string name)
        {
            this.name = name;
        }

        public void SetPath(string path)
        {
            this.path = path;
        }

        public void SetImage(Image image)
        {
            this.image = image;
        }
    }
}
