using CustomControlsProject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bibliotecaVideojuegos
{
    public partial class MainScreen : Form
    {
        static string preferencesPath = "settings.ini";
        List<string> gamePaths;
        List<Videojuego> juegos;

        Videojuego LastSelected;

        public MainScreen()
        {
            gamePaths = new List<string>();
            juegos = new List<Videojuego>();

            InitializeComponent();
            LoadGames();
        }

        //Save the stored games information on a file

        public void SavePreferences(string[] preferences)
        {
            try
            {
                if (File.Exists(preferencesPath))
                {
                    using (StreamWriter sw = File.AppendText(preferencesPath))
                    {
                        foreach (string str in preferences)
                            sw.WriteLine(str);
                    }
                }
                else
                {
                    using (StreamWriter sw = File.CreateText(preferencesPath))
                    {
                        foreach (string str in preferences)
                            sw.WriteLine(str);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }


        //Load the stored games information
        public void LoadGames()
        {
            flp_panel.Controls.Clear();
            gamePaths.Clear();
            juegos.Clear();
            LoadPaths();

            if (gamePaths.Count > 0)
            {
                HideEmptyLibraryHint();

                foreach (string str in gamePaths)
                {
                    Videojuego juego = null;

                    if (str.Split(';').Count() == 3 && str.Split(';')[2] != "")
                    {
                        string[] data =
                        {
                            str.Split(';')[0],
                            str.Split(';')[1],
                            str.Split(';')[2]
                        };

                        juego = new Videojuego(data[0], data[1], data[2]);
                    }
                    else if (str.Split(';').Count() == 3 && str.Split(';')[2] == "")
                    {

                        string[] data =
                        {
                            str.Split(';')[0],
                            str.Split(';')[1],
                            str.Split(';')[2]
                        };

                        juego = new Videojuego(data[0], data[1]);
                    }

                    if (juego != null)
                    {
                        juegos.Add(juego);
                        juego.ContextMenuStrip = cms_properties;
                        juego.pb_Image.MouseDown += Juego_MouseClick;
                        flp_panel.Controls.Add(juego);
                    }
                }
            }
        }

        private void Juego_MouseClick(object sender, MouseEventArgs e)
        {
            PictureBox pb_game = (PictureBox)sender;
            LastSelected = (Videojuego)pb_game.Parent;
        }

        //Loads the games path only
        private void LoadPaths()
        {
            if (File.Exists(preferencesPath))
            {
                string[] lines = File.ReadAllLines(preferencesPath);

                foreach (string str in lines)
                {
                    gamePaths.Add(str);
                }
            }
        }

        //Hide the labels, button and image

        public void HideEmptyLibraryHint()
        {
            lb_addGame.Enabled = false;
            lb_addGame.Visible = false;

            lb_empty.Enabled = false;
            lb_empty.Visible = false;

            pb_empty.Enabled = false;
            pb_empty.Visible = false;
        }

        //Show the labels, button and image
        public void ShowEmptyLibraryHint()
        {
            lb_addGame.Enabled = true;
            lb_addGame.Visible = true;

            lb_empty.Enabled = true;
            lb_empty.Visible = true;

            pb_empty.Enabled = true;
            pb_empty.Visible = true;
        }

        private void lb_addGame_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddView addGame = new AddView(this);
            addGame.ShowDialog();
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            AddView addGame = new AddView(this);
            addGame.ShowDialog();
        }

        private void tsmi_run_Click(object sender, EventArgs e)
        {
            LastSelected.RunGame(sender, e);
        }

        private void tsmi_properties_Click(object sender, EventArgs e)
        {
            AddView addGame = new AddView(this);
            addGame.FillFields(LastSelected);
            addGame.ShowDialog();
        }

        private void tsmi_delete_Click(object sender, EventArgs e)
        {

        }
    }
}
