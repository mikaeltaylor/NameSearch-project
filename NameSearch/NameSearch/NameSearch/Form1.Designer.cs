namespace NameSearch
{
    partial class Form1
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
            this.txtBoysInput = new System.Windows.Forms.TextBox();
            this.txtGirlsInput = new System.Windows.Forms.TextBox();
            this.lblBoysInput = new System.Windows.Forms.Label();
            this.lblInputGirls = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBoysInput
            // 
            this.txtBoysInput.Location = new System.Drawing.Point(105, 48);
            this.txtBoysInput.Name = "txtBoysInput";
            this.txtBoysInput.Size = new System.Drawing.Size(100, 20);
            this.txtBoysInput.TabIndex = 0;
            // 
            // txtGirlsInput
            // 
            this.txtGirlsInput.Location = new System.Drawing.Point(105, 74);
            this.txtGirlsInput.Name = "txtGirlsInput";
            this.txtGirlsInput.Size = new System.Drawing.Size(100, 20);
            this.txtGirlsInput.TabIndex = 1;
            // 
            // lblBoysInput
            // 
            this.lblBoysInput.AutoSize = true;
            this.lblBoysInput.Location = new System.Drawing.Point(33, 51);
            this.lblBoysInput.Name = "lblBoysInput";
            this.lblBoysInput.Size = new System.Drawing.Size(66, 13);
            this.lblBoysInput.TabIndex = 2;
            this.lblBoysInput.Text = "Boy\'s Name:";
            // 
            // lblInputGirls
            // 
            this.lblInputGirls.AutoSize = true;
            this.lblInputGirls.Location = new System.Drawing.Point(36, 77);
            this.lblInputGirls.Name = "lblInputGirls";
            this.lblInputGirls.Size = new System.Drawing.Size(63, 13);
            this.lblInputGirls.TabIndex = 3;
            this.lblInputGirls.Text = "Girl\'s Name:";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(91, 138);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 187);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblInputGirls);
            this.Controls.Add(this.lblBoysInput);
            this.Controls.Add(this.txtGirlsInput);
            this.Controls.Add(this.txtBoysInput);
            this.Name = "Form1";
            this.Text = "Name Search";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoysInput;
        private System.Windows.Forms.TextBox txtGirlsInput;
        private System.Windows.Forms.Label lblBoysInput;
        private System.Windows.Forms.Label lblInputGirls;
        private System.Windows.Forms.Button btnSearch;
    }
}

