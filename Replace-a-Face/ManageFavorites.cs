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
    //Form to manage favorites
    public partial class ManageFavorites : Form
    {
        public List<Tuple<string, string>> faves;
        //populate listbox and class variables
        public ManageFavorites(List<Tuple<string, string>> faves)
        {
            this.faves = faves;
            InitializeComponent();
            foreach (Tuple<string, string> item in faves)
            {
                FavoriteListBox.Items.Add(item.Item1 + " | " + item.Item2);
            }

            FavoriteListBox.SelectedIndex = 0;
        }

        //delete the currently selected favorite
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            //checks that some favorites exist
            if(FavoriteListBox.Items.Count < 1)
            {
                MessageBox.Show("Nothing to delete.");
                return;
            }
            //get index of listbox item to be deleted
            int toDelete = FavoriteListBox.SelectedIndex;

            //remove the favorite from list and listbox
            faves.RemoveAt(toDelete);
            FavoriteListBox.Items.RemoveAt(toDelete);

            //overwrite favorites.txt and write new favorites. Not perfect but works
            StreamWriter writer = new StreamWriter(File.Open("favorites.txt", FileMode.Create));

            foreach (Tuple<string, string> fave in faves)
            {
                writer.WriteLine(fave.Item1 + "\t" + fave.Item2);
            }
            writer.Close();
        }

        //Opens modify favorite form, checks that there are favorites to modify first
        private void ModifyButton_Click(object sender, EventArgs e)
        {
            if (FavoriteListBox.Items.Count < 1)
            {
                MessageBox.Show("Nothing to modify.");
                return;
            }
            int toChange = FavoriteListBox.SelectedIndex;
            ModifyFavorite mF = new ModifyFavorite(faves,toChange);
            mF.Show();
            this.Close();
        }
    }
}
