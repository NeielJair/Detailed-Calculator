namespace Complex_Numbers_Calculator
{
    partial class VariableControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnVar = new System.Windows.Forms.Button();
            this.varValueTextbox = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Label();
            this.toolTipVarControl = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // btnVar
            // 
            this.btnVar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVar.Location = new System.Drawing.Point(4, 4);
            this.btnVar.Name = "btnVar";
            this.btnVar.Size = new System.Drawing.Size(74, 32);
            this.btnVar.TabIndex = 37;
            this.btnVar.Text = "x";
            this.toolTipVarControl.SetToolTip(this.btnVar, "Insert Variable");
            this.btnVar.UseVisualStyleBackColor = true;
            this.btnVar.Click += new System.EventHandler(this.btnVar_Click);
            // 
            // varValueTextbox
            // 
            this.varValueTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.varValueTextbox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.varValueTextbox.Location = new System.Drawing.Point(84, 4);
            this.varValueTextbox.MaxLength = 30;
            this.varValueTextbox.Name = "varValueTextbox";
            this.varValueTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.varValueTextbox.Size = new System.Drawing.Size(223, 32);
            this.varValueTextbox.TabIndex = 39;
            this.varValueTextbox.Text = "0";
            this.toolTipVarControl.SetToolTip(this.varValueTextbox, "Variable Value");
            this.varValueTextbox.TextChanged += new System.EventHandler(this.VariableControl_ValueChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSize = true;
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnDelete.Location = new System.Drawing.Point(313, -3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(45, 39);
            this.btnDelete.TabIndex = 40;
            this.btnDelete.Text = "🗙";
            this.toolTipVarControl.SetToolTip(this.btnDelete, "Delete Variable");
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            this.btnDelete.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LabelButton_MouseDown);
            this.btnDelete.MouseEnter += new System.EventHandler(this.LabelButton_MouseEnter);
            this.btnDelete.MouseLeave += new System.EventHandler(this.LabelButton_MouseLeave);
            this.btnDelete.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LabelButton_MouseUp);
            // 
            // VariableControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.varValueTextbox);
            this.Controls.Add(this.btnVar);
            this.Name = "VariableControl";
            this.Size = new System.Drawing.Size(351, 40);
            this.Load += new System.EventHandler(this.VariableControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVar;
        private System.Windows.Forms.TextBox varValueTextbox;
        private System.Windows.Forms.Label btnDelete;
        private System.Windows.Forms.ToolTip toolTipVarControl;
    }
}
