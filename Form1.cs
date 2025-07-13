using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using NCalc;

namespace MyCompiler
{
    public partial class Form1 : Form
    {
        string _currentFileName = string.Empty;
        List<Simbolo> _tablaSimbolos = new List<Simbolo>();
        private Lexico _lexico = new Lexico();
        private Sintactico _sintactico = new Sintactico();


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //sourceTextBox.Language = FastColoredTextBoxNS.Language.CSharp;
        }

        private void btnLexico_Click(object sender, EventArgs e)
        {
            _tablaSimbolos.Clear();
            _tablaSimbolos = _lexico.Analizar(textBoxCalculatorDisplay.Text);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = _tablaSimbolos;

            if (_lexico.Errors.Count > 0)
            {
                MessageBox.Show("Se encontraron errores léxicos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                listErrors.DataSource = _lexico.Errors;
            }
            else
            {
                listErrors.DataSource = null;
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && e.RowIndex < ((DataGridView)sender).Rows.Count)
            {
                if (e.RowIndex % 2 == 0)
                {
                    e.CellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
                }
                else
                {
                    e.CellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
                }
                e.CellStyle.ForeColor = System.Drawing.Color.WhiteSmoke;
            }
        }

        private void btnSintactico_Click(object sender, EventArgs e)
        {
            if (_tablaSimbolos == null || _tablaSimbolos.Count <= 0)
            {
                MessageBox.Show("Ejecute el Analizador Lexico Primero", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bool resultado = _sintactico.Analizar(_tablaSimbolos);
                if (!resultado)
                {
                    MessageBox.Show("Se encontraron errores sintácticos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    listErrors.DataSource = _sintactico.Errors;
                }
                else
                {
                    listErrors.DataSource = null;
                }
            }
        }

        private void btnCodigo_Click(object sender, EventArgs e)
        {

        }

        private void AppendToDisplay(string value)
        {
            if (textBoxCalculatorDisplay.Text == "0" && value != "." && value != "(")
            {
                textBoxCalculatorDisplay.Text = value;
            }
            else
            {
                textBoxCalculatorDisplay.Text += value;
            }
        }

        private void btnCalcSin_Click(object sender, EventArgs e)
        {
            AppendToDisplay("Sin(");
        }

        private void btnCalcCos_Click(object sender, EventArgs e)
        {
            AppendToDisplay("Cos(");
        }

        private void btnCalcTan_Click(object sender, EventArgs e)
        {
            AppendToDisplay("Tan(");
        }

        private void btnCalcClear_Click(object sender, EventArgs e)
        {
            textBoxCalculatorDisplay.Text = "0";
            lblResultado.Text = "";
        }

        private void btnCalcPercentage_Click(object sender, EventArgs e)
        {
            AppendToDisplay("%");
        }

        private void btnCalcParenthesisOpen_Click(object sender, EventArgs e)
        {
            AppendToDisplay("(");
        }

        private void btnCalcParenthesisClose_Click(object sender, EventArgs e)
        {
            AppendToDisplay(")");
        }

        private void btnCalcDivide_Click(object sender, EventArgs e)
        {
            AppendToDisplay("/");
        }

        private void btnCalcATan_Click(object sender, EventArgs e)
        {
            AppendToDisplay("Cotan(");
        }

        private void btnCalc7_Click(object sender, EventArgs e)
        {
            AppendToDisplay("7");
        }

        private void btnCalc8_Click(object sender, EventArgs e)
        {
            AppendToDisplay("8");
        }

        private void btnCalc9_Click(object sender, EventArgs e)
        {
            AppendToDisplay("9");
        }

        private void btnCalcMultiply_Click(object sender, EventArgs e)
        {
            AppendToDisplay("*");
        }

        private void btnCalcExp_Click(object sender, EventArgs e)
        {
            AppendToDisplay("^");
        }

        private void btnCalcLog_Click(object sender, EventArgs e)
        {
            AppendToDisplay("Log10(");
        }

        private void btnCalc4_Click(object sender, EventArgs e)
        {
            AppendToDisplay("4");
        }

        private void btnCalc5_Click(object sender, EventArgs e)
        {
            AppendToDisplay("5");
        }

        private void btnCalc6_Click(object sender, EventArgs e)
        {
            AppendToDisplay("6");
        }

        private void btnCalcSubtract_Click(object sender, EventArgs e)
        {
            AppendToDisplay("-");
        }

        private void btnCalcEuler_Click(object sender, EventArgs e)
        {
            AppendToDisplay("e");
        }

        private void btnCalcPi_Click(object sender, EventArgs e)
        {
            AppendToDisplay("pi");
        }

        private void btnCalcLn_Click(object sender, EventArgs e)
        {
            AppendToDisplay("Ln(");
        }

        private void btnCalcMod_Click(object sender, EventArgs e)
        {
            AppendToDisplay("%");
        }

        private void btnCalcCsc_Click(object sender, EventArgs e)
        {
            AppendToDisplay("Csc(");
        }

        private void btnCalcDel_Click(object sender, EventArgs e)
        {
            if (textBoxCalculatorDisplay.Text.Length > 0 && textBoxCalculatorDisplay.Text != "0")
            {
                textBoxCalculatorDisplay.Text = textBoxCalculatorDisplay.Text.Remove(textBoxCalculatorDisplay.Text.Length - 1);
                if (textBoxCalculatorDisplay.Text.Length == 0)
                {
                    textBoxCalculatorDisplay.Text = "0";
                }
            }
        }

        private void btnCalcSec_Click(object sender, EventArgs e)
        {
            AppendToDisplay("Sec(");
        }

        private void btnCalcAbs_Click(object sender, EventArgs e)
        {
            AppendToDisplay("Abs(");
        }

        private void btnCalcFactorial_Click(object sender, EventArgs e)
        {
            AppendToDisplay("!");
        }

        private void btnCalcAdd_Click(object sender, EventArgs e)
        {
            AppendToDisplay("+");
        }

        private void btnCalc3_Click(object sender, EventArgs e)
        {
            AppendToDisplay("3");
        }

        private void btnCalc2_Click(object sender, EventArgs e)
        {
            AppendToDisplay("2");
        }

        private void btnCalc1_Click(object sender, EventArgs e)
        {
            AppendToDisplay("1");
        }

        private void btnCalc0_Click(object sender, EventArgs e)
        {
            AppendToDisplay("0");
        }

        private void btnCalcDecimal_Click(object sender, EventArgs e)
        {
            AppendToDisplay(".");
        }

        private void btnCalcEquals_Click(object sender, EventArgs e)
        {
            try
            {
                string expression = textBoxCalculatorDisplay.Text;

                if (expression.EndsWith("%") && expression.IndexOf('%') == expression.Length - 1)
                {
                    expression = expression.Substring(0, expression.Length - 1) + "/100";
                }

                string _operandPattern = @"(?: \d+(?:\.\d+)?                  | " +
                                         @"    [a-zA-Z_][a-zA-Z0-9_]* | " +
                                         @"    [a-zA-Z_][a-zA-Z0-9_]*\((?>[^()]+|\((?<DEPTH>)|\)(?<-DEPTH>))*\) | " +
                                         @"    \((?>[^()]+|\((?<DEPTH>)|\)(?<-DEPTH>))*\)    " +
                                         @")";

                expression = System.Text.RegularExpressions.Regex.Replace(expression,
                             @"(?<LHS>" + _operandPattern + @")\s*%\s*(?<RHS>" + _operandPattern + @")",
                             "mod(${LHS},${RHS})",
                             RegexOptions.IgnoreCase | RegexOptions.IgnorePatternWhitespace);

                expression = System.Text.RegularExpressions.Regex.Replace(expression,
                             @"(?<LHS>" + _operandPattern + @")!",
                             "Fact(${LHS})",
                             RegexOptions.IgnoreCase | RegexOptions.IgnorePatternWhitespace);

                expression = System.Text.RegularExpressions.Regex.Replace(expression,
                             @"(?<LHS>" + _operandPattern + @")\s*\^\s*(?<RHS>" + _operandPattern + @")",
                             "Pow(${LHS},${RHS})",
                             RegexOptions.IgnoreCase | RegexOptions.IgnorePatternWhitespace);


                var expr = new NCalc.Expression(expression);

                expr.EvaluateFunction += (name, args) =>
                {
                    try
                    {
                        if (name.Equals("!", StringComparison.OrdinalIgnoreCase) && args.Parameters.Length == 1)
                        {
                            object evaluatedArg = args.Parameters[0].Evaluate();
                            if (!(evaluatedArg is int || evaluatedArg is long || evaluatedArg is double))
                            {
                                throw new ArgumentException("El argumento de Factorial debe ser un número entero.");
                            }
                            long n = Convert.ToInt64(evaluatedArg);
                            if (n < 0) throw new ArgumentException("Factorial no definido para números negativos.");
                            if (n > 20) throw new ArgumentException("Factorial para números muy grandes puede desbordar el resultado.");

                            long funcResult = 1;
                            for (long i = 1; i <= n; i++) funcResult *= i;
                            args.Result = funcResult;
                        }
                        else if (name.Equals("Csc", StringComparison.OrdinalIgnoreCase) && args.Parameters.Length == 1)
                        {
                            double val = Convert.ToDouble(args.Parameters[0].Evaluate());
                            double sinVal = Math.Sin(DegreesToRadians(val));
                            if (sinVal == 0) throw new DivideByZeroException("Cosecante de ángulo donde seno es cero.");
                            args.Result = 1 / sinVal;
                        }
                        else if (name.Equals("Sec", StringComparison.OrdinalIgnoreCase) && args.Parameters.Length == 1)
                        {
                            double val = Convert.ToDouble(args.Parameters[0].Evaluate());
                            double cosVal = Math.Cos(DegreesToRadians(val));
                            if (cosVal == 0) throw new DivideByZeroException("Secante de ángulo donde coseno es cero.");
                            args.Result = 1 / cosVal;
                        }
                        else if (name.Equals("mod", StringComparison.OrdinalIgnoreCase) && args.Parameters.Length == 2)
                        {
                            double x = Convert.ToDouble(args.Parameters[0].Evaluate());
                            double y = Convert.ToDouble(args.Parameters[1].Evaluate());
                            if (y == 0) throw new DivideByZeroException("Módulo por cero no permitido.");
                            args.Result = x % y;
                        }
                        else if (name.Equals("Sin", StringComparison.OrdinalIgnoreCase) && args.Parameters.Length == 1)
                        {
                            double val = Convert.ToDouble(args.Parameters[0].Evaluate());
                            args.Result = Math.Sin(DegreesToRadians(val));
                        }
                        else if (name.Equals("Cos", StringComparison.OrdinalIgnoreCase) && args.Parameters.Length == 1)
                        {
                            double val = Convert.ToDouble(args.Parameters[0].Evaluate());
                            args.Result = Math.Cos(DegreesToRadians(val));
                        }
                        else if (name.Equals("Tan", StringComparison.OrdinalIgnoreCase) && args.Parameters.Length == 1)
                        {
                            double val = Convert.ToDouble(args.Parameters[0].Evaluate());
                            args.Result = Math.Tan(DegreesToRadians(val));
                        }
                        else if (name.Equals("Cotan", StringComparison.OrdinalIgnoreCase) && args.Parameters.Length == 1)
                        {
                            double val = Convert.ToDouble(args.Parameters[0].Evaluate());
                            args.Result = RadiansToDegrees(Math.Atan(val));
                        }
                        else if (name.Equals("Log10", StringComparison.OrdinalIgnoreCase) && args.Parameters.Length == 1)
                        {
                            double val = Convert.ToDouble(args.Parameters[0].Evaluate());
                            if (val <= 0) throw new ArgumentException("Logaritmo de un número no positivo.");
                            args.Result = Math.Log10(val);
                        }
                        else if (name.Equals("Ln", StringComparison.OrdinalIgnoreCase) && args.Parameters.Length == 1)
                        {
                            double val = Convert.ToDouble(args.Parameters[0].Evaluate());
                            if (val <= 0) throw new ArgumentException("Logaritmo natural de un número no positivo.");
                            args.Result = Math.Log(val);
                        }
                        else if (name.Equals("Abs", StringComparison.OrdinalIgnoreCase) && args.Parameters.Length == 1)
                        {
                            double val = Convert.ToDouble(args.Parameters[0].Evaluate());
                            args.Result = Math.Abs(val);
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new ArgumentException($"Error en función '{name}': {ex.Message}");
                    }
                };

                expr.Parameters["pi"] = Math.PI;
                expr.Parameters["e"] = Math.E;

                object result = expr.Evaluate();
                lblResultado.Text = result.ToString();
            }
            catch (Exception ex)
            {
                lblResultado.Text = "Error: " + ex.Message;
            }
        }

        private double DegreesToRadians(double degrees)
        {
            return degrees * (Math.PI / 180);
        }

        private double RadiansToDegrees(double radians)
        {
            return radians * (180 / Math.PI);
        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }

        private void textBoxCalculatorDisplay_TextChanged(object sender, EventArgs e)
        {
            textBoxCalculatorDisplay.SelectionStart = textBoxCalculatorDisplay.Text.Length;
            textBoxCalculatorDisplay.ScrollToCaret();
        }
    }
}