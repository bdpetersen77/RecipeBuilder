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

namespace RecipeBuilder
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        
        private void Settings_Load(object sender, EventArgs e)
        {
            LoadIngredients();
            EntryNewMasterIngredient.Focus();
        }

        private void LoadIngredients()
        {
            //On load, load the list items
            StreamReader inputFile;
            inputFile = File.OpenText("IngredientMasterList.txt");

            //load the list with items from the text file
            while (!inputFile.EndOfStream)
            {
                LstMasterIngredients.Items.Add(inputFile.ReadLine());
            }
            //close the file
            inputFile.Close();
        }

        private void BtnReturnFromSettings_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void BtnAddMasterIngredient_Click(object sender, EventArgs e)
        {
            try
            {
                //add new ingredient to teh file
                StreamWriter outputFile;

                outputFile = File.AppendText("IngredientMasterList.txt");

                outputFile.WriteLine(EntryNewMasterIngredient.Text);

                outputFile.Close();

                LstMasterIngredients.Items.Clear();

                LoadIngredients();

                EntryNewMasterIngredient.Clear();

                EntryNewMasterIngredient.Focus();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }

        private void BtnRemoveMasterIngredient_Click(object sender, EventArgs e)
        {

            try
            {
                //remove item selected
                string removeThis = LstMasterIngredients.SelectedItem.ToString();
                LstMasterIngredients.Items.Remove(LstMasterIngredients.SelectedItem);


                //Code from 'https://stackoverflow.com/questions/10371630/c-sharp-text-file-search-for-specific-word-and-delete-whole-line-of-text-that-co'
                var oldLines = System.IO.File.ReadAllLines("IngredientMasterList.txt");
                var newLines = oldLines.Where(line => !line.Contains(removeThis));
                System.IO.File.WriteAllLines("IngredientMasterList.txt", newLines);

                //Clear and reload list
                LstMasterIngredients.Items.Clear();
                LoadIngredients();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }    


            
        }

        private void keypressed(Object o, KeyPressEventArgs e)
        {
            // The keypressed method uses the KeyChar property to check 
            // whether the ENTER key is pressed. 

            // If the ENTER key is pressed, the Handled property is set to true, 
            // to indicate the event is handled.

            //If enter key is pressed, click the add button
            if (e.KeyChar == (char)Keys.Return)
            {
                BtnAddMasterIngredient.PerformClick();
            }
        }

        private void EntryNewMasterIngredient_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
