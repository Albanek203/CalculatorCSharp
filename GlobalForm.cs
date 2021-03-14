using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator {
    public partial class Calculators : Form {
        Point pointRightPanel = new Point(580,0);
        private TypeConvertion[] m_aTypes;
        private TypeConvertion[] m_aTypesConvBin;
        private TypeConvertion[] m_aTypesLeftBin;
        private TypeConvertion[] m_aTypesRightBin;
        private TypeConvertion[] m_aOperations;
        private TypeConvertion[] m_aBinOperatin;
        private TypeConvertion[] m_aTypeSystem;
        private double ResultD;
        private string ResultS;
        public Calculators() {
            InitializeComponent();
            var tmpType = new TypeConvertion();
            Size = new Size(580, 450);

            m_aBinOperatin = tmpType.BinOperation();
            for(int iter = 0; iter < m_aBinOperatin.Length; iter++)
                cmbLogicalOper.Items.Add(m_aBinOperatin[iter].sTypeName);            

            m_aTypeSystem = tmpType.TypeConvertionsBinBottom();
            for(int iter = 0; iter < m_aTypeSystem.Length; iter++)
                cmbTypeBinOper.Items.Add(m_aTypeSystem[iter].sTypeName);

            m_aOperations = tmpType.Operation();
            for(int iter = 0; iter < m_aOperations.Length; iter++)
                cmbOperationBin.Items.Add(m_aOperations[iter].sTypeName);

            m_aTypesLeftBin = tmpType.TypeConvertionsBinBottom();
            for(int iter = 0; iter < m_aTypesLeftBin.Length; iter++)
                cmbTypeBinLeft.Items.Add(m_aTypesLeftBin[iter].sTypeName);

            m_aTypesRightBin = tmpType.TypeConvertionsBinBottom();
            for(int iter = 0; iter < m_aTypesRightBin.Length; iter++)
                cmbTypeBinRight.Items.Add(m_aTypesRightBin[iter].sTypeName);

            m_aTypes = tmpType.TypesConvert();
            for(int iter = 0; iter < m_aTypes.Length; iter++)
                cmbType.Items.Add(m_aTypes[iter].sTypeName);

            m_aTypesConvBin = tmpType.TypeConvertionsBin();            
            for(int iter = 0; iter < m_aTypesConvBin.Length; iter++)
                cmbTypeBin.Items.Add(m_aTypesConvBin[iter].sTypeName);
        }
        private void butNumber0_Click(object sender, EventArgs e) { txtEnter.Text += 0; }
        private void butNumber1_Click(object sender, EventArgs e) { txtEnter.Text += 1; }
        private void butNumber2_Click(object sender, EventArgs e) { txtEnter.Text += 2; }
        private void butNumber3_Click(object sender, EventArgs e) { txtEnter.Text += 3; }
        private void butNumber4_Click(object sender, EventArgs e) { txtEnter.Text += 4; }
        private void butNumber5_Click(object sender, EventArgs e) { txtEnter.Text += 5; }
        private void butNumber6_Click(object sender, EventArgs e) { txtEnter.Text += 6; }
        private void butNumber7_Click(object sender, EventArgs e) { txtEnter.Text += 7; }
        private void butNumber8_Click(object sender, EventArgs e) { txtEnter.Text += 8; }
        private void butNumber9_Click(object sender, EventArgs e) { txtEnter.Text += 9; }
        private void butDot_Click(object sender, EventArgs e) {
            if(txtEnter.Text.IndexOf('.') == -1 && txtEnter.Text.Length > 0)
                txtEnter.Text += ",";
        }
        private void butAllClear_Click(object sender, EventArgs e) { 
            txtEnter.Text = ""; ResultD = 0; ResultS = ""; 
        }
        private void CheckNoneEnter(string operation) {
            if(txtEnter.Text != "")
                ResultS += txtEnter.Text + operation;
            else
                ResultS += "0" + txtEnter.Text + operation;
        }
        private void butPlus_Click(object sender, EventArgs e) {
            double.TryParse(txtEnter.Text, out var tmpNumber);
            ResultD += tmpNumber;
            CheckNoneEnter(" +");
            txtEnter.Text = "";
        }
        private void butMinus_Click(object sender, EventArgs e) {
            double.TryParse(txtEnter.Text, out var tmpNumber);
            if(ResultD == 0) { ResultD = tmpNumber; }
            else
                ResultD -= tmpNumber;
            CheckNoneEnter(" -");
            txtEnter.Text = "";
        }
        private void butMultiplication_Click(object sender, EventArgs e) {
            double.TryParse(txtEnter.Text, out var tmpNumber);
            if(ResultD == 0) { ResultD = tmpNumber; }
            else
                ResultD *= tmpNumber;
            CheckNoneEnter(" *");
            txtEnter.Text = "";
        }
        private void butDivision_Click(object sender, EventArgs e) {
            double.TryParse(txtEnter.Text, out var tmpNumber);
            if(ResultD == 0) { ResultD = tmpNumber; }
            else
                ResultD /= tmpNumber;
            CheckNoneEnter(" /");
            txtEnter.Text = "";
        }
        private void butInterest_Click(object sender, EventArgs e) {
            double.TryParse(txtEnter.Text, out var tmpNumber);
            if(ResultD == 0) { ResultD = tmpNumber; }
            else
                ResultD %= tmpNumber;
            CheckNoneEnter(" %");
            txtEnter.Text = "";
        }
        private void butChangeMark_Click(object sender, EventArgs e) {
            txtEnter.Text = "-" + txtEnter.Text;
        }
        private void butEqual_Click(object sender, EventArgs e) {
            var tmpVal = ResultS.Split(' ');
            double.TryParse(txtEnter.Text, out var tmpNumber);
            ResultS = ResultS.Replace(" ", "");

            if(tmpVal[tmpVal.Length - 1] == "+")
                ResultD += tmpNumber;
            else if(tmpVal[tmpVal.Length - 1] == "-")
                ResultD -= tmpNumber;
            else if(tmpVal[tmpVal.Length - 1] == "*")
                ResultD *= tmpNumber;
            else if(tmpVal[tmpVal.Length - 1] == "/")
                ResultD /= tmpNumber;
            else if(tmpVal[tmpVal.Length - 1] == "%")
                ResultD %= tmpNumber;

            if(txtEnter.Text != "")
                ResultS += txtEnter.Text + "=" + Math.Round(ResultD, 2);
            else
                ResultS += "0" + "=" + Math.Round(ResultD, 2);

            if(txtResult.Text == "")
                txtResult.Text = ResultS;
            else {
                txtResultBefore.Text = txtResult.Text;
                txtResult.Text = ResultS;
            }
            txtEnter.Text = "";
            ResultS = "";
            ResultD = 0;
        }
        private void cbConverter_CheckedChanged(object sender, EventArgs e) {
            Calculators calculators = new Calculators();
            if(cbConverter.Checked && !cbBinCalculator.Checked && !cbBinOperations.Checked) {                
                rightPanelConvert.Location = pointRightPanel;
                Size = calculators.MaximumSize;
                rightPanelConvert.Visible = true;
            }
            else {
                Size = calculators.MinimumSize;
                rightPanelConvert.Visible = false;
            }
            calculators.Size = Size;
        }
        private void cbBinCalculator_CheckedChanged(object sender, EventArgs e) {
            Calculators calculators = new Calculators();
            if(cbBinCalculator.Checked && !cbConverter.Checked && !cbBinOperations.Checked) {
                rightPanelBinCalc.Location = pointRightPanel;
                Size = calculators.MaximumSize;
                rightPanelBinCalc.Visible = true;
            }
            else {
                Size = calculators.MinimumSize;
                rightPanelBinCalc.Visible = false;
            }
            calculators.Size = Size;
        }
        private void cbBinOperations_CheckedChanged(object sender, EventArgs e) {
            Calculators calculators = new Calculators();
            if(cbBinOperations.Checked && !cbConverter.Checked && !cbBinCalculator.Checked) {
                rightPanelBinOper.Location = pointRightPanel;
                Size = calculators.MaximumSize;
                rightPanelBinOper.Visible = true;
            }
            else {
                Size = calculators.MinimumSize;
                rightPanelBinOper.Visible = false;
            }
        }
        private void VisibleConvertTxT() {
            txtFromType.Visible = true;
            txtToType.Visible = true;
            editFrom.Visible = true;
            editTo.Visible = true;
            butConvert.Visible = true;
        }
        private void VisibleBinTxT() {
            txtFromTypeBin.Visible = true;
            txtToTypeBin.Visible = true;
            editFromBin.Visible = true;
            editToBin.Visible = true;
            butConvertBin.Visible = true;
        }
        private void cmbType_SelectedIndexChanged(object sender, EventArgs e) {
            for(int iter = 0; iter < m_aTypes.Length; iter++) {
                if(cmbType.SelectedIndex == iter) {
                    VisibleConvertTxT();
                    txtFromType.Text = m_aTypes[iter].sFromName;
                    txtToType.Text = m_aTypes[iter].sToName;
                    editFrom.Text = "";
                    editTo.Text = "";
                }
            }
        }
        private void butConvert_Click(object sender, EventArgs e) {
            for(int i = 0; i < m_aTypes.Length; i++) {
                if(cmbType.SelectedIndex == i) {
                    double.TryParse(editFrom.Text, out var From);
                    editTo.Text = (From * m_aTypes[i].dCoef).ToString();
                }
            }
        }
        private void cmbTypeBin_SelectedIndexChanged(object sender, EventArgs e) {
            for(int i = 0; i < m_aTypesConvBin.Length; i++) {
                if(cmbTypeBin.SelectedIndex == i) {
                    VisibleBinTxT();
                    txtFromTypeBin.Text = m_aTypesConvBin[i].sFromName;
                    txtToTypeBin.Text = m_aTypesConvBin[i].sToName;
                    editFromBin.Text = "";
                    editToBin.Text = "";
                }
            }
        }
        private void butConvertBin_Click(object sender, EventArgs e) {
            var tmpTypeConv = new TypeConvertion();
            if(editFromBin.Text == "") { return; }
            for(int i = 0; i < m_aTypesConvBin.Length; i++) {
                if(cmbTypeBin.SelectedIndex == i) {
                    if(m_aTypesConvBin[i].dCoef == 28)
                        editToBin.Text = tmpTypeConv.ConvertBinToOct(editFromBin.Text);
                    else if(m_aTypesConvBin[i].dCoef == 210)
                        editToBin.Text = tmpTypeConv.ConvertBinToDec(editFromBin.Text).ToString();
                    else if(m_aTypesConvBin[i].dCoef == 216)
                        editToBin.Text = tmpTypeConv.ConvertBinToHex(editFromBin.Text);
                    else if(m_aTypesConvBin[i].dCoef == 82)
                        editToBin.Text = tmpTypeConv.ConvertOctToBin(editFromBin.Text);
                    else if(m_aTypesConvBin[i].dCoef == 810)
                        editToBin.Text = tmpTypeConv.ConvertOctToDec(editFromBin.Text);
                    else if(m_aTypesConvBin[i].dCoef == 816)
                        editToBin.Text = tmpTypeConv.ConvertOctToHex(editFromBin.Text);
                    else if(m_aTypesConvBin[i].dCoef == 102)
                        editToBin.Text = tmpTypeConv.ConvertDecToBin(editFromBin.Text);
                    else if(m_aTypesConvBin[i].dCoef == 108)
                        editToBin.Text = tmpTypeConv.ConvertDecToOct(editFromBin.Text);
                    else if(m_aTypesConvBin[i].dCoef == 1016)
                        editToBin.Text = tmpTypeConv.ConvertDecToHex(editFromBin.Text);
                    else if(m_aTypesConvBin[i].dCoef == 162)
                        editToBin.Text = tmpTypeConv.ConvertHexToBin(editFromBin.Text);
                    else if(m_aTypesConvBin[i].dCoef == 168)
                        editToBin.Text = tmpTypeConv.ConvertHexToOct(editFromBin.Text);
                    else if(m_aTypesConvBin[i].dCoef == 1610)
                        editToBin.Text = tmpTypeConv.ConvertHexToDec(editFromBin.Text);
                }
            }
        }
        private void cmbTypeBinLeft_SelectedIndexChanged(object sender, EventArgs e) {
            cmbOperationBin.Visible = true;
            butCalculationBin.Visible = true;
            editLeftBin.Visible = true;
            editLeftBin.Text = "";
        }
        private void cmbTypeBinRight_SelectedIndexChanged(object sender, EventArgs e) {
            for(int i = 0; i < m_aTypesRightBin.Length; i++) {
                if(cmbTypeBinRight.SelectedIndex == i) {
                    editRightBin.Visible = true;
                    editRightBin.Text = "";
                }
            }
        }
        private double CalculateLeft_RightValue(double leftValue, double rightValue) {
            var result = 0.0;
            if(cmbOperationBin.SelectedIndex == 0)
                result = leftValue + rightValue;
            else if(cmbOperationBin.SelectedIndex == 1)
                result = leftValue - rightValue;
            else if(cmbOperationBin.SelectedIndex == 2)
                result = leftValue * rightValue;
            else if(cmbOperationBin.SelectedIndex == 3)
                result = Math.Round(leftValue / rightValue);
            return result;
        }
        private void butCalculationBin_Click(object sender, EventArgs e) {
            var tmpTypeConv = new TypeConvertion();
            txtResBinCalc.Visible = true;
            if(editLeftBin.Text == "" || editRightBin.Text == "") { return; }
            if(cmbTypeBinLeft.SelectedIndex == cmbTypeBinRight.SelectedIndex) {
                if(cmbTypeBinLeft.SelectedIndex == 0) {
                    int.TryParse(tmpTypeConv.ConvertBinToDec(editLeftBin.Text), out var leftValue);
                    int.TryParse(tmpTypeConv.ConvertBinToDec(editRightBin.Text), out var rightValue);
                    txtResultBinCalc.Text = tmpTypeConv.ConvertDecToBin(CalculateLeft_RightValue(leftValue, rightValue).ToString());
                }
                else if(cmbTypeBinLeft.SelectedIndex == 1) {
                    int.TryParse(tmpTypeConv.ConvertOctToDec(editLeftBin.Text), out var leftValue);
                    int.TryParse(tmpTypeConv.ConvertOctToDec(editRightBin.Text), out var rightValue);
                    txtResultBinCalc.Text = tmpTypeConv.ConvertDecToOct(CalculateLeft_RightValue(leftValue, rightValue).ToString());
                }
                else if(cmbTypeBinLeft.SelectedIndex == 2) {
                    int.TryParse(editLeftBin.Text, out var leftValue);
                    int.TryParse(editRightBin.Text, out var rightValue);
                    txtResultBinCalc.Text = CalculateLeft_RightValue(leftValue, rightValue).ToString();
                }
                else if(cmbTypeBinLeft.SelectedIndex == 3) {
                    int.TryParse(tmpTypeConv.ConvertHexToDec(editLeftBin.Text), out var leftValue);
                    int.TryParse(tmpTypeConv.ConvertHexToDec(editRightBin.Text), out var rightValue);
                    txtResultBinCalc.Text = tmpTypeConv.ConvertDecToHex(CalculateLeft_RightValue(leftValue, rightValue).ToString());
                }
            }
            else if(cmbTypeBinLeft.SelectedIndex == 0) {
                int.TryParse(tmpTypeConv.ConvertBinToDec(editLeftBin.Text), out var leftValue);
                var rightValue = 0;
                if(cmbTypeBinRight.SelectedIndex == 1)
                    int.TryParse(tmpTypeConv.ConvertOctToDec(editRightBin.Text), out rightValue);
                else if(cmbTypeBinRight.SelectedIndex == 2)
                    int.TryParse(editRightBin.Text, out rightValue);
                else if(cmbTypeBinRight.SelectedIndex == 3)
                    int.TryParse(tmpTypeConv.ConvertHexToDec(editRightBin.Text), out rightValue);
                txtResultBinCalc.Text = tmpTypeConv.ConvertDecToBin(CalculateLeft_RightValue(leftValue, rightValue).ToString());
            }
            else if(cmbTypeBinLeft.SelectedIndex == 1) {
                int.TryParse(tmpTypeConv.ConvertOctToDec(editLeftBin.Text), out var leftValue);
                var rightValue = 0;
                if(cmbTypeBinRight.SelectedIndex == 0)
                    int.TryParse(tmpTypeConv.ConvertBinToDec(editRightBin.Text), out rightValue);
                else if(cmbTypeBinRight.SelectedIndex == 2)
                    int.TryParse(editRightBin.Text, out rightValue);
                else if(cmbTypeBinRight.SelectedIndex == 3)
                    int.TryParse(tmpTypeConv.ConvertHexToDec(editRightBin.Text), out rightValue);
                txtResultBinCalc.Text = tmpTypeConv.ConvertDecToOct(CalculateLeft_RightValue(leftValue, rightValue).ToString());
            }
            else if(cmbTypeBinLeft.SelectedIndex == 2) {
                int.TryParse(editLeftBin.Text, out var leftValue);
                var rightValue = 0;
                if(cmbTypeBinRight.SelectedIndex == 0)
                    int.TryParse(tmpTypeConv.ConvertBinToDec(editRightBin.Text), out rightValue);
                else if(cmbTypeBinRight.SelectedIndex == 1)
                    int.TryParse(tmpTypeConv.ConvertOctToDec(editRightBin.Text), out rightValue);
                else if(cmbTypeBinRight.SelectedIndex == 3)
                    int.TryParse(tmpTypeConv.ConvertHexToDec(editRightBin.Text), out rightValue);
                txtResultBinCalc.Text = CalculateLeft_RightValue(leftValue, rightValue).ToString();
            }
            else if(cmbTypeBinLeft.SelectedIndex == 3) {
                int.TryParse(tmpTypeConv.ConvertHexToDec(editLeftBin.Text), out var leftValue);
                var rightValue = 0;
                if(cmbTypeBinRight.SelectedIndex == 0)
                    int.TryParse(tmpTypeConv.ConvertBinToDec(editRightBin.Text), out rightValue);
                else if(cmbTypeBinRight.SelectedIndex == 1)
                    int.TryParse(tmpTypeConv.ConvertOctToDec(editRightBin.Text), out rightValue);
                else if(cmbTypeBinRight.SelectedIndex == 2)
                    int.TryParse(editRightBin.Text, out rightValue);
                txtResultBinCalc.Text = tmpTypeConv.ConvertDecToHex(CalculateLeft_RightValue(leftValue, rightValue).ToString());
            }
        }
        private void cmbTypeBinOper_SelectedIndexChanged(object sender, EventArgs e) {
            butBinOper.Visible = true;
            cmbLogicalOper.Visible = true;
            editRightOper.Visible = true;
            editLeftOper.Visible = true;
            editRightOper.Text = "";
            editLeftOper.Text = "";
        }
        private string CalculateBinOper(int leftVal,int rightVal) {
            if(cmbLogicalOper.SelectedIndex == 0) 
                return (leftVal & rightVal).ToString();
            else if(cmbLogicalOper.SelectedIndex == 1)
                return (leftVal | rightVal).ToString();
            else if(cmbLogicalOper.SelectedIndex == 2)
                return (leftVal ^ rightVal).ToString();
            else if(cmbLogicalOper.SelectedIndex == 3)
                return (leftVal << rightVal).ToString();
            else if(cmbLogicalOper.SelectedIndex == 4)
                return (leftVal >> rightVal).ToString();
            return "0";
        }
        private void butBinOper_Click(object sender, EventArgs e) {
            var tmpType = new TypeConvertion();
            if(editLeftOper.Text == "" || editRightOper.Text == "") { return; }
            txtBinOperDown.Visible = true;
            if(cmbTypeBinOper.SelectedIndex == 0) {
                int.TryParse(tmpType.ConvertBinToDec(editLeftOper.Text),out var leftVal);
                int.TryParse(tmpType.ConvertBinToDec(editRightOper.Text),out var rightVal);
                txtBinOperResult.Text = tmpType.ConvertDecToBin(CalculateBinOper(leftVal, rightVal));
            }
            if(cmbTypeBinOper.SelectedIndex == 1) {
                int.TryParse(tmpType.ConvertOctToDec(editLeftOper.Text), out var leftVal);
                int.TryParse(tmpType.ConvertOctToDec(editRightOper.Text), out var rightVal);
                txtBinOperResult.Text = tmpType.ConvertDecToOct(CalculateBinOper(leftVal, rightVal));
            }
            if(cmbTypeBinOper.SelectedIndex == 2) {
                int.TryParse(editLeftOper.Text, out var leftVal);
                int.TryParse(editRightOper.Text, out var rightVal);
                txtBinOperResult.Text = CalculateBinOper(leftVal, rightVal);
            }
            if(cmbTypeBinOper.SelectedIndex == 3) {
                int.TryParse(tmpType.ConvertHexToDec(editLeftOper.Text), out var leftVal);
                int.TryParse(tmpType.ConvertHexToDec(editRightOper.Text), out var rightVal);
                txtBinOperResult.Text = tmpType.ConvertDecToHex(CalculateBinOper(leftVal, rightVal));
            }
        }
        private void butClose_Click(object sender, EventArgs e) {
            Application.Exit();
        }
        private void FAQBinCalculator_MouseEnter(object sender, EventArgs e) {
            panelFAQBinCalculator.Visible = true;
        }
        private void FAQBinCalculator_MouseLeave(object sender, EventArgs e) {
            panelFAQBinCalculator.Visible = false;
        }
        Point lastPoint;
        private void movePanel_MouseMove(object sender, MouseEventArgs e) {
            if(e.Button == MouseButtons.Left) {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        private void movePanel_MouseDown(object sender, MouseEventArgs e) {
            lastPoint = new Point(e.X, e.Y);
        }

        
    }
}