Imports DevExpress.Xpf.PivotGrid

Class MainWindow
    Private Sub Window_Loaded(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles MyBase.Loaded
        fieldCountry.FilterValues.FilterType = FieldFilterType.Included
        fieldCountry.FilterValues.Add("UK")
    End Sub
    Private Sub PivotGridControl1_CustomCellDisplayText(sender As System.Object,
                e As DevExpress.Xpf.PivotGrid.PivotCellDisplayTextEventArgs) Handles pivotGridControl1.CustomCellDisplayText
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
