Partial Class instituteDataDataSet
    Partial Public Class PaymentTableDataTable
        Private Sub PaymentTableDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.payment_fieldColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class
End Class
