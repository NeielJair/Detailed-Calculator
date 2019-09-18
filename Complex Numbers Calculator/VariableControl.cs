using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Complex_Numbers_Calculator
{
    public partial class VariableControl : UserControl
    {
        public VariablesForm varForm;
        public MainForm mainForm;
        public string varName;
        public string varValue;
        public Variable varParent;

        private bool mouseHover = false;

        public VariableControl()
        {
            InitializeComponent();
        }

        private void VariableControl_Load(object sender, EventArgs e)
        {
            btnVar.Text = varName;
        }

        public void Rename(string name)
        {
            varName = name;
            btnVar.Text = name;
        }

        public void Edit(string value)
        {
            varValue = value;
            varParent.valueStr = value;
        }

        private void VariableControl_ValueChanged(object sender, EventArgs e)
        {
            Edit(((TextBox)sender).Text);
        }

        private void btnVar_Click(object sender, EventArgs e)
        {
            varForm.InsertVariable(varParent);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            LabelButton_Click(sender, e);

            varForm.RemoveVariable(varParent);
        }

        #region Label Buttons Management
        public void LabelButton_Click(object sender, EventArgs e)
        {
            ((Label)sender).ForeColor = Color.Black;
        }

        public void LabelButton_MouseEnter(object sender, EventArgs e)
        {
            ((Label)sender).ForeColor = SystemColors.ControlDarkDark;
            mouseHover = true;
        }

        public void LabelButton_MouseDown(object sender, EventArgs e)
        {
            ((Label)sender).ForeColor = Color.Black;
        }

        public void LabelButton_MouseUp(object sender, EventArgs e)
        {
            ((Label)sender).ForeColor = SystemColors.ControlDarkDark;
        }

        public void LabelButton_MouseLeave(object sender, EventArgs e)
        {
            ((Label)sender).ForeColor = SystemColors.ButtonShadow;
            mouseHover = false;
        }
        #endregion
    }
}
