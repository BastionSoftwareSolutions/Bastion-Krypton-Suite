' ****************************************************************************
'
'  © Component Factory Pty Ltd, 2006 - 2016. All rights reserved.
'	The software and associated documentation supplied hereunder are the
'  proprietary information of Component Factory Pty Ltd, PO Box 1504,
'  Glen Waverley, Vic 3150, Australia and are supplied subject to licence terms.
'  Version 4.5.0.0  www.ComponentFactory.com
'
'  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV) 2017 - 2024. All rights reserved. (https://github.com/Krypton-Suite/Standard-Toolkit)
'
' *****************************************************************************
' VB.NET twin of Source\Krypton Toolkit Examples\KryptonBreadCrumb Examples\Form1.cs (Bastion Phase 4c).

Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports System.ComponentModel
Imports System.Collections.Generic
Imports Krypton.Toolkit

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        kryptonBreadCrumb1.SelectedItem = kryptonBreadCrumb1.RootItem.Items(0).Items(0).Items(1).Items(1)
        kryptonBreadCrumb2.SelectedItem = kryptonBreadCrumb2.RootItem.Items(0).Items(1).Items(1)
        kryptonBreadCrumb3.SelectedItem = kryptonBreadCrumb3.RootItem.Items(1).Items(0)
        kryptonBreadCrumb4.SelectedItem = kryptonBreadCrumb4.RootItem

        ' Setup the property grid to edit this bread crumb
        propertyGrid.SelectedObject = New KryptonBreadCrumbProxy(kryptonBreadCrumb1)
    End Sub

    Private Sub breadCrumb_MouseDown(sender As Object, e As MouseEventArgs) Handles _
        kryptonBreadCrumb1.MouseDown, kryptonBreadCrumb2.MouseDown, kryptonBreadCrumb3.MouseDown, kryptonBreadCrumb4.MouseDown

        ' Setup the property grid to edit this bread crumb
        propertyGrid.SelectedObject = New KryptonBreadCrumbProxy(DirectCast(sender, KryptonBreadCrumb))
    End Sub

    Private Sub buttonSpecAny1_Click(sender As Object, e As EventArgs) Handles buttonSpecAny1.Click
        kryptonBreadCrumb2.SelectedItem = kryptonBreadCrumb2.RootItem
    End Sub

    Private Sub menuSpider_Click(sender As Object, e As EventArgs) Handles menuSpider.Click
        kryptonBreadCrumb3.SelectedItem = kryptonBreadCrumb3.RootItem.Items(0).Items(1).Items(2).Items(1)
    End Sub

    Private Sub menuKangeroo_Click(sender As Object, e As EventArgs) Handles menuKangeroo.Click
        kryptonBreadCrumb3.SelectedItem = kryptonBreadCrumb3.RootItem.Items(0).Items(0).Items(2).Items(2)
    End Sub

    Private Sub menuFern_Click(sender As Object, e As EventArgs) Handles menuFern.Click
        kryptonBreadCrumb3.SelectedItem = kryptonBreadCrumb3.RootItem.Items(1).Items(0).Items(0)
    End Sub

    Private Sub treeView1_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles treeView1.AfterSelect
        Dim indexes As New Stack(Of Integer)()

        ' Walk up the tree and stack the node indexes as we go
        Dim node As TreeNode = e.Node
        While node IsNot Nothing AndAlso node.Parent IsNot Nothing
            indexes.Push(node.Index)
            node = node.Parent
        End While

        ' Start with the root crumb
        Dim crumb As KryptonBreadCrumbItem = kryptonBreadCrumb4.RootItem

        ' Walk down the matching path of the bread crumb trail
        While indexes.Count > 0
            crumb = crumb.Items(indexes.Pop())
        End While

        kryptonBreadCrumb4.SelectedItem = crumb
    End Sub

    Private Sub kryptonBreadCrumb4_SelectedItemChanged(sender As Object, e As EventArgs) Handles kryptonBreadCrumb4.SelectedItemChanged
        Dim indexes As New Stack(Of Integer)()

        ' Walk up the tree and stack the crumb indexes as we go
        Dim crumb As KryptonBreadCrumbItem = kryptonBreadCrumb4.SelectedItem
        While crumb IsNot Nothing AndAlso crumb.Parent IsNot Nothing
            indexes.Push(crumb.Parent.Items.IndexOf(crumb))
            crumb = crumb.Parent
        End While

        ' Start with the rot node
        Dim node As TreeNode = treeView1.Nodes(0)

        ' Walk down the matching path of the node
        While indexes.Count > 0
            node = node.Nodes(indexes.Pop())
        End While

        treeView1.SelectedNode = node
    End Sub

    Private Sub buttonClose_Click(sender As Object, e As EventArgs) Handles buttonClose.Click
        Close()
    End Sub

End Class

Public Class KryptonBreadCrumbProxy

    Private _breadCrumb As KryptonBreadCrumb

    Public Sub New(breadCrumb As KryptonBreadCrumb)
        _breadCrumb = breadCrumb
    End Sub

    <Category("Visuals")>
    <Description("Palette applied to drawing.")>
    <DefaultValue(Krypton.Toolkit.PaletteMode.Global)>
    Public Property PaletteMode As Krypton.Toolkit.PaletteMode
        Get
            Return _breadCrumb.PaletteMode
        End Get
        Set(value As Krypton.Toolkit.PaletteMode)
            _breadCrumb.PaletteMode = value
        End Set
    End Property

    <Category("Layout")>
    <Description("Specifies whether a control will automatically size itself to fit its contents.")>
    Public Property AutoSize As Boolean
        Get
            Return _breadCrumb.AutoSize
        End Get
        Set(value As Boolean)
            _breadCrumb.AutoSize = value
        End Set
    End Property

    <Category("Layout")>
    <Description("Specifies if the control grows and shrinks to fit the contents exactly.")>
    Public Property AutoSizeMode As System.Windows.Forms.AutoSizeMode
        Get
            Return _breadCrumb.AutoSizeMode
        End Get
        Set(value As System.Windows.Forms.AutoSizeMode)
            _breadCrumb.AutoSizeMode = value
        End Set
    End Property

    <Category("Layout")>
    <Description("The size of the control is pixels.")>
    Public Property Size As System.Drawing.Size
        Get
            Return _breadCrumb.Size
        End Get
        Set(value As System.Drawing.Size)
            _breadCrumb.Size = value
        End Set
    End Property

    <Category("Layout")>
    <Description("The location of the control in pixels.")>
    Public Property Location As Point
        Get
            Return _breadCrumb.Location
        End Get
        Set(value As Point)
            _breadCrumb.Location = value
        End Set
    End Property

    <Category("Behavior")>
    <Description("Indicates whether the control is enabled.")>
    Public Property Enabled As Boolean
        Get
            Return _breadCrumb.Enabled
        End Get
        Set(value As Boolean)
            _breadCrumb.Enabled = value
        End Set
    End Property

    <Category("Visuals")>
    <Description("Collection of button specifications.")>
    Public ReadOnly Property ButtonSpecs As KryptonBreadCrumb.BreadCrumbButtonSpecCollection
        Get
            Return _breadCrumb.ButtonSpecs
        End Get
    End Property

    <Category("Visuals")>
    <Description("Should drop down buttons allow navigation to children.")>
    Public Property DropDownNavigation As Boolean
        Get
            Return _breadCrumb.DropDownNavigation
        End Get
        Set(value As Boolean)
            _breadCrumb.DropDownNavigation = value
        End Set
    End Property

    <Category("Visuals")>
    <Description("Should tooltips be displayed for button specs.")>
    Public Property AllowButtonSpecToolTips As Boolean
        Get
            Return _breadCrumb.AllowButtonSpecToolTips
        End Get
        Set(value As Boolean)
            _breadCrumb.AllowButtonSpecToolTips = value
        End Set
    End Property

    <Category("Visuals")>
    <Description("Background style for the control.")>
    Public Property ControlBackStyle As PaletteBackStyle
        Get
            Return _breadCrumb.ControlBackStyle
        End Get
        Set(value As PaletteBackStyle)
            _breadCrumb.ControlBackStyle = value
        End Set
    End Property

    <Category("Visuals")>
    <Description("Button style used for drawing each bread crumb.")>
    Public Property CrumbButtonStyle As ButtonStyle
        Get
            Return _breadCrumb.CrumbButtonStyle
        End Get
        Set(value As ButtonStyle)
            _breadCrumb.CrumbButtonStyle = value
        End Set
    End Property

    <Category("Visuals")>
    <Description("Border style for the control.")>
    Public Property ControlBorderStyle As PaletteBorderStyle
        Get
            Return _breadCrumb.ControlBorderStyle
        End Get
        Set(value As PaletteBorderStyle)
            _breadCrumb.ControlBorderStyle = value
        End Set
    End Property

    <Category("Data")>
    <Description("Root bread crumb item.")>
    Public ReadOnly Property RootItem As KryptonBreadCrumbItem
        Get
            Return _breadCrumb.RootItem
        End Get
    End Property

    <Category("Visuals")>
    <Description("Overrides for defining common bread crumb appearance that other states can override.")>
    Public ReadOnly Property StateCommon As PaletteDoubleMetricRedirect
        Get
            Return _breadCrumb.StateCommon
        End Get
    End Property

    <Category("Visuals")>
    <Description("Overrides for defining disabled appearance.")>
    Public ReadOnly Property StateDisabled As PaletteBreadCrumbDoubleState
        Get
            Return _breadCrumb.StateDisabled
        End Get
    End Property

    <Category("Visuals")>
    <Description("Overrides for defining normal appearance.")>
    Public ReadOnly Property StateNormal As PaletteBreadCrumbDoubleState
        Get
            Return _breadCrumb.StateNormal
        End Get
    End Property

    <Category("Visuals")>
    <Description("Overrides for defining tracking bread crumb appearance.")>
    Public ReadOnly Property StateTracking As PaletteBreadCrumbState
        Get
            Return _breadCrumb.StateTracking
        End Get
    End Property

    <Category("Visuals")>
    <Description("Overrides for defining pressed bread crumb appearance.")>
    Public ReadOnly Property StatePressed As PaletteBreadCrumbState
        Get
            Return _breadCrumb.StatePressed
        End Get
    End Property

End Class
