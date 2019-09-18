using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Complex_Numbers_Calculator
{
    public partial class VariablesForm : Form
    {
        public MainForm mainForm;

        public VariablesForm()
        {
            InitializeComponent();
        }

        private void VariablesForm_Load(object sender, EventArgs e)
        {
            AutoScroll = true;
            HorizontalScroll.Enabled = false;
            HorizontalScroll.Visible = false;
            //Initial variableControls location = (12, 27)
            //Second = (12, 74)
            //Vertical Discrepancy = 47
        }

        public void CreateVariable(string varName)
        {
            //if(varName)

            var newVar = new Variable();
            Controls.Add(newVar.varControl);
            newVar.Init(varName, new Point(12, 27 + 47 * mainForm.varList.Count), this);

            mainForm.varList.Add(newVar);
        }

        public void InsertVariable(Variable variable)
        {
            mainForm.InputMultContent(variable.name);
        }

        public void RemoveVariable(Variable variable)
        {
            Controls.Remove(variable.varControl);

            var listTotal = mainForm.varList.Count;
            var varIndex = mainForm.varList.IndexOf(variable);

            for(var i = varIndex; i < listTotal; i++)
            {
                mainForm.varList.ElementAt(i).varControl.Location = new Point(mainForm.varList.ElementAt(i).varControl.Location.X, mainForm.varList.ElementAt(i).varControl.Location.Y - 47);
            }

            mainForm.varList.Remove(variable);
        }

        private void addVarStrip_textbox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                CreateVariable(addVarStrip_textbox.Text);
                addVarStrip_textbox.Text = "";
            }
            
        }

        private void VariablesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }
    }
}
