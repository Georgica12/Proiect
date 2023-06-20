namespace Proiect
{
    partial class sec_page
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
            this.lista1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lista1
            // 
            this.lista1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lista1.FormattingEnabled = true;
            this.lista1.Items.AddRange(new object[] {
            "AIA",
            "TI",
            "SEA",
            "SECI"});
            this.lista1.Location = new System.Drawing.Point(12, 38);
            this.lista1.Name = "lista1";
            this.lista1.Size = new System.Drawing.Size(121, 21);
            this.lista1.TabIndex = 0;
            this.lista1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // sec_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 271);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lista1);
            this.Name = "sec_page";
            this.Text = "sec_page";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox lista1;
        public System.Windows.Forms.Label label1;
    }
}