Imports System.ComponentModel
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraBars
Imports DevExpress.XtraEditors
Imports System.Text
Public Structure courseList
    <VBFixedString(50)> Dim courseTitle, depart, fac As String
    Dim Duration As Integer
    <VBFixedString(20)> Dim type, Abbr, code As String
    <VBFixedString(50)> <VBFixedArray(20)> Dim units As String()
    <VBFixedString(50)> <VBFixedArray(6)> Dim programs As String()
    Dim tuition As Decimal
End Structure
Public Structure StudList
    <VBFixedString(50)> Dim iName, course, regNo, proG, sponsorship, nation As String
    Dim regDate As Date
End Structure
Partial Public Class Form1

    Shared Sub New()
        DevExpress.UserSkins.BonusSkins.Register()
        DevExpress.Skins.SkinManager.EnableFormSkins()
    End Sub

    Public Sub New()
        InitializeComponent()
    End Sub
    Private Sub saveCourses(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        WaitForm1.Show(Me)
        Dim cS As New courseList
        Dim rl As Integer = Len(cS)
        Dim x As Integer = 1
        Dim fn As Integer = FreeFile()

        FileOpen(fn, ".Courses.id", OpenMode.Random,,, rl)
        With GridView2
            For i As Integer = 0 To .RowCount - 1
                cS.courseTitle = Trim(CType(.GetRowCellValue(i, "course name"), String))
                cS.depart = Trim(CType(.GetRowCellValue(i, "department"), String))
                cS.Duration = CType(.GetRowCellValue(i, "years"), Integer)
                cS.fac = Trim(CType(.GetRowCellValue(i, "faculty"), String))
                cS.tuition = CType(.GetRowCellValue(i, "tuition fee"), Decimal)
                cS.type = Trim(CType(.GetRowCellValue(i, "course type"), String))
                cS.units = Trim(CType(.GetRowCellValue(i, "course units"), String)).Split({","}, StringSplitOptions.RemoveEmptyEntries)
                cS.programs = Trim(CType(.GetRowCellValue(i, "programmes"), String)).Split({","}, StringSplitOptions.RemoveEmptyEntries)
                cS.Abbr = Trim(CType(.GetRowCellValue(i, "course Abbr"), String))

                FilePut(fn, cS, x)
                x += 1
            Next
        End With
        FileClose(fn)
        Me.Validate()
        Me.CoursesTableBindingSource.EndEdit()
        Me.CoursesTableTableAdapter.Update(Me.InstituteDataDataSet.coursesTable)
        Badge2.Properties.Text = GridView2.RowCount.ToString
        WaitForm1.Close()
    End Sub

    Private Sub BarButtonItem3_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        WaitForm1.Show(Me)
        Dim sL As New StudList
        Dim rl As Integer = Len(sL)
        Dim x As Integer = 1
        Dim fn As Integer = FreeFile()

        FileOpen(fn, ".StudList.id", OpenMode.Random,,, rl)
        With AdvBandedGridView1
            For i As Integer = 0 To .RowCount-1
                sL.course = Trim(CType(.GetRowCellValue(i, "course name"), String))
                sL.iName = Trim(CType(.GetRowCellDisplayText(i, "Students Name"), String))
                sL.nation = Trim(CType(.GetRowCellDisplayText(i, "nationality"), String))
                sL.proG = Trim(CType(.GetRowCellDisplayText(i, "Programme"), String))
                sL.regDate = CType(.GetRowCellValue(i, "registration date"), Date)
                sL.regNo = Trim(CType(.GetRowCellDisplayText(i, "registration number"), String))
                sL.sponsorship = Trim(CType(.GetRowCellDisplayText(i, "sponsorship"), String))
                FilePut(fn, sL, x)
                x += 1
            Next
        End With
        FileClose(fn)
        Me.Validate()
        Me.StudentInfoBindingSource.EndEdit()
        Me.StudentInfoTableAdapter.Update(Me.InstituteDataDataSet.StudentInfo)
        Badge1.Properties.Text = AdvBandedGridView1.RowCount.ToString
        WaitForm1.Close()
    End Sub

    Private Sub BarButtonItem4_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs)
        Me.Validate()
        '  Try
        Me.Year_RegisterBindingSource.EndEdit()
        Me.Year_RegisterTableAdapter.Update(Me.InstituteDataDataSet.Year_Register)
        '  Catch
        'NOTHING
        '  Finally
        Dim r As New ReportPrintTool(New RegCard)
        r.ShowRibbonPreview()
        ' End Try
    End Sub

    Private Sub CoursesTableBindingSource_AddingNew(sender As Object, e As AddingNewEventArgs) Handles CoursesTableBindingSource.AddingNew
        Dim gf = e.NewObject
        Badge2.Properties.Text = GridView2.RowCount.ToString
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'InstituteDataDataSet.OtherFeesTable' table. You can move, or remove it, as needed.
        Me.OtherFeesTableTableAdapter.Fill(Me.InstituteDataDataSet.OtherFeesTable)
        'TODO: This line of code loads data into the 'InstituteDataDataSet.PaymentTable' table. You can move, or remove it, as needed.
        Me.PaymentTableTableAdapter.Fill(Me.InstituteDataDataSet.PaymentTable)
        'TODO: This line of code loads data into the 'InstituteDataDataSet.Year_Register' table. You can move, or remove it, as needed.
        Me.Year_RegisterTableAdapter.Fill(Me.InstituteDataDataSet.Year_Register)
        'TODO: This line of code loads data into the 'InstituteDataDataSet.accountsTable' table. You can move, or remove it, as needed.
        ' Me.AccountsTableTableAdapter.Fill(Me.InstituteDataDataSet.accountsTable)
        'TODO: This line of code loads data into the 'InstituteDataDataSet.coursesTable' table. You can move, or remove it, as needed.
        Me.CoursesTableTableAdapter.Fill(Me.InstituteDataDataSet.coursesTable)
        'TODO: This line of code loads data into the 'InstituteDataDataSet.StudentInfo' table. You can move, or remove it, as needed.
        Me.StudentInfoTableAdapter.Fill(Me.InstituteDataDataSet.StudentInfo)
        ' Me.StudentInfoBindingSource.AddNew()
        Badge1.Properties.Text = AdvBandedGridView1.RowCount.ToString
        Badge2.Properties.Text = GridView2.RowCount.ToString

    End Sub

    Private Sub RepositoryItemPopupContainerEdit1_BeforePopup(sender As Object, e As EventArgs) Handles RepositoryItemPopupContainerEdit1.BeforePopup
        Try
            surNedit.EditValue = Nothing
            fisrtNedit.EditValue = Nothing
            oNedit.EditValue = Nothing
            If Not AdvBandedGridView1.IsNewItemRow(AdvBandedGridView1.FocusedRowHandle) Then
                Dim names() As String = AdvBandedGridView1.GetFocusedRowCellValue("Students Name").ToString.Split({" "}, 3, StringSplitOptions.RemoveEmptyEntries)
                surNedit.EditValue = names(0)
                fisrtNedit.EditValue = names(1)
                oNedit.EditValue = names(2)

            End If
        Catch
            'nothing
        End Try
    End Sub

    Private Sub RepositoryItemPopupContainerEdit1_CloseUp(sender As Object, e As DevExpress.XtraEditors.Controls.CloseUpEventArgs) Handles RepositoryItemPopupContainerEdit1.CloseUp
        Try
            If e.CloseMode = DevExpress.XtraEditors.PopupCloseMode.Immediate Or e.CloseMode = DevExpress.XtraEditors.PopupCloseMode.Normal Then
                Dim s As String = Nothing
                If surNedit.EditValue.ToString IsNot Nothing Then
                    s = surNedit.EditValue.ToString
                End If

                Dim f As String = Nothing
                If fisrtNedit.EditValue.ToString IsNot Nothing Then
                    f = fisrtNedit.EditValue.ToString
                End If
                Dim o As String = Nothing
                If oNedit.EditValue IsNot Nothing Then
                    o = oNedit.EditValue.ToString
                End If
                e.Value = s & " " & f & " " & o 'IIf(surNedit.EditValue Is Nothing, String.Empty, surNedit.EditValue.ToString).ToString & " " & IIf(fisrtNedit.EditValue Is Nothing, String.Empty, fisrtNedit.EditValue.ToString).ToString & " " '& IIf(oNedit.EditValue Is Nothing, String.Empty, oNedit.EditValue.ToString).ToString
                e.AcceptValue = True
            End If
        Catch

            'nothing
        End Try
    End Sub

    Private Sub RepositoryItemPopupContainerEdit1_Popup(sender As Object, e As EventArgs) Handles RepositoryItemPopupContainerEdit1.Popup

    End Sub

    Private Sub TileBarItem1_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles TileItem2.ItemClick
        NavigationFrame1.SelectedPageIndex = 0
        registerTab.Visible = True
        coursesTab.Visible = False
    End Sub

    Private Sub TileBarItem2_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles TileItem1.ItemClick
        NavigationFrame1.SelectedPageIndex = 1
        coursesTab.Visible = True
        registerTab.Visible = False
    End Sub

    Private Sub TileItem3_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles TileItem3.ItemClick
        NavigationFrame1.SelectedPageIndex = 2
        yearTab.Visible = False
        coursesTab.Visible = False
        payTab.Visible = True
        registerTab.Visible = False

    End Sub

    Private Sub TileItem4_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles TileItem4.ItemClick
        If sender Is Nothing OrElse e Is Nothing Then
            Return
        Else
            NavigationFrame1.SelectedPageIndex = 4
            'coursesTab.Visible = True
            'registerTab.Visible = False
        End If
    End Sub

    Private Sub TileItem5_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles TileItem5.ItemClick
        NavigationFrame1.SelectedPageIndex = 3
        yearTab.Visible = True
        coursesTab.Visible = False
        payTab.Visible = False
        registerTab.Visible = False
    End Sub

    Private Sub Unitstoken_ValidateToken(sender As Object, e As DevExpress.XtraEditors.TokenEditValidateTokenEventArgs) Handles unitstoken.ValidateToken
        If e.Description IsNot Nothing Then
            e.Value = e.Description
            e.IsValid = True
        End If
    End Sub

    Private Sub telToken_ValidateToken(sender As Object, e As DevExpress.XtraEditors.TokenEditValidateTokenEventArgs) Handles telToken.ValidateToken
        If e.Description.Length > 0 Then
            e.Value = e.Description
            e.IsValid = True
        End If
    End Sub

    Private Sub BarButtonItem4_ItemClick_1(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        AdvBandedGridView1.ShowRibbonPrintPreview()
    End Sub



    Private Sub StudentInfoGridControl_EmbeddedNavigator_ButtonClick(sender As Object, e As DevExpress.XtraEditors.NavigatorButtonClickEventArgs) Handles StudentInfoGridControl.EmbeddedNavigator.ButtonClick
        If e.Button.ButtonType = DevExpress.XtraEditors.NavigatorButtonType.Remove Then
            Dim r As DialogResult = XtraMessageBox.Show("Are Sure To Delete?", "Confirm", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
            If r = DialogResult.Yes Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub BarButtonItem5_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        If AdvBandedGridView2.SelectedRowsCount < 1 Then
            Return
        Else
            Dim r As DialogResult = XtraMessageBox.Show("Are Sure To Delete?", "Confirm", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
            If r = DialogResult.Yes Then
                AdvBandedGridView2.DeleteSelectedRows()
            Else
                Return
            End If

        End If
    End Sub

    Private Sub GridView1_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView1.CellValueChanged

    End Sub

    Private Sub GridView1_InitNewRow(sender As Object, e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GridView1.InitNewRow

    End Sub

    Private Sub GridView1_LayoutUpgrade(sender As Object, e As DevExpress.Utils.LayoutUpgradeEventArgs) Handles GridView1.LayoutUpgrade

    End Sub

    Private Sub GridView1_CustomSummaryCalculate(sender As Object, e As DevExpress.Data.CustomSummaryEventArgs) Handles GridView1.CustomSummaryCalculate

    End Sub

    Private Sub GridView1_TopRowChanged(sender As Object, e As EventArgs) Handles GridView1.TopRowChanged

    End Sub

    Private Sub GridView1_PrintInitialize(sender As Object, e As DevExpress.XtraGrid.Views.Base.PrintInitializeEventArgs) Handles GridView1.PrintInitialize
        e.Link.Landscape = True
        e.Link.PaperKind = Printing.PaperKind.A4

        'e.Link.RtfReportHeader = "hi"
    End Sub

    Private Sub BarButtonItem9_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem9.ItemClick
        GridView1.ShowRibbonPrintPreview()
    End Sub

    Private Sub AdvBandedGridView1_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles AdvBandedGridView1.CellValueChanged
        If e.Column.FieldName = "course name" Then
            Dim cS As New courseList
            Dim rl As Integer = Len(cS)
            Dim x As Integer = 1
            Dim fn As Integer = FreeFile()
            Dim proGs As String() = Nothing
            FileOpen(fn, ".Courses.id", OpenMode.Random,,, rl)
            Do While Not EOF(fn)
                FileGet(fn, cS, x)
                If Trim(e.Value.ToString) = Trim(cS.courseTitle) Then
                    proGs = cS.programs
                    Exit Do
                End If
                x += 1
            Loop
            FileClose(fn)

            Me.studprogcombo.Items.Clear()
            For Each prog As String In proGs
                Me.studprogcombo.Items.Add(trim(prog))
            Next
        End If

    End Sub


    Private Sub AdvBandedGridView1_ValidateRow(sender As Object, e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles AdvBandedGridView1.ValidateRow
        WaitForm1.Show()
        Dim sLi As New StudList
        Dim rli As Integer = Len(sLi)
        Dim xi As Integer = 1
        Dim fni As Integer = FreeFile()

        FileOpen(fni, ".StudList.id", OpenMode.Random,,, rli)
        With AdvBandedGridView1
            For i As Integer = 0 To .RowCount-1
                sLi.course = Trim(CType(.GetRowCellDisplayText(i, "course name"), String))
                sLi.iName = Trim(CType(.GetRowCellDisplayText(i, "Students Name"), String))
                sLi.nation = Trim(CType(.GetRowCellDisplayText(i, "nationality"), String))
                sLi.proG = Trim(CType(.GetRowCellDisplayText(i, "Programme"), String))
                sLi.regDate = CType(.GetRowCellValue(i, "registration date"), Date)
                sLi.regNo = Trim(CType(.GetRowCellDisplayText(i, "registration number"), String))
                sLi.sponsorship = Trim(CType(.GetRowCellDisplayText(i, "sponsorship"), String))
                FilePut(fni, sLi, xi)
                xi += 1
            Next
        End With
        FileClose(fni)

        With AdvBandedGridView1 'year/country/course abbr/index/sponsor
            Try
                Dim sL As New StudList
                Dim rl As Integer = Len(sL)
                Dim x As Integer = 1
                Dim ind As Integer = 1
                Dim fn As Integer = FreeFile()
                FileOpen(fn, ".StudList.id", OpenMode.Random,,, rl)
                Do While Not EOF(fn)
                    FileGet(fn, sL, x)
                    If sL.regDate.Year = CType(.GetRowCellValue(e.RowHandle, "registration date"), Date).Year Then
                        If Trim(sL.course) = Trim(CType(.GetRowCellValue(e.RowHandle, "course name"), String)) Then
                            ind += 1
                        End If
                    End If
                    x += 1
                Loop
                FileClose(fn)
                Dim cS As New courseList
                Dim rlx As Integer = Len(cS)
                Dim Abbr As String = Nothing

                x = 1
                fn = FreeFile()
                FileOpen(fn, ".Courses.id", OpenMode.Random,,, rlx)
                Do While Not EOF(fn)
                    FileGet(fn, cS, x)
                    If Trim(CType(.GetRowCellValue(e.RowHandle, "course name"), String)) = Trim(cS.courseTitle) Then
                        Abbr = Trim(cS.Abbr)
                        Exit Do
                    End If
                    x += 1
                Loop
                FileClose(fn)
                Dim reg As String = CType(.GetRowCellValue(e.RowHandle, "registration date"), Date).Year.ToString.Substring(2, 2) & "/" & CType(.GetRowCellValue(e.RowHandle, "nationality"), String).Substring(0, 2).ToUpper & "/" & Abbr & "/" & (ind).ToString & "/" & CType(.GetRowCellValue(e.RowHandle, "sponsorship"), String).Substring(0, 2)
                .SetRowCellValue(e.RowHandle, "registration number", reg)
                e.Valid = True
            Catch ex As Exception
                e.Valid = False
                e.ErrorText = ex.Message
            End Try
        End With
        WaitForm1.Close()
    End Sub
    Private Function getStudentDetails(registrationId As String) As String()
        Dim sL As New StudList
        Dim rl As Integer = Len(sL)
        Dim x As Integer = 1
        Dim details(5) As String
        Dim fn As Integer = FreeFile()
        FileOpen(fn, ".StudList.id", OpenMode.Random,,, rl)
        Do While Not EOF(fn)
            FileGet(fn, sL, x)
            If Trim(sL.regNo).ToUpper = Trim(registrationId).ToUpper Then
                With sL
                    details = {Trim(.iName), Trim(.course), Trim(.proG), Trim(.regDate.ToShortDateString), Trim(.sponsorship), Trim(.nation)}
                End With
                Exit Do
            End If
            x += 1
        Loop
        FileClose(fn)
        Return details
    End Function
    Private Function getcourseDetails(courseName As String) As String()
        Dim cS As New courseList
        Dim rlx As Integer = Len(cS)
        Dim x As Integer = 1
        Dim fn As Integer = FreeFile()
        Dim details(8) As String
        FileOpen(fn, ".Courses.id", OpenMode.Random,,, rlx)
        Do While Not EOF(fn)
            FileGet(fn, cS, x)
            If Trim(courseName).ToUpper = Trim(cS.courseTitle).ToUpper Then
                With cS
                    details = {Trim(.Abbr), Trim(.code), Trim(.depart), Trim(.fac), Trim(Join(.programs, ",")), Trim(.type), Trim(Join(.units, ",")), .Duration.ToString, .tuition.ToString}
                End With
                Exit Do
            End If
            x += 1
        Loop
        FileClose(fn)
        Return details
    End Function
    Private Sub BarButtonItem8_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem8.ItemClick
        PaymentTableBindingSource.AddNew()
        DateEdit1.EditValue = Today
        FlyoutPanel1.ShowPopup()
    End Sub

    Private Sub SearchLookUpEdit1_EditValueChanged(sender As Object, e As EventArgs) Handles SearchLookUpEdit1.EditValueChanged
        If SearchLookUpEdit1.EditValue IsNot Nothing AndAlso Not IsDBNull(SearchLookUpEdit1.EditValue) Then
            TextEdit6.EditValue = getStudentDetails(SearchLookUpEdit1.EditValue.ToString)(0)
            coursetextEdit.EditValue = getStudentDetails(SearchLookUpEdit1.EditValue.ToString)(1)
            SimpleLabelItem1.Text = TextEdit6.EditValue.ToString & " - " & SearchLookUpEdit1.EditValue.ToString
        Else
            Return
        End If
    End Sub

    Private Sub coursetextEdit_EditValueChanged(sender As Object, e As EventArgs) Handles coursetextEdit.EditValueChanged
        payFieldcombo.Properties.Items.Clear()
        If coursetextEdit.EditValue IsNot Nothing AndAlso Not IsDBNull(coursetextEdit.EditValue) Then
            Dim d = getcourseDetails(coursetextEdit.EditValue.ToString)(8)
            payFieldcombo.Properties.Items.Add("Tuition : " & d) '& getcourseDetails(coursetextEdit.EditValue.ToString)(8).ToString)
        Else
            Return
        End If
    End Sub

    Private Sub payFieldcombo_EditValueChanged(sender As Object, e As EventArgs) Handles payFieldcombo.EditValueChanged
        If payFieldcombo.EditValue IsNot Nothing Then
            Dim sum As Decimal
            For Each filed As String In payFieldcombo.EditValue.ToString.Split({","}, StringSplitOptions.RemoveEmptyEntries)
                sum += CDec(filed.Split({":"}, StringSplitOptions.RemoveEmptyEntries)(1))

            Next
            TextEdit4.EditValue = CInt(sum)
        Else
            Return
        End If
    End Sub

    Private Sub TextEdit4_EditValueChanged(sender As Object, e As EventArgs) Handles TextEdit4.EditValueChanged, TextEdit1.EditValueChanged
        If Not IsDBNull(TextEdit4.EditValue) AndAlso Not IsDBNull(TextEdit1.EditValue) Then
            TextEdit5.EditValue = CDec(TextEdit4.EditValue) - CDec(TextEdit1.EditValue)
        End If
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Me.PaymentTableBindingSource.EndEdit()
        Me.PaymentTableTableAdapter.Update(Me.InstituteDataDataSet.PaymentTable)
        Me.PaymentTableBindingSource.AddNew()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        FlyoutPanel1.HidePopup()
        Me.PaymentTableBindingSource.CancelEdit()

    End Sub

    Private Sub TextEdit6_EditValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub BarButtonItem6_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem6.ItemClick
        Year_RegisterBindingSource.AddNew()
        FlyoutPanel2.ShowPopup()

    End Sub

    Private Sub FlyoutPanel2_ButtonClick(sender As Object, e As DevExpress.Utils.FlyoutPanelButtonClickEventArgs) Handles FlyoutPanel2.ButtonClick
        If e.Button.Tag Is "Save" Then
            Year_RegisterBindingSource.EndEdit()
            Year_RegisterTableAdapter.Update(Me.InstituteDataDataSet.Year_Register)
            Year_RegisterBindingSource.AddNew()
        ElseIf e.Button.Tag Is "Previous" Then
            '   Year_RegisterBindingSource.EndEdit()
            Year_RegisterBindingSource.MovePrevious()
        ElseIf e.Button.Tag Is "Next" Then
            ' Year_RegisterBindingSource.EndEdit()
            Year_RegisterBindingSource.MoveNext()
        ElseIf e.Button.Tag Is "Cancel" Then
            Year_RegisterBindingSource.CancelEdit()
            FlyoutPanel2.HidePopup()
        ElseIf e.Button.Tag Is "Last" Then
            Year_RegisterBindingSource.MoveLast
        ElseIf e.Button.Tag Is "First" Then
            Year_RegisterBindingSource.MoveFirst
        End If
    End Sub

    Private Sub SearchLookUpEdit2_EditValueChanged(sender As Object, e As EventArgs) Handles SearchLookUpEdit2.EditValueChanged
        If SearchLookUpEdit2.EditValue IsNot Nothing AndAlso Not IsDBNull(SearchLookUpEdit2.EditValue) Then
            HyperLinkEdit1.EditValue = getStudentDetails(SearchLookUpEdit2.EditValue.ToString)(0)
            TextEdit7.EditValue = getStudentDetails(SearchLookUpEdit2.EditValue.ToString)(1)
            SimpleLabelItem2.Text = HyperLinkEdit1.EditValue.ToString & " - " & SearchLookUpEdit2.EditValue.ToString
        Else
            Return
        End If
    End Sub

    Private Sub TextEdit7_EditValueChanged(sender As Object, e As EventArgs) Handles TextEdit7.EditValueChanged
        '  payFieldcombo.Properties.Items.Clear()
        If TextEdit7.EditValue IsNot Nothing AndAlso Not IsDBNull(TextEdit7.EditValue) Then
            FacultyTextEdit.EditValue = getcourseDetails(TextEdit7.EditValue.ToString)(3)
            DepartmentTextEdit.EditValue = getcourseDetails(TextEdit7.EditValue.ToString)(2)
            DurationTextEdit.EditValue = Val(getcourseDetails(TextEdit7.EditValue.ToString)(7))
            unitsTextEdit.Properties.Tokens.Clear()
            For Each unit As String In getcourseDetails(TextEdit7.EditValue.ToString)(6).Split({","}, StringSplitOptions.RemoveEmptyEntries)
                If unit <> "                                                  " Then
                    unitsTextEdit.Properties.Tokens.AddToken(New TokenEditToken(Trim(unit), Trim(unit)))
                End If
            Next
        Else
            Return
        End If
    End Sub
End Class