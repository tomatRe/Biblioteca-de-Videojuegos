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
        string imagePath;

        public event EventHandler runHandler;
        public event EventHandler propertiesHandler;
        public event EventHandler deleteHandler;

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

        public Videojuego(string path, string name, string imagePath)
        {
            InitializeComponent();
            lb_name.Parent = pb_Image;
            lb_name.BackColor = Color.Transparent;

            this.path = path;
            this.name = name;
            this.imagePath = imagePath;

            lb_name.Text = name;
            pb_Image.Load(imagePath);
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

        public string GetImagePath()
        {
            return imagePath;
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

        public void SetImage(string imagePath)
        {
            this.imagePath = imagePath;
        }

        private void tsmi_run_Click(object sender, EventArgs e)
        {
            runHandler?.Invoke(this, e);
        }

        private void tsmi_properties_Click(object sender, EventArgs e)
        {
            propertiesHandler?.Invoke(this, e);
        }

        private void tsmi_delete_Click(object sender, EventArgs e)
        {
            deleteHandler?.Invoke(this, e);
        }
    }
}
