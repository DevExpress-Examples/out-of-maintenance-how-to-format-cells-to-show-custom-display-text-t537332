<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128578684/17.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T537332)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml.cs](./CS/WpfPivotCustomCellValueDisplaytext/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/VBWpfPivotCustomCellValueDisplaytext/MainWindow.xaml.vb))
<!-- default file list end -->
# How to format cells to show custom display text


<p>The following example shows how to provide custom text for the PivotGridControl's cells by handling the <a href="https://documentation.devexpress.com/WPF/DevExpress.Xpf.PivotGrid.PivotGridControl.CustomCellDisplayText.event">PivotGridControl.CustomCellDisplayText</a> event.</p>
<p>In this example, if a <a href="https://documentation.devexpress.com/WPF/8006/Controls-and-Libraries/Pivot-Grid/UI-Elements/Totals">row total value</a> is less than 2000, PivotGridControl displays the 'Low' value instead. If the value exceeds 6000, 'High' is displayed; otherwise, 'Middle'.</p>

<br/>


