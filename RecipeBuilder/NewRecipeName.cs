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
    public partial class NewRecipeName : Form
    {
        public NewRecipeName()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //validate that a name has been presented

            //Create new page
            CreateNewRecipe page = new CreateNewRecipe();
            this.Close();
            page.Show();
        }
    }
}
