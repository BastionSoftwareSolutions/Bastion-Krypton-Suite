#Region "BSD License"
'
' Original BSD 3-Clause License (https://github.com/ComponentFactory/Krypton/blob/master/LICENSE)
'  © Component Factory Pty Ltd, 2006 - 2016, (Version 4.5.0.0) All rights reserved.
'
'  New BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit/blob/master/LICENSE)
'  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV), et al. 2017 - 2024. All rights reserved.
'
' VB.NET twin of Source\Krypton Toolkit Examples\Three Pane Application (Extended)\Form1.cs (Bastion Phase 4c).
#End Region

Imports System.Drawing
Imports System.Windows.Forms

Imports Krypton.Toolkit

Public Class Form1

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Appointments
        dataTable.Rows.Add("Julius Ceaser", "End of career review for roman work", "Leadership skills are exceptional." & vbLf & "Good work suppressing the Gauls." & vbLf & "Tends to make political enemies." & vbLf & "Sticky end predicted.", "Appointments", "Staff reviews", True)
        dataTable.Rows.Add("Winston Churchhill", "End of war review for military campaign", "Very popular with the common people." & vbLf & "Tends towards being stubborn." & vbLf & "Easy going after two whiskys." & vbLf & "Reward with box of good cigars." & vbLf & "Too old for new projects.", "Appointments", "Staff reviews", False)
        dataTable.Rows.Add("Ghengis Khan", "End of year appraisal", "Good with animals." & vbLf & "Tends towards violent outbursts." & vbLf & "Could do better.", "Appointments", "Staff reviews", False)
        dataTable.Rows.Add("Steve Jobs", "Interview for position as junior tester", "Enjoys working with shiny objects." & vbLf & "Prefers working in white rooms." & vbLf & "Easily distracted by noises." & vbLf & "Rejected", "Appointments", "Job interviews", True)
        dataTable.Rows.Add("Larry Ellison", "Interview for marketing position", "Likes large marketing budgets." & vbLf & "Spends all budget on new plane." & vbLf & "Last heard he was in Hawaii." & vbLf & "Rejected", "Appointments", "Job interviews", False)
        dataTable.Rows.Add("Project Orcas", "Milestone review of work completed", "Project currently on target." & vbLf & "Need to improve average." & vbLf & "Must order new project mugs.", "Appointments", "Project meetings", True)
        dataTable.Rows.Add("Project Zebra", "Kick off meeting for Mac OS work", "Project in stealth mode." & vbLf & "Ensure official name is more sexy.", "Appointments", "Project meetings", True)

        ' Employees
        dataTable.Rows.Add("Holly Hunter", "Secretary", "New member of staff." & vbLf & "Very quick typist." & vbLf & "Just one task at a time.", "Employees", "Administration", False)
        dataTable.Rows.Add("Paula Abdul", "Meet and greet", "Good singing voice." & vbLf & "Keep away from accounts.", "Employees", "Administration", True)
        dataTable.Rows.Add("Zak Wolfson", "Junior developer", "Good degree from MIT." & vbLf & "Irrational need to use Linux." & vbLf & "Good when closely supervised.", "Employees", "Programmers", False)
        dataTable.Rows.Add("Simon Cowell", "Senior architect", "Poor understanding of concepts." & vbLf & "Poor mentoring of junior staff." & vbLf & "Looks good on television." & vbLf & "Fire at first opportunity.", "Employees", "Programmers", True)
        dataTable.Rows.Add("Peter Andre", "President", "Always appears at press conferences." & vbLf & "Picture of cover of accounts." & vbLf & "Drives a nice car." & vbLf & "Complete egomaniac.", "Employees", "Managers", False)

        ' Use the filtered view of the data table
        kryptonDataGridView.DataMember = String.Empty
        kryptonDataGridView.DataSource = dataTable.DefaultView

        ' Set correct initial checked button
        If KryptonManager.CurrentGlobalPalette Is KryptonManager.PaletteOffice2007Black Then
            toolStripOffice2007Black_Click(Me, EventArgs.Empty)
        End If

        ' Expand all the nodes to show entire tree structure
        For Each n As TreeNode In treeView.Nodes
            n.ExpandAll()
        Next

        ' Hook into the up and down buttons on the details heading
        ' (dynamic wiring, mirroring the C# twin)
        AddHandler kryptonHeaderGroupDetails.ButtonSpecs(0).Click, AddressOf OnPrevious
        AddHandler kryptonHeaderGroupDetails.ButtonSpecs(1).Click, AddressOf OnNext
    End Sub

    Private Sub Form1_SystemColorsChanged(sender As Object, e As EventArgs) Handles MyBase.SystemColorsChanged
        ' If the system colors change that might change the palette background
        ' if the palette is calculating it from the system colors and so update
        ' the control colors just in case.
        UpdateOnPaletteChanged()
    End Sub

    Private Sub toolStripLoadPalette_Click(sender As Object, e As EventArgs) Handles toolStripLoadPalette.Click
        loadPaletteToolStripMenuItem_Click(Me, EventArgs.Empty)
    End Sub

    Private Sub toolStripOffice2010Blue_Click(sender As Object, e As EventArgs) Handles toolStripOffice2010Blue.Click, office2010BlueToolStripMenuItem.Click
        If Not toolStripOffice2010Blue.Checked Then
            kryptonManager.GlobalPaletteMode = PaletteMode.Office2010Blue
            office2010BlueToolStripMenuItem.Checked = True
            toolStripOffice2010Blue.Checked = True
            office2010SilverToolStripMenuItem.Checked = False
            toolStripOffice2010Silver.Checked = False
            office2010BlackToolStripMenuItem.Checked = False
            toolStripOffice2010Black.Checked = False
            office2007BlueToolStripMenuItem.Checked = False
            toolStripOffice2007Blue.Checked = False
            office2007SilverToolStripMenuItem.Checked = False
            toolStripOffice2007Silver.Checked = False
            office2007BlackToolStripMenuItem.Checked = False
            toolStripOffice2007Black.Checked = False
            sparkleBlueToolStripMenuItem.Checked = False
            toolStripSparkleBlue.Checked = False
            sparkleOrangeToolStripMenuItem.Checked = False
            toolStripSparkleOrange.Checked = False
            sparklePurpleToolStripMenuItem.Checked = False
            toolStripSparklePurple.Checked = False
            systemToolStripMenuItem.Checked = False
            toolStripSystem.Checked = False
            customToolStripMenuItem.Checked = False
            toolStripCustom.Checked = False
            UpdateOnPaletteChanged()
        End If
    End Sub

    Private Sub toolStripOffice2010Silver_Click(sender As Object, e As EventArgs) Handles toolStripOffice2010Silver.Click, office2010SilverToolStripMenuItem.Click
        If Not toolStripOffice2010Silver.Checked Then
            kryptonManager.GlobalPaletteMode = PaletteMode.Office2010Silver
            office2010BlueToolStripMenuItem.Checked = False
            toolStripOffice2010Blue.Checked = False
            office2010SilverToolStripMenuItem.Checked = True
            toolStripOffice2010Silver.Checked = True
            office2010BlackToolStripMenuItem.Checked = False
            toolStripOffice2010Black.Checked = False
            office2007BlueToolStripMenuItem.Checked = False
            toolStripOffice2007Blue.Checked = False
            office2007SilverToolStripMenuItem.Checked = False
            toolStripOffice2007Silver.Checked = False
            office2007BlackToolStripMenuItem.Checked = False
            toolStripOffice2007Black.Checked = False
            sparkleBlueToolStripMenuItem.Checked = False
            toolStripSparkleBlue.Checked = False
            sparkleOrangeToolStripMenuItem.Checked = False
            toolStripSparkleOrange.Checked = False
            sparklePurpleToolStripMenuItem.Checked = False
            toolStripSparklePurple.Checked = False
            systemToolStripMenuItem.Checked = False
            toolStripSystem.Checked = False
            customToolStripMenuItem.Checked = False
            toolStripCustom.Checked = False
            UpdateOnPaletteChanged()
        End If
    End Sub

    Private Sub toolStripOffice2010Black_Click(sender As Object, e As EventArgs) Handles toolStripOffice2010Black.Click, office2010BlackToolStripMenuItem.Click
        If Not toolStripOffice2010Black.Checked Then
            kryptonManager.GlobalPaletteMode = PaletteMode.Office2010Black
            office2010BlueToolStripMenuItem.Checked = False
            toolStripOffice2010Blue.Checked = False
            office2010SilverToolStripMenuItem.Checked = False
            toolStripOffice2010Silver.Checked = False
            office2010BlackToolStripMenuItem.Checked = True
            toolStripOffice2010Black.Checked = True
            office2007BlueToolStripMenuItem.Checked = False
            toolStripOffice2007Blue.Checked = False
            office2007SilverToolStripMenuItem.Checked = False
            toolStripOffice2007Silver.Checked = False
            office2007BlackToolStripMenuItem.Checked = False
            toolStripOffice2007Black.Checked = False
            sparkleBlueToolStripMenuItem.Checked = False
            toolStripSparkleBlue.Checked = False
            sparkleOrangeToolStripMenuItem.Checked = False
            toolStripSparkleOrange.Checked = False
            sparklePurpleToolStripMenuItem.Checked = False
            toolStripSparklePurple.Checked = False
            systemToolStripMenuItem.Checked = False
            toolStripSystem.Checked = False
            customToolStripMenuItem.Checked = False
            toolStripCustom.Checked = False
            UpdateOnPaletteChanged()
        End If
    End Sub

    Private Sub toolStripOffice2007Blue_Click(sender As Object, e As EventArgs) Handles toolStripOffice2007Blue.Click, office2007BlueToolStripMenuItem.Click
        If Not toolStripOffice2007Blue.Checked Then
            kryptonManager.GlobalPaletteMode = PaletteMode.Office2007Blue
            office2010BlueToolStripMenuItem.Checked = False
            toolStripOffice2010Blue.Checked = False
            office2010SilverToolStripMenuItem.Checked = False
            toolStripOffice2010Silver.Checked = False
            office2010BlackToolStripMenuItem.Checked = False
            toolStripOffice2010Black.Checked = False
            office2007BlueToolStripMenuItem.Checked = True
            toolStripOffice2007Blue.Checked = True
            office2007SilverToolStripMenuItem.Checked = False
            toolStripOffice2007Silver.Checked = False
            office2007BlackToolStripMenuItem.Checked = False
            toolStripOffice2007Black.Checked = False
            sparkleBlueToolStripMenuItem.Checked = False
            toolStripSparkleBlue.Checked = False
            sparkleOrangeToolStripMenuItem.Checked = False
            toolStripSparkleOrange.Checked = False
            sparklePurpleToolStripMenuItem.Checked = False
            toolStripSparklePurple.Checked = False
            systemToolStripMenuItem.Checked = False
            toolStripSystem.Checked = False
            customToolStripMenuItem.Checked = False
            toolStripCustom.Checked = False
            UpdateOnPaletteChanged()
        End If
    End Sub

    Private Sub toolStripOffice2007Silver_Click(sender As Object, e As EventArgs) Handles toolStripOffice2007Silver.Click, office2007SilverToolStripMenuItem.Click
        If Not toolStripOffice2007Silver.Checked Then
            kryptonManager.GlobalPaletteMode = PaletteMode.Office2007Silver
            office2010BlueToolStripMenuItem.Checked = False
            toolStripOffice2010Blue.Checked = False
            office2010SilverToolStripMenuItem.Checked = False
            toolStripOffice2010Silver.Checked = False
            office2010BlackToolStripMenuItem.Checked = False
            toolStripOffice2010Black.Checked = False
            office2007BlueToolStripMenuItem.Checked = False
            toolStripOffice2007Blue.Checked = False
            office2007SilverToolStripMenuItem.Checked = True
            toolStripOffice2007Silver.Checked = True
            office2007BlackToolStripMenuItem.Checked = False
            toolStripOffice2007Black.Checked = False
            sparkleBlueToolStripMenuItem.Checked = False
            toolStripSparkleBlue.Checked = False
            sparkleOrangeToolStripMenuItem.Checked = False
            toolStripSparkleOrange.Checked = False
            sparklePurpleToolStripMenuItem.Checked = False
            toolStripSparklePurple.Checked = False
            systemToolStripMenuItem.Checked = False
            toolStripSystem.Checked = False
            customToolStripMenuItem.Checked = False
            toolStripCustom.Checked = False
            UpdateOnPaletteChanged()
        End If
    End Sub

    Private Sub toolStripOffice2007Black_Click(sender As Object, e As EventArgs) Handles toolStripOffice2007Black.Click, office2007BlackToolStripMenuItem.Click
        If Not toolStripOffice2007Black.Checked Then
            kryptonManager.GlobalPaletteMode = PaletteMode.Office2007Black
            office2010BlueToolStripMenuItem.Checked = False
            toolStripOffice2010Blue.Checked = False
            office2010SilverToolStripMenuItem.Checked = False
            toolStripOffice2010Silver.Checked = False
            office2010BlackToolStripMenuItem.Checked = False
            toolStripOffice2010Black.Checked = False
            office2007BlueToolStripMenuItem.Checked = False
            toolStripOffice2007Blue.Checked = False
            office2007SilverToolStripMenuItem.Checked = False
            toolStripOffice2007Silver.Checked = False
            office2007BlackToolStripMenuItem.Checked = True
            toolStripOffice2007Black.Checked = True
            sparkleBlueToolStripMenuItem.Checked = False
            toolStripSparkleBlue.Checked = False
            sparkleOrangeToolStripMenuItem.Checked = False
            toolStripSparkleOrange.Checked = False
            sparklePurpleToolStripMenuItem.Checked = False
            toolStripSparklePurple.Checked = False
            systemToolStripMenuItem.Checked = False
            toolStripSystem.Checked = False
            customToolStripMenuItem.Checked = False
            toolStripCustom.Checked = False
            UpdateOnPaletteChanged()
        End If
    End Sub

    Private Sub toolStripSparkleBlue_Click(sender As Object, e As EventArgs) Handles toolStripSparkleBlue.Click, sparkleBlueToolStripMenuItem.Click
        If Not toolStripSparkleBlue.Checked Then
            kryptonManager.GlobalPaletteMode = PaletteMode.SparkleBlue
            office2010BlueToolStripMenuItem.Checked = False
            toolStripOffice2010Blue.Checked = False
            office2010SilverToolStripMenuItem.Checked = False
            toolStripOffice2010Silver.Checked = False
            office2010BlackToolStripMenuItem.Checked = False
            toolStripOffice2010Black.Checked = False
            office2007BlueToolStripMenuItem.Checked = False
            toolStripOffice2007Blue.Checked = False
            office2007SilverToolStripMenuItem.Checked = False
            toolStripOffice2007Silver.Checked = False
            office2007BlackToolStripMenuItem.Checked = False
            toolStripOffice2007Black.Checked = False
            sparkleBlueToolStripMenuItem.Checked = True
            toolStripSparkleBlue.Checked = True
            sparkleOrangeToolStripMenuItem.Checked = False
            toolStripSparkleOrange.Checked = False
            sparklePurpleToolStripMenuItem.Checked = False
            toolStripSparklePurple.Checked = False
            systemToolStripMenuItem.Checked = False
            toolStripSystem.Checked = False
            customToolStripMenuItem.Checked = False
            toolStripCustom.Checked = False
            UpdateOnPaletteChanged()
        End If
    End Sub

    Private Sub toolStripSparkleOrange_Click(sender As Object, e As EventArgs) Handles toolStripSparkleOrange.Click, sparkleOrangeToolStripMenuItem.Click
        If Not toolStripSparkleOrange.Checked Then
            kryptonManager.GlobalPaletteMode = PaletteMode.SparkleOrange
            office2010BlueToolStripMenuItem.Checked = False
            toolStripOffice2010Blue.Checked = False
            office2010SilverToolStripMenuItem.Checked = False
            toolStripOffice2010Silver.Checked = False
            office2010BlackToolStripMenuItem.Checked = False
            toolStripOffice2010Black.Checked = False
            office2007BlueToolStripMenuItem.Checked = False
            toolStripOffice2007Blue.Checked = False
            office2007SilverToolStripMenuItem.Checked = False
            toolStripOffice2007Silver.Checked = False
            office2007BlackToolStripMenuItem.Checked = False
            toolStripOffice2007Black.Checked = False
            sparkleBlueToolStripMenuItem.Checked = False
            toolStripSparkleBlue.Checked = False
            sparkleOrangeToolStripMenuItem.Checked = True
            toolStripSparkleOrange.Checked = True
            sparklePurpleToolStripMenuItem.Checked = False
            toolStripSparklePurple.Checked = False
            systemToolStripMenuItem.Checked = False
            toolStripSystem.Checked = False
            customToolStripMenuItem.Checked = False
            toolStripCustom.Checked = False
            UpdateOnPaletteChanged()
        End If
    End Sub

    Private Sub toolStripSparklePurple_Click(sender As Object, e As EventArgs) Handles toolStripSparklePurple.Click, sparklePurpleToolStripMenuItem.Click
        If Not toolStripSparklePurple.Checked Then
            kryptonManager.GlobalPaletteMode = PaletteMode.SparklePurple
            office2010BlueToolStripMenuItem.Checked = False
            toolStripOffice2010Blue.Checked = False
            office2010SilverToolStripMenuItem.Checked = False
            toolStripOffice2010Silver.Checked = False
            office2010BlackToolStripMenuItem.Checked = False
            toolStripOffice2010Black.Checked = False
            office2007BlueToolStripMenuItem.Checked = False
            toolStripOffice2007Blue.Checked = False
            office2007SilverToolStripMenuItem.Checked = False
            toolStripOffice2007Silver.Checked = False
            office2007BlackToolStripMenuItem.Checked = False
            toolStripOffice2007Black.Checked = False
            sparkleBlueToolStripMenuItem.Checked = False
            toolStripSparkleBlue.Checked = False
            sparkleOrangeToolStripMenuItem.Checked = False
            toolStripSparkleOrange.Checked = False
            sparklePurpleToolStripMenuItem.Checked = True
            toolStripSparklePurple.Checked = True
            systemToolStripMenuItem.Checked = False
            toolStripSystem.Checked = False
            customToolStripMenuItem.Checked = False
            toolStripCustom.Checked = False
            UpdateOnPaletteChanged()
        End If
    End Sub

    Private Sub toolStripSystem_Click(sender As Object, e As EventArgs) Handles toolStripSystem.Click, systemToolStripMenuItem.Click
        If Not toolStripSystem.Checked Then
            kryptonManager.GlobalPaletteMode = PaletteMode.ProfessionalSystem
            office2010BlueToolStripMenuItem.Checked = False
            toolStripOffice2010Blue.Checked = False
            office2010SilverToolStripMenuItem.Checked = False
            toolStripOffice2010Silver.Checked = False
            office2010BlackToolStripMenuItem.Checked = False
            toolStripOffice2010Black.Checked = False
            office2007BlueToolStripMenuItem.Checked = False
            toolStripOffice2007Blue.Checked = False
            office2007SilverToolStripMenuItem.Checked = False
            toolStripOffice2007Silver.Checked = False
            office2007BlackToolStripMenuItem.Checked = False
            toolStripOffice2007Black.Checked = False
            sparkleBlueToolStripMenuItem.Checked = False
            toolStripSparkleBlue.Checked = False
            sparkleOrangeToolStripMenuItem.Checked = False
            toolStripSparkleOrange.Checked = False
            sparklePurpleToolStripMenuItem.Checked = False
            toolStripSparklePurple.Checked = False
            systemToolStripMenuItem.Checked = True
            toolStripSystem.Checked = True
            customToolStripMenuItem.Checked = False
            toolStripCustom.Checked = False
            UpdateOnPaletteChanged()
        End If
    End Sub

    Private Sub toolStripCustom_Click(sender As Object, e As EventArgs) Handles toolStripCustom.Click, customToolStripMenuItem.Click
        If Not toolStripCustom.Checked Then
            kryptonManager.GlobalCustomPalette = kryptonPaletteCustom
            office2010BlueToolStripMenuItem.Checked = False
            toolStripOffice2010Blue.Checked = False
            office2010SilverToolStripMenuItem.Checked = False
            toolStripOffice2010Silver.Checked = False
            office2010BlackToolStripMenuItem.Checked = False
            toolStripOffice2010Black.Checked = False
            office2007BlueToolStripMenuItem.Checked = False
            toolStripOffice2007Blue.Checked = False
            office2007SilverToolStripMenuItem.Checked = False
            toolStripOffice2007Silver.Checked = False
            office2007BlackToolStripMenuItem.Checked = False
            toolStripOffice2007Black.Checked = False
            sparkleBlueToolStripMenuItem.Checked = False
            toolStripSparkleBlue.Checked = False
            sparkleOrangeToolStripMenuItem.Checked = False
            toolStripSparkleOrange.Checked = False
            sparklePurpleToolStripMenuItem.Checked = False
            toolStripSparklePurple.Checked = False
            systemToolStripMenuItem.Checked = False
            toolStripSystem.Checked = False
            customToolStripMenuItem.Checked = True
            toolStripCustom.Checked = True
            UpdateOnPaletteChanged()
        End If
    End Sub

    Private Sub toolStripReadingPane_CheckedChanged(sender As Object, e As EventArgs) Handles toolStripReadingPane.Click
        ' Show/Hide the reading pane depending on new setting
        kryptonSplitContainerDetails.Panel2Collapsed = toolStripReadingPane.Checked
        readingPaneToolStripMenuItem.Checked = toolStripReadingPane.Checked
    End Sub

    Private Sub readingPaneToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles readingPaneToolStripMenuItem.Click
        toolStripReadingPane.Checked = Not toolStripReadingPane.Checked
    End Sub

    Private Sub toolStripPosition_CheckedChanged(sender As Object, e As EventArgs) Handles toolStripPosition.Click
        ' Vertical/Horizontal alignment depending on new setting
        kryptonSplitContainerDetails.Orientation = If(toolStripPosition.Checked, Orientation.Vertical, Orientation.Horizontal)
        panePositonToolStripMenuItem.Checked = toolStripPosition.Checked
    End Sub

    Private Sub panePositonToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles panePositonToolStripMenuItem.Click
        toolStripPosition.Checked = Not toolStripPosition.Checked
    End Sub

    Private Sub treeView_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles treeView.AfterSelect
        If e.Node IsNot Nothing Then
            ' Update the details header with selected node values
            kryptonHeaderGroupDetails.ValuesPrimary.Heading = e.Node.Text
            kryptonHeaderGroupDetails.ValuesPrimary.Image = imageList.Images(e.Node.ImageIndex)

            ' Change list of displayed items based on the new tree selection
            FilterDataTable(e.Node)
        Else
            ' Should never happen, but just in case!
            kryptonHeaderGroupDetails.ValuesPrimary.Heading = "Details"
            kryptonHeaderGroupDetails.ValuesPrimary.Image = Nothing
        End If
    End Sub

    Private Sub kryptonDataGridView_SelectionChanged(sender As Object, e As EventArgs) Handles kryptonDataGridView.SelectionChanged
        If kryptonDataGridView.SelectedRows.Count = 1 Then
            Dim details = TryCast(kryptonDataGridView.SelectedRows(0).Cells(2).Value, String)
            kryptonReadingLabel.Values.Text = details
        Else
            kryptonReadingLabel.Values.Text = String.Empty
        End If
    End Sub

    Private Sub loadPaletteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles loadPaletteToolStripMenuItem.Click
        ' Create a new palette for the importing
        Dim newPalette As New KryptonCustomPaletteBase()

        ' If the user managed to load a palette file
        If newPalette.Import().Length > 0 Then
            ' Then switch the using the new one
            kryptonPaletteCustom = newPalette

            If Not toolStripCustom.Checked Then
                ' Then use existing method to switch to using the custom palette
                toolStripCustom_Click(sender, EventArgs.Empty)
            Else
                ' Use the custom palette
                kryptonManager.GlobalCustomPalette = kryptonPaletteCustom
                UpdateOnPaletteChanged()
            End If

            ' Change of palette means a change in colors that need
            ' applying to the background of the standard controls
            UpdateOnPaletteChanged()
        End If
    End Sub

    Private Sub OnNext(sender As Object, e As EventArgs)
        ' If nothing is selected
        If kryptonDataGridView.SelectedRows.Count = 0 Then
            ' If there are rows in the grid
            If kryptonDataGridView.Rows.Count > 0 Then
                ' Select the first row
                kryptonDataGridView.Rows(0).Selected = True
            End If
        Else
            ' Find index of next row
            Dim index As Integer = kryptonDataGridView.SelectedRows(0).Index + 1

            ' If past end of list then go back to the start
            If index >= kryptonDataGridView.Rows.Count Then
                index = 0
            End If

            ' Select the row
            kryptonDataGridView.Rows(index).Selected = True
        End If

        kryptonDataGridView.Refresh()
    End Sub

    Private Sub OnPrevious(sender As Object, e As EventArgs)
        ' If nothing is selected
        If kryptonDataGridView.SelectedRows.Count = 0 Then
            ' If there are rows in the grid
            If kryptonDataGridView.Rows.Count > 0 Then
                ' Select the last row
                kryptonDataGridView.Rows(kryptonDataGridView.Rows.Count - 1).Selected = True
            End If
        Else
            ' Find index of previous row
            Dim index As Integer = kryptonDataGridView.SelectedRows(0).Index - 1

            ' If past start of list then go back to the end
            If index < 0 Then
                index = kryptonDataGridView.Rows.Count - 1
            End If

            ' Select the row
            kryptonDataGridView.Rows(index).Selected = True
        End If

        kryptonDataGridView.Refresh()
    End Sub

    Private Sub exitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles exitToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub FilterDataTable(node As TreeNode)
        ' Add entries for the current node
        If Not String.IsNullOrEmpty(node.Text) Then
            If (node.Text = "Appointments") OrElse
               (node.Text = "Employees") Then
                dataTable.DefaultView.RowFilter = $"Department = '{node.Text}'"
            Else
                dataTable.DefaultView.RowFilter = $"Category = '{node.Text}'"
            End If
        End If
    End Sub

    Private Sub UpdateOnPaletteChanged()
        ' Get the new control background color
        Dim backColor As Color = kryptonManager.GlobalCustomPalette.GetBackColor1(PaletteBackStyle.ControlClient,
                                                                                  PaletteState.Normal)

        ' Update the tree and listview controls with new color
        treeView.BackColor = backColor
    End Sub

End Class
