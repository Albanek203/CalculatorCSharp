using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

namespace Calculator {
    public partial class ConvertForm: Form {
        private readonly List<TypesOrder> _mTypes;
        public ConvertForm() {
            InitializeComponent();
            var tmpType = new TypeConvert();
            _mTypes = tmpType.GetTypes();
            foreach (var item in _mTypes) cmbTypeConvertation.Items.Add(item.STypeName);
        }
        private void cmbType_SelectedIndexChanged(object sender, EventArgs e) {
            for (var i = 0; i < _mTypes.Count; i++) {
                if (cmbTypeConvertation.SelectedIndex != i) continue;
                txtFromType.Visible = true;
                txtToType.Visible   = true;
                editFrom.Visible    = true;
                editTo.Visible      = true;
                butConvert.Visible  = true;
                txtFromType.Text    = _mTypes[i].SFromName;
                txtToType.Text      = _mTypes[i].SToName;
                editFrom.Text       = "";
                editTo.Text         = "";
            }
        }
        private void butConvert_Click(object sender, EventArgs e) {
            for (var i = 0; i < _mTypes.Count; i++) {
                if (cmbTypeConvertation.SelectedIndex != i) continue;
                double.TryParse(editFrom.Text, out var from);
                editTo.Text = (@from * _mTypes[i].DCoefficient).ToString(CultureInfo.InvariantCulture);
            }
        }
    }
}