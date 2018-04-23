using System;
using System.Windows;
using DevExpress.Xpf.PivotGrid;

namespace WpfPivotCustomCellValueDisplaytext
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            fieldCountry.FilterValues.FilterType = FieldFilterType.Included;
            fieldCountry.FilterValues.Add("UK");
        }

        private void pivotGridControl1_CustomCellDisplayText(object sender, 
                        DevExpress.Xpf.PivotGrid.PivotCellDisplayTextEventArgs e)
        {
            // In this example, if a row total value is less than 2000, 'Low' is displayed instead. 
            // If the value exceeds 6000, 'High' is displayed; otherwise, 'Middle'.
            if (e.RowValueType == FieldValueType.Total ||
                e.ColumnValueType != FieldValueType.Total) return;
            if (Convert.ToSingle(e.Value) < 2000)
                e.DisplayText = "Low";
            else if (Convert.ToSingle(e.Value) > 6000)
                e.DisplayText = "High";
            else
                e.DisplayText = "Middle";
        }
    }
}
