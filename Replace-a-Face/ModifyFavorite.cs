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

namespace Replace_a_Face
{
    //Repurposed AddFavorite form to modify a saved favorite
    public partial class ModifyFavorite : Form
    {
        List<Tuple<string, string>> faves;
        int index;
        

        //populate textboxes and class variables
        public ModifyFavorite(List<Tuple<string, string>> sendFaves, int indexToChange)
        {
            InitializeComponent();
            faves = sendFaves;
            index = indexToChange;
            NameTextBox.Text = sendFaves[indexToChange].Item1;
            FaceKeyTextBox.Text = sendFaves[indexToChange].Item2;
        }

        //Save the changes to file and memory
        private void SaveButton_Click(object sender, EventArgs e)
        {
            //validate face key, input santization
            if (!PublicMethods.faceValid(FaceKeyTextBox.Text.Substring(2)))
            {
                MessageBox.Show("Error: Invalid Face Key", "Error");
                return;
            }
            //create new tuple for changed favorite and insert it into List to be written
            Tuple<string, string> changedFave = new Tuple<string, string>(NameTextBox.Text, FaceKeyTextBox.Text);
            faves[index] = changedFave;

            //write favorites to file. Not perfect solution, but functional enough
            StreamWriter writer = new StreamWriter(File.Open("favorites.txt", FileMode.Create));
            foreach (Tuple<string, string> fave in faves)
            {
                writer.WriteLine(fave.Item1 + "\t" + fave.Item2);
            }
            writer.Close();
            //reopen manage favorites, causes refresh of favorites to memory. Also not idea, but works
            ManageFavorites mF = new ManageFavorites(faves);
            mF.Show();
            this.Close();
        }
    }
}
