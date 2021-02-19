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
    /// <summary>
    /// This class stores all the videogame data.
    /// </summary>
    public partial class Videojuego: UserControl
    {
        /// <summary>
        /// Properties.
        /// </summary>

        string name;
        string path;
        string imagePath;

        /// <summary>
        /// This event handler captures the run event.
        /// </summary>
        public event EventHandler runHandler;
        /// <summary>
        /// This event handler captures the properties event.
        /// </summary>
        public event EventHandler propertiesHandler;
        /// <summary>
        /// This event handler captures the delete event.
        /// </summary>
        public event EventHandler deleteHandler;

        /// <summary>
        /// Empty constructor that sets all the fields to its empty value.
        /// </summary>
        public Videojuego()
        {
            InitializeComponent();
            lb_name.Parent = pb_Image;
            lb_name.BackColor = Color.Transparent;
            path = "";
        }

        /// <summary>
        /// Constructor that only recives the game path as parameter.
        /// </summary>
        public Videojuego(string path)
        {
            InitializeComponent();
            lb_name.Parent = pb_Image;
            lb_name.BackColor = Color.Transparent;
            this.path = path;
        }

        /// <summary>
        /// Constructor that receives the game path as parameter and the game name.
        /// </summary>
        public Videojuego(string path, string name)
        {
            InitializeComponent();
            lb_name.Parent = pb_Image;
            lb_name.BackColor = Color.Transparent;
            this.path = path;
            this.name = name;

            lb_name.Text = name;
        }

        /// <summary>
        /// Constructor that receives the game path as parameter and the game name.
        /// </summary>
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


        /// <summary>
        /// This method opens the game.
        /// </summary>
        public void RunGame(object sender, EventArgs e)
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

        /// <summary>
        /// This method returns the game.
        /// </summary>
        /// <returns>
        /// The name of the game.
        /// </returns>
        public string GetName()
        {
            return name;
        }

        /// <summary>
        /// This method returns the path.
        /// </summary>
        /// <returns>
        /// The game executable path.
        /// </returns>
        public string GetPath()
        {
            return path;
        }

        /// <summary>
        /// This method returns the image path.
        /// </summary>
        public string GetImagePath()
        {
            return imagePath;
        }

        //Setters

        /// <summary>
        /// This method sets the game name.
        /// </summary>
        public void SetName(string name)
        {
            this.name = name;
        }

        /// <summary>
        /// This method sets the game path.
        /// </summary>
        public void SetPath(string path)
        {
            this.path = path;
        }

        /// <summary>
        /// This method sets the image path.
        /// </summary>
        public void SetImage(string imagePath)
        {
            this.imagePath = imagePath;
        }

        /// <summary>
        /// This method invokes the run handler listener.
        /// </summary>
        private void tsmi_run_Click(object sender, EventArgs e)
        {
            runHandler?.Invoke(this, e);
        }

        /// <summary>
        /// This method invokes the properties handler listener.
        /// </summary>
        private void tsmi_properties_Click(object sender, EventArgs e)
        {
            propertiesHandler?.Invoke(this, e);
        }

        /// <summary>
        /// This method invokes the delete handler listener.
        /// </summary>
        private void tsmi_delete_Click(object sender, EventArgs e)
        {
            deleteHandler?.Invoke(this, e);
        }
    }
}
