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
            this.GbMasterIngredients = new System.Windows.Forms.GroupBox();
            this.BtnRemoveMasterIngredient = new System.Windows.Forms.Button();
            this.BtnAddMasterIngredient = new System.Windows.Forms.Button();
            this.LstMasterIngredients = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EntryNewMasterIngredient = new System.Windows.Forms.TextBox();
            this.BtnReturnFromSettings = new System.Windows.Forms.Button();
            this.GbMasterIngredients.SuspendLayout();
            this.SuspendLayout();
            // 
            // GbMasterIngredients
            // 
            this.GbMasterIngredients.Controls.Add(this.EntryNewMasterIngredient);
            this.GbMasterIngredients.Controls.Add(this.label1);
            this.GbMasterIngredients.Controls.Add(this.BtnRemoveMasterIngredient);
            this.GbMasterIngredients.Controls.Add(this.BtnAddMasterIngredient);
            this.GbMasterIngredients.Controls.Add(this.LstMasterIngredients);
            this.GbMasterIngredients.Location = new System.Drawing.Point(88, 47);
            this.GbMasterIngredients.Name = "GbMasterIngredients";
            this.GbMasterIngredients.Size = new System.Drawing.Size(611, 288);
            this.GbMasterIngredients.TabIndex = 4;
            this.GbMasterIngredients.TabStop = false;
            this.GbMasterIngredients.Text = "Available Ingredients";
            // 
            // BtnRemoveMasterIngredient
            // 
            this.BtnRemoveMasterIngredient.Location = new System.Drawing.Point(500, 248);
            this.BtnRemoveMasterIngredient.Name = "BtnRemoveMasterIngredient";
            this.BtnRemoveMasterIngredient.Size = new System.Drawing.Size(75, 23);
            this.BtnRemoveMasterIngredient.TabIndex = 3;
            this.BtnRemoveMasterIngredient.Text = "Remove";
            this.BtnRemoveMasterIngredient.UseVisualStyleBackColor = true;
            this.BtnRemoveMasterIngredient.Click += new System.EventHandler(this.BtnRemoveMasterIngredient_Click);
            // 
            // BtnAddMasterIngredient
            // 
            this.BtnAddMasterIngredient.Location = new System.Drawing.Point(273, 250);
            this.BtnAddMasterIngredient.Name = "BtnAddMasterIngredient";
            this.BtnAddMasterIngredient.Size = new System.Drawing.Size(75, 23);
            this.BtnAddMasterIngredient.TabIndex = 2;
            this.BtnAddMasterIngredient.Text = "Add";
            this.BtnAddMasterIngredient.UseVisualStyleBackColor = true;
            this.BtnAddMasterIngredient.Click += new System.EventHandler(this.BtnAddMasterIngredient_Click);
            // 
            // LstMasterIngredients
            // 
            this.LstMasterIngredients.FormattingEnabled = true;
            this.LstMasterIngredients.Location = new System.Drawing.Point(31, 34);
            this.LstMasterIngredients.Name = "LstMasterIngredients";
            this.LstMasterIngredients.Size = new System.Drawing.Size(544, 199);
            this.LstMasterIngredients.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Add New Ingredient:";
            // 
            // EntryNewMasterIngredient
            // 
            this.EntryNewMasterIngredient.Location = new System.Drawing.Point(152, 250);
            this.EntryNewMasterIngredient.Name = "EntryNewMasterIngredient";
            this.EntryNewMasterIngredient.Size = new System.Drawing.Size(100, 20);
            this.EntryNewMasterIngredient.TabIndex = 5;
            this.EntryNewMasterIngredient.TextChanged += new System.EventHandler(this.EntryNewMasterIngredient_TextChanged);
            // 
            // BtnReturnFromSettings
            // 
            this.BtnReturnFromSettings.Location = new System.Drawing.Point(690, 433);
            this.BtnReturnFromSettings.Name = "BtnReturnFromSettings";
            this.BtnReturnFromSettings.Size = new System.Drawing.Size(75, 23);
            this.BtnReturnFromSettings.TabIndex = 5;
            this.BtnReturnFromSettings.Text = "Return";
            this.BtnReturnFromSettings.UseVisualStyleBackColor = true;
            this.BtnReturnFromSettings.Click += new System.EventHandler(this.BtnReturnFromSettings_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 482);
            this.Controls.Add(this.BtnReturnFromSettings);
            this.Controls.Add(this.GbMasterIngredients);
            this.Name = "Settings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.GbMasterIngredients.ResumeLayout(false);
            this.GbMasterIngredients.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GbMasterIngredients;
        private System.Windows.Forms.Button BtnRemoveMasterIngredient;
        private System.Windows.Forms.Button BtnAddMasterIngredient;
        private System.Windows.Forms.ListBox LstMasterIngredients;
        private System.Windows.Forms.TextBox EntryNewMasterIngredient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnReturnFromSettings;
    }
}