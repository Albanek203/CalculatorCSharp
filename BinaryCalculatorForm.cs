using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

namespace Calculator {
    public partial class BinaryCalculatorForm: Form {
        private readonly List<TypesOrder> _mTypesConv;

        private readonly List<TypesOrder> _mTypesBinCalcLeft;
        private readonly List<TypesOrder> _mTypesBinCalcRight;
        public BinaryCalculatorForm() {
            InitializeComponent();
            
            _mTypesConv = new TypeBinaryCalculator().GetTypes();
            foreach (var item in _mTypesConv) cmbTypeBin.Items.Add(item.STypeName);

            _mTypesBinCalcLeft = new TypesBinary().GetTypes();
            foreach (var item in _mTypesBinCalcLeft) cmbTypeBinLeft.Items.Add(item.STypeName);
            
            _mTypesBinCalcRight = new TypesBinary().GetTypes();
            foreach (var item in _mTypesBinCalcRight) cmbTypeBinRight.Items.Add(item.STypeName);
        }
#region Binary Convert
        private void cmbTypeBin_SelectedIndexChanged(object sender, EventArgs e) {
            for (var i = 0; i < _mTypesConv.Count; i++) {
                if (cmbTypeBin.SelectedIndex != i) continue;
                txtFromTypeBin.Visible = true;
                txtToTypeBin.Visible   = true;
                editFromBin.Visible    = true;
                editToBin.Visible      = true;
                butConvertBin.Visible  = true;
                txtFromTypeBin.Text    = _mTypesConv[i].SFromName;
                txtToTypeBin.Text      = _mTypesConv[i].SToName;
                editFromBin.Text       = "";
                editToBin.Text         = "";
            }
        }
        private void butConvertBin_Click(object sender, EventArgs e) {
            var tmpBinConvertor = new BinConvertor();
            if (editFromBin.Text == "") { return; }
            for (var i = 0; i < _mTypesConv.Count; i++) {
                if (cmbTypeBin.SelectedIndex != i) continue;
                switch (i) {
                    case 0: editToBin.Text = tmpBinConvertor.ConvertBinToOct(editFromBin.Text); break;
                    case 1: editToBin.Text = tmpBinConvertor.ConvertBinToDec(editFromBin.Text); break;
                    case 2: editToBin.Text = tmpBinConvertor.ConvertBinToHex(editFromBin.Text); break;
                    case 3: editToBin.Text = tmpBinConvertor.ConvertOctToBin(editFromBin.Text); break;
                    case 4: editToBin.Text = tmpBinConvertor.ConvertOctToDec(editFromBin.Text); break;
                    case 5: editToBin.Text = tmpBinConvertor.ConvertOctToHex(editFromBin.Text); break;
                    case 6: editToBin.Text = tmpBinConvertor.ConvertDecToBin(editFromBin.Text); break;
                    case 7: editToBin.Text = tmpBinConvertor.ConvertDecToOct(editFromBin.Text); break;
                    case 8: editToBin.Text = tmpBinConvertor.ConvertDecToHex(editFromBin.Text); break;
                    case 9: editToBin.Text = tmpBinConvertor.ConvertHexToBin(editFromBin.Text); break;
                    case 10: editToBin.Text = tmpBinConvertor.ConvertHexToOct(editFromBin.Text); break;
                    case 11: editToBin.Text = tmpBinConvertor.ConvertHexToDec(editFromBin.Text); break;
                }
            }
        }
#endregion
#region Binary Calculator
        private void cmbTypeBinLeft_SelectedIndexChanged(object sender, EventArgs e) {
            cmbOperationBin.Visible   = true;
            butCalculationBin.Visible = true;
            editLeftBin.Visible       = true;
            editLeftBin.Text          = "";
        }
        private void cmbTypeBinRight_SelectedIndexChanged(object sender, EventArgs e) {
            for(var i = 0; i < _mTypesBinCalcRight.Count; i++) {
                if(cmbTypeBinRight.SelectedIndex != i) continue;
                editRightBin.Visible = true;
                editRightBin.Text = "";
            }
        }
        private double CalculateLeft_RightValue(double leftValue, double rightValue) {
            var result = 0.0;
            switch(cmbOperationBin.SelectedIndex) {
                case 0: result = leftValue + rightValue; break;
                case 1: result = leftValue - rightValue; break;
                case 2: result = leftValue * rightValue; break;
                case 3: result = Math.Round(leftValue / rightValue); break;
            }
            return result;
        }
        private void butCalculationBin_Click(object sender, EventArgs e) {
            var tmpTypeConv = new BinConvertor();
            txtResBinCalc.Visible = true;
            if(editLeftBin.Text == "" || editRightBin.Text == "") { return; }
            if(cmbTypeBinLeft.SelectedIndex == cmbTypeBinRight.SelectedIndex) {
                switch(cmbTypeBinLeft.SelectedIndex) {
                    case 0: {
                        int.TryParse(tmpTypeConv.ConvertBinToDec(editLeftBin.Text), out var leftValue);
                        int.TryParse(tmpTypeConv.ConvertBinToDec(editRightBin.Text), out var rightValue);
                        txtResultBinCalc.Text = tmpTypeConv.ConvertDecToBin(CalculateLeft_RightValue(leftValue, rightValue).ToString(CultureInfo.InvariantCulture));
                        break;
                    }
                    case 1: {
                        int.TryParse(tmpTypeConv.ConvertOctToDec(editLeftBin.Text), out var leftValue);
                        int.TryParse(tmpTypeConv.ConvertOctToDec(editRightBin.Text), out var rightValue);
                        txtResultBinCalc.Text = tmpTypeConv.ConvertDecToOct(CalculateLeft_RightValue(leftValue, rightValue).ToString(CultureInfo.InvariantCulture));
                        break;
                    }
                    case 2: {
                        int.TryParse(editLeftBin.Text, out var leftValue);
                        int.TryParse(editRightBin.Text, out var rightValue);
                        txtResultBinCalc.Text = CalculateLeft_RightValue(leftValue, rightValue).ToString(CultureInfo.InvariantCulture);
                        break;
                    }
                    case 3: {
                        int.TryParse(tmpTypeConv.ConvertHexToDec(editLeftBin.Text), out var leftValue);
                        int.TryParse(tmpTypeConv.ConvertHexToDec(editRightBin.Text), out var rightValue);
                        txtResultBinCalc.Text = tmpTypeConv.ConvertDecToHex(CalculateLeft_RightValue(leftValue, rightValue).ToString(CultureInfo.InvariantCulture));
                        break;
                    }
                }
            }
            else if(cmbTypeBinLeft.SelectedIndex == 0) {
                int.TryParse(tmpTypeConv.ConvertBinToDec(editLeftBin.Text), out var leftValue);
                var rightValue = 0;
                if(cmbTypeBinRight.SelectedIndex == 1)
                    int.TryParse(tmpTypeConv.ConvertOctToDec(editRightBin.Text), out rightValue);
                else if(cmbTypeBinRight.SelectedIndex == 2)
                    int.TryParse(editRightBin.Text, out rightValue);
                else if(cmbTypeBinRight.SelectedIndex == 3) int.TryParse(tmpTypeConv.ConvertHexToDec(editRightBin.Text), out rightValue);
                txtResultBinCalc.Text = tmpTypeConv.ConvertDecToBin(CalculateLeft_RightValue(leftValue, rightValue).ToString(CultureInfo.InvariantCulture));
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
                txtResultBinCalc.Text = tmpTypeConv.ConvertDecToOct(CalculateLeft_RightValue(leftValue, rightValue).ToString(CultureInfo.InvariantCulture));
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
                txtResultBinCalc.Text = CalculateLeft_RightValue(leftValue, rightValue).ToString(CultureInfo.InvariantCulture);
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
                txtResultBinCalc.Text = tmpTypeConv.ConvertDecToHex(CalculateLeft_RightValue(leftValue, rightValue).ToString(CultureInfo.InvariantCulture));
            }
        }
        private void FAQBinCalculator_MouseEnter(object sender, EventArgs e) {
            panelFAQBinCalculator.Visible = true;
        }
        private void FAQBinCalculator_MouseLeave(object sender, EventArgs e) {
            panelFAQBinCalculator.Visible = false;
        }
        #endregion
    }
}