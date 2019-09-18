using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace Complex_Numbers_Calculator
{
    public partial class MainForm : Form
    {
        public string[] FunctionsList = new string[] {"log", "ln"};
        public int LongestFunctionLength = 3;

        public List<Variable> varList = new List<Variable>();

        public int AnsMaxItems = 5;
        private bool Unfolded = false;

        public VariablesForm varForm = new VariablesForm();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            varForm.mainForm = this;

            NumberBox.ReadOnly = true;
            NumberBox.SelectionStart = NumberBox.TextLength;
            NumberBox.SelectionLength = 0;

            Width = 392;
            ResultLog.Visible = false;

            //Closed Size = (392, 478)
        }

        private void NumberBox_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.D0) || (e.KeyCode == Keys.NumPad0))
                ClickButton(btn0);

            if ((e.KeyCode == Keys.D1) || (e.KeyCode == Keys.NumPad1))
                ClickButton(btn1);

            if ((e.KeyCode == Keys.D2) || (e.KeyCode == Keys.NumPad2))
                ClickButton(btn2);

            if ((e.KeyCode == Keys.D3) || (e.KeyCode == Keys.NumPad3))
                ClickButton(btn3);

            if ((e.KeyCode == Keys.D4) || (e.KeyCode == Keys.NumPad4))
                ClickButton(btn4);

            if ((e.KeyCode == Keys.D5) || (e.KeyCode == Keys.NumPad5))
                ClickButton(btn5);

            if ((e.KeyCode == Keys.D6) || (e.KeyCode == Keys.NumPad6))
                ClickButton(btn6);

            if ((e.KeyCode == Keys.D7) || (e.KeyCode == Keys.NumPad7))
                ClickButton(btn7);

            if ((e.KeyCode == Keys.D8) || (e.KeyCode == Keys.NumPad8))
                ClickButton(btn8);

            if ((e.KeyCode == Keys.D9) || (e.KeyCode == Keys.NumPad9))
                ClickButton(btn9);

            if (e.KeyCode == Keys.Back)
                ClickButton(btnErase);
        }

        private void ClickButton(Button button)
        {
            button.PerformClick();
            //button.BackColor = Color.Aqua;
        }

        #region Inputs
        public void InputContent(object sender, EventArgs e)
        {
            if (NumberBox.Text == "")
            {
                NumberBox.Text = ((Button)sender).Text;
                NumberBox.SelectionStart = NumberBox.TextLength;
            }
            else
            {
                NumberBox.SelectedText = ((Button)sender).Text;
            }
        }

        public void InputMultContent(object sender, EventArgs e)
        {
            InputMultContent(((Button)sender).Text);
        }

        public void InputMultContent(string chr)
        {
            if (NumberBox.Text == "")
            {
                NumberBox.Text = chr;
                NumberBox.SelectionStart = NumberBox.TextLength;
            }
            else
            {
                if ((NumberBox.SelectionStart == 0) || (StringEqualsAny(NumberBox.Text.Substring(NumberBox.SelectionStart - 1, 1), new string[] { "+", "-", "*", "/", "(", ".", "^", "√" })))
                {
                    NumberBox.SelectedText = chr;
                }
                else
                {
                    NumberBox.SelectedText = "*" + chr;
                }
            }
        }

        public void InputFunction(string fx, bool useParenthesis = true)
        {
            if (NumberBox.Text == "")
            {
                NumberBox.Text = fx + "()";
                NumberBox.SelectionStart = NumberBox.TextLength - 1;
            }
            else
            {
                if ((NumberBox.SelectionStart == 0) || StringEqualsAny(NumberBox.Text.Substring(NumberBox.SelectionStart - 1, 1), "+", "-", "*", "/", "(", ".", "^", ""))
                {
                    NumberBox.SelectedText = fx + "()";
                    NumberBox.SelectionStart = Math.Max(0, NumberBox.SelectionStart - 1);
                }
                else
                {
                    NumberBox.SelectedText = "*" + fx + "()";
                    NumberBox.SelectionStart = Math.Max(0, NumberBox.SelectionStart - 1);
                }
            }
        }

        public void InputFunction(object sender, EventArgs e)
        {
            InputFunction(((Button)sender).Text);
        }

        public void InputChar(string chr)
        {
            if (NumberBox.Text == "")
            {
                NumberBox.Text = chr;
                NumberBox.SelectionStart = NumberBox.TextLength;
            }
            else
            {
                NumberBox.SelectedText = chr;
            }
        }

        public void DelChar()
        {
            if (NumberBox.SelectionLength == 0 && NumberBox.SelectionStart != 0)
            {
                NumberBox.SelectionStart -= 1;
                NumberBox.SelectionLength = 1;
            }

            var selStart = NumberBox.SelectionStart;

            NumberBox.Text = NumberBox.Text.Substring(0, NumberBox.SelectionStart) +
                             NumberBox.Text.Substring(NumberBox.SelectionStart + NumberBox.SelectionLength, NumberBox.TextLength - (NumberBox.SelectionStart + NumberBox.SelectionLength));



            NumberBox.Focus();
            NumberBox.SelectionStart = selStart;
            NumberBox.SelectionLength = 0;
        }
        #endregion

        private void ResultLogAddText(string text, bool newLine = true)
        {
            foreach(var line in ResultLog.Text.Split(new[] { Environment.NewLine }, StringSplitOptions.None))
            {
                if (line == text)
                    return;
            }

            if (ResultLog.Text == "" || newLine == false)
                ResultLog.Text = text;
            else
                ResultLog.Text += Environment.NewLine + text;
        }

        #region ParseFunctions Overloads and Helpers
        private void ParseFunctionsAndReplace(ref string str, ref string termStr, ref string numberStr)
        {
            var oldStr = str;
            ParseFunctions(ref str);
            NumberBox.Text = NumberBox.Text.Replace(oldStr, str);
            ResultLogAddText(NumberBox.Text);
            termStr = termStr.Replace(oldStr, str);
            numberStr = numberStr.Replace(oldStr, str);
        }

        private void ParseFunctions(ref string numberStr)
        {
            String temp = "";

            ParseFunctions(ref numberStr, ref temp);
        }

        private void ParseFunctions (ref string numberStr, ref string termStr)
        {
            //MessageBox.Show("parsing");
            double res;
            
            while (true)
            {
                if (!double.TryParse(numberStr, out double n) /*&& numberStr.Length > 3*/)
                {
                    var firstFx = numberStr.Substring(0, Math.Min(3, numberStr.Length));

                    if (firstFx.Contains("log"))
                    {
                        var logInd = numberStr.IndexOf("log");
                        var opParInd = (numberStr.Substring(logInd, numberStr.Length - logInd).IndexOf("(") + logInd);
                        var clParInd = (numberStr.Substring(opParInd, numberStr.Length - opParInd).LastIndexOf(")") + opParInd);
                        var strLogBase = numberStr.Substring(logInd + 3, opParInd - (logInd + 3));
                        var strLogArg = numberStr.Substring(opParInd + 1, clParInd - (opParInd + 1));

                        if (strLogArg == "")
                        {
                            DeclareError(Error.Syntax);
                        }

                        if (strLogBase != "")
                        {
                            if (double.TryParse(strLogBase, out double logBase))
                            {
                                if (double.TryParse(strLogArg, out double logArg))
                                {
                                    res = Math.Log10(logArg) / Math.Log10(logBase);
                                    NumberBox.Text = NumberBox.Text.Replace(numberStr.Substring(logInd, clParInd + 1), res.ToString());
                                    ResultLogAddText(NumberBox.Text);
                                    termStr = termStr.Replace(numberStr.Substring(logInd, clParInd + 1), res.ToString());
                                    numberStr = numberStr.Replace(numberStr.Substring(logInd, clParInd + 1), res.ToString());
                                    continue;
                                }
                                else
                                {
                                    ParseFunctionsAndReplace(ref strLogArg, ref termStr, ref numberStr);
                                    continue;
                                }
                            }
                            else
                            {
                                ParseFunctionsAndReplace(ref strLogBase, ref termStr, ref numberStr);
                                continue;
                            }
                        }
                        else
                        {
                            if (double.TryParse(strLogArg, out double logArg))
                            {
                                res = Math.Log10(logArg);
                                NumberBox.Text = NumberBox.Text.Replace(numberStr.Substring(logInd, clParInd + 1), res.ToString());
                                ResultLogAddText(NumberBox.Text);
                                termStr = termStr.Replace(numberStr.Substring(logInd, clParInd + 1), res.ToString());
                                numberStr = numberStr.Replace(numberStr.Substring(logInd, clParInd + 1), res.ToString());
                                continue;
                            }
                            else
                            {
                                ParseFunctionsAndReplace(ref strLogArg, ref termStr, ref numberStr);
                                continue;
                            }
                        }
                    }
                    else if (firstFx.Contains("ln"))
                    {
                        var lnInd = numberStr.IndexOf("ln");
                        var opParInd = (numberStr.Substring(lnInd, numberStr.Length - lnInd).IndexOf("(") + lnInd);
                        var clParInd = (numberStr.Substring(opParInd, numberStr.Length - opParInd).LastIndexOf(")") + opParInd);
                        var strLnArg = numberStr.Substring(opParInd + 1, clParInd - (opParInd + 1));

                        if (strLnArg == "")
                        {
                            DeclareError(Error.Syntax);
                        }

                        if (double.TryParse(strLnArg, out double lnArg))
                        {
                            res = Math.Log(lnArg);
                            NumberBox.Text = NumberBox.Text.Replace(numberStr.Substring(lnInd, clParInd + 1), res.ToString());
                            ResultLogAddText(NumberBox.Text);
                            termStr = termStr.Replace(numberStr.Substring(lnInd, clParInd + 1), res.ToString());
                            numberStr = numberStr.Replace(numberStr.Substring(lnInd, clParInd + 1), res.ToString());
                            continue;
                        }
                        else
                        {
                            ParseFunctionsAndReplace(ref strLnArg, ref termStr, ref numberStr);
                            continue;
                        }
                    }
                    else if (numberStr.Contains("^"))
                    {
                        var powSignInd = numberStr.IndexOf("^");
                        var strPowBase = numberStr.Substring(0, powSignInd);
                        var strPowExp = numberStr.Substring(powSignInd + 1, numberStr.Length - (powSignInd + 1));

                        if ((strPowBase == "") || (strPowExp == ""))
                        {
                            DeclareError(Error.Syntax);
                        }

                        if (!double.TryParse(strPowExp, out double powExp))
                        {
                            ParseFunctionsAndReplace(ref strPowExp, ref termStr, ref numberStr);
                            continue;
                        }
                        else if (double.TryParse(strPowBase, out double powBase))
                        {
                            res = Math.Pow(powBase, powExp);
                            NumberBox.Text = NumberBox.Text.Replace(numberStr, res.ToString());
                            ResultLogAddText(NumberBox.Text);
                            termStr = termStr.Replace(strPowBase + "^" + strPowExp, res.ToString());
                            numberStr = numberStr.Replace(strPowBase + "^" + strPowExp, res.ToString());
                            continue;
                        }
                        else
                        {
                            ParseFunctionsAndReplace(ref strPowBase, ref termStr, ref numberStr);
                            continue;
                        }
                    }
                    else if(numberStr.Contains("√"))
                    {
                        var rtSignInd = numberStr.IndexOf("√");
                        var strRtIndex = numberStr.Substring(0, rtSignInd);
                        var strRtRadicand = numberStr.Substring(rtSignInd + 1, numberStr.Length - (rtSignInd + 1));

                        if(strRtRadicand == "")
                        {
                            DeclareError(Error.Syntax);
                        }

                        if(!double.TryParse(strRtRadicand, out double rtRadicand))
                        {
                            ParseFunctionsAndReplace(ref strRtRadicand, ref termStr, ref numberStr);
                            continue;
                        }
                        else if(strRtIndex == "")
                        {
                            res = Math.Sqrt(rtRadicand);
                            NumberBox.Text = NumberBox.Text.Replace(numberStr, res.ToString());
                            ResultLogAddText(NumberBox.Text);
                            termStr = termStr.Replace("√" + strRtRadicand, res.ToString());
                            numberStr = numberStr.Replace("√" + strRtRadicand, res.ToString());
                            continue;
                        }
                        else if(double.TryParse(strRtIndex, out double rtIndex))
                        {
                            if (strRtIndex.Contains('-'))
                            {
                                var newFx = '(' + strRtRadicand + ")^(" + "1/(" + strRtIndex + "))";

                                NumberBox.Text = NumberBox.Text.Replace(numberStr, newFx);
                                ResultLogAddText(NumberBox.Text);
                                termStr = termStr.Replace(strRtIndex + "√" + strRtRadicand, newFx);
                                numberStr = numberStr.Replace(strRtIndex + "√" + strRtRadicand, newFx);
                                continue;
                            }
                            else
                            {
                                res = Math.Pow(rtRadicand, 1 / rtIndex);
                                NumberBox.Text = NumberBox.Text.Replace(numberStr, res.ToString());
                                ResultLogAddText(NumberBox.Text);
                                termStr = termStr.Replace(strRtIndex + "√" + strRtRadicand, res.ToString());
                                numberStr = numberStr.Replace(strRtIndex + "√" + strRtRadicand, res.ToString());
                                continue;
                            }
                        }
                        else
                        {
                            ParseFunctionsAndReplace(ref strRtIndex, ref termStr, ref numberStr);
                            continue;
                        }
                    }
                    else
                    {
                        if (!double.TryParse(numberStr, out double num))
                        {
                            MessageBox.Show("heh");
                            DeclareError(Error.Syntax);
                        }
                        else
                            return;
                    }
                }
            else return;
            }
        }
        #endregion

        private string Operate(string Operation, string leftPart = "", string rightPart = "")
        {
            var whileExecuted = false;

            while(StringContainsAny(Operation, "++", "+-", "-+", "--"))
            {
                Operation = Operation.Replace("++", "+");
                Operation = Operation.Replace("+-", "-");
                Operation = Operation.Replace("-+", "-");
                Operation = Operation.Replace("--", "+");

                whileExecuted = true;
            }

            if(whileExecuted)
                ResultLogAddText(leftPart + Operation + rightPart);

            //Check for Negative Numbers
            List<string> Terms;

            if(StringEqualsAny(Operation.Substring(0, 1), "+", "-"))
            {
                var tempOperation = Operation.Substring(1, Operation.Length - 1);
                Terms = new List<string>(tempOperation.Split(new Char[] { '+', '-' }));
                Terms[0] = Operation.Substring(0, 1) + Terms[0];
            }
            else Terms = new List<string>(Operation.Split(new Char[] { '+', '-' }));

            string result = Operation;

            //Operate Individual Terms
            for (var i = 0; i < Terms.Count; i++)
            {
                string term = Terms.ElementAt(i);

                //Get Numbers
                List<string> numbers = new List<string>(term.Split(new char[] { '*', '/' }));

                //Check for Functions
                for (var j = 0; j < numbers.Count; j++)
                {
                    var arrayNumber = numbers[j];
                    ParseFunctions(ref arrayNumber, ref term);
                    numbers[j] = arrayNumber;
                }

                while (numbers.Count > 1)
                {
                    //Parse Numbers
                    List<double> nums = new List<double>();
                    foreach (string number in numbers)
                    {
                        nums.Add(Double.Parse(number));
                    }

                    //Operate Numbers
                    while ((nums.Count > 1) && (numbers.Count > 1))
                    {
                        var num0 = nums.ElementAt(0);
                        var num1 = nums.ElementAt(1);

                        var num0_pos = term.IndexOf(nums.ElementAt(0).ToString());
                        
                        var _operator = term.Substring(num0_pos + numbers.ElementAt(0).Length, 1);

                        var numRes = new double();

                        if (_operator.Equals("*"))
                        {
                            numRes = num0 * num1;
                        }
                        else if (_operator.Equals("/"))
                        {
                            numRes = num0 / num1;
                        }
                        

                        nums.RemoveAt(1);
                        nums.RemoveAt(0);
                        nums.Insert(0, numRes);

                        /*var temp = numbers.ElementAt(0) + _operator.ToString() + numbers.ElementAt(1);
                        term = term.Substring(temp.Length, term.Length - temp.Length);
                        term = numRes.ToString() + term;*/
                        term = term.Replace(numbers.ElementAt(0) + _operator.ToString() + numbers.ElementAt(1), numRes.ToString());

                        numbers.RemoveAt(1);
                        numbers.RemoveAt(0);
                        numbers.Insert(0, numRes.ToString());

                        ResultLogAddText(leftPart + Operation.Replace(Terms[i], term) + rightPart);
                    }
                }

                Operation = Operation.Replace(Terms[i], term);

                Terms[i] = term;

                result = Operation;

                ResultLogAddText(leftPart + Operation.Replace(Terms[i], term) + rightPart);
            }

            //Operate Between Terms
            while (Terms.Count > 1)
            {
                List<double> TermDb = new List<double>();
                foreach (string t in Terms)
                {
                    TermDb.Add(Double.Parse(t));
                }

                var num0 = TermDb.ElementAt(0);
                var num1 = TermDb.ElementAt(1);

                var num0_pos = Operation.IndexOf(Terms.ElementAt(0));

                var _operator = Operation.Substring(num0_pos + Terms.ElementAt(0).Length, 1);

                var numRes = new double();

                if (_operator.Equals("+"))
                {
                    numRes = num0 + num1;
                }
                else if (_operator.Equals("-"))
                {
                    numRes = num0 - num1;
                }

                Operation = Operation.Replace(Terms.ElementAt(0) + _operator + Terms.ElementAt(1), numRes.ToString());

                Terms.RemoveAt(1);
                Terms.RemoveAt(0);
                Terms.Insert(0, numRes.ToString());

                TermDb.RemoveAt(1);
                TermDb.RemoveAt(0);
                TermDb.Insert(0, numRes);

                ResultLogAddText(leftPart + Operation + rightPart);

                result = Operation;
            }

            return result;
        }

        private void GetResult(EventArgs e)
        {
            string Operation = NumberBox.Text;
            string InitialOperation = Operation;

            ResultLog.Text = "";

            if(varList.Count != 0)
            {
                RecheckVariables:

                var replaced = false;

                foreach (var variable in varList)
                {
                    var varName = variable.name;

                    if (NumberBox.Text.Contains(varName))
                    {
                        var varValue = variable.valueStr;

                        if(!ResultLog.Text.Contains(varName + " = " + varValue))
                        {
                            if (ResultLog.Text == "")
                            {
                                ResultLog.Text = varName + " = " + varValue;
                            }
                            else
                            {
                                ResultLog.Text += ", " + varName + " = " + varValue;
                            }
                        }
                        

                        if(!StringContainsAny(varValue, "+", "-", "*", "/"/*, "^", "√"*/))
                            Operation = NumberBox.Text = Operation.Replace(varName, varValue);
                        else
                            Operation = NumberBox.Text = Operation.Replace(varName, "(" + varValue + ")");

                        replaced = true;
                    }
                }

                if (replaced)
                    goto RecheckVariables;
            }

            Operation = NumberBox.Text = Operation.Replace("e", Math.E.ToString());
            Operation = NumberBox.Text = Operation.Replace("π", Math.PI.ToString());

            ResultLogAddText(InitialOperation, true);

            if (InitialOperation != Operation)
            {
                ResultLogAddText(Operation, true);
            }

            //Check for Syntax Errors
            if ((Operation.Count(p => p == '(') != Operation.Count(p => p == ')')) || (Operation.IndexOf('(') > Operation.IndexOf(')')))
            {
                NumberBox.Text = InitialOperation;
                ResultLog.Text = "";
                DeclareError(Error.Syntax);
            }

            #region Solve Parenthesis
            List<int> indexIgnore = new List<int>();

            Repeat:

            int opParInd = -1;
            int clParInd = -1;

            for (var i = 0; i < Operation.Length; i++)
            {
                if (indexIgnore.Contains(i))
                    continue;

                if (Operation.Substring(i, 1).Equals("("))
                {
                    opParInd = i;
                }

                if (Operation.Substring(i, 1).Equals(")"))
                {
                    if (opParInd == -1)
                    {
                        NumberBox.Text = InitialOperation;
                        ResultLog.Text = "";
                        DeclareError(Error.Syntax);
                    }

                    clParInd = i;

                    var parContent = Operation.Substring(opParInd + 1, clParInd - (opParInd + 1));
                    var parLeft = Operation.Substring(0, opParInd + 1);
                    var parRight = Operation.Substring(clParInd, Operation.Length - clParInd);

                    var newParContent = Operate(parContent, parLeft, parRight);

                    if((opParInd == 0) || StringEqualsAny(Operation.Substring(opParInd - 1, 1), "+", "-", "*", "/", "^", "√"))
                    {
                        Operation = Operation.Replace('(' + parContent + ')', newParContent);
                    }
                    else
                    {
                        Operation = Operation.Replace(parContent, newParContent);
                        indexIgnore.Add(opParInd);
                        indexIgnore.Add(opParInd + 1 + newParContent.Length);
                    }

                    ResultLogAddText(Operation);

                    goto Repeat;
                }
            }
            #endregion

            NumberBox.Text = Operation;

            string result = Operate(Operation);
            string simplifiedResult = result;

            if(result == "NaN")
            {
                NumberBox.Text = InitialOperation;
                DeclareError(Error.NaN);
            }

            if (result != "")
            {
                if(!double.TryParse(result, out double dResult))
                {
                    NumberBox.Text = InitialOperation;
                    DeclareError(Error.Syntax);
                }

                double dSimplifiedResult = dResult;

                /*
                #region Simplify Result
                var simplified = false;

                if ((dSimplifiedResult % Math.E == 0) || (dSimplifiedResult % Math.PI == 0))
                    simplifiedResult = "";
                //MessageBox.Show(((dSimplifiedResult / Math.E) - Math.Floor(dSimplifiedResult / Math.E)).ToString() + ", " + (dSimplifiedResult / Math.E).ToString() + ", " + Math.Floor(dSimplifiedResult / Math.E).ToString());


                while ((dSimplifiedResult/Math.E) - Math.Floor(dSimplifiedResult / Math.E) == 0)
                {
                    dSimplifiedResult /= Math.E;
                    //MessageBox.Show("e-ed");
                    simplifiedResult = (simplifiedResult == "")?"e":"*e";
                    simplified = true;
                }

                while ((dSimplifiedResult / Math.PI) - Math.Floor(dSimplifiedResult / Math.PI) == 0)
                {
                    dSimplifiedResult /= Math.PI;
                    simplifiedResult = (simplifiedResult == "") ? "π" : "*π";
                    simplified = true;
                }

                if(simplified)
                {
                    simplifiedResult = dSimplifiedResult.ToString() + "*" + simplifiedResult;
                }
                #endregion
                */

                #region Add To Ans
                btnAns.Enabled = true;
                labelAns.Visible = true;
                btnAns.Text = result;
                if (AnsMenuStrip.Items.Count > AnsMaxItems)
                    AnsMenuStrip.Items.RemoveAt(AnsMaxItems - 1);

                AnsMenuStrip.Items.Insert(0, new ToolStripMenuItem(Text = simplifiedResult));
                #endregion

                #region Manage Results
                if (result.Length > 13)
                {
                    if (result.IndexOf('.') != -1)
                    {
                        var _res = result.Split('.');
                        if ((_res[0].Length + 1 + 1) > 13)
                        {
                            ResultBox.Text = "(check result log)";
                        }
                        else
                        {
                            ResultBox.Text = "≈ " + result.Substring(0, 13);
                        }
                    }
                    else
                    {
                        ResultBox.Text = "(check result log)";
                    }
                }
                else
                    ResultBox.Text = "= " + result;
            }
            #endregion

            NumberBox.Text = InitialOperation;
        }

        private void DeclareError(Error error)
        {
            ResultLog.Text = "";

            switch(error)
            {
                case Error.Syntax:
                    ResultBox.Text = "Syntax Error";
                    throw new System.InvalidOperationException("Syntax Error: Check for mistakes in operation.");

                case Error.NaN:
                    ResultBox.Text = "NaN";
                    throw new System.InvalidOperationException("Not a Real Number");
            }
        }

        enum Error
        {
            Syntax,
            NaN
        }

        #region Buttons Click
        private void btnExp_Click(object sender, EventArgs e)
        {
            switch(btnExp.Text)
            {
                case "xʸ":
                    InputChar("^()");
                    NumberBox.SelectionStart--;
                    break;

                case "x²":
                    InputChar("^2");
                    break;

                case "x³":
                    InputChar("^3");
                    break;

                case "x⁻¹":
                    InputChar("^(-1)");
                    NumberBox.SelectionStart--;
                    break;

                case "x⁻²":
                    InputChar("^(-2)");
                    break;

                case "x⁻³":
                    InputChar("^(-3)");
                    break;
            }
        }

        private void btnRoot_Click(object sender, EventArgs e)
        {
            switch(btnRoot.Text)
            {
                case "ʸ√x":
                    InputMultContent("()√()");
                    NumberBox.SelectionStart -= 4;
                    break;

                case "√x":
                    InputFunction("√");
                    break;

                case "³√x":
                    InputFunction("3√");
                    break;
            }
            
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            InputFunction("log");
            NumberBox.SelectionStart--;
        }

        private void btnFact_Click(object sender, EventArgs e)
        {
            InputChar("!");
        }

        private void btn10exp_Click(object sender, EventArgs e)
        {
            InputMultContent("10^");
        }

        private void btnErase_Click(object sender, EventArgs e)
        {
            DelChar();
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            GetResult(e);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            NumberBox.Text = "";
            //ResultBox.Text = "";
            ResultLog.Text = "";
            NumberBox.Focus();
            NumberBox.SelectionStart = NumberBox.TextLength;
            NumberBox.SelectionLength = 0;
        }

        private void btnUnfold_Click(object sender, EventArgs e)
        {
            if (Unfolded == false)
            {
                Width = 392 * 2;
                Unfolded = true;
                ((Button)sender).Text = "<<";
                ResultLog.Visible = true;
                ToolTip.SetToolTip(btnUnfold, "Close Result Log");
            }
            else
            {
                Width = 392;
                Unfolded = false;
                ((Button)sender).Text = ">>";
                ResultLog.Visible = false;
                ToolTip.SetToolTip(btnUnfold, "Open Result Log");
            }
        }

        private void btnVar_Click(object sender, EventArgs e)
        {
            varForm.Show();
        }

        private void AnsMenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.ToString() != "Clear")
            {
                btnAns.Text = e.ClickedItem.ToString();
            }
            else
            {
                AnsMenuStrip.Items.Clear();
                AnsMenuStrip.Items.Add("Clear");
                labelAns.Visible = false;
                btnAns.Enabled = false;
                btnAns.ResetText();
                btnAns.Text = "Ans";
            }
        }

        private void ExpMenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            btnExp.Text = e.ClickedItem.ToString();
        }

        private void RootMenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            btnRoot.Text = e.ClickedItem.ToString();
        }
        #endregion

        #region Formulas
        private double GetFactorial(int n)
        {
            double res = n;
            while (n != 1)
            {
                res = res * n;
                n--;
            }

            return res;
        }
        #endregion

        #region Misc
        public bool StringEqualsAny(string str, params string[] array)
        {
            foreach (string item in array)
            {
                if (str == item)
                    return true;
            }
            return false;
        }

        private bool StringContainsAny(string str, params string[] array)
        {
            foreach (string item in array)
            {
                if (str.Contains(item))
                    return true;
            }
            return false;
        }

        private void btnAns_Paint(object sender, PaintEventArgs e)
        {
            if (btnAns.Text != "Ans")
            {
                float fontSize = NewFontSize(e.Graphics, btnAns.Size, btnAns.Font, btnAns.Text);

                btnAns.Font = new Font(btnAns.Font.ToString(), Math.Min(15, fontSize), FontStyle.Regular);
            }
            else
            {
                btnAns.Font = new Font(btnAns.Font.ToString(), 15, FontStyle.Regular);
            }
        }

        public static float NewFontSize(Graphics graphics, Size size, Font font, string str)
        {
            SizeF stringSize = graphics.MeasureString(str, font);
            float wRatio = size.Width / stringSize.Width;
            float hRatio = size.Height / stringSize.Height;
            float ratio = Math.Min(hRatio, wRatio);
            return font.Size * ratio;
        }
        #endregion
    }

    public class Variable
    {
        public string name;
        public string valueStr = "0";
        public VariableControl varControl = new VariableControl();

        public void Init (string Name, Point controlLocation, VariablesForm VarForm)
        {
            name = Name;
            varControl.varParent = this;
            varControl.varValue = valueStr;
            varControl.Location = controlLocation;
            varControl.varForm = VarForm;
            varControl.Rename(Name);
            Edit(valueStr);
        }

        public void Edit(string newValue)
        {
            valueStr = newValue;
            varControl.Edit(newValue);
        }
    }
}