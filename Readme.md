<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/147419099/17.1.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T830525)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
# Grid View for ASP.NET MVC - How to bind a combo box column to Enum

This example demonstrates how to use the `Enum.GetNames` method to bind a combo box column to **Enum**.

![Bind combo box column to Enum](bindToEnum.png)

## Overview

Create a combo box column and call the [Enum.GetNames](https://docs.microsoft.com/en-us/dotnet/api/system.enum.getnames?view=netframework-4.7.2) method to generate combo box items based on custom Enum items.

```csharp
settings.Columns.Add(m => m.Status, column => {
    column.ColumnType = MVCxGridViewColumnType.ComboBox;
    var comboBoxProperties = (ComboBoxProperties)column.PropertiesEdit;
    comboBoxProperties.DataSource = Enum.GetNames(typeof(ComboBoxColumnBoundToEnum.Models.OrderHelper.OrderStatus));
});
```

## Files to Review

* [_GridViewPartial.cshtml](./CS/ComboBoxColumnBoundToEnum/Views/Home/_GridViewPartial.cshtml) (VB: [_GridViewPartial.vbhtml](./VB/ComboColumnBoundToEnum/Views/Home/_GridViewPartial.vbhtml))
* [Order.cs](./CS/ComboBoxColumnBoundToEnum/Models/Order.cs) (VB: [Order.vb](./VB/ComboColumnBoundToEnum/Models/Order.vb))
