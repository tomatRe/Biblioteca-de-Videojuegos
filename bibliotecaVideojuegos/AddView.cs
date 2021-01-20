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
    public partial class AddView : Form
    {

        static string preferencesPath = "settings.ini";

        string gamePath;
        string gameName;
        string imagePath;
        string args;

        public AddView()
        {
            InitializeComponent();
        }

        private void bt_executablePath_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            //dialog.InitialDirectory = "c:\\";
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

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            args = tb_Args.Text;

            string data = gamePath + args + ";" + gameName + ";" + imagePath;

            SaveGameData(data);
            Close();
        }

        private void SaveGameData(string GameData)
        {
            try
            {
                if (File.Exists(preferencesPath))
                {
                    using (StreamWriter sw = File.AppendText(preferencesPath))
                    {
                        sw.WriteLine(GameData);
                    }
                }
                else
                {
                    using (StreamWriter sw = File.CreateText(preferencesPath))
                    {
                        sw.WriteLine();
                        sw.WriteLine(GameData);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}
