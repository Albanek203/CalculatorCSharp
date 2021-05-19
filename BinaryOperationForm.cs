using System;
using System.Windows.Forms;

namespace Calculator {
    public partial class BinaryOperationForm : Form {
        public BinaryOperationForm() {
            InitializeComponent();
            
            var mTypesOperation = new TypeBinaryCalculator().GetTypes();
            foreach (var item in mTypesOperation) cmbTypeBinOper.Items.Add(item.STypeName);
        }
        private void cmbTypeBinOper_SelectedIndexChanged(object sender, EventArgs e) {
            butBinOper.Visible     = true;
            cmbLogicalOper.Visible = true;
            editRightOper.Visible  = true;
            editLeftOper.Visible   = true;
            editRightOper.Text     = "";
            editLeftOper.Text      = "";
        }
        private string CalculateBinOper(int leftVal,int rightVal) {
            if(cmbLogicalOper.SelectedIndex == 0) 
                return (leftVal & rightVal).ToString();
            if(cmbLogicalOper.SelectedIndex == 1)
                return (leftVal | rightVal).ToString();
            if(cmbLogicalOper.SelectedIndex == 2)
                return (leftVal ^ rightVal).ToString();
            if(cmbLogicalOper.SelectedIndex == 3)
                return (leftVal << rightVal).ToString();
            if(cmbLogicalOper.SelectedIndex == 4)
                return (leftVal >> rightVal).ToString();
            return "0";
        }
        private void butBinOper_Click(object sender, EventArgs e) {
            var tmpType = new BinConvertor();
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
    }
}
