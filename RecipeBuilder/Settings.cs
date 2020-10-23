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
        string meatPath = @"IngredientMasterMeatList.txt";
        string veggiePath = @"IngredientMasterVeggieList.txt";
        string fruitPath = @"IngredientMasterFruitList.txt";
        string miscItemPath = @"IngredientMasterMiscItemList.txt";

        int meatType = 1;
        int veggieType = 2;
        int fruitType = 3;
        int miscType = 4;

        public Settings()
        {
            InitializeComponent();
        }

        
        private void Settings_Load(object sender, EventArgs e)
        {
            LoadIngredients(meatPath, meatType);
            LoadIngredients(veggiePath, veggieType);
            LoadIngredients(fruitPath, fruitType);
            LoadIngredients(miscItemPath, miscType);
            EntryMeatNewMasterIngredient.Focus();
        }


        /// <summary>
        /// GENERIC LOAD INGREDIENTS
        /// Receives a file path and an int "type" to determine the group box
        /// </summary>
        private void LoadIngredients(string filePath, int type)
        {
            //Open the file specified with filePath
            StreamReader inputFile;
            inputFile = File.OpenText(filePath);

            switch (type)
            {
                //EACH CASE LOADS THE SPECIFIC GROUP BOX THAT NEEDS UPDATING
                //Meat
                case 1:
                    //load the list with items from the text file
                    while (!inputFile.EndOfStream)
                    {
                        LstMasterMeatIngredients.Items.Add(inputFile.ReadLine());
                    }
                    break;
                //Veggies
                case 2: 
                    //load the list with items from the text file
                    while (!inputFile.EndOfStream)
                    {
                        LstMasterVeggieIngredients.Items.Add(inputFile.ReadLine());
                    }
                    break;
                //Fruit
                case 3:
                    while (!inputFile.EndOfStream)
                    {
                        LstMasterFruit.Items.Add(inputFile.ReadLine());
                    }
                    break;
                //Misc
                case 4:
                    while (!inputFile.EndOfStream)
                    {
                        LstMasterMiscellaneous.Items.Add(inputFile.ReadLine());
                    }
                    break;
                default:
                    MessageBox.Show("Type could not be determined.");
                    break;
            }

            //close the file
            inputFile.Close();
        }

        private void BtnReturnFromSettings_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }


        /***********MEAT OPERATIONS***********/
        //Add Meat
        private void BtnAddMeatMasterIngredient_Click(object sender, EventArgs e)
        {
            try {AddNewIngredient(meatPath, meatType);}
            catch (Exception ex) {MessageBox.Show(ex.Message);}
            
        }
        //Remove Meat
        private void BtnRemoveMasterIngredient_Click(object sender, EventArgs e)
        {
            try {RemoveIngredient(meatPath, meatType);}
            catch (Exception ex) {MessageBox.Show(ex.Message);}                
        }


        /***********VEGGIE OPERATIONS***********/
        //Add Veggie
        private void BtnAddVeggie_Click(object sender, EventArgs e)
        {
            try {AddNewIngredient(veggiePath, veggieType);}
            catch (Exception ex) {MessageBox.Show(ex.Message);}
        }
        //Remove Veggie
        private void BtnRemoveVeggie_Click(object sender, EventArgs e)
        {
            try { RemoveIngredient(veggiePath, veggieType); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        /***********FRUIT OPERATIONS***********/
        //Add Fruit
        private void BtnAddFruit_Click(object sender, EventArgs e)
        {
            try { AddNewIngredient(fruitPath, fruitType); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        //Remove Fruit
        private void BtnRemoveFruit_Click(object sender, EventArgs e)
        {
            try { RemoveIngredient(fruitPath, fruitType); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        /***********MISC ITEM OPERATIONS***********/
        //Add Misc item
        private void BtnAddMiscellaneous_Click(object sender, EventArgs e)
        {
            try { AddNewIngredient(miscItemPath, miscType); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        //Remove Misc Item
        private void BtnRemoveMiscellaneous_Click(object sender, EventArgs e)
        {
            try { RemoveIngredient(miscItemPath, miscType); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        /************************GENERIC METHODS***************************/
        //Add new Ingredient
        private void AddNewIngredient(string filePath, int type)
        {
            //add new ingredient to teh file
            StreamWriter outputFile;

            outputFile = File.AppendText(filePath);

            switch (type)
            {
                //Meat
                case 1:
                    outputFile.WriteLine(EntryMeatNewMasterIngredient.Text);
                    outputFile.Close();
                    LstMasterMeatIngredients.Items.Clear();
                    LoadIngredients(filePath, type);
                    EntryMeatNewMasterIngredient.Clear();
                    EntryMeatNewMasterIngredient.Focus();
                    break;
                //Veggie
                case 2:
                    outputFile.WriteLine(EntryNewVeggie.Text);
                    outputFile.Close();
                    LstMasterVeggieIngredients.Items.Clear();
                    LoadIngredients(filePath, type);
                    EntryNewVeggie.Clear();
                    EntryNewVeggie.Focus();
                    break;
                //Fruit
                case 3:
                    outputFile.WriteLine(EntryFruit.Text);
                    outputFile.Close();
                    LstMasterFruit.Items.Clear();
                    LoadIngredients(filePath, type);
                    EntryFruit.Clear();
                    EntryFruit.Focus();
                    break;
                //Misc Item
                case 4:
                    outputFile.WriteLine(EntryMiscellaneous.Text);
                    outputFile.Close();
                    LstMasterMiscellaneous.Items.Clear();
                    LoadIngredients(filePath, type);
                    EntryMiscellaneous.Clear();
                    EntryMiscellaneous.Focus();
                    break;

                default:
                    MessageBox.Show("There is something wrong with the AddNewIngredient method.");
                    break;
            }

        }
        //Remove Ingredient
        private void RemoveIngredient(string filePath, int type)
        {
            switch (type)
            {
                //Meat
                case 1:
                    //remove item selected
                    string removeThisMeat = LstMasterMeatIngredients.SelectedItem.ToString();
                    LstMasterMeatIngredients.Items.Remove(LstMasterMeatIngredients.SelectedItem);

                    //Code from  'https://stackoverflow.com/questions/10371630/c-sharp-text-file-search-for-specific-word-and-delete-whole-line-of-text-that-co'
                    var oldLinesMeat = System.IO.File.ReadAllLines(filePath);
                    var newLinesMeat = oldLinesMeat.Where(line => !line.Contains(removeThisMeat));
                    System.IO.File.WriteAllLines(filePath, newLinesMeat);


                    //Clear and reload list
                    LstMasterMeatIngredients.Items.Clear();
                    LoadIngredients(meatPath, meatType);
                    break;

                //Veggie
                case 2:
                    //remove item selected
                    string removeThisVeggie = LstMasterVeggieIngredients.SelectedItem.ToString();
                    LstMasterVeggieIngredients.Items.Remove(LstMasterVeggieIngredients.SelectedItem);

                    //Code from  'https://stackoverflow.com/questions/10371630/c-sharp-text-file-search-for-specific-word-and-delete-whole-line-of-text-that-co'
                    var oldLinesVeggie = System.IO.File.ReadAllLines(filePath);
                    var newLinesVeggie = oldLinesVeggie.Where(line => !line.Contains(removeThisVeggie));
                    System.IO.File.WriteAllLines(filePath, newLinesVeggie);

                    //Clear and reload list
                    LstMasterVeggieIngredients.Items.Clear();
                    LoadIngredients(filePath, type);
                    break;

                //Fruit
                case 3:
                    //remove item selected
                    string removeThisFruit = LstMasterFruit.SelectedItem.ToString();
                    LstMasterFruit.Items.Remove(LstMasterFruit.SelectedItem);

                    //Code from  'https://stackoverflow.com/questions/10371630/c-sharp-text-file-search-for-specific-word-and-delete-whole-line-of-text-that-co'
                    var oldLinesFruit = System.IO.File.ReadAllLines(filePath);
                    var newLinesFruit = oldLinesFruit.Where(line => !line.Contains(removeThisFruit));
                    System.IO.File.WriteAllLines(filePath, newLinesFruit);

                    //Clear and reload list
                    LstMasterFruit.Items.Clear();
                    LoadIngredients(filePath, type);
                    break;

                //Misc Item
                case 4:
                    //remove item selected
                    string removeThisMisc = LstMasterMiscellaneous.SelectedItem.ToString();
                    LstMasterMiscellaneous.Items.Remove(LstMasterMiscellaneous.SelectedItem);

                    //Code from  'https://stackoverflow.com/questions/10371630/c-sharp-text-file-search-for-specific-word-and-delete-whole-line-of-text-that-co'
                    var oldLinesMisc = System.IO.File.ReadAllLines(filePath);
                    var newLinesMisc = oldLinesMisc.Where(line => !line.Contains(removeThisMisc));
                    System.IO.File.WriteAllLines(filePath, newLinesMisc);

                    //Clear and reload list
                    LstMasterMiscellaneous.Items.Clear();
                    LoadIngredients(filePath, type);
                    break;

                default:
                    MessageBox.Show("Something went wrong in the RemoveIngredient method.");
                    break;
            }




        }








        //Doesn't work?
        private void keypressed(Object o, KeyPressEventArgs e)
        {
            // The keypressed method uses the KeyChar property to check 
            // whether the ENTER key is pressed. 

            // If the ENTER key is pressed, the Handled property is set to true, 
            // to indicate the event is handled.

            //If enter key is pressed, click the add button
            if (e.KeyChar == (char)Keys.Return)
            {
                BtnAddMeatMasterIngredient.PerformClick();
            }
        }

        /// <summary>
        /// Not Needed (All three below)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EntryNewMasterIngredient_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


    }
}
