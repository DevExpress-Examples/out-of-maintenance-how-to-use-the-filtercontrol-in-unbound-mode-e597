Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors.Filtering
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.Data.Filtering.Helpers

Namespace UnboundFilterControl
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			CreateFilterColumns()
		End Sub

		Private Sub CreateFilterColumns()
			filterControl1.FilterColumns.Add(New UnboundFilterColumn("Name", "Field1", GetType(String), New RepositoryItemTextEdit(), FilterColumnClauseClass.String))
			filterControl1.FilterColumns.Add(New UnboundFilterColumn("Age", "Field2", GetType(Integer), New RepositoryItemSpinEdit(), FilterColumnClauseClass.Generic))
		End Sub

		Private Sub filterControl1_FilterChanged(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.FilterChangedEventArgs) Handles filterControl1.FilterChanged
			labelControl1.Text = filterControl1.FilterCriteria.LegacyToString() ' SQL-like filter
		End Sub
	End Class
End Namespace