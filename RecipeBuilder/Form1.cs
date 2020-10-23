using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecipeBuilder
{
    public partial class MainPageForm : Form
    {
        //this is a test comment to test a Pull request
        public MainPageForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void BtnCreateRecipe_Click(object sender, EventArgs e)
        {
            NewRecipeName page = new NewRecipeName();
            page.Show();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            Settings page = new Settings();
            page.Show();
        }
    }
}
