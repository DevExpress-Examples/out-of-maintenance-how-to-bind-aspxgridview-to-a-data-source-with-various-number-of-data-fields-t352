Imports DevExpress.Web
Imports System

Partial Public Class _Default
    Inherits System.Web.UI.Page

    Protected Sub ASPxCallbackPanel1_Callback(ByVal sender As Object, ByVal e As CallbackEventArgsBase)
        ASPxGridView1.ClientVisible = True
    End Sub
    Protected Sub ASPxGridView1_Init(ByVal sender As Object, ByVal e As EventArgs)
        ColumnUpdater.Initialize(DirectCast(sender, ASPxGridView))
    End Sub
    Protected Sub ASPxGridView1_RowUpdating(ByVal sender As Object, ByVal e As DevExpress.Web.Data.ASPxDataUpdatingEventArgs)
        e.Cancel = True
        DirectCast(sender, ASPxGridView).CancelEdit()
        'update is not allowed in online demos
    End Sub
End Class