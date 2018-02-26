namespace Pk_Uppgift
{
    partial class WebService
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
            this.btnGo = new System.Windows.Forms.Button();
            this.txtBoxBrowseText = new System.Windows.Forms.TextBox();
            this.txtBoxFileContent = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtBoxEntityContent = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBoxEntities = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(107, 473);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(530, 26);
            this.btnGo.TabIndex = 0;
            this.btnGo.Text = "Go!";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // txtBoxBrowseText
            // 
            this.txtBoxBrowseText.Location = new System.Drawing.Point(107, 78);
            this.txtBoxBrowseText.Name = "txtBoxBrowseText";
            this.txtBoxBrowseText.Size = new System.Drawing.Size(449, 26);
            this.txtBoxBrowseText.TabIndex = 1;
            // 
            // txtBoxFileContent
            // 
            this.txtBoxFileContent.Location = new System.Drawing.Point(107, 165);
            this.txtBoxFileContent.Multiline = true;
            this.txtBoxFileContent.Name = "txtBoxFileContent";
            this.txtBoxFileContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBoxFileContent.Size = new System.Drawing.Size(530, 302);
            this.txtBoxFileContent.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(562, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 26);
            this.button1.TabIndex = 3;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BtnBrowse_Click);
            // 
            // txtBoxEntityContent
            // 
            this.txtBoxEntityContent.Location = new System.Drawing.Point(780, 165);
            this.txtBoxEntityContent.Multiline = true;
            this.txtBoxEntityContent.Name = "txtBoxEntityContent";
            this.txtBoxEntityContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBoxEntityContent.Size = new System.Drawing.Size(530, 302);
            this.txtBoxEntityContent.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(780, 473);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(530, 26);
            this.button2.TabIndex = 5;
            this.button2.Text = "Go!";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBoxEntities
            // 
            this.comboBoxEntities.FormattingEnabled = true;
            this.comboBoxEntities.Location = new System.Drawing.Point(780, 76);
            this.comboBoxEntities.Name = "comboBoxEntities";
            this.comboBoxEntities.Size = new System.Drawing.Size(334, 28);
            this.comboBoxEntities.TabIndex = 6;
            this.comboBoxEntities.DropDownClosed += new System.EventHandler(this.comboBoxEntities_DropDownClosed);
            // 
            // WebService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1381, 898);
            this.Controls.Add(this.comboBoxEntities);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtBoxEntityContent);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtBoxFileContent);
            this.Controls.Add(this.txtBoxBrowseText);
            this.Controls.Add(this.btnGo);
            this.Name = "WebService";
            this.Text = "WebService";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.TextBox txtBoxBrowseText;
        private System.Windows.Forms.TextBox txtBoxFileContent;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtBoxEntityContent;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBoxEntities;
    }
}