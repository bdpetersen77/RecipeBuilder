namespace RecipeBuilder
{
    partial class CreateNewRecipe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblMainPageTitle = new System.Windows.Forms.Label();
            this.GbIngredients = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.LstAddedIngredients = new System.Windows.Forms.ListBox();
            this.LstIngredients = new System.Windows.Forms.ListBox();
            this.GbIngredients.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblMainPageTitle
            // 
            this.LblMainPageTitle.AutoSize = true;
            this.LblMainPageTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMainPageTitle.Location = new System.Drawing.Point(276, 30);
            this.LblMainPageTitle.Name = "LblMainPageTitle";
            this.LblMainPageTitle.Size = new System.Drawing.Size(245, 33);
            this.LblMainPageTitle.TabIndex = 1;
            this.LblMainPageTitle.Text = "Add New Recipe";
            // 
            // GbIngredients
            // 
            this.GbIngredients.Controls.Add(this.button2);
            this.GbIngredients.Controls.Add(this.button1);
            this.GbIngredients.Controls.Add(this.LstAddedIngredients);
            this.GbIngredients.Controls.Add(this.LstIngredients);
            this.GbIngredients.Location = new System.Drawing.Point(88, 122);
            this.GbIngredients.Name = "GbIngredients";
            this.GbIngredients.Size = new System.Drawing.Size(611, 272);
            this.GbIngredients.TabIndex = 3;
            this.GbIngredients.TabStop = false;
            this.GbIngredients.Text = "Ingredients";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(274, 152);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Remove";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(274, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // LstAddedIngredients
            // 
            this.LstAddedIngredients.FormattingEnabled = true;
            this.LstAddedIngredients.Location = new System.Drawing.Point(352, 34);
            this.LstAddedIngredients.Name = "LstAddedIngredients";
            this.LstAddedIngredients.Size = new System.Drawing.Size(237, 199);
            this.LstAddedIngredients.TabIndex = 1;
            // 
            // LstIngredients
            // 
            this.LstIngredients.FormattingEnabled = true;
            this.LstIngredients.Location = new System.Drawing.Point(31, 34);
            this.LstIngredients.Name = "LstIngredients";
            this.LstIngredients.Size = new System.Drawing.Size(237, 199);
            this.LstIngredients.TabIndex = 0;
            // 
            // CreateNewRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 537);
            this.Controls.Add(this.GbIngredients);
            this.Controls.Add(this.LblMainPageTitle);
            this.Name = "CreateNewRecipe";
            this.Text = "CreateNewRecipe";
            this.GbIngredients.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblMainPageTitle;
        private System.Windows.Forms.GroupBox GbIngredients;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox LstAddedIngredients;
        private System.Windows.Forms.ListBox LstIngredients;
    }
}