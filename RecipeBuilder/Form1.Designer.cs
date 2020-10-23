namespace RecipeBuilder
{
    partial class MainPageForm
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
            this.BtnCreateRecipe = new System.Windows.Forms.Button();
            this.BtnViewRecipes = new System.Windows.Forms.Button();
            this.BtnSettings = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblMainPageTitle
            // 
            this.LblMainPageTitle.AutoSize = true;
            this.LblMainPageTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMainPageTitle.Location = new System.Drawing.Point(307, 52);
            this.LblMainPageTitle.Name = "LblMainPageTitle";
            this.LblMainPageTitle.Size = new System.Drawing.Size(178, 33);
            this.LblMainPageTitle.TabIndex = 0;
            this.LblMainPageTitle.Text = "My Recipes";
            // 
            // BtnCreateRecipe
            // 
            this.BtnCreateRecipe.Location = new System.Drawing.Point(148, 289);
            this.BtnCreateRecipe.Name = "BtnCreateRecipe";
            this.BtnCreateRecipe.Size = new System.Drawing.Size(153, 23);
            this.BtnCreateRecipe.TabIndex = 1;
            this.BtnCreateRecipe.Text = "Create New Recipe";
            this.BtnCreateRecipe.UseVisualStyleBackColor = true;
            this.BtnCreateRecipe.Click += new System.EventHandler(this.BtnCreateRecipe_Click);
            // 
            // BtnViewRecipes
            // 
            this.BtnViewRecipes.Location = new System.Drawing.Point(471, 289);
            this.BtnViewRecipes.Name = "BtnViewRecipes";
            this.BtnViewRecipes.Size = new System.Drawing.Size(153, 23);
            this.BtnViewRecipes.TabIndex = 2;
            this.BtnViewRecipes.Text = "View Recipes";
            this.BtnViewRecipes.UseVisualStyleBackColor = true;
            this.BtnViewRecipes.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnSettings
            // 
            this.BtnSettings.Location = new System.Drawing.Point(696, 374);
            this.BtnSettings.Name = "BtnSettings";
            this.BtnSettings.Size = new System.Drawing.Size(75, 23);
            this.BtnSettings.TabIndex = 3;
            this.BtnSettings.Text = "Settings";
            this.BtnSettings.UseVisualStyleBackColor = true;
            this.BtnSettings.Click += new System.EventHandler(this.BtnSettings_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(696, 415);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(75, 23);
            this.BtnExit.TabIndex = 4;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // MainPageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnSettings);
            this.Controls.Add(this.BtnViewRecipes);
            this.Controls.Add(this.BtnCreateRecipe);
            this.Controls.Add(this.LblMainPageTitle);
            this.Name = "MainPageForm";
            this.Text = "Main Page";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblMainPageTitle;
        private System.Windows.Forms.Button BtnCreateRecipe;
        private System.Windows.Forms.Button BtnViewRecipes;
        private System.Windows.Forms.Button BtnSettings;
        private System.Windows.Forms.Button BtnExit;
    }
}

