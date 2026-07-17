#Region "BSD License"
'
' Original BSD 3-Clause License (https://github.com/ComponentFactory/Krypton/blob/master/LICENSE)
'  © Component Factory Pty Ltd, 2006 - 2016, (Version 4.5.0.0) All rights reserved.
'
'  New BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit/blob/master/LICENSE)
'  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV), tobitege et al. 2017 - 2025. All rights reserved.
'
' VB.NET twin of Source\Krypton Toolkit Examples\Expanding HeaderGroups (Splitters)\Form1.cs (Bastion Phase 4c).
#End Region

Imports System
Imports System.Windows.Forms

Imports Krypton.Toolkit

Public Class Form1

    Private _heightUpDown As Integer
    Private _widthLeftRight As Integer

    Public Sub New()
        InitializeComponent()

        ' Hook into the click events on the header buttons
        AddHandler kryptonHeaderGroupRightBottom.ButtonSpecs(0).Click, AddressOf OnUpDown
        AddHandler kryptonHeaderGroupLeft.ButtonSpecs(0).Click, AddressOf OnLeftRight
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set position of caret in the text boxes, so it looks nicer at runtime!
        textBoxLeft.SelectionStart = 0
        textBoxRightTop.SelectionStart = 0
        textBoxRightBottom.SelectionStart = 0
        textBoxLeft.SelectionLength = 0
        textBoxRightTop.SelectionLength = 0
        textBoxRightBottom.SelectionLength = 0
    End Sub

    Private Sub OnUpDown(sender As Object, e As EventArgs)
        ' Suspend layout changes until all splitter properties have been updated
        kryptonSplitContainerVertical.SuspendLayout()

        ' Is the bottom right header group currently expanded?
        If kryptonSplitContainerVertical.FixedPanel = FixedPanel.None Then
            ' Make the bottom panel of the splitter fixed in size
            kryptonSplitContainerVertical.FixedPanel = FixedPanel.Panel2
            kryptonSplitContainerVertical.IsSplitterFixed = True

            ' Remember the current height of the header group (to restore later)
            _heightUpDown = kryptonHeaderGroupRightBottom.Height

            ' Find the new height to use for the header group
            Dim newHeight As Integer = kryptonHeaderGroupRightBottom.PreferredSize.Height

            ' Make the header group fixed to the new height
            kryptonSplitContainerVertical.Panel2MinSize = newHeight
            kryptonSplitContainerVertical.SplitterDistance = kryptonSplitContainerVertical.Height
        Else
            ' Make the bottom panel not-fixed in size anymore
            kryptonSplitContainerVertical.FixedPanel = FixedPanel.None
            kryptonSplitContainerVertical.IsSplitterFixed = False

            ' Put back the minimise size to the original
            kryptonSplitContainerVertical.Panel2MinSize = 100

            ' Calculate the correct splitter we want to put back
            kryptonSplitContainerVertical.SplitterDistance = kryptonSplitContainerVertical.Height - _heightUpDown - kryptonSplitContainerVertical.SplitterWidth
        End If

        kryptonSplitContainerVertical.ResumeLayout()
    End Sub

    Private Sub OnLeftRight(sender As Object, e As EventArgs)
        ' Suspend layout changes until all splitter properties have been updated
        kryptonSplitContainerHorizontal.SuspendLayout()

        ' Is the left header group currently expanded?
        If kryptonSplitContainerHorizontal.FixedPanel = FixedPanel.None Then
            ' Make the left panel of the splitter fixed in size
            kryptonSplitContainerHorizontal.FixedPanel = FixedPanel.Panel1
            kryptonSplitContainerHorizontal.IsSplitterFixed = True

            ' Remember the current height of the header group
            _widthLeftRight = kryptonHeaderGroupLeft.Width

            ' We have not changed the orientation of the header yet, so the width of
            ' the splitter panel is going to be the height of the collapsed header group
            Dim newWidth As Integer = kryptonHeaderGroupLeft.PreferredSize.Height

            ' Make the header group fixed just as the new height
            kryptonSplitContainerHorizontal.Panel1MinSize = newWidth
            kryptonSplitContainerHorizontal.SplitterDistance = newWidth

            ' Change header to be vertical and button to near edge
            kryptonHeaderGroupLeft.HeaderPositionPrimary = VisualOrientation.Right
            kryptonHeaderGroupLeft.ButtonSpecs(0).Edge = PaletteRelativeEdgeAlign.Near
        Else
            ' Make the bottom panel not-fixed in size anymore
            kryptonSplitContainerHorizontal.FixedPanel = FixedPanel.None
            kryptonSplitContainerHorizontal.IsSplitterFixed = False

            ' Put back the minimise size to the original
            kryptonSplitContainerHorizontal.Panel1MinSize = 100

            ' Calculate the correct splitter we want to put back
            kryptonSplitContainerHorizontal.SplitterDistance = _widthLeftRight

            ' Change header to be horizontal and button to far edge
            kryptonHeaderGroupLeft.HeaderPositionPrimary = VisualOrientation.Top
            kryptonHeaderGroupLeft.ButtonSpecs(0).Edge = PaletteRelativeEdgeAlign.Far
        End If

        kryptonSplitContainerHorizontal.ResumeLayout()
    End Sub

    Private Sub UpdateCollapsedSizing()
        ' Is the bottom right header group currently collapsed?
        If kryptonSplitContainerVertical.FixedPanel = FixedPanel.Panel2 Then
            ' Suspend layout changes until all splitter properties have been updated
            kryptonSplitContainerHorizontal.SuspendLayout()

            ' Get the new preferred height of the header group and apply it
            Dim newHeight As Integer = kryptonHeaderGroupRightBottom.PreferredSize.Height
            kryptonSplitContainerVertical.Panel2MinSize = newHeight
            kryptonSplitContainerVertical.SplitterDistance = kryptonSplitContainerVertical.Height

            kryptonSplitContainerHorizontal.ResumeLayout()
        End If

        ' Is the left header group currently collapsed?
        If kryptonSplitContainerHorizontal.FixedPanel = FixedPanel.Panel1 Then
            ' Suspend layout changes until all splitter properties have been updated
            kryptonSplitContainerVertical.SuspendLayout()

            ' Get the new preferred width of the header group and apply it
            Dim newWidth As Integer = kryptonHeaderGroupLeft.PreferredSize.Width
            kryptonSplitContainerHorizontal.Panel1MinSize = newWidth
            kryptonSplitContainerHorizontal.SplitterDistance = newWidth

            kryptonSplitContainerVertical.ResumeLayout()
        End If
    End Sub

    Private Sub toolOffice2010_Click(sender As Object, e As EventArgs) Handles toolOffice2010.Click, menuOffice2010.Click
        If Not toolOffice2010.Checked Then
            kryptonManager.GlobalPaletteMode = PaletteMode.Office2010Blue
            toolOffice2010.Checked = True : menuOffice2010.Checked = True
            toolOffice2007.Checked = False : menuOffice2007.Checked = False
            toolSystem.Checked = False : menuSystem.Checked = False
            toolSparkle.Checked = False : menuSparkle.Checked = False
            UpdateCollapsedSizing()
        End If
    End Sub

    Private Sub toolOffice2007_Click(sender As Object, e As EventArgs) Handles toolOffice2007.Click, menuOffice2007.Click
        If Not toolOffice2007.Checked Then
            kryptonManager.GlobalPaletteMode = PaletteMode.Office2007Blue
            toolOffice2010.Checked = False : menuOffice2010.Checked = False
            toolOffice2007.Checked = True : menuOffice2007.Checked = True
            toolSystem.Checked = False : menuSystem.Checked = False
            toolSparkle.Checked = False : menuSparkle.Checked = False
            UpdateCollapsedSizing()
        End If
    End Sub

    Private Sub toolSystem_Click(sender As Object, e As EventArgs) Handles toolSystem.Click, menuSystem.Click
        If Not toolSystem.Checked Then
            kryptonManager.GlobalPaletteMode = PaletteMode.ProfessionalSystem
            toolOffice2010.Checked = False : menuOffice2010.Checked = False
            toolOffice2007.Checked = False : menuOffice2007.Checked = False
            toolSystem.Checked = True : menuSystem.Checked = True
            toolSparkle.Checked = False : menuSparkle.Checked = False
            UpdateCollapsedSizing()
        End If
    End Sub

    Private Sub toolSparkle_Click(sender As Object, e As EventArgs) Handles toolSparkle.Click, menuSparkle.Click
        If Not toolSparkle.Checked Then
            kryptonManager.GlobalPaletteMode = PaletteMode.SparkleBlue
            toolOffice2010.Checked = False : menuOffice2010.Checked = False
            toolOffice2007.Checked = False : menuOffice2007.Checked = False
            toolSystem.Checked = False : menuSystem.Checked = False
            toolSparkle.Checked = True : menuSparkle.Checked = True
            UpdateCollapsedSizing()
        End If
    End Sub

    Private Sub exitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles exitToolStripMenuItem.Click
        Close()
    End Sub

End Class
