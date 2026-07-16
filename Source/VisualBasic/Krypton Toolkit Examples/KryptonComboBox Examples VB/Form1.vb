#Region "BSD License"
'
' Original BSD 3-Clause License (https://github.com/ComponentFactory/Krypton/blob/master/LICENSE)
'  © Component Factory Pty Ltd, 2006 - 2016, (Version 4.5.0.0) All rights reserved.
'
'  New BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit/blob/master/LICENSE)
'  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV), et al. 2017 - 2024. All rights reserved.
'
' VB.NET twin of Source\Krypton Toolkit Examples\KryptonComboBox Examples\Form1.cs (Bastion Phase 4c).
#End Region

Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms

Imports Krypton.Toolkit

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Setup the property grid to edit this combo box
        propertyGrid.SelectedObject = New KryptonComboBoxProxy(kryptonComboBox1Blue)
    End Sub

    Private Sub kryptonComboBox1Blue_Enter(sender As Object, e As EventArgs) Handles _
        kryptonComboBox1Blue.Enter, kryptonComboBox2Blue.Enter, kryptonComboBox3Blue.Enter,
        kryptonComboBox4System.Enter, kryptonComboBox5System.Enter, kryptonComboBox6System.Enter,
        kryptonComboBox7Custom.Enter, kryptonComboBox8Custom.Enter

        ' Setup the property grid to edit this combo box
        propertyGrid.SelectedObject = New KryptonComboBoxProxy(DirectCast(sender, KryptonComboBox))
    End Sub

    Private Sub buttonSpecAny1_Click(sender As Object, e As EventArgs) Handles buttonSpecAny1.Click
        kryptonComboBox2Blue.Text = String.Empty
        kryptonComboBox2Blue.ComboBox.Focus()
    End Sub

    Private Sub buttonSpecAny2_Click(sender As Object, e As EventArgs) Handles buttonSpecAny2.Click
        kryptonComboBox5System.Text = String.Empty
        kryptonComboBox5System.ComboBox.Focus()
    End Sub

    Private Sub buttonSpecAny3_Click(sender As Object, e As EventArgs) Handles buttonSpecAny3.Click
        If kryptonComboBox8Custom.SelectedIndex > 0 Then
            kryptonComboBox8Custom.SelectedIndex -= 1
            kryptonComboBox8Custom.ComboBox.Focus()
        End If
    End Sub

    Private Sub buttonSpecAny4_Click(sender As Object, e As EventArgs) Handles buttonSpecAny4.Click
        If kryptonComboBox8Custom.SelectedIndex < (kryptonComboBox8Custom.Items.Count - 1) Then
            kryptonComboBox8Custom.SelectedIndex += 1
            kryptonComboBox8Custom.ComboBox.Focus()
        End If
    End Sub

    Private Sub buttonClose_Click(sender As Object, e As EventArgs) Handles buttonClose.Click
        Close()
    End Sub

    Private Sub kryptonComboBox1Blue_DoubleClick(sender As Object, e As EventArgs) Handles kryptonComboBox1Blue.DoubleClick
        InvokeDoubleClick()
    End Sub

    Private Sub InvokeDoubleClick()
        KryptonMessageBox.Show("You've invoked the double click event.", "Double Click",
                               KryptonMessageBoxButtons.OK,
                               KryptonMessageBoxIcon.Information)
    End Sub

    Private Sub kryptonComboBox2Blue_DoubleClick(sender As Object, e As EventArgs) Handles kryptonComboBox2Blue.DoubleClick
        InvokeDoubleClick()
    End Sub

    Private Sub kryptonComboBox4System_DoubleClick(sender As Object, e As EventArgs) Handles kryptonComboBox4System.DoubleClick
        InvokeDoubleClick()
    End Sub

    Private Sub kryptonComboBox5System_DoubleClick(sender As Object, e As EventArgs) Handles kryptonComboBox5System.DoubleClick
        InvokeDoubleClick()
    End Sub

    Private Sub kryptonComboBox6System_DoubleClick(sender As Object, e As EventArgs) Handles kryptonComboBox6System.DoubleClick
        InvokeDoubleClick()
    End Sub

    Private Sub kryptonComboBox7Custom_DoubleClick(sender As Object, e As EventArgs) Handles kryptonComboBox7Custom.DoubleClick
        InvokeDoubleClick()
    End Sub

    Private Sub kryptonComboBox8Custom_DoubleClick(sender As Object, e As EventArgs) Handles kryptonComboBox8Custom.DoubleClick
        InvokeDoubleClick()
    End Sub

End Class

Public Class KryptonComboBoxProxy

    Private _comboBox As KryptonComboBox

    Public Sub New(comboBox As KryptonComboBox)
        _comboBox = comboBox
    End Sub

    <Category("Appearance")>
    <Description("Text for display inside the control.")>
    Public Property Text As String
        Get
            Return _comboBox.Text
        End Get
        Set(value As String)
            _comboBox.Text = value
        End Set
    End Property

    <Category("Visuals")>
    <Description("Determines if the control is always active or only when the mouse is over the control or has focus.")>
    Public Property AlwaysActive As Boolean
        Get
            Return _comboBox.AlwaysActive
        End Get
        Set(value As Boolean)
            _comboBox.AlwaysActive = value
        End Set
    End Property

    <Category("Appearance")>
    <Description("Controls the appearance and functionality of the KryptonComboBox.")>
    Public Property DropDownStyle As ComboBoxStyle
        Get
            Return _comboBox.DropDownStyle
        End Get
        Set(value As ComboBoxStyle)
            _comboBox.DropDownStyle = value
        End Set
    End Property

    <Category("Behavior")>
    <Description("The height, in pixels, of the drop down box in a KryptonComboBox.")>
    Public Property DropDownHeight As Integer
        Get
            Return _comboBox.DropDownHeight
        End Get
        Set(value As Integer)
            _comboBox.DropDownHeight = value
        End Set
    End Property

    <Category("Behavior")>
    <Description("The width, in pixels, of the drop down box in a KryptonComboBox.")>
    Public Property DropDownWidth As Integer
        Get
            Return _comboBox.DropDownWidth
        End Get
        Set(value As Integer)
            _comboBox.DropDownWidth = value
        End Set
    End Property

    <Category("Behavior")>
    <Description("The height, in pixels, of items in an owner-draw KryptomComboBox.")>
    Public Property ItemHeight As Integer
        Get
            Return _comboBox.ItemHeight
        End Get
        Set(value As Integer)
            _comboBox.ItemHeight = value
        End Set
    End Property

    <Category("Behavior")>
    <Description("The maximum number of entries to display in the drop-down list.")>
    Public Property MaxDropDownItems As Integer
        Get
            Return _comboBox.MaxDropDownItems
        End Get
        Set(value As Integer)
            _comboBox.MaxDropDownItems = value
        End Set
    End Property

    <Category("Behavior")>
    <Description("Specifies the maximum number of characters that can be entered into the edit control.")>
    Public Property MaxLength As Integer
        Get
            Return _comboBox.MaxLength
        End Get
        Set(value As Integer)
            _comboBox.MaxLength = value
        End Set
    End Property

    <Category("Behavior")>
    <Description("Specifies whether the items in the list portion of the KryptonComboBox are sorted.")>
    Public Property Sorted As Boolean
        Get
            Return _comboBox.Sorted
        End Get
        Set(value As Boolean)
            _comboBox.Sorted = value
        End Set
    End Property

    <Category("Data")>
    <Description("The items in the KryptonComboBox.")>
    Public ReadOnly Property Items As ComboBox.ObjectCollection
        Get
            Return _comboBox.Items
        End Get
    End Property

    <Category("Visuals")>
    <Description("Input control style.")>
    Public Property InputControlStyle As Krypton.Toolkit.InputControlStyle
        Get
            Return _comboBox.InputControlStyle
        End Get
        Set(value As Krypton.Toolkit.InputControlStyle)
            _comboBox.InputControlStyle = value
        End Set
    End Property

    <Category("Visuals")>
    <Description("DropButton style.")>
    Public Property DropButtonStyle As ButtonStyle
        Get
            Return _comboBox.DropButtonStyle
        End Get
        Set(value As ButtonStyle)
            _comboBox.DropButtonStyle = value
        End Set
    End Property

    <Category("Visuals")>
    <Description("Should tooltips be displayed for button specs.")>
    Public Property AllowButtonSpecToolTips As Boolean
        Get
            Return _comboBox.AllowButtonSpecToolTips
        End Get
        Set(value As Boolean)
            _comboBox.AllowButtonSpecToolTips = value
        End Set
    End Property

    <Category("Visuals")>
    <Description("Collection of button specifications.")>
    Public ReadOnly Property ButtonSpecs As KryptonComboBox.ComboBoxButtonSpecCollection
        Get
            Return _comboBox.ButtonSpecs
        End Get
    End Property

    <Category("Visuals")>
    <Description("Overrides for defining common combobox appearance that other states can override.")>
    Public ReadOnly Property StateCommon As PaletteComboBoxRedirect
        Get
            Return _comboBox.StateCommon
        End Get
    End Property

    <Category("Visuals")>
    <Description("Overrides for defining disabled combobox appearance.")>
    Public ReadOnly Property StateDisabled As PaletteComboBoxStates
        Get
            Return _comboBox.StateDisabled
        End Get
    End Property

    <Category("Visuals")>
    <Description("Overrides for defining normal combobox appearance.")>
    Public ReadOnly Property StateNormal As PaletteComboBoxStates
        Get
            Return _comboBox.StateNormal
        End Get
    End Property

    <Category("Visuals")>
    <Description("Overrides for defining active combobox appearance.")>
    Public ReadOnly Property StateActive As PaletteComboBoxJustComboStates
        Get
            Return _comboBox.StateActive
        End Get
    End Property

    <Category("Layout")>
    <Description("The size of the control is pixels.")>
    Public Property Size As System.Drawing.Size
        Get
            Return _comboBox.Size
        End Get
        Set(value As System.Drawing.Size)
            _comboBox.Size = value
        End Set
    End Property

    <Category("Layout")>
    <Description("The location of the control in pixels.")>
    Public Property Location As Point
        Get
            Return _comboBox.Location
        End Get
        Set(value As Point)
            _comboBox.Location = value
        End Set
    End Property

End Class
