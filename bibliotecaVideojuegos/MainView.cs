using CustomControlsProject;
using System;
using System.Collections;
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

    /// <summary>
    /// This class its the core of the aplication.
    /// It handles the main screen and loads the videogames.
    /// </summary>
    public partial class MainScreen : Form
    {
        static string preferencesPath = "settings.ini";
        List<string> gamePaths;
        List<Videojuego> juegos;

        Videojuego LastSelected;

        /// <summary>
        /// Empty constructor that loads all the videogames located at "settings.ini"
        /// </summary>
        public MainScreen()
        {
            gamePaths = new List<string>();
            juegos = new List<Videojuego>();

            InitializeComponent();
            LoadGames();
        }

        /// <summary>
        /// Save the stored games information on a file
        /// </summary>

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

        /// <summary>
        /// Load the stored games information
        /// </summary>
        public void LoadGames()
        {
            flp_panel.Controls.Clear();
            gamePaths.Clear();
            juegos.Clear();
            LoadPaths();

            if (gamePaths.Count > 0 && gamePaths[0] != "")
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
                        juego.lb_name.MouseDown += Juego_MouseClick;
                        flp_panel.Controls.Add(juego);
                    }
                }
            }

            if(gamePaths.Count == 0 || gamePaths[0] == "")//there are no games
            {
                ShowEmptyLibraryHint();
            }
        }


        /// <summary>
        /// Captures the event when the user clicks the image or the label of an item
        /// </summary>
        private void Juego_MouseClick(object sender, MouseEventArgs e)
        {

            PictureBox pb_game = null;
            Label lb_game = null;

            try
            {
                pb_game = (PictureBox)sender;
            }
            catch
            {
                lb_game = (Label)sender;
                Console.WriteLine("User clicked the text label instead of the image");
            }

            if (pb_game != null)
                LastSelected = (Videojuego)pb_game.Parent;
            else
                LastSelected = (Videojuego)lb_game.Parent.Parent;
        }


        /// <summary>
        /// Loads the games path only
        /// </summary>
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

        /// <summary>
        /// Hide the labels, button and image
        /// </summary>
        public void HideEmptyLibraryHint()
        {
            lb_addGame.Enabled = false;
            lb_addGame.Visible = false;

            lb_empty.Enabled = false;
            lb_empty.Visible = false;

            pb_empty.Enabled = false;
            pb_empty.Visible = false;
        }

        /// <summary>
        /// Show the labels, button and image
        /// </summary>
        public void ShowEmptyLibraryHint()
        {
            lb_addGame.Enabled = true;
            lb_addGame.Visible = true;

            lb_empty.Enabled = true;
            lb_empty.Visible = true;

            pb_empty.Enabled = true;
            pb_empty.Visible = true;
        }

        /// <summary>
        /// Add game event when the screen its empty
        /// </summary>
        private void lb_addGame_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddView addGame = new AddView(this);
            addGame.ShowDialog();
        }

        /// <summary>
        /// Add game event from the upper left corner
        /// </summary>
        private void bt_add_Click(object sender, EventArgs e)
        {
            AddView addGame = new AddView(this);
            addGame.ShowDialog();
        }

        /// <summary>
        /// Runs the specified game from the contextual menu
        /// </summary>
        private void tsmi_run_Click(object sender, EventArgs e)
        {
            if (LastSelected != null)
            {
                LastSelected.RunGame(sender, e);
            }
        }

        /// <summary>
        /// Opens the properties window from the contextual menu
        /// </summary>
        private void tsmi_properties_Click(object sender, EventArgs e)
        {
            AddView addGame = new AddView(this);
            addGame.FillFields(LastSelected);
            addGame.ShowDialog();
        }

        /// <summary>
        /// Deletes the game from the contextual menu
        /// </summary>
        private void tsmi_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(preferencesPath))
                {

                    //Read All Games
                    ArrayList lines = new ArrayList();
                    string[] games = File.ReadAllLines(preferencesPath);

                    //Dump them into a dynaic collection
                    for (int i = 0; i < games.Length; i++)
                    {
                        lines.Add(games[i]);
                    }

                    //Get the game we need to delete
                    string line = LastSelected.GetPath() + ";" + LastSelected.GetName() + ";" + LastSelected.GetImagePath();

                    //Seek the game we want to delete
                    for (int i = 0; i < lines.Count; i++)
                    {
                        if ((string)lines[i] == line)
                        {
                            //if found, delete it from the list
                            lines.RemoveAt(i);
                            //break the loop
                            i = lines.Count;
                        }
                    }

                    //Dump the games back to a normal array
                    games = new string[lines.Count];

                    for (int i = 0; i < lines.Count; i++)
                    {
                        games[i] = (string)lines[i];
                    }

                    //Confirmation?
                    if (MessageBox.Show("Desea borrar por completo el elemento",
                        "Borrado", MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        //Save the settings file and update the game list
                        File.WriteAllLines(preferencesPath, games);
                        LoadGames();
                    }
                }
                else
                {
                    MessageBox.Show("No se pudo acceder al archivo de configuración",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);

                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Exits the program
        /// </summary>
        private void bt_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Opens the help prompt
        /// </summary>
        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mediante este software es posible el tener una colección " +
                "de videojuegos, con su ruta de ejecución, imagen y nombre del videojuego.\n" +
                "Para agregar un videojuego nuevo, seleccione archivo - añadir.\n" +
                "Para editar un item, haga clic derecho sobre el videojuego y editar.\n" +
                "Para borrar un item, haga clic derecho y borrar."
                , "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
