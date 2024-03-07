Imports System.IO
Imports System.Linq.Expressions
Imports System.Runtime.CompilerServices
Imports System.Threading
' Jaden Torres'
'Assignment A5'
'GUI Development CPSC 3118'
'Sources Used: https://www.tutorialspoint.com/vb.net/vb.net_radio_button.htm'


Public Class Form1

    Dim strInput As String 'gather input'
    Dim intInput As Integer 'gather input into int'
    Dim CnSEtool As Decimal = 380 'Comic and Superhero Experience (CnSE) addon'
    Dim CnAtool As Decimal = 275 'Comic and Autographs (CnA) addon'
    Dim Ctool As Decimal = 209 'Comic con (C) addon'
    Dim DecCnSETool As Decimal 'Product of CnSE and temp'
    Dim DecCnATool As Decimal 'Product of CnA and temp'
    Dim DecCTool As Decimal 'Product of C and temp'
    Dim Answer As Decimal 'not used'
    Dim temp As Decimal 'Group size'
    Dim subanswer As Decimal 'subanswer to be sent to finalanswer'
    Dim proc As Decimal 'not used'
    Dim counter As Decimal = 1 'counter to prevent start up glitch with the radio buttons'
    Dim finalanswer As Decimal 'final answer to be outputted'


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load 'loads form'
        GroupSizeBox.ResetText() 'resets group size box'
        CostBox.ResetText() 'resets cost box'
        Ignore.PerformClick() 'auto clicking ignore radio button'
        Ignore.Hide() 'hiding ignore radio button'


    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Title.Click

    End Sub

    Private Sub Clear_Click(sender As Object, e As EventArgs) Handles Clear.Click
        GroupSizeBox.ResetText() 'resets group size box'
        CostBox.ResetText() 'resets cost box'
    End Sub

    Private Sub Calculate_Click(sender As Object, e As EventArgs) Handles Calculate.Click 'calculate button'
        strInput = GroupSizeBox.Text 'gathering input'
        If Integer.TryParse(strInput, intInput) = False And counter = 0 Then 'if statment parsing decimal and if counter = 0'
            MsgBox("Error: Please input a whole number") 'error message pop up'
            GroupSizeBox.ResetText() 'resets group size box'
            CostBox.ResetText() 'resets cost box'
        End If
        temp = 0 'reseting temp'
        temp = intInput 'group box to temp'
        Compute() 'running stat output action'


    End Sub

    Private Sub Compute()
        If proc = 1 Then
            subanswer = 0 'resets subanswer'
            DecCnSETool = Math.Round(CnSEtool * temp) 'calculates cost * number of group memebers'
            subanswer = subanswer + DecCnSETool 'sends answer to subanswer'
        Else
            If proc = 2 Then
                subanswer = 0
                DecCnATool = Math.Round(CnAtool * temp) 'calculates cost * number of group memebers'
                subanswer = subanswer + DecCnATool 'sends answer to subanswer'
            Else
                If proc = 3 Then
                    subanswer = 0
                    DecCTool = Math.Round(Ctool * temp) 'calculates cost * number of group memebers'
                    subanswer = subanswer + DecCTool 'sends answer to subanswer'
                End If
            End If
        End If
        Stat_Output()
    End Sub

    Private Sub Stat_Output() 'stat output action'
        finalanswer = 0 'resets final answer'
        finalanswer = subanswer 'final answer to subanswer'
        CostBox.Text = "$" + finalanswer.ToString() 'formatting and send output toString'

    End Sub

    Private Sub GroupSizeBox_TextChanged(sender As Object, e As EventArgs) Handles GroupSizeBox.TextChanged

    End Sub

    Private Sub CostBox_Enter(sender As Object, e As EventArgs) Handles CostBox.Enter

    End Sub

    Private Sub CnSE_Click(sender As Object, e As EventArgs) Handles CnSE.Click 'CnSE Click action'

        proc = 1


    End Sub

    Private Sub CnA_Click(sender As Object, e As EventArgs) Handles CnA.Click

        proc = 2


    End Sub

    Private Sub C_Click(sender As Object, e As EventArgs) Handles C.Click

        proc = 3



    End Sub

    Private Sub Ignore_CheckedChanged(sender As Object, e As EventArgs) Handles Ignore.CheckedChanged 'I used this action to remove the weird button showing glitch on the radio buttons. start up should show no buttons being clicked'
        Calculate.PerformClick() 'performs calculate for the counter parameter'
        counter = counter - 1 ' removes one from counter making it able to complete the rest of the code'

    End Sub
End Class
