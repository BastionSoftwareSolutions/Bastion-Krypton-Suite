#Region "BSD License"
'
' Original BSD 3-Clause License (https://github.com/ComponentFactory/Krypton/blob/master/LICENSE)
'  © Component Factory Pty Ltd, 2006 - 2016, (Version 4.5.0.0) All rights reserved.
'
'  New BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit/blob/master/LICENSE)
'  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV), et al. 2017 - 2024. All rights reserved.
'
' VB.NET twin of Source\Krypton Navigator Examples\Outlook Mockup\Form1.cs (Bastion Phase 4c).
#End Region

Imports System
Imports System.Windows.Forms

Imports Krypton.Navigator
Imports Krypton.Toolkit

Public Class Form1

    ' Cache the full expanded size of the outlook navigator
    Private _widthLeftRight As Integer

    ' Set of fake notes entries
    Private _notes As Object() = New Object() {New String() {"Bug Reports v1.2", "Featuer Requests v1.3", "Wish List"},
                                               New String() {"Xmas List", "Birthday Dates"},
                                               New String() {"Season Schedule", "Party Invites", "Jokes", "Diary"}}

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Populate the different data table
        dtDrafts.Rows.Add("Ray Clemence", "Need to improve handling", "Mon 02/09/2006", "10 KB")
        dtDrafts.Rows.Add("Garth Crooks", "Excellent team performance", "Tue 03/09/2006", "5 KB")
        dtDrafts.Rows.Add("Peter Shilten", "Good defence is important", "Wed 04/09/2006", "21 KB")
        dtDrafts.Rows.Add("Steve McClaren", "Nice work, keep it going", "Tue 05/09/2006", "11 KB")
        dtFamily.Rows.Add("John Smith", "Did you get my new pics?", "Mon 02/09/2006", "11 KB")
        dtFamily.Rows.Add("Mike Smith", "Remember to get Emma a present", "Mon 02/09/2006", "17 KB")
        dtFamily.Rows.Add("Susan Smith", "What did you get Emma?", "Tue 03/09/2006", "10 KB")
        dtFamily.Rows.Add("Emma Smith", "RE: Happy Birthday!", "Wed 04/09/2006", "6 KB")
        dtFamily.Rows.Add("Emma Smith", "Have you seen Dad recently?", "Thu 05/09/2006", "32 KB")
        dtFamily.Rows.Add("Percy Smith", "Great holiday, see you soon", "Thu 05/09/2006", "2 KB")
        dtFriends.Rows.Add("Dirk Huber", "Arsenal 0 - Liverpool 3 Nice!!", "Tue 03/09/2006", "2 KB")
        dtFriends.Rows.Add("Jimmy Jones", "Are you going to the big game?", "Wed 04/09/2006", "32 KB")
        dtFriends.Rows.Add("Nick Robinson", "Just noticed you have a blog", "Thu 05/09/2006", "2 KB")
        dtWork.Rows.Add("Your Boss", "Take the week off", "Wed 04/09/2006", "2 KB")
        dtOutbox.Rows.Add("Wayne Rooney", "Need to control your emotions", "Thu 01/09/2006", "17 KB")
        dtSentItems.Rows.Add("Sven Ericcson", "Poor managing performance", "Fri 07/09/2006", "5 KB")
        dtSentItems.Rows.Add("David Beckham", "You have been dropped", "Thu 05/09/2006", "12 KB")

        ' Set the initial main and detail pages
        kryptonNavigatorMain.SelectedIndex = 0
        kryptonNavigatorDetails.SelectedIndex = 0

        ' Start with all folders expanded
        treeViewMailFolders.ExpandAll()

        ' Set initial focus to the tree view for mail
        treeViewMailFolders.Focus()
        treeViewMailFolders.SelectedNode = treeViewMailFolders.Nodes(2).Nodes(0)

        ' Set the initial set of notes entries
        radioNotes_CheckedChanged(radioProject, EventArgs.Empty)
    End Sub

    Private Sub buttonSpecExpandCollapse_Click(sender As Object, e As EventArgs) Handles buttonSpecExpandCollapse.Click
        kryptonSplitContainerMain.SuspendLayout()
        kryptonNavigatorMain.SuspendLayout()

        ' Is the navigator currently in full mode?
        If kryptonNavigatorMain.NavigatorMode = NavigatorMode.OutlookFull Then
            ' Make the left panel of the splitter fixed in size
            kryptonSplitContainerMain.FixedPanel = FixedPanel.Panel1
            kryptonSplitContainerMain.IsSplitterFixed = True

            ' Remember the current height of the header group
            _widthLeftRight = kryptonNavigatorMain.Width

            ' Switch to the mini mode
            kryptonNavigatorMain.NavigatorMode = NavigatorMode.OutlookMini

            ' Discover the new width required to display the mini mode
            Dim newWidth = kryptonNavigatorMain.PreferredSize.Width

            ' Make the header group fixed just as the new height
            kryptonSplitContainerMain.Panel1MinSize = newWidth
            kryptonSplitContainerMain.SplitterDistance = newWidth

            ' Switch the arrow to point the opposite way
            buttonSpecExpandCollapse.TypeRestricted = PaletteNavButtonSpecStyle.ArrowRight
        Else
            ' Switch to the full mode
            kryptonNavigatorMain.NavigatorMode = NavigatorMode.OutlookFull

            ' Make the bottom panel not-fixed in size anymore
            kryptonSplitContainerMain.FixedPanel = FixedPanel.None
            kryptonSplitContainerMain.IsSplitterFixed = False

            ' Put back the minimum size to the original
            kryptonSplitContainerMain.Panel1MinSize = 100

            ' Calculate the correct splitter we want to put back
            kryptonSplitContainerMain.SplitterDistance = _widthLeftRight

            ' Switch the arrow to point the opposite way
            buttonSpecExpandCollapse.TypeRestricted = PaletteNavButtonSpecStyle.ArrowLeft
        End If

        kryptonSplitContainerMain.ResumeLayout()
        kryptonNavigatorMain.ResumeLayout()
    End Sub

    Private Sub kryptonNavigatorMain_SelectedPageChanged(sender As Object, e As EventArgs) Handles kryptonNavigatorMain.SelectedPageChanged
        ' NOTE (Bastion 4c): VB Handles binds at field assignment, so this handler can fire during
        ' InitializeComponent while the main navigator pages are added but before the details
        ' navigator has any pages; the C# twin wires events afterwards.
        If kryptonNavigatorDetails Is Nothing OrElse
           kryptonNavigatorMain.SelectedIndex < 0 OrElse
           kryptonNavigatorMain.SelectedIndex >= kryptonNavigatorDetails.Pages.Count Then Return

        ' Update the details page to match the main pages
        kryptonNavigatorDetails.SelectedIndex = kryptonNavigatorMain.SelectedIndex
    End Sub

    Private Sub treeViewMail_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles _
        treeViewMailFolders.AfterSelect, treeViewMailFavs.AfterSelect

        ' Remove selection from the other tree
        If sender Is treeViewMailFavs Then
            treeViewMailFolders.SelectedNode = Nothing
        Else
            treeViewMailFavs.SelectedNode = Nothing
        End If

        ' Cast event source to the correct type
        Dim tv = DirectCast(sender, TreeView)

        ' Update the mail heading entries
        If tv.SelectedNode IsNot Nothing Then
            ' Update the title to match the folder
            kryptonPageMailDetails.TextTitle = tv.SelectedNode.Text

            ' Set the data grid to show details from this table
            kryptonDataGridView1.DataSource = dataSet.Tables(tv.SelectedNode.Text)
        Else
            ' Update the title to a generic title
            kryptonPageMailDetails.TextTitle = "Mail"

            ' Nothing selected so remove any source from the data grid
            kryptonDataGridView1.DataSource = Nothing
        End If
    End Sub

    Private Sub radioNotes_CheckedChanged(sender As Object, e As EventArgs) Handles _
        radioFriends.CheckedChanged, radioFamily.CheckedChanged, radioProject.CheckedChanged

        Dim index = 0

        ' Find index of note names
        If radioFamily.Checked Then
            index = 1
        ElseIf radioFriends.Checked Then
            index = 2
        End If

        ' Remove all existing notes
        listViewNotes.Items.Clear()

        ' Get the set of strings that contain the note names
        Dim group = DirectCast(_notes(index), String())

        ' Add each mail entry as an item
        For Each entry In group
            listViewNotes.Items.Add(New ListViewItem(entry, 0))
        Next
    End Sub

    Private Sub radioOffice2010Blue_CheckedChanged(sender As Object, e As EventArgs) Handles radioOffice2010Blue.CheckedChanged
        If radioOffice2010Blue.Checked Then
            kryptonManager.GlobalPaletteMode = PaletteMode.Office2010Blue
        End If
    End Sub

    Private Sub radioOffice2010Silver_CheckedChanged(sender As Object, e As EventArgs) Handles radioOffice2010Silver.CheckedChanged
        If radioOffice2010Silver.Checked Then
            kryptonManager.GlobalPaletteMode = PaletteMode.Office2010Silver
        End If
    End Sub

    Private Sub radioOffice2010Black_CheckedChanged(sender As Object, e As EventArgs) Handles radioOffice2010Black.CheckedChanged
        If radioOffice2010Black.Checked Then
            kryptonManager.GlobalPaletteMode = PaletteMode.Office2010Black
        End If
    End Sub

    Private Sub radioOffice2007Blue_CheckedChanged(sender As Object, e As EventArgs) Handles radioOffice2007Blue.CheckedChanged
        If radioOffice2007Blue.Checked Then
            kryptonManager.GlobalPaletteMode = PaletteMode.Office2007Blue
        End If
    End Sub

    Private Sub radioOffice2007Silver_CheckedChanged(sender As Object, e As EventArgs) Handles radioOffice2007Silver.CheckedChanged
        If radioOffice2007Silver.Checked Then
            kryptonManager.GlobalPaletteMode = PaletteMode.Office2007Silver
        End If
    End Sub

    Private Sub radioOffice2007Black_CheckedChanged(sender As Object, e As EventArgs) Handles radioOffice2007Black.CheckedChanged
        If radioOffice2007Black.Checked Then
            kryptonManager.GlobalPaletteMode = PaletteMode.Office2007Black
        End If
    End Sub

    Private Sub radioOffice2003_CheckedChanged(sender As Object, e As EventArgs) Handles radioOffice2003.CheckedChanged
        If radioOffice2003.Checked Then
            kryptonManager.GlobalPaletteMode = PaletteMode.ProfessionalOffice2003
        End If
    End Sub

    Private Sub radioSystem_CheckedChanged(sender As Object, e As EventArgs) Handles radioSystem.CheckedChanged
        If radioSystem.Checked Then
            kryptonManager.GlobalPaletteMode = PaletteMode.ProfessionalSystem
        End If
    End Sub

    Private Sub radioSparkle_CheckedChanged(sender As Object, e As EventArgs) Handles radioSparkle.CheckedChanged
        If radioSparkle.Checked Then
            kryptonManager.GlobalPaletteMode = PaletteMode.SparkleBlue
        End If
    End Sub

End Class
