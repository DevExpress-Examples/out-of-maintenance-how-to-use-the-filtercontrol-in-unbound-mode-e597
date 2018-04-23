using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors.Filtering;
using DevExpress.XtraEditors.Repository;
using DevExpress.Data.Filtering.Helpers;

namespace UnboundFilterControl {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            CreateFilterColumns();
        }

        private void CreateFilterColumns() {
            filterControl1.FilterColumns.Add(new UnboundFilterColumn("Name", "Field1", typeof(string), new RepositoryItemTextEdit(), FilterColumnClauseClass.String));
            filterControl1.FilterColumns.Add(new UnboundFilterColumn("Age", "Field2", typeof(int), new RepositoryItemSpinEdit(), FilterColumnClauseClass.Generic));
        }

        private void filterControl1_FilterChanged(object sender, DevExpress.XtraEditors.FilterChangedEventArgs e) {
            labelControl1.Text = filterControl1.FilterCriteria.LegacyToString(); // SQL-like filter
        }
    }
}