' Name:         Total Cookie Sales Project
' Purpose:      Display the total number of boxes of each cookie type sold.
' Programmer:   Austin Parker June 5, 2020

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CookieSalesDataSet.Sales' table. You can move, or remove it, as needed.
        Me.SalesTableAdapter.Fill(Me.CookieSalesDataSet.Sales)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_Celd(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellStyleChanged

    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click

        'Declared variables'
        Dim chocolateTotal As Double
        Dim peanutButterTotal As Double
        Dim pecanTotal As Double

        'For statements to calculate and store values in chocolateTotal'
        For i As Integer = 0 To DataGridView1.RowCount - 1
            chocolateTotal += Val(DataGridView1.Rows(i).Cells(1).Value)
        Next
        'Displays total'
        lblChocolate.Text = chocolateTotal.ToString()

        'For statements to calculate and store values in peanutButterTotal'
        For i As Integer = 0 To DataGridView1.RowCount - 1
            peanutButterTotal += Val(DataGridView1.Rows(i).Cells(2).Value)
        Next
        'Displays total'
        lblPeanut.Text = peanutButterTotal.ToString()

        'For statements to calculate and store values in pecanTotal'
        For i As Integer = 0 To DataGridView1.RowCount - 1
            pecanTotal += Val(DataGridView1.Rows(i).Cells(3).Value)
        Next
        'Displays total'
        lblPecan.Text = pecanTotal.ToString()

    End Sub

    Private Sub lblChocolate_Click(sender As Object, e As EventArgs) Handles lblChocolate.Click

    End Sub

    Private Sub lblPeanut_Click(sender As Object, e As EventArgs) Handles lblPeanut.Click

    End Sub

    Private Sub lblPecan_Click(sender As Object, e As EventArgs) Handles lblPecan.Click

    End Sub
End Class
