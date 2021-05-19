using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Calculator {
    public partial class GlobalForm: Form {
        private          Point        _lastPoint;
        private          Form         _activeForm;
        private          double       _resultD;
        private          string       _resultS;
        private readonly List<Button> _additionButtons;
        private readonly List<Form>   _additionForm;
        public GlobalForm() {
            InitializeComponent();
            Size = new Size(580, 450);
            _additionButtons = new List<Button>() {butConverter, butBinaryCalculator, butBinaryOperation};
            _additionForm = new List<Form>() {new ConvertForm(), new BinaryCalculatorForm(), new BinaryOperationForm()};
        }
        private void OpenChildForm(Form childForm) {
            // ReSharper disable once RedundantCheckBeforeAssignment
            if (_activeForm != null) _activeForm = null;
            _activeForm                = childForm;
            childForm.TopLevel        = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock            = DockStyle.Fill;
            pnRight.Controls.Add(childForm);
            pnRight.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

#region Calcuvator
        private void CheckNoneEnter(string operation) {
            if (txtEnter.Text != "")
                _resultS += txtEnter.Text + operation;
            else
                _resultS += "0" + txtEnter.Text + operation;
        }
        private void butAllClear_Click(object sender, EventArgs e) {
            txtEnter.Text = "";
            _resultD       = 0;
            _resultS       = "";
        }
        private void butChangeMark_Click(object sender, EventArgs e) {
            if (txtEnter.Text.Length > 0 && txtEnter.Text[0] == '-')
                txtEnter.Text                                                           = txtEnter.Text.Remove(0, 1);
            else if (txtEnter.Text.Length > 0 && txtEnter.Text[0] != '-') txtEnter.Text = @"-" + txtEnter.Text;
        }
        private void butDivision_Click(object sender, EventArgs e) {
            double.TryParse(txtEnter.Text, out var tmpNumber);
            if (_resultD == 0) { _resultD = tmpNumber; }
            else
                _resultD /= tmpNumber;
            CheckNoneEnter(" /");
            txtEnter.Text = "";
        }
        private void butDot_Click(object sender, EventArgs e) {
            if (txtEnter.Text.IndexOf('.') == -1 && txtEnter.Text.Length > 0) txtEnter.Text += @",";
        }
        private void butEqual_Click(object sender, EventArgs e) {
            var tmpVal = _resultS.Split(' ');
            double.TryParse(txtEnter.Text, out var tmpNumber);
            _resultS = _resultS.Replace(" ", "");

            if (tmpVal[tmpVal.Length - 1] == "+")
                _resultD += tmpNumber;
            else if (tmpVal[tmpVal.Length - 1] == "-")
                _resultD -= tmpNumber;
            else if (tmpVal[tmpVal.Length - 1] == "*")
                _resultD *= tmpNumber;
            else if (tmpVal[tmpVal.Length - 1] == "/")
                _resultD                                        /= tmpNumber;
            else if (tmpVal[tmpVal.Length - 1] == "%") _resultD %= tmpNumber;

            if (txtEnter.Text != "")
                _resultS += txtEnter.Text + "=" + Math.Round(_resultD, 2);
            else
                _resultS += "0" + "=" + Math.Round(_resultD, 2);

            if (txtResult.Text == "")
                txtResult.Text = _resultS;
            else {
                txtResultBefore.Text = txtResult.Text;
                txtResult.Text       = _resultS;
            }
            txtEnter.Text = "";
            _resultS       = "";
            _resultD       = 0;
        }
        private void butInterest_Click(object sender, EventArgs e) {
            double.TryParse(txtEnter.Text, out var tmpNumber);
            if (_resultD == 0) { _resultD = tmpNumber; }
            else
                _resultD %= tmpNumber;
            CheckNoneEnter(" %");
            txtEnter.Text = "";
        }
        private void butMinus_Click(object sender, EventArgs e) {
            double.TryParse(txtEnter.Text, out var tmpNumber);
            if (_resultD == 0) { _resultD = tmpNumber; }
            else
                _resultD -= tmpNumber;
            CheckNoneEnter(" -");
            txtEnter.Text = "";
        }
        private void butMultiplication_Click(object sender, EventArgs e) {
            double.TryParse(txtEnter.Text, out var tmpNumber);
            if (_resultD == 0) { _resultD = tmpNumber; }
            else
                _resultD *= tmpNumber;
            CheckNoneEnter(" *");
            txtEnter.Text = "";
        }
        private void butNumbers_Click(object sender, EventArgs e) { txtEnter.Text += ((Button) sender).Text; }
        private void butPlus_Click(object sender, EventArgs e) {
            double.TryParse(txtEnter.Text, out var tmpNumber);
            _resultD += tmpNumber;
            CheckNoneEnter(" +");
            txtEnter.Text = "";
        }
#endregion
        private void butAddition_Click(object sender, EventArgs e) {
            var tmpGlobalForm = new GlobalForm();
            var button = (Button) sender;
            foreach (var additionButton in _additionButtons.Where(additionButton => additionButton == button)) {
                if (button.BackColor == Color.FromArgb(0, 0, 180)) {
                    this.Size        = tmpGlobalForm.MinimumSize;
                    button.BackColor = Color.FromArgb(90, 120, 170);
                    _activeForm      = null;
                    return;
                }
                OpenChildForm(_additionForm[_additionButtons.IndexOf(additionButton)]);
                this.Size = tmpGlobalForm.MaximumSize;
                foreach (var item in _additionButtons) {
                    if (item == button)
                        button.BackColor = Color.FromArgb(0, 0, 180);
                    else
                        item.BackColor = Color.FromArgb(90, 120, 170);
                }
            }
        }
        private void butClose_Click(object sender, EventArgs e) { Application.Exit(); }
        private void movePanel_MouseMove(object sender, MouseEventArgs e) {
            if(e.Button == MouseButtons.Left) {
                this.Left += e.X - _lastPoint.X;
                this.Top += e.Y - _lastPoint.Y;
            }
        }
        private void movePanel_MouseDown(object sender, MouseEventArgs e) {
            _lastPoint = new Point(e.X, e.Y);
        }
    }
}