# GridView - How to bind a combo box column to Enum

*Files to look at:*
* CS
	* [_GridViewPartial.cshtml](https://github.com/DevExpress-Examples/GridView-How-to-bind-a-combo-box-column-to-Enum/blob/17.1.2%2B/CS/ComboBoxColumnBoundToEnum/Views/Home/_GridViewPartial.cshtml)
	* [Order.cs](https://github.com/DevExpress-Examples/GridView-How-to-bind-a-combo-box-column-to-Enum/blob/17.1.2%2B/CS/ComboBoxColumnBoundToEnum/Models/Order.cs)
* VB
	* [_GridViewPartial.vbhtml](https://github.com/DevExpress-Examples/GridView-How-to-bind-a-combo-box-column-to-Enum/blob/17.1.2%2B/VB/ComboColumnBoundToEnum/Views/Home/_GridViewPartial.vbhtml)
	* [Order.vb](https://github.com/DevExpress-Examples/GridView-How-to-bind-a-combo-box-column-to-Enum/blob/17.1.2%2B/VB/ComboColumnBoundToEnum/Models/Order.vb)

This example illustrates how to bind a combo box column to **Enum** using the [Enum.GetNames](https://docs.microsoft.com/en-us/dotnet/api/system.enum.getnames?view=netframework-4.7.2) method:
```csharp
settings.Columns.Add(m => m.Status, column =>
{
	column.ColumnType = MVCxGridViewColumnType.ComboBox;
	var comboBoxProperties = (ComboBoxProperties)column.PropertiesEdit;
	comboBoxProperties.DataSource = Enum.GetNames(typeof(ComboBoxColumnBoundToEnum.Models.OrderHelper.OrderStatus));
});
```
```vbnet
settings.Columns.Add(Function(m) m.Status, Sub(column)
		column.ColumnType = MVCxGridViewColumnType.ComboBox
		Dim properties = CType(column.PropertiesEdit, ComboBoxProperties)
		properties.DataSource = [Enum].GetNames(GetType(ComboColumnBoundToEnum.OrderHelper.OrderStatus))
	End Sub)
```