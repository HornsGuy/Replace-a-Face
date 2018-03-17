using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Replace_a_Face
{
    //Selection form to insert a favorite face key into the main form
    public partial class InsertFavorite : Form
    {
        //current favorites
        List<Tuple<string, string>> faves;

        //The cell to insert to
        private DataGridViewCell dataGridViewCell;

        public InsertFavorite(List<Tuple<string, string>> faves, DataGridViewCell dataGridViewCell)
        {
            InitializeComponent();
            //set class variables
            this.faves = faves;
            this.dataGridViewCell = dataGridViewCell;
            
            //populate listbox
            foreach (Tuple<string,string> item in faves)
            {
                FavoriteListBox.Items.Add(item.Item1+" | "+item.Item2);
            }
            FavoriteListBox.SelectedIndex = 0;
        }

        //inserts selected facekey into NameFaceDataGrid
        //DOES NOT SAVE AUTOMATICALLLY
        private void InsertButton_Click(object sender, EventArgs e)
        {
            dataGridViewCell.Value = faves[FavoriteListBox.SelectedIndex].Item2;
            Close();
        }
    }
}
