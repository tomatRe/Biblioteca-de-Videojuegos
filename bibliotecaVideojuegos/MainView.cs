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

        public MainScreen()
        {
            gamePaths = new List<string>();
            juegos = new List<Videojuego>();

            InitializeComponent();
            LoadGames();
        }

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

        public void LoadGames()
        {
            LoadPaths();

            if (gamePaths.Count > 0)
            {
                HideEmptyLibraryHint();

                foreach (string str in gamePaths)
                {
                    juegos.Add(new Videojuego(str));
                    flp_panel.Controls.Add(new Videojuego(str));
                }
            }
        }

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

        }
    }
}
