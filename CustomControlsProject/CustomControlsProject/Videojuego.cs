using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomControlsProject
{
    public partial class Videojuego: UserControl
    {
        string name;
        string path;
        Image image;

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
