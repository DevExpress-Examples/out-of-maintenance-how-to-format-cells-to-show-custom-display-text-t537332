# How to format cells to show custom display text


<p>The following example shows how to provide custom text for the PivotGridControl's cells by handling the <a href="https://documentation.devexpress.com/WPF/DevExpress.Xpf.PivotGrid.PivotGridControl.CustomCellDisplayText.event">PivotGridControl.CustomCellDisplayText</a> event.</p>
<p>In this example, if a <a href="https://documentation.devexpress.com/WPF/8006/Controls-and-Libraries/Pivot-Grid/UI-Elements/Totals">row total value</a> is less than 2000, PivotGridControl displays the 'Low' value instead. If the value exceeds 6000, 'High' is displayed; otherwise, 'Middle'.</p>

<br/>


