namespace Pk_Uppgift
{
    partial class Launch
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
            this.btnPk = new System.Windows.Forms.Button();
            this.btnWebSerivce = new System.Windows.Forms.Button();
            this.btnErp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPk
            // 
            this.btnPk.Location = new System.Drawing.Point(53, 142);
            this.btnPk.Name = "btnPk";
            this.btnPk.Size = new System.Drawing.Size(355, 161);
            this.btnPk.TabIndex = 0;
            this.btnPk.Text = "Programkonstruktion";
            this.btnPk.UseVisualStyleBackColor = true;
            this.btnPk.Click += new System.EventHandler(this.btnPk_Click);
            // 
            // btnWebSerivce
            // 
            this.btnWebSerivce.Location = new System.Drawing.Point(444, 142);
            this.btnWebSerivce.Name = "btnWebSerivce";
            this.btnWebSerivce.Size = new System.Drawing.Size(355, 161);
            this.btnWebSerivce.TabIndex = 1;
            this.btnWebSerivce.Text = "Webservice";
            this.btnWebSerivce.UseVisualStyleBackColor = true;
            this.btnWebSerivce.Click += new System.EventHandler(this.btnWebSerivce_Click);
            // 
            // btnErp
            // 
            this.btnErp.Location = new System.Drawing.Point(842, 142);
            this.btnErp.Name = "btnErp";
            this.btnErp.Size = new System.Drawing.Size(355, 161);
            this.btnErp.TabIndex = 2;
            this.btnErp.Text = "Erp Integration";
            this.btnErp.UseVisualStyleBackColor = true;
            // 
            // Launch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 483);
            this.Controls.Add(this.btnErp);
            this.Controls.Add(this.btnWebSerivce);
            this.Controls.Add(this.btnPk);
            this.Name = "Launch";
            this.Text = "Launch";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPk;
        private System.Windows.Forms.Button btnWebSerivce;
        private System.Windows.Forms.Button btnErp;
    }
}