using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Replace_a_Face
{
    public partial class MainForm : Form
    {
        List<long> facePosition = new List<long>();

        //reads in a server from profiles.dat, put into its own method to reduce repeating and clutter
        public void readServer(BinaryReader reader)
        {
            //the length of the IP string
            int ipLength = reader.ReadInt32();

            //read in the IP string, same as char name
            string ip = Encoding.Default.GetString(reader.ReadBytes(ipLength));

            //read in ping when last loaded the server to list
            int ping = reader.ReadInt32();

            // port of the server
            int port = reader.ReadInt32();

            //mapID, unkown if this is accurate
            int mapID = reader.ReadInt32();

            //burn 2 unkowns
            reader.ReadInt32(); // unkown                            
            reader.ReadInt32(); // unkown          

            //mapTypeID, unkown if this is accurate
            int mapTypeID = reader.ReadInt32();

            //read in several strings, same as previous
            int serverLength = reader.ReadInt32();
            string server = Encoding.Default.GetString(reader.ReadBytes(serverLength));
            int moduleLength = reader.ReadInt32();
            string module = Encoding.Default.GetString(reader.ReadBytes(moduleLength));
            int mapLength = reader.ReadInt32();
            string map = Encoding.Default.GetString(reader.ReadBytes(mapLength));
            int gameTypeLength = reader.ReadInt32();
            string gameType = Encoding.Default.GetString(reader.ReadBytes(gameTypeLength));

            //player info for server
            int numPlayers = reader.ReadInt32();
            int maxPlayers = reader.ReadInt32();

            reader.ReadInt32();// unkown   
            reader.ReadInt32();// unkown 

            //version of wb executable and version of mod being ran
            int wbVersion = reader.ReadInt32();
            int modVersion = reader.ReadInt32();
            reader.ReadInt32();// unkown   
            reader.ReadInt32();// unkown   

            //number of server settings to expect
            int numSettings = reader.ReadInt32();

            //each setting is an int32, not used
            reader.ReadBytes(numSettings * 4);
        }

        //Method is ran immediately after start
        public void loadProfiles()
        {
            //clear the datagrid if already loaded
            NameFaceDataGrid.Rows.Clear();
            //clear face positions if already loaded
            facePosition = new List<long>();

            //Look for profile.dat under %appdata%\Mount&Blade Warband\
            string profileFile = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Mount&Blade Warband\\profiles.dat";
            //check if file does not exist
            if (!File.Exists(profileFile))
            {
                // inform user that profiles.dat is missing and return
                MessageBox.Show("File profiles.dat not found in default location. Open warband, close it, and try again.");
                return;
            }

            //open profiles.dat
            using (BinaryReader reader = new BinaryReader(File.Open(profileFile, FileMode.Open)))
            {
                //First int32 is the version of this file (correlates to warband version). 10 is the only valid version number and the most recent
                //Other versions would have to be reverse engineered, only 10 is accpeted for now
                int version = reader.ReadInt32();
                if (version != 10)
                {
                    MessageBox.Show("This version of Warband is not supported. Update to a newer versiona and try again.");
                    return;
                }

                //The character that was used most recently in multiplayer 0..n
                int curProfileIndex = reader.ReadInt32();

                //the number of characters in the file
                int numChars = reader.ReadInt32();

                //loop over the characters, could be broken out into own method
                for (int i = 0; i < numChars; i++)
                {

                    //length of the cahracters name
                    int nameLength = reader.ReadInt32();

                    //read in nameLength bytes and convert to string
                    string charName = Encoding.Default.GetString(reader.ReadBytes(nameLength));

                    //gender of character
                    int gender = reader.ReadInt32();
                    //banner id of character
                    int banner = reader.ReadInt32();

                    // get the byte location of the beginning of the face codes
                    // used when writing to the profiles file
                    facePosition.Add(reader.BaseStream.Position);

                    //face keys are stored in a strang manner, numbers correlate to the position in 32 byte big endian face key
                    string face2 = reader.ReadInt32().ToString("X8").ToLower();
                    string face1 = reader.ReadInt32().ToString("X8").ToLower();
                    string face4 = reader.ReadInt32().ToString("X8").ToLower();
                    string face3 = reader.ReadInt32().ToString("X8").ToLower();
                    string face6 = reader.ReadInt32().ToString("X8").ToLower();
                    string face5 = reader.ReadInt32().ToString("X8").ToLower();
                    string face8 = reader.ReadInt32().ToString("X8").ToLower();
                    string face7 = reader.ReadInt32().ToString("X8").ToLower();

                    //compile them all into one string adding the hex identifier to be compatible with warband's face key copy function
                    string face = "0x" + face1 + face2 + face3 + face4 + face5 + face6 + face7 + face8;

                    //add the name, facekey, and buttons to the datagrid
                    NameFaceDataGrid.Rows.Add(charName, face, "Save", "Favorite", "Insert Fav");

                    //the number of favorite servers a character has
                    int numFavoriteServers = reader.ReadInt32();

                    //loop over the number of servers to expect
                    for (int j = 0; j < numFavoriteServers; j++)
                    {
                        readServer(reader);
                    }

                    //index of this character, 0..n
                    int charNum = reader.ReadInt32();

                    //number of servers from the server selection page. Why this is stored in profiles ¯\_(ツ)_/¯
                    int numServers = reader.ReadInt32();

                    //loop numServers and read them
                    for (int j = 0; j < numServers; j++)
                    {
                        readServer(reader);
                    }
                    //32 bytes at the end of every character. Could be used as a delimiter
                    for (int k = 0; k < 8; k++)
                    {
                        int b = reader.ReadInt32();
                    }

                }
            }


        }

        //writes the face keys to profiles.dat
        //index is the row index of the datagridview and newFace is the key to be written
        public void saveProfiles(int index, string newFace)
        {
            //drop the 0x at the beginning
            newFace = newFace.Substring(2);

            //check that the key is valid. Input sanization
            if (PublicMethods.faceValid(newFace))
            {
                
                string profileFile = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Mount&Blade Warband\\profiles.dat";

                if (!File.Exists(profileFile))
                {
                    MessageBox.Show("Profiles.dat has been removed. Reopen warband and try again.");
                    return;
                }
                using (BinaryWriter writer = new BinaryWriter(File.Open(profileFile, FileMode.Open)))
                {

                    //move the binary writer to the position we want to write to
                    writer.Seek((int)facePosition[index], SeekOrigin.Begin);

                    //breakup the facekey and convert to an int format
                    string face1 = newFace.Substring(0, 8);
                    string face2 = newFace.Substring(8, 8);
                    string face3 = newFace.Substring(16, 8);
                    string face4 = newFace.Substring(24, 8);
                    string face5 = newFace.Substring(32, 8);
                    string face6 = newFace.Substring(40, 8);
                    string face7 = newFace.Substring(48, 8);
                    string face8 = newFace.Substring(56, 8);
                    int face1Val = Convert.ToInt32("0x" + face1, 16);
                    int face2Val = Convert.ToInt32("0x" + face2, 16);
                    int face3Val = Convert.ToInt32("0x" + face3, 16);
                    int face4Val = Convert.ToInt32("0x" + face4, 16);
                    int face5Val = Convert.ToInt32("0x" + face5, 16);
                    int face6Val = Convert.ToInt32("0x" + face6, 16);
                    int face7Val = Convert.ToInt32("0x" + face7, 16);
                    int face8Val = Convert.ToInt32("0x" + face8, 16);

                    //write the broken face key to the file
                    writer.Write(face2Val);
                    writer.Write(face1Val);
                    writer.Write(face4Val);
                    writer.Write(face3Val);
                    writer.Write(face6Val);
                    writer.Write(face5Val);
                    writer.Write(face8Val);
                    writer.Write(face7Val);

                    //inform user of completion
                    MessageBox.Show("Done!");
                }

            }
            else
            {
                MessageBox.Show("Error: Invalid Face Code", "Eror");
            }
        }

        public MainForm()
        {
            InitializeComponent();
            loadProfiles();
        }

        //loads favorites from favorites.txt
        public List<Tuple<string, string>> getFaves()
        {
            //favorites.txt is created when a favorite is added. No text file, no favorites
            if (!File.Exists("favorites.txt"))
            {
                MessageBox.Show("No favorites found.");
                return new List<Tuple<string, string>>();
            }

            //favorites are stored as a tuple of strings
            List<Tuple<string, string>> faves = new List<Tuple<string, string>>();
            StreamReader reader = new StreamReader(File.Open("favorites.txt", FileMode.Open));

            //read favorites, format is "charnam\tfacekey"
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                if (line.Contains("\t"))
                {
                    string[] splitLine = line.Split('\t');
                    faves.Add(new Tuple<string, string>(splitLine[0], splitLine[1]));
                }
            }
            reader.Close();

            
            return faves;
        }

        //copies profiles.dat to the local directory
        private void SaveProfile_Click(object sender, EventArgs e)
        {
            File.Copy(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Mount&Blade Warband\\profiles.dat", ".\\profiles.dat", true);
            MessageBox.Show("Saved");

        }

        //moves the saved profile file to appdata if it exists
        private void LoadProfile_Click(object sender, EventArgs e)
        {
            if (!File.Exists(".\\profiles.dat"))
            {
                MessageBox.Show("No backup found.");
                return;
            }
            File.Copy(".\\profiles.dat", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Mount&Blade Warband\\profiles.dat", true);
            loadProfiles();
            MessageBox.Show("Loaded");
        }

        //open addfavorite form, importing the char name and face key to the form
        public void addFavorite(int row)
        {
            AddFavorite aF = new AddFavorite((string)NameFaceDataGrid.Rows[row].Cells[0].Value, (string)NameFaceDataGrid.Rows[row].Cells[1].Value);
            aF.Show();
        }

        //opens the InsertFavorite form. Checks if any favorites exist first
        private void insertFavorite(int rowIndex)
        {
            List<Tuple<string, string>> faves = getFaves();
            if (faves.Count > 0)
            {
                InsertFavorite favForm = new InsertFavorite(getFaves(), NameFaceDataGrid.Rows[rowIndex].Cells[1]);
                favForm.Show();
            }
            else
            {
                MessageBox.Show("No Favorites found.");
            }
        }

        //catches clicking on the NameFaceDataGrid
        private void FavoritesDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridView senderGrid = (DataGridView)sender;

            //check for a valid row index
            if (e.RowIndex >= 0)
            {

                
                if (e.ColumnIndex == 2)
                {
                    //SaveButton clicked
                    saveProfiles(e.RowIndex, (string)NameFaceDataGrid.Rows[e.RowIndex].Cells[1].Value);
                }
                else if (e.ColumnIndex == 3)
                {
                    //FavoriteButton clicked
                    addFavorite(e.RowIndex);
                }
                else if (e.ColumnIndex == 4)
                {
                    //InsertFavoriteButton clicked
                    insertFavorite(e.RowIndex);
                }
                else if (e.ColumnIndex == 1)
                {
                    //facekey has been clicked, highlight the text to be edited
                    DataGridViewCell cell = NameFaceDataGrid.Rows[e.RowIndex].Cells[1];
                    if (!cell.IsInEditMode)
                    {
                        this.NameFaceDataGrid.CurrentCell = cell;
                        this.NameFaceDataGrid.BeginEdit(false);
                    }

                    TextBox control = (TextBox)this.NameFaceDataGrid.EditingControl;

                    control.SelectionStart = 0;
                    control.SelectionLength = ((string)cell.Value).Length;
                }
            }
        }

        //ManageFavorites menu button has been clicked, open manage favorites form
        private void ManageFavorites_Click(object sender, EventArgs e)
        {
            List<Tuple<string, string>> faves = getFaves();
            if (faves.Count > 0)
            {
                ManageFavorites mf = new ManageFavorites(faves);
                mf.Show();
            }
            else
            {
                MessageBox.Show("No Favorites found.");
            }

        }

    }
}
