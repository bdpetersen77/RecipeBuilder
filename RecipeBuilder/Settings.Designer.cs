namespace RecipeBuilder
{
    partial class Settings
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
            this.GbMasterMeatIngredients = new System.Windows.Forms.GroupBox();
            this.EntryMeatNewMasterIngredient = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnRemoveMeatMasterIngredient = new System.Windows.Forms.Button();
            this.BtnAddMeatMasterIngredient = new System.Windows.Forms.Button();
            this.LstMasterMeatIngredients = new System.Windows.Forms.ListBox();
            this.BtnReturnFromSettings = new System.Windows.Forms.Button();
            this.GbMasterVeggieIngredients = new System.Windows.Forms.GroupBox();
            this.EntryNewVeggie = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnRemoveVeggie = new System.Windows.Forms.Button();
            this.BtnAddVeggie = new System.Windows.Forms.Button();
            this.LstMasterVeggieIngredients = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.GbFruit = new System.Windows.Forms.GroupBox();
            this.EntryFruit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnRemoveFruit = new System.Windows.Forms.Button();
            this.BtnAddFruit = new System.Windows.Forms.Button();
            this.LstMasterFruit = new System.Windows.Forms.ListBox();
            this.GbMiscellaneous = new System.Windows.Forms.GroupBox();
            this.EntryMiscellaneous = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnRemoveMiscellaneous = new System.Windows.Forms.Button();
            this.BtnAddMiscellaneous = new System.Windows.Forms.Button();
            this.LstMasterMiscellaneous = new System.Windows.Forms.ListBox();
            this.settingsIngredientsTab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.GbMasterMeatIngredients.SuspendLayout();
            this.GbMasterVeggieIngredients.SuspendLayout();
            this.GbFruit.SuspendLayout();
            this.GbMiscellaneous.SuspendLayout();
            this.settingsIngredientsTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GbMasterMeatIngredients
            // 
            this.GbMasterMeatIngredients.Controls.Add(this.EntryMeatNewMasterIngredient);
            this.GbMasterMeatIngredients.Controls.Add(this.label1);
            this.GbMasterMeatIngredients.Controls.Add(this.BtnRemoveMeatMasterIngredient);
            this.GbMasterMeatIngredients.Controls.Add(this.BtnAddMeatMasterIngredient);
            this.GbMasterMeatIngredients.Controls.Add(this.LstMasterMeatIngredients);
            this.GbMasterMeatIngredients.Location = new System.Drawing.Point(20, 30);
            this.GbMasterMeatIngredients.Name = "GbMasterMeatIngredients";
            this.GbMasterMeatIngredients.Size = new System.Drawing.Size(353, 238);
            this.GbMasterMeatIngredients.TabIndex = 4;
            this.GbMasterMeatIngredients.TabStop = false;
            this.GbMasterMeatIngredients.Text = "Meat";
            // 
            // EntryMeatNewMasterIngredient
            // 
            this.EntryMeatNewMasterIngredient.Location = new System.Drawing.Point(116, 31);
            this.EntryMeatNewMasterIngredient.Name = "EntryMeatNewMasterIngredient";
            this.EntryMeatNewMasterIngredient.Size = new System.Drawing.Size(100, 20);
            this.EntryMeatNewMasterIngredient.TabIndex = 5;
            this.EntryMeatNewMasterIngredient.TextChanged += new System.EventHandler(this.EntryNewMasterIngredient_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Add New Meat:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // BtnRemoveMeatMasterIngredient
            // 
            this.BtnRemoveMeatMasterIngredient.Location = new System.Drawing.Point(242, 190);
            this.BtnRemoveMeatMasterIngredient.Name = "BtnRemoveMeatMasterIngredient";
            this.BtnRemoveMeatMasterIngredient.Size = new System.Drawing.Size(75, 23);
            this.BtnRemoveMeatMasterIngredient.TabIndex = 3;
            this.BtnRemoveMeatMasterIngredient.Text = "Remove";
            this.BtnRemoveMeatMasterIngredient.UseVisualStyleBackColor = true;
            this.BtnRemoveMeatMasterIngredient.Click += new System.EventHandler(this.BtnRemoveMasterIngredient_Click);
            // 
            // BtnAddMeatMasterIngredient
            // 
            this.BtnAddMeatMasterIngredient.Location = new System.Drawing.Point(242, 29);
            this.BtnAddMeatMasterIngredient.Name = "BtnAddMeatMasterIngredient";
            this.BtnAddMeatMasterIngredient.Size = new System.Drawing.Size(75, 23);
            this.BtnAddMeatMasterIngredient.TabIndex = 2;
            this.BtnAddMeatMasterIngredient.Text = "Add";
            this.BtnAddMeatMasterIngredient.UseVisualStyleBackColor = true;
            this.BtnAddMeatMasterIngredient.Click += new System.EventHandler(this.BtnAddMeatMasterIngredient_Click);
            // 
            // LstMasterMeatIngredients
            // 
            this.LstMasterMeatIngredients.FormattingEnabled = true;
            this.LstMasterMeatIngredients.Location = new System.Drawing.Point(32, 66);
            this.LstMasterMeatIngredients.Name = "LstMasterMeatIngredients";
            this.LstMasterMeatIngredients.Size = new System.Drawing.Size(181, 147);
            this.LstMasterMeatIngredients.TabIndex = 0;
            // 
            // BtnReturnFromSettings
            // 
            this.BtnReturnFromSettings.Location = new System.Drawing.Point(726, 644);
            this.BtnReturnFromSettings.Name = "BtnReturnFromSettings";
            this.BtnReturnFromSettings.Size = new System.Drawing.Size(75, 23);
            this.BtnReturnFromSettings.TabIndex = 5;
            this.BtnReturnFromSettings.Text = "Return";
            this.BtnReturnFromSettings.UseVisualStyleBackColor = true;
            this.BtnReturnFromSettings.Click += new System.EventHandler(this.BtnReturnFromSettings_Click);
            // 
            // GbMasterVeggieIngredients
            // 
            this.GbMasterVeggieIngredients.Controls.Add(this.EntryNewVeggie);
            this.GbMasterVeggieIngredients.Controls.Add(this.label2);
            this.GbMasterVeggieIngredients.Controls.Add(this.BtnRemoveVeggie);
            this.GbMasterVeggieIngredients.Controls.Add(this.BtnAddVeggie);
            this.GbMasterVeggieIngredients.Controls.Add(this.LstMasterVeggieIngredients);
            this.GbMasterVeggieIngredients.Location = new System.Drawing.Point(409, 31);
            this.GbMasterVeggieIngredients.Name = "GbMasterVeggieIngredients";
            this.GbMasterVeggieIngredients.Size = new System.Drawing.Size(353, 238);
            this.GbMasterVeggieIngredients.TabIndex = 6;
            this.GbMasterVeggieIngredients.TabStop = false;
            this.GbMasterVeggieIngredients.Text = "Veggies";
            // 
            // EntryNewVeggie
            // 
            this.EntryNewVeggie.Location = new System.Drawing.Point(116, 31);
            this.EntryNewVeggie.Name = "EntryNewVeggie";
            this.EntryNewVeggie.Size = new System.Drawing.Size(100, 20);
            this.EntryNewVeggie.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Add New Veggie:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // BtnRemoveVeggie
            // 
            this.BtnRemoveVeggie.Location = new System.Drawing.Point(242, 190);
            this.BtnRemoveVeggie.Name = "BtnRemoveVeggie";
            this.BtnRemoveVeggie.Size = new System.Drawing.Size(75, 23);
            this.BtnRemoveVeggie.TabIndex = 3;
            this.BtnRemoveVeggie.Text = "Remove";
            this.BtnRemoveVeggie.UseVisualStyleBackColor = true;
            this.BtnRemoveVeggie.Click += new System.EventHandler(this.BtnRemoveVeggie_Click);
            // 
            // BtnAddVeggie
            // 
            this.BtnAddVeggie.Location = new System.Drawing.Point(242, 29);
            this.BtnAddVeggie.Name = "BtnAddVeggie";
            this.BtnAddVeggie.Size = new System.Drawing.Size(75, 23);
            this.BtnAddVeggie.TabIndex = 2;
            this.BtnAddVeggie.Text = "Add";
            this.BtnAddVeggie.UseVisualStyleBackColor = true;
            this.BtnAddVeggie.Click += new System.EventHandler(this.BtnAddVeggie_Click);
            // 
            // LstMasterVeggieIngredients
            // 
            this.LstMasterVeggieIngredients.FormattingEnabled = true;
            this.LstMasterVeggieIngredients.Location = new System.Drawing.Point(32, 66);
            this.LstMasterVeggieIngredients.Name = "LstMasterVeggieIngredients";
            this.LstMasterVeggieIngredients.Size = new System.Drawing.Size(181, 147);
            this.LstMasterVeggieIngredients.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(63, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "PROGRAM SETTINGS";
            // 
            // GbFruit
            // 
            this.GbFruit.Controls.Add(this.EntryFruit);
            this.GbFruit.Controls.Add(this.label4);
            this.GbFruit.Controls.Add(this.BtnRemoveFruit);
            this.GbFruit.Controls.Add(this.BtnAddFruit);
            this.GbFruit.Controls.Add(this.LstMasterFruit);
            this.GbFruit.Location = new System.Drawing.Point(20, 298);
            this.GbFruit.Name = "GbFruit";
            this.GbFruit.Size = new System.Drawing.Size(353, 238);
            this.GbFruit.TabIndex = 6;
            this.GbFruit.TabStop = false;
            this.GbFruit.Text = "Fruit";
            // 
            // EntryFruit
            // 
            this.EntryFruit.Location = new System.Drawing.Point(116, 31);
            this.EntryFruit.Name = "EntryFruit";
            this.EntryFruit.Size = new System.Drawing.Size(100, 20);
            this.EntryFruit.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Add New Fruit:";
            // 
            // BtnRemoveFruit
            // 
            this.BtnRemoveFruit.Location = new System.Drawing.Point(242, 190);
            this.BtnRemoveFruit.Name = "BtnRemoveFruit";
            this.BtnRemoveFruit.Size = new System.Drawing.Size(75, 23);
            this.BtnRemoveFruit.TabIndex = 3;
            this.BtnRemoveFruit.Text = "Remove";
            this.BtnRemoveFruit.UseVisualStyleBackColor = true;
            this.BtnRemoveFruit.Click += new System.EventHandler(this.BtnRemoveFruit_Click);
            // 
            // BtnAddFruit
            // 
            this.BtnAddFruit.Location = new System.Drawing.Point(242, 29);
            this.BtnAddFruit.Name = "BtnAddFruit";
            this.BtnAddFruit.Size = new System.Drawing.Size(75, 23);
            this.BtnAddFruit.TabIndex = 2;
            this.BtnAddFruit.Text = "Add";
            this.BtnAddFruit.UseVisualStyleBackColor = true;
            this.BtnAddFruit.Click += new System.EventHandler(this.BtnAddFruit_Click);
            // 
            // LstMasterFruit
            // 
            this.LstMasterFruit.FormattingEnabled = true;
            this.LstMasterFruit.Location = new System.Drawing.Point(32, 66);
            this.LstMasterFruit.Name = "LstMasterFruit";
            this.LstMasterFruit.Size = new System.Drawing.Size(181, 147);
            this.LstMasterFruit.TabIndex = 0;
            // 
            // GbMiscellaneous
            // 
            this.GbMiscellaneous.Controls.Add(this.EntryMiscellaneous);
            this.GbMiscellaneous.Controls.Add(this.label5);
            this.GbMiscellaneous.Controls.Add(this.BtnRemoveMiscellaneous);
            this.GbMiscellaneous.Controls.Add(this.BtnAddMiscellaneous);
            this.GbMiscellaneous.Controls.Add(this.LstMasterMiscellaneous);
            this.GbMiscellaneous.Location = new System.Drawing.Point(409, 298);
            this.GbMiscellaneous.Name = "GbMiscellaneous";
            this.GbMiscellaneous.Size = new System.Drawing.Size(353, 238);
            this.GbMiscellaneous.TabIndex = 7;
            this.GbMiscellaneous.TabStop = false;
            this.GbMiscellaneous.Text = "Miscellaneous";
            // 
            // EntryMiscellaneous
            // 
            this.EntryMiscellaneous.Location = new System.Drawing.Point(116, 31);
            this.EntryMiscellaneous.Name = "EntryMiscellaneous";
            this.EntryMiscellaneous.Size = new System.Drawing.Size(100, 20);
            this.EntryMiscellaneous.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Add Misc Item:";
            // 
            // BtnRemoveMiscellaneous
            // 
            this.BtnRemoveMiscellaneous.Location = new System.Drawing.Point(242, 190);
            this.BtnRemoveMiscellaneous.Name = "BtnRemoveMiscellaneous";
            this.BtnRemoveMiscellaneous.Size = new System.Drawing.Size(75, 23);
            this.BtnRemoveMiscellaneous.TabIndex = 3;
            this.BtnRemoveMiscellaneous.Text = "Remove";
            this.BtnRemoveMiscellaneous.UseVisualStyleBackColor = true;
            this.BtnRemoveMiscellaneous.Click += new System.EventHandler(this.BtnRemoveMiscellaneous_Click);
            // 
            // BtnAddMiscellaneous
            // 
            this.BtnAddMiscellaneous.Location = new System.Drawing.Point(242, 29);
            this.BtnAddMiscellaneous.Name = "BtnAddMiscellaneous";
            this.BtnAddMiscellaneous.Size = new System.Drawing.Size(75, 23);
            this.BtnAddMiscellaneous.TabIndex = 2;
            this.BtnAddMiscellaneous.Text = "Add";
            this.BtnAddMiscellaneous.UseVisualStyleBackColor = true;
            this.BtnAddMiscellaneous.Click += new System.EventHandler(this.BtnAddMiscellaneous_Click);
            // 
            // LstMasterMiscellaneous
            // 
            this.LstMasterMiscellaneous.FormattingEnabled = true;
            this.LstMasterMiscellaneous.Location = new System.Drawing.Point(32, 66);
            this.LstMasterMiscellaneous.Name = "LstMasterMiscellaneous";
            this.LstMasterMiscellaneous.Size = new System.Drawing.Size(181, 147);
            this.LstMasterMiscellaneous.TabIndex = 0;
            // 
            // settingsIngredientsTab
            // 
            this.settingsIngredientsTab.Controls.Add(this.tabPage1);
            this.settingsIngredientsTab.Controls.Add(this.tabPage2);
            this.settingsIngredientsTab.Location = new System.Drawing.Point(67, 55);
            this.settingsIngredientsTab.Name = "settingsIngredientsTab";
            this.settingsIngredientsTab.Padding = new System.Drawing.Point(10, 5);
            this.settingsIngredientsTab.SelectedIndex = 0;
            this.settingsIngredientsTab.Size = new System.Drawing.Size(799, 583);
            this.settingsIngredientsTab.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.GbMasterMeatIngredients);
            this.tabPage1.Controls.Add(this.GbMiscellaneous);
            this.tabPage1.Controls.Add(this.GbFruit);
            this.tabPage1.Controls.Add(this.GbMasterVeggieIngredients);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(8);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(8);
            this.tabPage1.Size = new System.Drawing.Size(791, 553);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ingredients";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(791, 553);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 690);
            this.Controls.Add(this.settingsIngredientsTab);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnReturnFromSettings);
            this.Name = "Settings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.GbMasterMeatIngredients.ResumeLayout(false);
            this.GbMasterMeatIngredients.PerformLayout();
            this.GbMasterVeggieIngredients.ResumeLayout(false);
            this.GbMasterVeggieIngredients.PerformLayout();
            this.GbFruit.ResumeLayout(false);
            this.GbFruit.PerformLayout();
            this.GbMiscellaneous.ResumeLayout(false);
            this.GbMiscellaneous.PerformLayout();
            this.settingsIngredientsTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GbMasterMeatIngredients;
        private System.Windows.Forms.Button BtnRemoveMeatMasterIngredient;
        private System.Windows.Forms.Button BtnAddMeatMasterIngredient;
        private System.Windows.Forms.ListBox LstMasterMeatIngredients;
        private System.Windows.Forms.TextBox EntryMeatNewMasterIngredient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnReturnFromSettings;
        private System.Windows.Forms.GroupBox GbMasterVeggieIngredients;
        private System.Windows.Forms.TextBox EntryNewVeggie;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnRemoveVeggie;
        private System.Windows.Forms.Button BtnAddVeggie;
        private System.Windows.Forms.ListBox LstMasterVeggieIngredients;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox GbFruit;
        private System.Windows.Forms.TextBox EntryFruit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnRemoveFruit;
        private System.Windows.Forms.Button BtnAddFruit;
        private System.Windows.Forms.ListBox LstMasterFruit;
        private System.Windows.Forms.GroupBox GbMiscellaneous;
        private System.Windows.Forms.TextBox EntryMiscellaneous;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnRemoveMiscellaneous;
        private System.Windows.Forms.Button BtnAddMiscellaneous;
        private System.Windows.Forms.ListBox LstMasterMiscellaneous;
        private System.Windows.Forms.TabControl settingsIngredientsTab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}