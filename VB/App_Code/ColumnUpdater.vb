Imports DevExpress.Web
Imports System
Imports System.Collections.Generic
Imports System.Web.UI

Public Class ColumnUpdater
    Private columns As List(Of GridViewColumn)
    Private _grid As ASPxGridView
    Private page As Page
    Private Sub New(ByVal currentGrid As ASPxGridView)
        _grid = currentGrid
        page = _grid.Page
        If page.IsPostBack Then
            Return
        End If
        AddHandler _grid.DataBinding, AddressOf ASPxGridView1_DataBinding
        AddHandler _grid.DataBound, AddressOf ASPxGridView1_DataBound
    End Sub
    Public Shared Sub Initialize(ByVal currentGrid As ASPxGridView)
        Dim TempColumnUpdater As ColumnUpdater = New ColumnUpdater(currentGrid)
    End Sub
    Private Sub ASPxGridView1_DataBinding(ByVal sender As Object, ByVal e As EventArgs)
        SaveColumns()
    End Sub
    Private Sub ASPxGridView1_DataBound(ByVal sender As Object, ByVal e As EventArgs)
        UpdateColumns()
    End Sub
    Private Sub SaveColumns()
        columns = New List(Of GridViewColumn)()
        For i As Integer = 0 To _grid.Columns.Count - 1
            columns.Add(_grid.Columns(i))
        Next i
        _grid.Columns.Clear()
        _grid.AutoGenerateColumns = True
    End Sub
    Private Sub UpdateColumns()
        For Each col As GridViewColumn In columns
            If Not(TypeOf col Is GridViewDataColumn) Then
                _grid.Columns.Add(col)
                Continue For
            End If
            Dim j As Integer = 0
            Do While j < _grid.Columns.Count
                If CType(col, GridViewDataColumn).FieldName <> CType(_grid.Columns(j), GridViewDataColumn).FieldName Then
                    j += 1
                    Continue Do
                End If
                _grid.Columns.RemoveAt(j)
                _grid.Columns.Add(col)
                Exit Do
                j += 1
            Loop
        Next col
    End Sub
End Class