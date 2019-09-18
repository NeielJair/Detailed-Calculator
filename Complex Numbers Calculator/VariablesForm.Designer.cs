namespace Complex_Numbers_Calculator
{
    partial class VariablesForm
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
            this.addVarStrip = new System.Windows.Forms.MenuStrip();
            this.addVariableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addVarStrip_textbox = new System.Windows.Forms.ToolStripTextBox();
            this.addVarStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // addVarStrip
            // 
            this.addVarStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addVariableToolStripMenuItem});
            this.addVarStrip.Location = new System.Drawing.Point(0, 0);
            this.addVarStrip.Name = "addVarStrip";
            this.addVarStrip.Size = new System.Drawing.Size(376, 24);
            this.addVarStrip.TabIndex = 1;
            this.addVarStrip.Text = "menuStrip1";
            // 
            // addVariableToolStripMenuItem
            // 
            this.addVariableToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addVarStrip_textbox});
            this.addVariableToolStripMenuItem.Name = "addVariableToolStripMenuItem";
            this.addVariableToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.addVariableToolStripMenuItem.Text = "Add Variable";
            // 
            // addVarStrip_textbox
            // 
            this.addVarStrip_textbox.MaxLength = 1;
            this.addVarStrip_textbox.Name = "addVarStrip_textbox";
            this.addVarStrip_textbox.Size = new System.Drawing.Size(100, 23);
            this.addVarStrip_textbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.addVarStrip_textbox_KeyDown);
            // 
            // VariablesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 439);
            this.Controls.Add(this.addVarStrip);
            this.MainMenuStrip = this.addVarStrip;
            this.Name = "VariablesForm";
            this.Text = "Variables";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VariablesForm_FormClosing);
            this.Load += new System.EventHandler(this.VariablesForm_Load);
            this.addVarStrip.ResumeLayout(false);
            this.addVarStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip addVarStrip;
        private System.Windows.Forms.ToolStripMenuItem addVariableToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox addVarStrip_textbox;
    }
}