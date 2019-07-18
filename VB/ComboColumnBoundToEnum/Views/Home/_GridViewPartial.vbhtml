@ModelType IEnumerable(Of ComboColumnBoundToEnum.Order)
@Code
    Dim grid = Html.DevExpress().GridView(Of ComboColumnBoundToEnum.Order)(Sub(settings)
                                                                               settings.Name = "GridView1"
                                                                               settings.CallbackRouteValues = New With {Key .Controller = "Home", Key .Action = "GridViewPartial"}

                                                                               settings.KeyFields(Function(m) m.ID)

                                                                               settings.Settings.ShowFilterRow = True
                                                                               settings.Settings.ShowHeaderFilterButton = True
                                                                               settings.Settings.ShowFilterBar = GridViewStatusBarMode.Visible

                                                                               settings.Columns.Add(Function(m) m.ID)
                                                                               settings.Columns.Add(Function(m) m.Status, Sub(column)
                                                                                                                              column.ColumnType = MVCxGridViewColumnType.ComboBox
                                                                                                                              Dim properties = CType(column.PropertiesEdit, ComboBoxProperties)
                                                                                                                              properties.DataSource = [Enum].GetNames(GetType(ComboColumnBoundToEnum.OrderHelper.OrderStatus))
                                                                                                                          End Sub)
                                                                           End Sub)
End Code
@grid.Bind(Model).GetHtml()