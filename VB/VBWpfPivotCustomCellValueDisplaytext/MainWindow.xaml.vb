Imports System
Imports System.Windows
Imports DevExpress.Xpf.PivotGrid

Namespace WpfPivotCustomCellValueDisplaytext
    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Partial Public Class MainWindow
        Inherits Window

        Public Sub New()
            InitializeComponent()
            fieldCountry.FilterValues.FilterType = FieldFilterType.Included
            fieldCountry.FilterValues.Add("UK")
        End Sub

        Private Sub pivotGridControl1_CustomCellDisplayText(ByVal sender As Object, ByVal e As DevExpress.Xpf.PivotGrid.PivotCellDisplayTextEventArgs)
            ' In this example, if a row total value is less than 2000, 'Low' is displayed instead. 
            ' If the value exceeds 6000, 'High' is displayed; otherwise, 'Middle'.
            If e.RowValueType = FieldValueType.Total OrElse e.ColumnValueType <> FieldValueType.Total Then
                Return
            End If
            If Convert.ToSingle(e.Value) < 2000 Then
                e.DisplayText = "Low"
            ElseIf Convert.ToSingle(e.Value) > 6000 Then
                e.DisplayText = "High"
            Else
                e.DisplayText = "Middle"
            End If
        End Sub
    End Class
End Namespace
