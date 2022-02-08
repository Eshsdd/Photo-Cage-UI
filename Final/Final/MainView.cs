using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;

namespace Final
{
    public partial class MainView : Form
    {
        //Setting up Stream Reader, my list of arrays, and a dictonary for searching
        StreamReader charRead;
        List<string[]> lineArray = new List<string[]> ();
        Dictionary<string, string> charClass = new Dictionary<string, string>();
        public MainView()
        {
            InitializeComponent();
        }

        //  Code to open a special window to allow the user to select the file to load
        private void loadButton_Click(object sender, EventArgs e)
        {
            try
            {
                //line will become streamreader lines
                string line = null;

                openFileDialog1.ShowDialog();

                //open stream reader file from openFile (which I dont think was ever taught before and took me forever to figure out what to refrence)
                charRead = new StreamReader(openFileDialog1.FileName);
                while ((line = charRead.ReadLine()) != null)
                {
                    string[] data = line.Split(',');
                    if (data.Length == 6)
                    {
                        lineArray.Add(data);
                    }
                }
            } catch (Exception)
            {
                Console.WriteLine("Load Error");
            }

            for (var i = 0; i < lineArray.Count; i++)
            {
                string[] addName = lineArray[i];

                //took me awhile but you add items to the listbox now.
                //my problem isn't that i dont know what im doing; it's more that the specific terms like "openFileDialog1.fileName" are impossible to find without googling it.
                //like honestly if this wasn't named "list" box how would I have ever figured out that it was a list. It's called a collection??? 
                characterListBox.Items.Add(addName[0]);

                //adding all the diff names to a dictonary with there class' so i can seach them for later
                charClass.Add(addName[0], addName[1]);
            }

            //try working on class but just didn't have the time after I worked on index selector
           // CharFolder newCharacter = new CharFolder(  Add array here      );

        }

        //  This function gets called when the user has selected a file
        //      double click a file or click "Open" button
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            //  You may need to make the window wider to see the text
            //  You can remove this. I just wanted to make sure you knew how to get the file to load
            //      this is the string to use when creating your stream to the file
            //      it is an absolute path to the file
            fileLoadedToolStripStatusLabel.Text = ((OpenFileDialog)sender).FileName;
        }

        private void clearDataButton_Click(object sender, EventArgs e)
        {
            //clears all the lists
            lineArray.Clear();
            charClass.Clear();
            characterListBox.Items.Clear();
        }

        private void classComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if the correct class is selected it will check all the values that match it. then print only those.
            if (classComboBox.SelectedIndex == 0)
            {
                characterListBox.Items.Clear();
                foreach (KeyValuePair<string, string> pair in charClass)
                { if(pair.Value == "warrior")
                    {
                        characterListBox.Items.Add(pair.Key);
                    }
                    
                }
            }

            //the same as before but with rouge
            if (classComboBox.SelectedIndex == 1)
            {
                characterListBox.Items.Clear();
                foreach (KeyValuePair<string, string> pair in charClass)
                {
                    if (pair.Value == "rouge")
                    {
                        characterListBox.Items.Add(pair.Key);
                    }

                }
            }

            //and once more with mage
            if (classComboBox.SelectedIndex == 2)
            {
                characterListBox.Items.Clear();
                foreach (KeyValuePair<string, string> pair in charClass)
                {
                    if (pair.Value == "mage")
                    {
                        characterListBox.Items.Add(pair.Key);
                    }

                }
            }
        }
    }
}
