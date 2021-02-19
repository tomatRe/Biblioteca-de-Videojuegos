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
    /// <summary>
    /// This class handles the gathering of the information needed for adding a new videogame.
    /// </summary>
    public partial class AddView : Form
    {
        MainScreen menu;
        static string preferencesPath = "settings.ini";

        string gamePath;
        string gameName;
        string imagePath;
        string args;

        bool newGame;
        string oldData;

        /// <summary>
        /// This constructor sets the menu propertie and sets the new game variable to true
        /// </summary>
        public AddView(MainScreen mainScreen)
        {
            InitializeComponent();
            menu = mainScreen;
            newGame = true;
        }

        /// <summary>
        /// Fills the fields from the videogame that is passed by parameter.
        /// </summary>
        public void FillFields(Videojuego v)
        {
            this.gamePath = v.GetPath();
            this.gameName = v.GetName();
            this.imagePath = v.GetImagePath();

            tb_GamePath.Text = gamePath;
            tb_ImagePath.Text = imagePath;

            if (imagePath != null)
                pb_image.Load(imagePath);

            this.Text = "Propiedades";
            newGame = false;

            oldData = gamePath + args + ";" + gameName + ";" + imagePath;
        }

        /// <summary>
        /// Opens a new window to find the videogame executable.
        /// </summary>
        private void bt_executablePath_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            dialog.Filter = "exe Files (*.exe)|*.exe|All Files|*.*";
            dialog.FilterIndex = 1;
            dialog.RestoreDirectory = true;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                gamePath = dialog.FileName;
                tb_GamePath.Text = gamePath;
                gameName = gamePath.Split('\\')[gamePath.Split('\\').Count() - 1].Split('.')[0];
                lb_gameName.Text = gameName;
            }
        }

        /// <summary>
        /// Opens a new window to find the videogame´s image path.
        /// </summary>
        private void bt_imagePath_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "PNG Files (*.png)|*png|JPEG Files (*.jpeg)|*.jpeg|JPG Files(*.jpg)|*jpg|All Files|*.*";
            dialog.FilterIndex = 1;
            dialog.RestoreDirectory = true;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imagePath = dialog.FileName;
                tb_ImagePath.Text = imagePath;

                pb_image.Load(imagePath);
            }
        }

        /// <summary>
        /// Closes this window.
        /// </summary>
        private void bt_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Saves all the gathered data
        /// </summary>
        private void bt_add_Click(object sender, EventArgs e)
        {
            args = tb_Args.Text;

            string data = gamePath + args + ";" + gameName + ";" + imagePath;

            if (FieldsValid())
            {
                SaveGameData(data);
                menu.LoadGames();
                Close();
            }
        }

        /// <summary>
        /// Stores the string on "settings.ini".
        /// </summary>
        private void SaveGameData(string GameData)
        {
            try
            {
                
                if (File.Exists(preferencesPath))
                {
                    
                    if (newGame)
                    {
                        using (StreamWriter sw = File.AppendText(preferencesPath))
                        {
                            sw.WriteLine(GameData);
                        }
                    }
                    else
                    {
                        string[] lines = File.ReadAllLines(preferencesPath);

                        for (int i = 0; i < lines.Length; i++)
                        {
                            if (lines[i] == oldData)
                            {
                                lines[i] = GameData;
                            }
                        }

                        File.WriteAllLines(preferencesPath, lines);
                    }
                }
                else
                {
                    using (StreamWriter sw = File.CreateText(preferencesPath))
                    {

                        if (newGame)
                        {
                            sw.WriteLine();
                            sw.WriteLine(GameData);
                        }
                        else
                        {
                            MessageBox.Show("how you got here?");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }

        /// <summary>
        /// Validates the fields.
        /// </summary>
        /// <returns>
        /// True or false if the fields are not empty.
        /// </returns>
        private bool FieldsValid()
        {
            bool result = false;
            if (gamePath != null && gameName != null)
            {
                if (gamePath != "" && gameName != "")
                {
                    result = true;
                }
                else if (gamePath == "")
                {
                    MessageBox.Show("La ruta del ejecutable debe ser valida",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return result;
        }
    }
}
