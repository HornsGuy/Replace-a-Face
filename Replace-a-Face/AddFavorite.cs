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
    //Form for adding favorites
    public partial class AddFavorite : Form
    {

        //populate form textboxes
        public AddFavorite(string name, string faceKey)
        {
            InitializeComponent();
            NameTextBox.Text = name;
            FaceKeyTextBox.Text = faceKey;
        }

        //saves the favorite to file and memory
        private void SaveButton_Click(object sender, EventArgs e)
        {
            //validate that the key provided is valid, input sanitization
            if (!PublicMethods.faceValid(FaceKeyTextBox.Text.Substring(2)))
            {
                MessageBox.Show("Error: Invalid Face Key", "Error");
                return;
            }
            //write the key to file
            StreamWriter writer = new StreamWriter("favorites.txt", true);
            writer.WriteLine(NameTextBox.Text + "\t" + FaceKeyTextBox.Text, "a");
            writer.Close();
            //inform user
            MessageBox.Show(NameTextBox.Text + " added to favorites.");
            Close();
        }

    }
}
