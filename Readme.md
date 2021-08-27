<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/147419099/17.1.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T830525)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
# GridView - How to bind a combo box column to Enum
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/147419099/)**
<!-- run online end -->

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
