﻿Imports FC.IVM.Bus.Modules
Imports FC.MainApp.Modules
Imports FC.MainWinApp
Imports FC.M.BLL_Util
Imports DevExpress.XtraMap
Imports DevExpress.XtraBars
Imports System.Drawing
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid.Views.Layout
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Columns
Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Layout.Events
Imports System.ComponentModel
Imports FC.M.PSL_Win.Classes_Helper
Imports DevExpress.XtraLayout

Namespace PopupForms
    ''' <summary>Windows form สำหรับอำนวยความสะดวกในการป้อนตัวเลข</summary>
    ''' <remarks>
    '''   <para>ใช้งานในโปรเซส Unload วัตถุดิบ</para>
    ''' </remarks>
    Public Class frm_IVM_Popup_Num_Key
        'Inherits DevExpress.XtraLayout.Customization.UserCustomizationForm
        Inherits System.Windows.Forms.Form
        Implements IChildOfMainForm
        Public Event OnPassData As IChildOfMainForm.OnPassDataEventHandler Implements IChildOfMainForm.OnPassData
        Public Sub OnBeforeFormLoad(param As Object) Implements IChildOfMainForm.OnBeforeFormLoad

        End Sub
        Public Sub OnClickClear(ByRef Optional showMessageType As EnumMainFormShowMessageType = EnumMainFormShowMessageType.None, ByRef Optional customMessage As String = "", ByRef Optional customCaption As String = "") Implements IChildOfMainForm.OnClickClear

        End Sub
        Public Sub OnClickCustomButton(customButtonName As String, ByRef Optional showMessageType As EnumMainFormShowMessageType = EnumMainFormShowMessageType.None, ByRef Optional customMessage As String = "", ByRef Optional customCaption As String = "") Implements IChildOfMainForm.OnClickCustomButton
        End Sub
        Public Sub OnClickReload(ByRef Optional showMessageType As EnumMainFormShowMessageType = EnumMainFormShowMessageType.None, ByRef Optional customMessage As String = "", ByRef Optional customCaption As String = "") Implements IChildOfMainForm.OnClickReload
        End Sub
        Public Sub OnClickSave(ByRef Optional showMessageType As EnumMainFormShowMessageType = EnumMainFormShowMessageType.None, ByRef Optional customMessage As String = "", ByRef Optional customCaption As String = "") Implements IChildOfMainForm.OnClickSave
        End Sub
        Public MatQTY As Decimal = 0
        Private tmpBeginQTY As Decimal = 0

        Sub New()
            InitializeComponent()
            Me.FormBorderStyle = FormBorderStyle.None
        End Sub

        Private Sub frm_IVM_Popup_Num_Key_Load(sender As Object, e As EventArgs) Handles Me.Load
            Try
                txtQTY.EditValue = MatQTY.ToString("##0.0")
                tmpBeginQTY = MatQTY
                txtQTY.Focus()
            Catch ex As Exception

            End Try
        End Sub

        Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
            Try
                tmpUnloadQuantity = CType(txtQTY.EditValue, Decimal)
                isEdit = False
                Me.Close()
            Catch ex As Exception

            End Try
        End Sub
        Private Sub press_num(sender As Object, e As EventArgs) Handles btn9.Click, btn8.Click, btn7.Click, btn6.Click, btn5.Click, btn4.Click, btn3.Click, btn2.Click, btn1.Click, btn0.Click, btnClear.Click, btnP.Click
            Try
                Dim btn As New DevExpress.XtraEditors.SimpleButton
                btn = CType(sender, DevExpress.XtraEditors.SimpleButton)

                If (txtQTY.Text = "0") Then
                    txtQTY.EditValue = String.Empty
                End If

                If (btn.Text = ".") Then

                    If (txtQTY.Text.Contains(".") = False) Then
                        txtQTY.Text &= btn.Text
                    End If

                ElseIf (btn.Text = "C") Then
                    txtQTY.EditValue = CDbl(0).ToString
                ElseIf (isEdit = True) Then
                    txtQTY.EditValue = CType(txtQTY.EditValue, String) & btn.Text
                    txtQTY.Focus()
                Else
                    txtQTY.EditValue = btn.Text
                    txtQTY.Focus()
                    isEdit = True
                End If
                btnUpdate.Focus()
            Catch ex As Exception
                MsgBox("press_num" & ex.Message)
            Finally

            End Try
        End Sub
        Private Sub frm_IVM_Popup_Num_Key_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
            isEdit = False
        End Sub
        Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
            isEdit = False
            tmpUnloadQuantity = tmpBeginQTY
            Me.Close()
        End Sub

        Private Sub txtQTY_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtQTY.Validating
            Try
                Dim QTY As Decimal = CDec(CType(sender, DevExpress.XtraEditors.TextEdit).EditValue)
                If (QTY <= 0) Then e.Cancel = True
            Catch ex As Exception
                MsgBox("txtQTY_Validating : " & ex.Message)
            End Try
        End Sub

        Private Sub txtQTY_InvalidValue(sender As Object, e As InvalidValueExceptionEventArgs) Handles txtQTY.InvalidValue
            WinUtil.ShowErrorBox("จำนวนวัตถุดิบที่แก้ไข ต้องมีจำนวน มากกว่า 0 !", "ผิดพลาด")
            isEdit = False
            e.ExceptionMode = ExceptionMode.Ignore
        End Sub

    End Class
End Namespace