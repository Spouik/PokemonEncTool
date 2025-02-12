namespace PokemonEncTool
{
    partial class MainPage
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.cbGameVer = new System.Windows.Forms.ComboBox();
            this.cbLang = new System.Windows.Forms.ComboBox();
            this.lblTestGameVer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(285, 196);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbGameVer
            // 
            this.cbGameVer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGameVer.FormattingEnabled = true;
            this.cbGameVer.Location = new System.Drawing.Point(441, 268);
            this.cbGameVer.Name = "cbGameVer";
            this.cbGameVer.Size = new System.Drawing.Size(121, 21);
            this.cbGameVer.TabIndex = 1;
            this.cbGameVer.SelectedIndexChanged += new System.EventHandler(this.cbGameVer_SelectedIndexChanged);
            // 
            // cbLang
            // 
            this.cbLang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLang.FormattingEnabled = true;
            this.cbLang.Location = new System.Drawing.Point(441, 68);
            this.cbLang.Name = "cbLang";
            this.cbLang.Size = new System.Drawing.Size(121, 21);
            this.cbLang.TabIndex = 2;
            // 
            // lblTestGameVer
            // 
            this.lblTestGameVer.AutoSize = true;
            this.lblTestGameVer.Location = new System.Drawing.Point(449, 315);
            this.lblTestGameVer.Name = "lblTestGameVer";
            this.lblTestGameVer.Size = new System.Drawing.Size(22, 13);
            this.lblTestGameVer.TabIndex = 3;
            this.lblTestGameVer.Text = "- - -";
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTestGameVer);
            this.Controls.Add(this.cbLang);
            this.Controls.Add(this.cbGameVer);
            this.Controls.Add(this.button1);
            this.Name = "MainPage";
            this.Text = "Pokémon Encounter Tool 0.1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbGameVer;
        private System.Windows.Forms.ComboBox cbLang;
        private System.Windows.Forms.Label lblTestGameVer;
    }
}

