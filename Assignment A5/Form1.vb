Imports System.IO
Imports System.Linq.Expressions
Imports System.Runtime.CompilerServices
Imports System.Threading

Public Class Form1

    Dim strInput As String
    Dim intInput As Integer
    Dim CnSEtool As Decimal = 380
    Dim CnAtool As Decimal = 275
    Dim Ctool As Decimal = 209
    Dim DecCnSETool As Decimal
    Dim DecCnATool As Decimal
    Dim DecCTool As Decimal
    Dim Answer As Decimal
    Dim temp As Decimal
    Dim subanswer As Decimal
    Dim proc As Boolean = False
    Dim counter As Decimal = 1
    Dim finalanswer As Decimal


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GroupSizeBox.ResetText()
        CostBox.ResetText()
        Ignore.PerformClick()
        Ignore.Hide()


    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Title.Click

    End Sub

    Private Sub Clear_Click(sender As Object, e As EventArgs) Handles Clear.Click
        GroupSizeBox.ResetText()
        CostBox.ResetText()
    End Sub

    Private Sub Calculate_Click(sender As Object, e As EventArgs) Handles Calculate.Click
        strInput = GroupSizeBox.Text
        If Integer.TryParse(strInput, intInput) = False And counter = 0 Then
            MsgBox("Error: Please input a whole number")
            GroupSizeBox.ResetText()
            CostBox.ResetText()
        End If
        temp = 0
        temp = intInput
        Stat_Output()


    End Sub

    Private Sub Stat_Output()
        finalanswer = 0
        finalanswer = subanswer
        CostBox.Text = "$" + finalanswer.ToString()

    End Sub

    Private Sub GroupSizeBox_TextChanged(sender As Object, e As EventArgs) Handles GroupSizeBox.TextChanged

    End Sub

    Private Sub CostBox_Enter(sender As Object, e As EventArgs) Handles CostBox.Enter

    End Sub

    Private Sub CnSE_Click(sender As Object, e As EventArgs) Handles CnSE.Click


        subanswer = 0
        DecCnSETool = Math.Round(CnSEtool * temp)
        subanswer = subanswer + DecCnSETool

    End Sub

    Private Sub CnA_Click(sender As Object, e As EventArgs) Handles CnA.Click

        subanswer = 0
        DecCnATool = Math.Round(CnAtool * temp)
        subanswer = subanswer + DecCnATool


    End Sub

    Private Sub C_Click(sender As Object, e As EventArgs) Handles C.Click

        subanswer = 0
        DecCTool = Math.Round(Ctool * temp)
        subanswer = subanswer + DecCTool


    End Sub

    Private Sub Ignore_CheckedChanged(sender As Object, e As EventArgs) Handles Ignore.CheckedChanged
        Calculate.PerformClick()
        counter = counter - 1

    End Sub
End Class
