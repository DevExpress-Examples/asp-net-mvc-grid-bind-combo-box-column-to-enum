Imports DevExpress.Web.Mvc
Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult
        Return View()
    End Function

    <ValidateInput(False)>
    Public Function GridViewPartial() As ActionResult
        Return PartialView("_GridViewPartial", OrderHelper.GetOrders())
    End Function
End Class