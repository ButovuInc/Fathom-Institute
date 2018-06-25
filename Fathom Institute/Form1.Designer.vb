Partial Public Class Form1
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm

    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Windows Form Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim ContextButton1 As DevExpress.Utils.ContextButton = New DevExpress.Utils.ContextButton()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim ContextButton2 As DevExpress.Utils.ContextButton = New DevExpress.Utils.ContextButton()
        Dim GridFormatRule1 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleUniqueDuplicate1 As DevExpress.XtraEditors.FormatConditionRuleUniqueDuplicate = New DevExpress.XtraEditors.FormatConditionRuleUniqueDuplicate()
        Dim GridFormatRule2 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleDateOccuring1 As DevExpress.XtraEditors.FormatConditionRuleDateOccuring = New DevExpress.XtraEditors.FormatConditionRuleDateOccuring()
        Dim EditorButtonImageOptions1 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject4 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim GridLevelNode2 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim GridLevelNode3 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim GridFormatRule3 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleUniqueDuplicate2 As DevExpress.XtraEditors.FormatConditionRuleUniqueDuplicate = New DevExpress.XtraEditors.FormatConditionRuleUniqueDuplicate()
        Dim GridFormatRule4 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleTopBottom1 As DevExpress.XtraEditors.FormatConditionRuleTopBottom = New DevExpress.XtraEditors.FormatConditionRuleTopBottom()
        Dim GridFormatRule5 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleDataBar1 As DevExpress.XtraEditors.FormatConditionRuleDataBar = New DevExpress.XtraEditors.FormatConditionRuleDataBar()
        Dim SplashScreenManager1 As DevExpress.XtraSplashScreen.SplashScreenManager = New DevExpress.XtraSplashScreen.SplashScreenManager(Me, GetType(Global.Fathom_Institute.SplashScreen1), True, True, True)
        Dim GridLevelNode4 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim GridLevelNode5 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim GridLevelNode6 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim GridLevelNode7 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim GridLevelNode8 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim GridLevelNode9 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim GridLevelNode10 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim GridLevelNode11 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim GridLevelNode12 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim GridLevelNode13 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim GridLevelNode14 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim GridFormatRule6 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleDateOccuring2 As DevExpress.XtraEditors.FormatConditionRuleDateOccuring = New DevExpress.XtraEditors.FormatConditionRuleDateOccuring()
        Dim GridFormatRule7 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleDataBar2 As DevExpress.XtraEditors.FormatConditionRuleDataBar = New DevExpress.XtraEditors.FormatConditionRuleDataBar()
        Dim ButtonImageOptions1 As DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions = New DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions()
        Dim ButtonImageOptions2 As DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions = New DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions()
        Dim ButtonImageOptions3 As DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions = New DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions()
        Dim ButtonImageOptions4 As DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions = New DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions()
        Dim ButtonImageOptions5 As DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions = New DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions()
        Dim ButtonImageOptions6 As DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions = New DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions()
        Dim GridLevelNode15 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim GridLevelNode16 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim GridLevelNode17 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim GridLevelNode18 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim GridLevelNode19 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim GridLevelNode20 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim GridLevelNode21 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim GridLevelNode22 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim GridLevelNode23 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim GridLevelNode24 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim GridLevelNode25 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim GridLevelNode26 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim GridLevelNode27 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim GridLevelNode28 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim GridLevelNode29 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim GridLevelNode30 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim GridLevelNode31 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim GridLevelNode32 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim GridLevelNode33 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim GridLevelNode34 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim GridLevelNode35 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim GridLevelNode36 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim GridLevelNode37 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim GridLevelNode38 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim GridLevelNode39 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim GridLevelNode40 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim GridLevelNode41 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim GridLevelNode42 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim GridLevelNode43 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim GridLevelNode44 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim GridLevelNode45 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim GridLevelNode46 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim GridLevelNode47 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim GridLevelNode48 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim GridLevelNode49 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim GridLevelNode50 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim GridLevelNode51 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim GridLevelNode52 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim GridLevelNode53 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim GridLevelNode54 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim GridLevelNode55 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim GridLevelNode56 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim GridLevelNode57 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim TileItemElement1 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement2 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemFrame1 As DevExpress.XtraEditors.TileItemFrame = New DevExpress.XtraEditors.TileItemFrame()
        Dim TileItemElement3 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemFrame2 As DevExpress.XtraEditors.TileItemFrame = New DevExpress.XtraEditors.TileItemFrame()
        Dim TileItemElement4 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement5 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement16 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement17 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemFrame7 As DevExpress.XtraEditors.TileItemFrame = New DevExpress.XtraEditors.TileItemFrame()
        Dim TileItemElement18 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemFrame8 As DevExpress.XtraEditors.TileItemFrame = New DevExpress.XtraEditors.TileItemFrame()
        Dim TileItemElement19 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement20 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement6 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement7 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemFrame3 As DevExpress.XtraEditors.TileItemFrame = New DevExpress.XtraEditors.TileItemFrame()
        Dim TileItemElement8 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemFrame4 As DevExpress.XtraEditors.TileItemFrame = New DevExpress.XtraEditors.TileItemFrame()
        Dim TileItemElement9 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement10 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement11 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement12 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemFrame5 As DevExpress.XtraEditors.TileItemFrame = New DevExpress.XtraEditors.TileItemFrame()
        Dim TileItemElement13 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemFrame6 As DevExpress.XtraEditors.TileItemFrame = New DevExpress.XtraEditors.TileItemFrame()
        Dim TileItemElement14 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement15 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement21 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Me.CardView1 = New DevExpress.XtraGrid.Views.Card.CardView()
        Me.StudentInfoGridControl = New DevExpress.XtraGrid.GridControl()
        Me.StudentInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InstituteDataDataSet = New Fathom_Institute.instituteDataDataSet()
        Me.PersistentRepository1 = New DevExpress.XtraEditors.Repository.PersistentRepository(Me.components)
        Me.regedit = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.reglookUp = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
        Me.GridView7 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.nameLookup = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
        Me.GridView8 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.courseLookup = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
        Me.CoursesTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView9 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.fieldglookUP = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.OtherFeesTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView10 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.feegLookup = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.GridView11 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.banknameCombo = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.MoneyText = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.SEmCombo = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.yearCombo = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.DateEdit = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.otextEdit = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.photoEdit = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
        Me.nationCombo = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.religionCombo = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.studprogcombo = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.telToken = New DevExpress.XtraEditors.Repository.RepositoryItemTokenEdit()
        Me.sponsorCombo = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.levelCombo = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.AdvBandedGridView1 = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView()
        Me.gridBand2 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.colStudentsName = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.RepositoryItemPopupContainerEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit()
        Me.PopupContainerControl1 = New DevExpress.XtraEditors.PopupContainerControl()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.oNedit = New DevExpress.XtraEditors.TextEdit()
        Me.ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem5 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem6 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem7 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem8 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem9 = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPageCategory1 = New DevExpress.XtraBars.Ribbon.RibbonPageCategory()
        Me.registerTab = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup4 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup8 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.yearTab = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup6 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup10 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.payTab = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup5 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup7 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup11 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.coursesTab = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.AccountsTab = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup9 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonStatusBar1 = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.surNedit = New DevExpress.XtraEditors.TextEdit()
        Me.fisrtNedit = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem17 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem18 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem19 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.colregistrationnumber = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colregistrationdate = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.regdate = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.GridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.colPhoto = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.gridBand5 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.colnationality = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.coltribe = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colreligion = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.coldateofbirth = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colbirthdistrict = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colresidence = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.gridBand3 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.colProgramme = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colcoursename = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.gridBand4 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.colguardian1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colguardian2 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colguardian1contact = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colguardian2contact = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.gridBand6 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.colnin = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colphonecontact = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colsponsorship = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colemail = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.gridBand7 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.coldocumentsverified = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.paperschk = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.colLastAcademicLevel = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.RepositoryItemImageComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
        Me.RepositoryItemComboBox2 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.PROGcOMB = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.COURSEGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.RepositoryItemGridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.CardView2 = New DevExpress.XtraGrid.Views.Card.CardView()
        Me.colPhoto1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStudentsName1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colregistrationnumber1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProgramme1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colphonecontact1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsponsorship1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CoursesTableGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colcoursename1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcourseAbbr = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcoursecode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colyears = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemSpinEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.colcourseunits = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.unitstoken = New DevExpress.XtraEditors.Repository.RepositoryItemTokenEdit()
        Me.colcoursetype = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TYPEEDIT = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.colprogrammes = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.progedit = New DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit()
        Me.coltuitionfee = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.MoneyEdit = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colfaculty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.fLookUp = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.coldepartment = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.dLookUp = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colpaymentdate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Balance = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NavigationFrame1 = New DevExpress.XtraBars.Navigation.NavigationFrame()
        Me.NavigationPage1 = New DevExpress.XtraBars.Navigation.NavigationPage()
        Me.GridSplitContainer1 = New DevExpress.XtraGrid.GridSplitContainer()
        Me.NavigationPage2 = New DevExpress.XtraBars.Navigation.NavigationPage()
        Me.NavigationPage4 = New DevExpress.XtraBars.Navigation.NavigationPage()
        Me.FlyoutPanel1 = New DevExpress.Utils.FlyoutPanel()
        Me.FlyoutPanelControl1 = New DevExpress.Utils.FlyoutPanelControl()
        Me.DataLayoutControl1 = New DevExpress.XtraDataLayout.DataLayoutControl()
        Me.TextEdit6 = New DevExpress.XtraEditors.TextEdit()
        Me.PaymentTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TextEdit5 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit4 = New DevExpress.XtraEditors.TextEdit()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.SearchLookUpEdit1 = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colregistrationnumber4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStudentsName4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcoursename3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProgramme2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsponsorship2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.semesterComboBoxEdit = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.ComboBoxEdit1 = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.DateEdit1 = New DevExpress.XtraEditors.DateEdit()
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit2 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit3 = New DevExpress.XtraEditors.TextEdit()
        Me.coursetextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.payFieldcombo = New DevExpress.XtraEditors.CheckedComboBoxEdit()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForsemester = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.SimpleLabelItem1 = New DevExpress.XtraLayout.SimpleLabelItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.SimpleSeparator1 = New DevExpress.XtraLayout.SimpleSeparator()
        Me.AccountsTableGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colregistrationnumber2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStudentsName2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcoursename2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsemester = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colacademicyear = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colpaymentfield = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colamountpaid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coltotalfees = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colbankname = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colslipnumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NavigationPage5 = New DevExpress.XtraBars.Navigation.NavigationPage()
        Me.FlyoutPanel2 = New DevExpress.Utils.FlyoutPanel()
        Me.FlyoutPanelControl2 = New DevExpress.Utils.FlyoutPanelControl()
        Me.DataLayoutControl2 = New DevExpress.XtraDataLayout.DataLayoutControl()
        Me.SearchLookUpEdit2 = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.Year_RegisterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SearchLookUpEdit2View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.HyperLinkEdit1 = New DevExpress.XtraEditors.HyperLinkEdit()
        Me.FacultyTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.DepartmentTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit7 = New DevExpress.XtraEditors.TextEdit()
        Me.YearComboBoxEdit = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.DurationTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.DateEdit2 = New DevExpress.XtraEditors.DateEdit()
        Me.RetakeCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.ComboBoxEdit2 = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.ComboBoxEdit3 = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.unitsTextEdit = New DevExpress.XtraEditors.TokenEdit()
        Me.LayoutControlGroup4 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup5 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.TabbedControlGroup1 = New DevExpress.XtraLayout.TabbedControlGroup()
        Me.LayoutControlGroup7 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForFaculty = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForDepartment = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForCourse = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForYear = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForDuration = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup6 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem21 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForunits = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem20 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForRetake = New DevExpress.XtraLayout.LayoutControlItem()
        Me.SimpleLabelItem2 = New DevExpress.XtraLayout.SimpleLabelItem()
        Me.Year_RegisterGridControl = New DevExpress.XtraGrid.GridControl()
        Me.AdvBandedGridView2 = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView()
        Me.GridBand8 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.colRegistrationNumber3 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colStudentsName3 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colFaculty1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colDepartment1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colCourse = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colYear = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colDuration = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.gridBand9 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.colRetake = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colRegistrationDate1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colRetakeYear = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colRetakeSemester = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colunits = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.namesearch = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
        Me.RepositoryItemSearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.facgrid = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.deptgrid = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.RepositoryItemGridLookUpEdit2View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.coursegrid = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.GridView5 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.regsearch = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
        Me.GridView6 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.RepositoryItemDateEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.NavigationPage6 = New DevExpress.XtraBars.Navigation.NavigationPage()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView13 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.OtherFeesTableGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView12 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colfield = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colfee = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DefaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
        Me.DockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.hideContainerRight = New DevExpress.XtraBars.Docking.AutoHideContainer()
        Me.DockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.StudentInfoTableAdapter = New Fathom_Institute.instituteDataDataSetTableAdapters.StudentInfoTableAdapter()
        Me.TableAdapterManager = New Fathom_Institute.instituteDataDataSetTableAdapters.TableAdapterManager()
        Me.CoursesTableTableAdapter = New Fathom_Institute.instituteDataDataSetTableAdapters.coursesTableTableAdapter()
        Me.AdornerUIManager1 = New DevExpress.Utils.VisualEffects.AdornerUIManager(Me.components)
        Me.Badge1 = New DevExpress.Utils.VisualEffects.Badge()
        Me.TileItem2 = New DevExpress.XtraEditors.TileItem()
        Me.Badge2 = New DevExpress.Utils.VisualEffects.Badge()
        Me.TileItem1 = New DevExpress.XtraEditors.TileItem()
        Me.TileControl1 = New DevExpress.XtraEditors.TileControl()
        Me.TileGroup2 = New DevExpress.XtraEditors.TileGroup()
        Me.TileItem5 = New DevExpress.XtraEditors.TileItem()
        Me.TileItem3 = New DevExpress.XtraEditors.TileItem()
        Me.TileItem4 = New DevExpress.XtraEditors.TileItem()
        Me.NavigationPage3 = New DevExpress.XtraBars.Navigation.NavigationPage()
        Me.Year_RegisterTableAdapter = New Fathom_Institute.instituteDataDataSetTableAdapters.Year_RegisterTableAdapter()
        Me.PaymentTableTableAdapter = New Fathom_Institute.instituteDataDataSetTableAdapters.PaymentTableTableAdapter()
        Me.OtherFeesTableTableAdapter = New Fathom_Institute.instituteDataDataSetTableAdapters.OtherFeesTableTableAdapter()
        CType(Me.CardView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentInfoGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InstituteDataDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.regedit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.reglookUp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nameLookup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.courseLookup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CoursesTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fieldglookUP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OtherFeesTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.feegLookup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.banknameCombo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MoneyText, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SEmCombo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.yearCombo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.otextEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.photoEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nationCombo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.religionCombo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.studprogcombo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.telToken, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sponsorCombo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.levelCombo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdvBandedGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemPopupContainerEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PopupContainerControl1.SuspendLayout()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.oNedit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.surNedit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fisrtNedit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.regdate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.regdate.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.paperschk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PROGcOMB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.COURSEGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CardView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CoursesTableGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.unitstoken, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TYPEEDIT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.progedit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MoneyEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fLookUp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dLookUp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NavigationFrame1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NavigationFrame1.SuspendLayout()
        Me.NavigationPage1.SuspendLayout()
        CType(Me.GridSplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GridSplitContainer1.SuspendLayout()
        Me.NavigationPage2.SuspendLayout()
        Me.NavigationPage4.SuspendLayout()
        CType(Me.FlyoutPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlyoutPanel1.SuspendLayout()
        CType(Me.FlyoutPanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlyoutPanelControl1.SuspendLayout()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DataLayoutControl1.SuspendLayout()
        CType(Me.TextEdit6.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PaymentTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit5.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.semesterComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.coursetextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.payFieldcombo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForsemester, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SimpleLabelItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SimpleSeparator1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccountsTableGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NavigationPage5.SuspendLayout()
        CType(Me.FlyoutPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlyoutPanel2.SuspendLayout()
        CType(Me.FlyoutPanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlyoutPanelControl2.SuspendLayout()
        CType(Me.DataLayoutControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DataLayoutControl2.SuspendLayout()
        CType(Me.SearchLookUpEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Year_RegisterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit2View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HyperLinkEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacultyTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DepartmentTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit7.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.YearComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DurationTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RetakeCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComboBoxEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComboBoxEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.unitsTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabbedControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForFaculty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForDepartment, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForCourse, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForYear, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForDuration, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForunits, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForRetake, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SimpleLabelItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Year_RegisterGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdvBandedGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.namesearch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.facgrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deptgrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit2View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.coursegrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.regsearch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit2.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NavigationPage6.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OtherFeesTableGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.hideContainerRight.SuspendLayout()
        Me.DockPanel1.SuspendLayout()
        CType(Me.AdornerUIManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CardView1
        '
        Me.CardView1.FocusedCardTopFieldIndex = 0
        Me.CardView1.GridControl = Me.StudentInfoGridControl
        Me.CardView1.Name = "CardView1"
        '
        'StudentInfoGridControl
        '
        Me.StudentInfoGridControl.DataSource = Me.StudentInfoBindingSource
        Me.StudentInfoGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.StudentInfoGridControl.EmbeddedNavigator.TextStringFormat = "Student {0} of {1}"
        Me.StudentInfoGridControl.ExternalRepository = Me.PersistentRepository1
        GridLevelNode1.LevelTemplate = Me.CardView1
        Me.StudentInfoGridControl.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.StudentInfoGridControl.Location = New System.Drawing.Point(0, 0)
        Me.StudentInfoGridControl.MainView = Me.AdvBandedGridView1
        Me.StudentInfoGridControl.MenuManager = Me.ribbonControl1
        Me.StudentInfoGridControl.Name = "StudentInfoGridControl"
        Me.StudentInfoGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemPopupContainerEdit1, Me.RepositoryItemComboBox1, Me.RepositoryItemImageComboBox1, Me.RepositoryItemComboBox2, Me.RepositoryItemDateEdit1, Me.regdate, Me.paperschk, Me.PROGcOMB, Me.COURSEGridLookUpEdit})
        Me.StudentInfoGridControl.Size = New System.Drawing.Size(1694, 742)
        Me.StudentInfoGridControl.TabIndex = 0
        Me.StudentInfoGridControl.UseEmbeddedNavigator = True
        Me.StudentInfoGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.AdvBandedGridView1, Me.CardView1})
        '
        'StudentInfoBindingSource
        '
        Me.StudentInfoBindingSource.DataMember = "StudentInfo"
        Me.StudentInfoBindingSource.DataSource = Me.InstituteDataDataSet
        '
        'InstituteDataDataSet
        '
        Me.InstituteDataDataSet.DataSetName = "instituteDataDataSet"
        Me.InstituteDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PersistentRepository1
        '
        Me.PersistentRepository1.Items.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.regedit, Me.reglookUp, Me.nameLookup, Me.courseLookup, Me.fieldglookUP, Me.feegLookup, Me.banknameCombo, Me.MoneyText, Me.SEmCombo, Me.yearCombo, Me.DateEdit, Me.otextEdit, Me.photoEdit, Me.nationCombo, Me.religionCombo, Me.studprogcombo, Me.telToken, Me.sponsorCombo, Me.levelCombo})
        '
        'regedit
        '
        Me.regedit.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.regedit.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.None
        Me.regedit.MaxLength = 50
        Me.regedit.Name = "regedit"
        Me.regedit.NullValuePrompt = "Enter Registration Number..."
        '
        'reglookUp
        '
        Me.reglookUp.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit
        Me.reglookUp.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.reglookUp.CascadingMember = "registration number;Students Name"
        Me.reglookUp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.reglookUp.DataSource = Me.StudentInfoBindingSource
        Me.reglookUp.DisplayMember = "registration number"
        Me.reglookUp.Name = "reglookUp"
        Me.reglookUp.NullText = ""
        Me.reglookUp.NullValuePrompt = "Select Registration Number"
        Me.reglookUp.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.reglookUp.PopupView = Me.GridView7
        Me.reglookUp.PopupWidthMode = DevExpress.XtraEditors.PopupWidthMode.ContentWidth
        Me.reglookUp.ValueMember = "registration number"
        '
        'GridView7
        '
        Me.GridView7.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView7.Name = "GridView7"
        Me.GridView7.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView7.OptionsView.ShowGroupPanel = False
        '
        'nameLookup
        '
        Me.nameLookup.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.nameLookup.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.nameLookup.DataSource = Me.StudentInfoBindingSource
        Me.nameLookup.DisplayMember = "Students Name"
        Me.nameLookup.Name = "nameLookup"
        Me.nameLookup.NullText = ""
        Me.nameLookup.PopupView = Me.GridView8
        Me.nameLookup.ValueMember = "Students Name"
        '
        'GridView8
        '
        Me.GridView8.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView8.Name = "GridView8"
        Me.GridView8.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView8.OptionsView.ShowGroupPanel = False
        '
        'courseLookup
        '
        Me.courseLookup.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.courseLookup.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.courseLookup.DataSource = Me.CoursesTableBindingSource
        Me.courseLookup.DisplayMember = "course name"
        Me.courseLookup.Name = "courseLookup"
        Me.courseLookup.NullText = ""
        Me.courseLookup.PopupView = Me.GridView9
        Me.courseLookup.PopupWidthMode = DevExpress.XtraEditors.PopupWidthMode.UseEditorWidth
        Me.courseLookup.ValueMember = "course name"
        '
        'CoursesTableBindingSource
        '
        Me.CoursesTableBindingSource.DataMember = "coursesTable"
        Me.CoursesTableBindingSource.DataSource = Me.InstituteDataDataSet
        '
        'GridView9
        '
        Me.GridView9.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView9.Name = "GridView9"
        Me.GridView9.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView9.OptionsView.ShowGroupPanel = False
        '
        'fieldglookUP
        '
        Me.fieldglookUP.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.fieldglookUP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.fieldglookUP.DataSource = Me.OtherFeesTableBindingSource
        Me.fieldglookUP.DisplayMember = "field"
        Me.fieldglookUP.ImmediatePopup = True
        Me.fieldglookUP.Name = "fieldglookUP"
        Me.fieldglookUP.NullText = ""
        Me.fieldglookUP.PopupView = Me.GridView10
        Me.fieldglookUP.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.fieldglookUP.ValueMember = "field"
        '
        'OtherFeesTableBindingSource
        '
        Me.OtherFeesTableBindingSource.DataMember = "OtherFeesTable"
        Me.OtherFeesTableBindingSource.DataSource = Me.InstituteDataDataSet
        '
        'GridView10
        '
        Me.GridView10.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView10.Name = "GridView10"
        Me.GridView10.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView10.OptionsView.ShowGroupPanel = False
        '
        'feegLookup
        '
        Me.feegLookup.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.feegLookup.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.feegLookup.DataSource = Me.OtherFeesTableBindingSource
        Me.feegLookup.DisplayFormat.FormatString = "{0} Ugx"
        Me.feegLookup.DisplayMember = "field"
        Me.feegLookup.ImmediatePopup = True
        Me.feegLookup.Name = "feegLookup"
        Me.feegLookup.NullText = ""
        Me.feegLookup.PopupView = Me.GridView11
        Me.feegLookup.PopupWidthMode = DevExpress.XtraEditors.PopupWidthMode.ContentWidth
        Me.feegLookup.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.feegLookup.ValueMember = "fee"
        '
        'GridView11
        '
        Me.GridView11.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView11.Name = "GridView11"
        Me.GridView11.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView11.OptionsView.ShowGroupPanel = False
        '
        'banknameCombo
        '
        Me.banknameCombo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.banknameCombo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.banknameCombo.ImmediatePopup = True
        Me.banknameCombo.Items.AddRange(New Object() {"Centenury Bank", "DFCU Banck", "Post Bank", "Stanbic Bank"})
        Me.banknameCombo.Name = "banknameCombo"
        Me.banknameCombo.Sorted = True
        '
        'MoneyText
        '
        Me.MoneyText.DisplayFormat.FormatString = "{0} Ugx"
        Me.MoneyText.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.MoneyText.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.MoneyText.Name = "MoneyText"
        '
        'SEmCombo
        '
        Me.SEmCombo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SEmCombo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.SEmCombo.ImmediatePopup = True
        Me.SEmCombo.Items.AddRange(New Object() {"I", "II"})
        Me.SEmCombo.Name = "SEmCombo"
        Me.SEmCombo.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'yearCombo
        '
        Me.yearCombo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.yearCombo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.yearCombo.ImmediatePopup = True
        Me.yearCombo.Items.AddRange(New Object() {"I", "II", "III", "IV", "V"})
        Me.yearCombo.Name = "yearCombo"
        Me.yearCombo.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'DateEdit
        '
        Me.DateEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DateEdit.DisplayFormat.FormatString = "d/MMM/yy"
        Me.DateEdit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.DateEdit.EditFormat.FormatString = "d/MMM/yy"
        Me.DateEdit.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.DateEdit.Mask.EditMask = "d/MMM/yy"
        Me.DateEdit.Name = "DateEdit"
        '
        'otextEdit
        '
        Me.otextEdit.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.otextEdit.DisplayFormat.FormatString = "{###}#-######"
        Me.otextEdit.MaxLength = 50
        Me.otextEdit.Name = "otextEdit"
        '
        'photoEdit
        '
        ContextButton1.AlignmentOptions.Position = DevExpress.Utils.ContextItemPosition.Far
        ContextButton1.AnimationType = DevExpress.Utils.ContextAnimationType.OutAnimation
        ContextButton1.Id = New System.Guid("f278a47d-cbc2-412f-9003-b07340b14fd2")
        ContextButton1.ImageOptions.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        ContextButton1.ImageOptions.SvgImage = CType(resources.GetObject("resource.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        ContextButton1.ImageOptions.SvgImageSize = New System.Drawing.Size(16, 16)
        ContextButton1.Name = "picDeleteBtn"
        ContextButton2.Id = New System.Guid("29d0a69c-a305-43b8-b781-5dfde7acb37e")
        ContextButton2.ImageOptions.SvgImage = CType(resources.GetObject("resource.SvgImage1"), DevExpress.Utils.Svg.SvgImage)
        ContextButton2.ImageOptions.SvgImageSize = New System.Drawing.Size(16, 16)
        ContextButton2.Name = "picLoad"
        Me.photoEdit.ContextButtons.Add(ContextButton1)
        Me.photoEdit.ContextButtons.Add(ContextButton2)
        Me.photoEdit.EnableLODImages = True
        Me.photoEdit.Name = "photoEdit"
        Me.photoEdit.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.photoEdit.ShowZoomSubMenu = DevExpress.Utils.DefaultBoolean.[True]
        Me.photoEdit.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
        '
        'nationCombo
        '
        Me.nationCombo.AutoHeight = False
        Me.nationCombo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.nationCombo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.nationCombo.ItemAutoHeight = True
        Me.nationCombo.Items.AddRange(New Object() {"Congolese", "Kenyan", "Rwandanese", "Sudanese", "Tanzanian", "Ugandan"})
        Me.nationCombo.Name = "nationCombo"
        Me.nationCombo.Sorted = True
        Me.nationCombo.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'religionCombo
        '
        Me.religionCombo.AutoHeight = False
        Me.religionCombo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.religionCombo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.religionCombo.Items.AddRange(New Object() {"Christian", "Happy Science", "Muslim", "Orthodox", "Other"})
        Me.religionCombo.Name = "religionCombo"
        Me.religionCombo.Sorted = True
        Me.religionCombo.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'studprogcombo
        '
        Me.studprogcombo.AutoHeight = False
        Me.studprogcombo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.studprogcombo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.studprogcombo.Items.AddRange(New Object() {"Day", "Evening", "Morning", "Online", "Weekend"})
        Me.studprogcombo.Name = "studprogcombo"
        Me.studprogcombo.Sorted = True
        Me.studprogcombo.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'telToken
        '
        Me.telToken.DisplayFormat.FormatString = "{###}#-######"
        Me.telToken.EditMode = DevExpress.XtraEditors.TokenEditMode.Manual
        Me.telToken.MaxExpandLines = 2
        Me.telToken.MaxTokenCount = 1
        Me.telToken.Name = "telToken"
        Me.telToken.PopupFilterMode = DevExpress.XtraEditors.TokenEditPopupFilterMode.Contains
        Me.telToken.ShowRemoveTokenButtons = True
        '
        'sponsorCombo
        '
        Me.sponsorCombo.AutoHeight = False
        Me.sponsorCombo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sponsorCombo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.sponsorCombo.Items.AddRange(New Object() {"Bursary", "Government", "Private"})
        Me.sponsorCombo.Name = "sponsorCombo"
        Me.sponsorCombo.Sorted = True
        '
        'levelCombo
        '
        Me.levelCombo.AutoHeight = False
        Me.levelCombo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.levelCombo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.levelCombo.Items.AddRange(New Object() {"A Level", "Cerificate", "Degree", "Diploma", "Masters", "O' Level"})
        Me.levelCombo.Name = "levelCombo"
        Me.levelCombo.Sorted = True
        Me.levelCombo.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'AdvBandedGridView1
        '
        Me.AdvBandedGridView1.Appearance.EvenRow.Options.UseTextOptions = True
        Me.AdvBandedGridView1.Appearance.EvenRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.AdvBandedGridView1.Appearance.OddRow.Options.UseTextOptions = True
        Me.AdvBandedGridView1.Appearance.OddRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.AdvBandedGridView1.Appearance.Row.Options.UseTextOptions = True
        Me.AdvBandedGridView1.Appearance.Row.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.AdvBandedGridView1.Appearance.SelectedRow.Options.UseTextOptions = True
        Me.AdvBandedGridView1.Appearance.SelectedRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.AdvBandedGridView1.AppearancePrint.BandPanel.Options.UseTextOptions = True
        Me.AdvBandedGridView1.AppearancePrint.BandPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.AdvBandedGridView1.AppearancePrint.EvenRow.Options.UseTextOptions = True
        Me.AdvBandedGridView1.AppearancePrint.EvenRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.AdvBandedGridView1.AppearancePrint.FilterPanel.Options.UseTextOptions = True
        Me.AdvBandedGridView1.AppearancePrint.FilterPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.AdvBandedGridView1.AppearancePrint.FooterPanel.Options.UseTextOptions = True
        Me.AdvBandedGridView1.AppearancePrint.FooterPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.AdvBandedGridView1.AppearancePrint.GroupFooter.Options.UseTextOptions = True
        Me.AdvBandedGridView1.AppearancePrint.GroupFooter.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.AdvBandedGridView1.AppearancePrint.GroupRow.Options.UseTextOptions = True
        Me.AdvBandedGridView1.AppearancePrint.GroupRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.AdvBandedGridView1.AppearancePrint.HeaderPanel.Options.UseTextOptions = True
        Me.AdvBandedGridView1.AppearancePrint.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.AdvBandedGridView1.AppearancePrint.Lines.Options.UseTextOptions = True
        Me.AdvBandedGridView1.AppearancePrint.Lines.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.AdvBandedGridView1.AppearancePrint.OddRow.Options.UseTextOptions = True
        Me.AdvBandedGridView1.AppearancePrint.OddRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.AdvBandedGridView1.AppearancePrint.Preview.Options.UseTextOptions = True
        Me.AdvBandedGridView1.AppearancePrint.Preview.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.AdvBandedGridView1.AppearancePrint.Row.Options.UseTextOptions = True
        Me.AdvBandedGridView1.AppearancePrint.Row.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.AdvBandedGridView1.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.gridBand2, Me.GridBand1, Me.gridBand5, Me.gridBand3, Me.gridBand4, Me.gridBand6, Me.gridBand7})
        Me.AdvBandedGridView1.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.colregistrationnumber, Me.colStudentsName, Me.colPhoto, Me.colnationality, Me.coltribe, Me.colreligion, Me.coldateofbirth, Me.colresidence, Me.colbirthdistrict, Me.colnin, Me.colemail, Me.colphonecontact, Me.colguardian1, Me.colguardian1contact, Me.colguardian2, Me.colguardian2contact, Me.colcoursename, Me.colProgramme, Me.colsponsorship, Me.colLastAcademicLevel, Me.coldocumentsverified, Me.colregistrationdate})
        Me.AdvBandedGridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus
        GridFormatRule1.ApplyToRow = True
        GridFormatRule1.Column = Me.colStudentsName
        GridFormatRule1.ColumnApplyTo = Me.colStudentsName
        GridFormatRule1.Name = "Format0"
        FormatConditionRuleUniqueDuplicate1.PredefinedName = "Strikeout Text"
        GridFormatRule1.Rule = FormatConditionRuleUniqueDuplicate1
        GridFormatRule2.Column = Me.colregistrationdate
        GridFormatRule2.ColumnApplyTo = Me.colStudentsName
        GridFormatRule2.Name = "Format1"
        FormatConditionRuleDateOccuring1.DateType = DevExpress.XtraEditors.FilterDateType.Today
        FormatConditionRuleDateOccuring1.PredefinedName = "Bold Text"
        GridFormatRule2.Rule = FormatConditionRuleDateOccuring1
        Me.AdvBandedGridView1.FormatRules.Add(GridFormatRule1)
        Me.AdvBandedGridView1.FormatRules.Add(GridFormatRule2)
        Me.AdvBandedGridView1.GridControl = Me.StudentInfoGridControl
        Me.AdvBandedGridView1.Name = "AdvBandedGridView1"
        Me.AdvBandedGridView1.OptionsBehavior.AllowIncrementalSearch = True
        Me.AdvBandedGridView1.OptionsBehavior.AllowSortAnimation = DevExpress.Utils.DefaultBoolean.[True]
        Me.AdvBandedGridView1.OptionsBehavior.AutoExpandAllGroups = True
        Me.AdvBandedGridView1.OptionsBehavior.SummariesIgnoreNullValues = True
        Me.AdvBandedGridView1.OptionsBehavior.UnboundColumnExpressionEditorMode = DevExpress.XtraEditors.ExpressionEditorMode.AutoComplete
        Me.AdvBandedGridView1.OptionsDetail.AutoZoomDetail = True
        Me.AdvBandedGridView1.OptionsFind.AlwaysVisible = True
        Me.AdvBandedGridView1.OptionsImageLoad.AnimationType = DevExpress.Utils.ImageContentAnimationType.Expand
        Me.AdvBandedGridView1.OptionsMenu.ShowConditionalFormattingItem = True
        Me.AdvBandedGridView1.OptionsMenu.ShowFooterItem = True
        Me.AdvBandedGridView1.OptionsMenu.ShowGroupSummaryEditorItem = True
        Me.AdvBandedGridView1.OptionsNavigation.EnterMoveNextColumn = True
        Me.AdvBandedGridView1.OptionsSelection.CheckBoxSelectorField = "Students Name"
        Me.AdvBandedGridView1.OptionsSelection.MultiSelect = True
        Me.AdvBandedGridView1.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateAllContent
        Me.AdvBandedGridView1.OptionsView.ColumnAutoWidth = True
        Me.AdvBandedGridView1.OptionsView.EnableAppearanceEvenRow = True
        Me.AdvBandedGridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        Me.AdvBandedGridView1.OptionsView.ShowChildrenInGroupPanel = True
        Me.AdvBandedGridView1.OptionsView.ShowFooter = True
        Me.AdvBandedGridView1.OptionsView.ShowViewCaption = True
        Me.AdvBandedGridView1.RowSeparatorHeight = 3
        Me.AdvBandedGridView1.ViewCaption = "Student Database"
        '
        'gridBand2
        '
        Me.gridBand2.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Bold)
        Me.gridBand2.AppearanceHeader.Options.UseFont = True
        Me.gridBand2.Caption = "Information"
        Me.gridBand2.Columns.Add(Me.colStudentsName)
        Me.gridBand2.Columns.Add(Me.colregistrationnumber)
        Me.gridBand2.Columns.Add(Me.colregistrationdate)
        Me.gridBand2.MinWidth = 12
        Me.gridBand2.Name = "gridBand2"
        Me.gridBand2.VisibleIndex = 0
        Me.gridBand2.Width = 225
        '
        'colStudentsName
        '
        Me.colStudentsName.AutoFillDown = True
        Me.colStudentsName.ColumnEdit = Me.RepositoryItemPopupContainerEdit1
        Me.colStudentsName.FieldName = "Students Name"
        Me.colStudentsName.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.Alphabetical
        Me.colStudentsName.MinWidth = 23
        Me.colStudentsName.Name = "colStudentsName"
        Me.colStudentsName.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "Students Name", "{0} Students")})
        Me.colStudentsName.Visible = True
        Me.colStudentsName.Width = 225
        '
        'RepositoryItemPopupContainerEdit1
        '
        Me.RepositoryItemPopupContainerEdit1.AutoHeight = False
        Me.RepositoryItemPopupContainerEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemPopupContainerEdit1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.RepositoryItemPopupContainerEdit1.Name = "RepositoryItemPopupContainerEdit1"
        Me.RepositoryItemPopupContainerEdit1.PopupControl = Me.PopupContainerControl1
        '
        'PopupContainerControl1
        '
        Me.PopupContainerControl1.AutoSize = True
        Me.PopupContainerControl1.Controls.Add(Me.LayoutControl1)
        Me.PopupContainerControl1.Location = New System.Drawing.Point(761, 39)
        Me.PopupContainerControl1.Name = "PopupContainerControl1"
        Me.PopupContainerControl1.Size = New System.Drawing.Size(344, 116)
        Me.PopupContainerControl1.TabIndex = 1
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.oNedit)
        Me.LayoutControl1.Controls.Add(Me.surNedit)
        Me.LayoutControl1.Controls.Add(Me.fisrtNedit)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(996, 165, 812, 500)
        Me.LayoutControl1.OptionsFocus.AllowFocusControlOnActivatedTabPage = True
        Me.LayoutControl1.OptionsFocus.AllowFocusControlOnLabelClick = True
        Me.LayoutControl1.OptionsView.AllowExpandAnimation = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControl1.OptionsView.AllowGlyphSkinning = True
        Me.LayoutControl1.OptionsView.AllowHotTrack = True
        Me.LayoutControl1.OptionsView.DrawAdornerLayer = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControl1.OptionsView.HighlightFocusedItem = True
        Me.LayoutControl1.Root = Me.LayoutControlGroup3
        Me.LayoutControl1.Size = New System.Drawing.Size(344, 116)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'oNedit
        '
        Me.oNedit.Location = New System.Drawing.Point(85, 64)
        Me.oNedit.MenuManager = Me.ribbonControl1
        Me.oNedit.Name = "oNedit"
        Me.oNedit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.oNedit.Size = New System.Drawing.Size(247, 22)
        Me.oNedit.StyleController = Me.LayoutControl1
        Me.oNedit.TabIndex = 3
        '
        'ribbonControl1
        '
        Me.ribbonControl1.ApplicationCaption = "YCMA "
        Me.ribbonControl1.ApplicationDocumentCaption = "Database"
        Me.ribbonControl1.ApplicationIcon = Global.Fathom_Institute.My.Resources.Resources.logo
        Me.ribbonControl1.AutoHideEmptyItems = True
        Me.ribbonControl1.AutoSaveLayoutToXml = True
        Me.ribbonControl1.AutoSizeItems = True
        Me.ribbonControl1.ExpandCollapseItem.Id = 0
        Me.ribbonControl1.Image = Global.Fathom_Institute.My.Resources.Resources.logo
        Me.ribbonControl1.ImageAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribbonControl1.ExpandCollapseItem, Me.BarButtonItem2, Me.BarButtonItem1, Me.BarButtonItem3, Me.BarButtonItem4, Me.BarButtonItem5, Me.BarButtonItem6, Me.BarButtonItem7, Me.BarButtonItem8, Me.BarButtonItem9})
        Me.ribbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.ribbonControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ribbonControl1.MaxItemId = 13
        Me.ribbonControl1.Name = "ribbonControl1"
        Me.ribbonControl1.OptionsAnimation.PageCategoryShowAnimation = DevExpress.Utils.DefaultBoolean.[True]
        Me.ribbonControl1.PageCategories.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageCategory() {Me.RibbonPageCategory1})
        Me.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.TabletOffice
        Me.ribbonControl1.Size = New System.Drawing.Size(1724, 122)
        Me.ribbonControl1.StatusBar = Me.RibbonStatusBar1
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "SAVE"
        Me.BarButtonItem2.Id = 2
        Me.BarButtonItem2.ImageOptions.SvgImage = CType(resources.GetObject("BarButtonItem2.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.BarButtonItem2.Name = "BarButtonItem2"
        Me.BarButtonItem2.RibbonStyle = CType(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) _
            Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText), DevExpress.XtraBars.Ribbon.RibbonItemStyles)
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Pint"
        Me.BarButtonItem1.Id = 3
        Me.BarButtonItem1.ImageOptions.SvgImage = CType(resources.GetObject("BarButtonItem1.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "Save"
        Me.BarButtonItem3.Id = 4
        Me.BarButtonItem3.ImageOptions.Image = CType(resources.GetObject("BarButtonItem3.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Caption = "Print"
        Me.BarButtonItem4.Id = 6
        Me.BarButtonItem4.ImageOptions.Image = CType(resources.GetObject("BarButtonItem4.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem4.Name = "BarButtonItem4"
        '
        'BarButtonItem5
        '
        Me.BarButtonItem5.Caption = "Delete"
        Me.BarButtonItem5.Id = 7
        Me.BarButtonItem5.ImageOptions.SvgImage = CType(resources.GetObject("BarButtonItem5.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.BarButtonItem5.Name = "BarButtonItem5"
        '
        'BarButtonItem6
        '
        Me.BarButtonItem6.Caption = "Register New"
        Me.BarButtonItem6.Id = 9
        Me.BarButtonItem6.ImageOptions.SvgImage = CType(resources.GetObject("BarButtonItem6.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.BarButtonItem6.Name = "BarButtonItem6"
        '
        'BarButtonItem7
        '
        Me.BarButtonItem7.Caption = "Print"
        Me.BarButtonItem7.Id = 10
        Me.BarButtonItem7.ImageOptions.SvgImage = CType(resources.GetObject("BarButtonItem7.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.BarButtonItem7.Name = "BarButtonItem7"
        '
        'BarButtonItem8
        '
        Me.BarButtonItem8.Caption = "New Payment"
        Me.BarButtonItem8.Id = 11
        Me.BarButtonItem8.ImageOptions.Image = CType(resources.GetObject("BarButtonItem8.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem8.ImageOptions.SvgImage = CType(resources.GetObject("BarButtonItem8.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.BarButtonItem8.Name = "BarButtonItem8"
        '
        'BarButtonItem9
        '
        Me.BarButtonItem9.Caption = "Print"
        Me.BarButtonItem9.Id = 12
        Me.BarButtonItem9.ImageOptions.SvgImage = CType(resources.GetObject("BarButtonItem9.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.BarButtonItem9.Name = "BarButtonItem9"
        '
        'RibbonPageCategory1
        '
        Me.RibbonPageCategory1.Name = "RibbonPageCategory1"
        Me.RibbonPageCategory1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.registerTab, Me.yearTab, Me.payTab, Me.coursesTab, Me.AccountsTab})
        Me.RibbonPageCategory1.Text = "Home"
        '
        'registerTab
        '
        Me.registerTab.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup3, Me.RibbonPageGroup4, Me.RibbonPageGroup8})
        Me.registerTab.ImageOptions.Image = CType(resources.GetObject("registerTab.ImageOptions.Image"), System.Drawing.Image)
        Me.registerTab.Name = "registerTab"
        Me.registerTab.Text = "Database"
        '
        'RibbonPageGroup3
        '
        Me.RibbonPageGroup3.ItemLinks.Add(Me.BarButtonItem3)
        Me.RibbonPageGroup3.Name = "RibbonPageGroup3"
        Me.RibbonPageGroup3.Text = "RibbonPageGroup3"
        '
        'RibbonPageGroup4
        '
        Me.RibbonPageGroup4.ItemLinks.Add(Me.BarButtonItem4)
        Me.RibbonPageGroup4.Name = "RibbonPageGroup4"
        Me.RibbonPageGroup4.Text = "RibbonPageGroup4"
        '
        'RibbonPageGroup8
        '
        Me.RibbonPageGroup8.ItemLinks.Add(Me.BarButtonItem5)
        Me.RibbonPageGroup8.Name = "RibbonPageGroup8"
        Me.RibbonPageGroup8.Text = "RibbonPageGroup8"
        '
        'yearTab
        '
        Me.yearTab.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup6, Me.RibbonPageGroup10})
        Me.yearTab.ImageOptions.Image = CType(resources.GetObject("yearTab.ImageOptions.Image"), System.Drawing.Image)
        Me.yearTab.Name = "yearTab"
        Me.yearTab.Text = "Yearly Register"
        '
        'RibbonPageGroup6
        '
        Me.RibbonPageGroup6.ImageOptions.Image = CType(resources.GetObject("RibbonPageGroup6.ImageOptions.Image"), System.Drawing.Image)
        Me.RibbonPageGroup6.ItemLinks.Add(Me.BarButtonItem6)
        Me.RibbonPageGroup6.Name = "RibbonPageGroup6"
        Me.RibbonPageGroup6.Text = "RibbonPageGroup6"
        '
        'RibbonPageGroup10
        '
        Me.RibbonPageGroup10.ItemLinks.Add(Me.BarButtonItem7)
        Me.RibbonPageGroup10.Name = "RibbonPageGroup10"
        Me.RibbonPageGroup10.Text = "RibbonPageGroup10"
        '
        'payTab
        '
        Me.payTab.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup5, Me.RibbonPageGroup7, Me.RibbonPageGroup11})
        Me.payTab.ImageOptions.Image = CType(resources.GetObject("payTab.ImageOptions.Image"), System.Drawing.Image)
        Me.payTab.Name = "payTab"
        Me.payTab.Text = "Payments"
        '
        'RibbonPageGroup5
        '
        Me.RibbonPageGroup5.ImageOptions.SvgImage = CType(resources.GetObject("RibbonPageGroup5.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.RibbonPageGroup5.ItemLinks.Add(Me.BarButtonItem8)
        Me.RibbonPageGroup5.Name = "RibbonPageGroup5"
        Me.RibbonPageGroup5.Text = "RibbonPageGroup5"
        '
        'RibbonPageGroup7
        '
        Me.RibbonPageGroup7.ItemLinks.Add(Me.BarButtonItem9)
        Me.RibbonPageGroup7.Name = "RibbonPageGroup7"
        Me.RibbonPageGroup7.Text = "RibbonPageGroup7"
        '
        'RibbonPageGroup11
        '
        Me.RibbonPageGroup11.Name = "RibbonPageGroup11"
        Me.RibbonPageGroup11.Text = "RibbonPageGroup11"
        '
        'coursesTab
        '
        Me.coursesTab.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1, Me.RibbonPageGroup2})
        Me.coursesTab.ImageOptions.Image = CType(resources.GetObject("coursesTab.ImageOptions.Image"), System.Drawing.Image)
        Me.coursesTab.Name = "coursesTab"
        Me.coursesTab.Text = "Courses"
        Me.coursesTab.Visible = False
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BarButtonItem2)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.Text = "Save"
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.ItemLinks.Add(Me.BarButtonItem1)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.Text = "Print"
        '
        'AccountsTab
        '
        Me.AccountsTab.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup9})
        Me.AccountsTab.ImageOptions.Image = CType(resources.GetObject("AccountsTab.ImageOptions.Image"), System.Drawing.Image)
        Me.AccountsTab.Name = "AccountsTab"
        Me.AccountsTab.Text = "Accounts"
        '
        'RibbonPageGroup9
        '
        Me.RibbonPageGroup9.Name = "RibbonPageGroup9"
        Me.RibbonPageGroup9.Text = "RibbonPageGroup9"
        '
        'RibbonStatusBar1
        '
        Me.RibbonStatusBar1.Location = New System.Drawing.Point(0, 958)
        Me.RibbonStatusBar1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RibbonStatusBar1.Name = "RibbonStatusBar1"
        Me.RibbonStatusBar1.Ribbon = Me.ribbonControl1
        Me.RibbonStatusBar1.Size = New System.Drawing.Size(1724, 32)
        '
        'surNedit
        '
        Me.surNedit.Location = New System.Drawing.Point(85, 38)
        Me.surNedit.MenuManager = Me.ribbonControl1
        Me.surNedit.Name = "surNedit"
        Me.surNedit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.surNedit.Size = New System.Drawing.Size(247, 22)
        Me.surNedit.StyleController = Me.LayoutControl1
        Me.surNedit.TabIndex = 2
        '
        'fisrtNedit
        '
        Me.fisrtNedit.Location = New System.Drawing.Point(85, 12)
        Me.fisrtNedit.MenuManager = Me.ribbonControl1
        Me.fisrtNedit.Name = "fisrtNedit"
        Me.fisrtNedit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.fisrtNedit.Size = New System.Drawing.Size(247, 22)
        Me.fisrtNedit.StyleController = Me.LayoutControl1
        Me.fisrtNedit.TabIndex = 0
        '
        'LayoutControlGroup3
        '
        Me.LayoutControlGroup3.AllowBorderColorBlending = True
        Me.LayoutControlGroup3.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup3.GroupBordersVisible = False
        Me.LayoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem17, Me.LayoutControlItem18, Me.LayoutControlItem19})
        Me.LayoutControlGroup3.Name = "Root"
        Me.LayoutControlGroup3.OptionsItemText.TextToControlDistance = 4
        Me.LayoutControlGroup3.Size = New System.Drawing.Size(344, 116)
        Me.LayoutControlGroup3.TextVisible = False
        '
        'LayoutControlItem17
        '
        Me.LayoutControlItem17.Control = Me.fisrtNedit
        Me.LayoutControlItem17.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem17.Name = "LayoutControlItem17"
        Me.LayoutControlItem17.Size = New System.Drawing.Size(324, 26)
        Me.LayoutControlItem17.Text = "First Name"
        Me.LayoutControlItem17.TextSize = New System.Drawing.Size(69, 16)
        '
        'LayoutControlItem18
        '
        Me.LayoutControlItem18.Control = Me.surNedit
        Me.LayoutControlItem18.Location = New System.Drawing.Point(0, 26)
        Me.LayoutControlItem18.Name = "LayoutControlItem18"
        Me.LayoutControlItem18.Size = New System.Drawing.Size(324, 26)
        Me.LayoutControlItem18.Text = "Surname"
        Me.LayoutControlItem18.TextSize = New System.Drawing.Size(69, 16)
        '
        'LayoutControlItem19
        '
        Me.LayoutControlItem19.Control = Me.oNedit
        Me.LayoutControlItem19.Location = New System.Drawing.Point(0, 52)
        Me.LayoutControlItem19.Name = "LayoutControlItem19"
        Me.LayoutControlItem19.Size = New System.Drawing.Size(324, 44)
        Me.LayoutControlItem19.Text = "Other Name"
        Me.LayoutControlItem19.TextSize = New System.Drawing.Size(69, 16)
        '
        'colregistrationnumber
        '
        Me.colregistrationnumber.AutoFillDown = True
        Me.colregistrationnumber.Caption = "Registration Number"
        Me.colregistrationnumber.ColumnEdit = Me.regedit
        Me.colregistrationnumber.FieldName = "registration number"
        Me.colregistrationnumber.MinWidth = 23
        Me.colregistrationnumber.Name = "colregistrationnumber"
        Me.colregistrationnumber.OptionsColumn.AllowEdit = False
        Me.colregistrationnumber.OptionsColumn.AllowFocus = False
        Me.colregistrationnumber.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[False]
        Me.colregistrationnumber.RowIndex = 1
        Me.colregistrationnumber.Visible = True
        Me.colregistrationnumber.Width = 225
        '
        'colregistrationdate
        '
        Me.colregistrationdate.AutoFillDown = True
        Me.colregistrationdate.Caption = "Registration Date"
        Me.colregistrationdate.ColumnEdit = Me.regdate
        Me.colregistrationdate.FieldName = "registration date"
        Me.colregistrationdate.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.DateRange
        Me.colregistrationdate.MinWidth = 23
        Me.colregistrationdate.Name = "colregistrationdate"
        Me.colregistrationdate.RowIndex = 2
        Me.colregistrationdate.Visible = True
        Me.colregistrationdate.Width = 225
        '
        'regdate
        '
        Me.regdate.AutoHeight = False
        Me.regdate.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.OK, "", -1, True, True, False, EditorButtonImageOptions1, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, SerializableAppearanceObject2, SerializableAppearanceObject3, SerializableAppearanceObject4, "", "ok", Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.regdate.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.[False]
        Me.regdate.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.regdate.DrawCellLines = True
        Me.regdate.HighlightTodayCell = DevExpress.Utils.DefaultBoolean.[True]
        Me.regdate.Name = "regdate"
        Me.regdate.ShowWeekNumbers = True
        Me.regdate.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'GridBand1
        '
        Me.GridBand1.Columns.Add(Me.colPhoto)
        Me.GridBand1.MinWidth = 12
        Me.GridBand1.Name = "GridBand1"
        Me.GridBand1.VisibleIndex = 1
        Me.GridBand1.Width = 125
        '
        'colPhoto
        '
        Me.colPhoto.AutoFillDown = True
        Me.colPhoto.ColumnEdit = Me.photoEdit
        Me.colPhoto.FieldName = "Photo"
        Me.colPhoto.MinWidth = 23
        Me.colPhoto.Name = "colPhoto"
        Me.colPhoto.Visible = True
        Me.colPhoto.Width = 125
        '
        'gridBand5
        '
        Me.gridBand5.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Bold)
        Me.gridBand5.AppearanceHeader.Options.UseFont = True
        Me.gridBand5.Caption = "Ethnicity & Residence"
        Me.gridBand5.Columns.Add(Me.colnationality)
        Me.gridBand5.Columns.Add(Me.coltribe)
        Me.gridBand5.Columns.Add(Me.colreligion)
        Me.gridBand5.Columns.Add(Me.coldateofbirth)
        Me.gridBand5.Columns.Add(Me.colbirthdistrict)
        Me.gridBand5.Columns.Add(Me.colresidence)
        Me.gridBand5.MinWidth = 12
        Me.gridBand5.Name = "gridBand5"
        Me.gridBand5.VisibleIndex = 2
        Me.gridBand5.Width = 476
        '
        'colnationality
        '
        Me.colnationality.AutoFillDown = True
        Me.colnationality.Caption = "Nationality"
        Me.colnationality.ColumnEdit = Me.nationCombo
        Me.colnationality.FieldName = "nationality"
        Me.colnationality.MinWidth = 23
        Me.colnationality.Name = "colnationality"
        Me.colnationality.Visible = True
        Me.colnationality.Width = 154
        '
        'coltribe
        '
        Me.coltribe.AutoFillDown = True
        Me.coltribe.Caption = "Tribe"
        Me.coltribe.ColumnEdit = Me.otextEdit
        Me.coltribe.FieldName = "tribe"
        Me.coltribe.MinWidth = 23
        Me.coltribe.Name = "coltribe"
        Me.coltribe.Visible = True
        Me.coltribe.Width = 154
        '
        'colreligion
        '
        Me.colreligion.AutoFillDown = True
        Me.colreligion.Caption = "Religion"
        Me.colreligion.ColumnEdit = Me.religionCombo
        Me.colreligion.FieldName = "religion"
        Me.colreligion.MinWidth = 23
        Me.colreligion.Name = "colreligion"
        Me.colreligion.Visible = True
        Me.colreligion.Width = 168
        '
        'coldateofbirth
        '
        Me.coldateofbirth.AutoFillDown = True
        Me.coldateofbirth.Caption = "Date Of Birth"
        Me.coldateofbirth.ColumnEdit = Me.DateEdit
        Me.coldateofbirth.FieldName = "date of birth"
        Me.coldateofbirth.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.DateRange
        Me.coldateofbirth.MinWidth = 23
        Me.coldateofbirth.Name = "coldateofbirth"
        Me.coldateofbirth.RowIndex = 1
        Me.coldateofbirth.Visible = True
        Me.coldateofbirth.Width = 154
        '
        'colbirthdistrict
        '
        Me.colbirthdistrict.AutoFillDown = True
        Me.colbirthdistrict.Caption = "District Of Birth"
        Me.colbirthdistrict.ColumnEdit = Me.otextEdit
        Me.colbirthdistrict.FieldName = "birth district"
        Me.colbirthdistrict.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.DateRange
        Me.colbirthdistrict.MinWidth = 23
        Me.colbirthdistrict.Name = "colbirthdistrict"
        Me.colbirthdistrict.RowIndex = 1
        Me.colbirthdistrict.Visible = True
        Me.colbirthdistrict.Width = 154
        '
        'colresidence
        '
        Me.colresidence.AutoFillDown = True
        Me.colresidence.Caption = "Residence"
        Me.colresidence.ColumnEdit = Me.otextEdit
        Me.colresidence.FieldName = "residence"
        Me.colresidence.MinWidth = 23
        Me.colresidence.Name = "colresidence"
        Me.colresidence.RowIndex = 1
        Me.colresidence.Visible = True
        Me.colresidence.Width = 168
        '
        'gridBand3
        '
        Me.gridBand3.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Bold)
        Me.gridBand3.AppearanceHeader.Options.UseFont = True
        Me.gridBand3.Caption = "course"
        Me.gridBand3.Columns.Add(Me.colProgramme)
        Me.gridBand3.Columns.Add(Me.colcoursename)
        Me.gridBand3.MinWidth = 12
        Me.gridBand3.Name = "gridBand3"
        Me.gridBand3.VisibleIndex = 3
        Me.gridBand3.Width = 157
        '
        'colProgramme
        '
        Me.colProgramme.AutoFillDown = True
        Me.colProgramme.ColumnEdit = Me.studprogcombo
        Me.colProgramme.FieldName = "Programme"
        Me.colProgramme.MinWidth = 23
        Me.colProgramme.Name = "colProgramme"
        Me.colProgramme.Visible = True
        Me.colProgramme.Width = 157
        '
        'colcoursename
        '
        Me.colcoursename.AppearanceCell.Options.UseTextOptions = True
        Me.colcoursename.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colcoursename.AppearanceHeader.Options.UseTextOptions = True
        Me.colcoursename.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colcoursename.AutoFillDown = True
        Me.colcoursename.Caption = "Course"
        Me.colcoursename.ColumnEdit = Me.courseLookup
        Me.colcoursename.FieldName = "course name"
        Me.colcoursename.MinWidth = 23
        Me.colcoursename.Name = "colcoursename"
        Me.colcoursename.RowIndex = 1
        Me.colcoursename.Visible = True
        Me.colcoursename.Width = 157
        '
        'gridBand4
        '
        Me.gridBand4.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Bold)
        Me.gridBand4.AppearanceHeader.Options.UseFont = True
        Me.gridBand4.Caption = "Relatives"
        Me.gridBand4.Columns.Add(Me.colguardian1)
        Me.gridBand4.Columns.Add(Me.colguardian2)
        Me.gridBand4.Columns.Add(Me.colguardian1contact)
        Me.gridBand4.Columns.Add(Me.colguardian2contact)
        Me.gridBand4.MinWidth = 12
        Me.gridBand4.Name = "gridBand4"
        Me.gridBand4.VisibleIndex = 4
        Me.gridBand4.Width = 317
        '
        'colguardian1
        '
        Me.colguardian1.AutoFillDown = True
        Me.colguardian1.Caption = "First Guardian Name"
        Me.colguardian1.ColumnEdit = Me.otextEdit
        Me.colguardian1.FieldName = "guardian 1"
        Me.colguardian1.MinWidth = 23
        Me.colguardian1.Name = "colguardian1"
        Me.colguardian1.Visible = True
        Me.colguardian1.Width = 154
        '
        'colguardian2
        '
        Me.colguardian2.AutoFillDown = True
        Me.colguardian2.Caption = "Guardian Name"
        Me.colguardian2.ColumnEdit = Me.otextEdit
        Me.colguardian2.FieldName = "guardian 2"
        Me.colguardian2.MinWidth = 23
        Me.colguardian2.Name = "colguardian2"
        Me.colguardian2.Visible = True
        Me.colguardian2.Width = 163
        '
        'colguardian1contact
        '
        Me.colguardian1contact.AppearanceHeader.Options.UseTextOptions = True
        Me.colguardian1contact.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colguardian1contact.AutoFillDown = True
        Me.colguardian1contact.Caption = "First Guardian Contact"
        Me.colguardian1contact.ColumnEdit = Me.otextEdit
        Me.colguardian1contact.FieldName = "guardian 1 contact"
        Me.colguardian1contact.MinWidth = 23
        Me.colguardian1contact.Name = "colguardian1contact"
        Me.colguardian1contact.RowIndex = 1
        Me.colguardian1contact.Visible = True
        Me.colguardian1contact.Width = 154
        '
        'colguardian2contact
        '
        Me.colguardian2contact.AppearanceHeader.Options.UseTextOptions = True
        Me.colguardian2contact.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colguardian2contact.AutoFillDown = True
        Me.colguardian2contact.Caption = "Second Guardian Contact"
        Me.colguardian2contact.ColumnEdit = Me.otextEdit
        Me.colguardian2contact.FieldName = "guardian 2 contact"
        Me.colguardian2contact.MinWidth = 23
        Me.colguardian2contact.Name = "colguardian2contact"
        Me.colguardian2contact.RowIndex = 1
        Me.colguardian2contact.Visible = True
        Me.colguardian2contact.Width = 163
        '
        'gridBand6
        '
        Me.gridBand6.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Bold)
        Me.gridBand6.AppearanceHeader.Options.UseFont = True
        Me.gridBand6.Caption = "ID & Contact"
        Me.gridBand6.Columns.Add(Me.colnin)
        Me.gridBand6.Columns.Add(Me.colphonecontact)
        Me.gridBand6.Columns.Add(Me.colsponsorship)
        Me.gridBand6.Columns.Add(Me.colemail)
        Me.gridBand6.MinWidth = 12
        Me.gridBand6.Name = "gridBand6"
        Me.gridBand6.VisibleIndex = 5
        Me.gridBand6.Width = 326
        '
        'colnin
        '
        Me.colnin.AutoFillDown = True
        Me.colnin.Caption = "NIN"
        Me.colnin.ColumnEdit = Me.otextEdit
        Me.colnin.FieldName = "nin"
        Me.colnin.MinWidth = 23
        Me.colnin.Name = "colnin"
        Me.colnin.Visible = True
        Me.colnin.Width = 325
        '
        'colphonecontact
        '
        Me.colphonecontact.AutoFillDown = True
        Me.colphonecontact.Caption = "Phone Contact"
        Me.colphonecontact.ColumnEdit = Me.telToken
        Me.colphonecontact.FieldName = "phone contact"
        Me.colphonecontact.MinWidth = 23
        Me.colphonecontact.Name = "colphonecontact"
        Me.colphonecontact.RowIndex = 1
        Me.colphonecontact.Visible = True
        Me.colphonecontact.Width = 160
        '
        'colsponsorship
        '
        Me.colsponsorship.AutoFillDown = True
        Me.colsponsorship.Caption = "Sponsorship"
        Me.colsponsorship.ColumnEdit = Me.sponsorCombo
        Me.colsponsorship.FieldName = "sponsorship"
        Me.colsponsorship.MinWidth = 23
        Me.colsponsorship.Name = "colsponsorship"
        Me.colsponsorship.RowIndex = 1
        Me.colsponsorship.Visible = True
        Me.colsponsorship.Width = 166
        '
        'colemail
        '
        Me.colemail.AutoFillDown = True
        Me.colemail.Caption = "Email"
        Me.colemail.FieldName = "email"
        Me.colemail.MinWidth = 23
        Me.colemail.Name = "colemail"
        Me.colemail.RowIndex = 2
        Me.colemail.Visible = True
        Me.colemail.Width = 325
        '
        'gridBand7
        '
        Me.gridBand7.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Bold)
        Me.gridBand7.AppearanceHeader.Options.UseFont = True
        Me.gridBand7.Caption = "Verification"
        Me.gridBand7.Columns.Add(Me.coldocumentsverified)
        Me.gridBand7.Columns.Add(Me.colLastAcademicLevel)
        Me.gridBand7.MinWidth = 12
        Me.gridBand7.Name = "gridBand7"
        Me.gridBand7.VisibleIndex = 6
        Me.gridBand7.Width = 168
        '
        'coldocumentsverified
        '
        Me.coldocumentsverified.AutoFillDown = True
        Me.coldocumentsverified.Caption = "Verified"
        Me.coldocumentsverified.ColumnEdit = Me.paperschk
        Me.coldocumentsverified.FieldName = "documents verified"
        Me.coldocumentsverified.MinWidth = 23
        Me.coldocumentsverified.Name = "coldocumentsverified"
        Me.coldocumentsverified.Visible = True
        Me.coldocumentsverified.Width = 168
        '
        'paperschk
        '
        Me.paperschk.AutoHeight = False
        Me.paperschk.Name = "paperschk"
        Me.paperschk.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.paperschk.ValueChecked = "fully verified"
        Me.paperschk.ValueGrayed = "partially verified"
        Me.paperschk.ValueUnchecked = "not verified"
        '
        'colLastAcademicLevel
        '
        Me.colLastAcademicLevel.AutoFillDown = True
        Me.colLastAcademicLevel.ColumnEdit = Me.levelCombo
        Me.colLastAcademicLevel.FieldName = "Last Academic Level"
        Me.colLastAcademicLevel.MinWidth = 23
        Me.colLastAcademicLevel.Name = "colLastAcademicLevel"
        Me.colLastAcademicLevel.RowIndex = 1
        Me.colLastAcademicLevel.Visible = True
        Me.colLastAcademicLevel.Width = 168
        '
        'RepositoryItemComboBox1
        '
        Me.RepositoryItemComboBox1.AutoHeight = False
        Me.RepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox1.Name = "RepositoryItemComboBox1"
        '
        'RepositoryItemImageComboBox1
        '
        Me.RepositoryItemImageComboBox1.AutoHeight = False
        Me.RepositoryItemImageComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemImageComboBox1.ImmediatePopup = True
        Me.RepositoryItemImageComboBox1.Name = "RepositoryItemImageComboBox1"
        '
        'RepositoryItemComboBox2
        '
        Me.RepositoryItemComboBox2.AutoHeight = False
        Me.RepositoryItemComboBox2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox2.Name = "RepositoryItemComboBox2"
        '
        'RepositoryItemDateEdit1
        '
        Me.RepositoryItemDateEdit1.AutoHeight = False
        Me.RepositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
        '
        'PROGcOMB
        '
        Me.PROGcOMB.AutoHeight = False
        Me.PROGcOMB.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.PROGcOMB.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.PROGcOMB.ImmediatePopup = True
        Me.PROGcOMB.Items.AddRange(New Object() {"DAY", "EVENING", "WEEKEND", "ONLINE", "MORNING"})
        Me.PROGcOMB.Name = "PROGcOMB"
        Me.PROGcOMB.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'COURSEGridLookUpEdit
        '
        Me.COURSEGridLookUpEdit.AutoHeight = False
        Me.COURSEGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.COURSEGridLookUpEdit.DataSource = Me.CoursesTableBindingSource
        Me.COURSEGridLookUpEdit.DisplayMember = "course name"
        Me.COURSEGridLookUpEdit.Name = "COURSEGridLookUpEdit"
        Me.COURSEGridLookUpEdit.PopupView = Me.RepositoryItemGridLookUpEdit1View
        Me.COURSEGridLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.COURSEGridLookUpEdit.ValueMember = "course name"
        '
        'RepositoryItemGridLookUpEdit1View
        '
        Me.RepositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit1View.Name = "RepositoryItemGridLookUpEdit1View"
        Me.RepositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'CardView2
        '
        Me.CardView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colPhoto1, Me.colStudentsName1, Me.colregistrationnumber1, Me.colProgramme1, Me.colphonecontact1, Me.colsponsorship1})
        Me.CardView2.FocusedCardTopFieldIndex = 0
        Me.CardView2.GridControl = Me.CoursesTableGridControl
        Me.CardView2.Name = "CardView2"
        '
        'colPhoto1
        '
        Me.colPhoto1.FieldName = "Photo"
        Me.colPhoto1.Name = "colPhoto1"
        Me.colPhoto1.Visible = True
        Me.colPhoto1.VisibleIndex = 0
        '
        'colStudentsName1
        '
        Me.colStudentsName1.FieldName = "Students Name"
        Me.colStudentsName1.Name = "colStudentsName1"
        Me.colStudentsName1.Visible = True
        Me.colStudentsName1.VisibleIndex = 1
        '
        'colregistrationnumber1
        '
        Me.colregistrationnumber1.FieldName = "registration number"
        Me.colregistrationnumber1.Name = "colregistrationnumber1"
        Me.colregistrationnumber1.Visible = True
        Me.colregistrationnumber1.VisibleIndex = 2
        '
        'colProgramme1
        '
        Me.colProgramme1.FieldName = "Programme"
        Me.colProgramme1.Name = "colProgramme1"
        Me.colProgramme1.Visible = True
        Me.colProgramme1.VisibleIndex = 3
        '
        'colphonecontact1
        '
        Me.colphonecontact1.FieldName = "phone contact"
        Me.colphonecontact1.Name = "colphonecontact1"
        Me.colphonecontact1.Visible = True
        Me.colphonecontact1.VisibleIndex = 4
        '
        'colsponsorship1
        '
        Me.colsponsorship1.FieldName = "sponsorship"
        Me.colsponsorship1.Name = "colsponsorship1"
        Me.colsponsorship1.Visible = True
        Me.colsponsorship1.VisibleIndex = 5
        '
        'CoursesTableGridControl
        '
        Me.CoursesTableGridControl.DataSource = Me.CoursesTableBindingSource
        Me.CoursesTableGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CoursesTableGridControl.ExternalRepository = Me.PersistentRepository1
        GridLevelNode2.LevelTemplate = Me.CardView2
        GridLevelNode3.LevelTemplate = Me.GridView3
        GridLevelNode2.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode3})
        GridLevelNode2.RelationName = "coursesTable_StudentInfo"
        Me.CoursesTableGridControl.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode2})
        Me.CoursesTableGridControl.Location = New System.Drawing.Point(0, 0)
        Me.CoursesTableGridControl.MainView = Me.GridView2
        Me.CoursesTableGridControl.MenuManager = Me.ribbonControl1
        Me.CoursesTableGridControl.Name = "CoursesTableGridControl"
        Me.CoursesTableGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.unitstoken, Me.RepositoryItemSpinEdit1, Me.TYPEEDIT, Me.progedit, Me.MoneyEdit, Me.dLookUp, Me.fLookUp})
        Me.CoursesTableGridControl.Size = New System.Drawing.Size(1694, 742)
        Me.CoursesTableGridControl.TabIndex = 0
        Me.CoursesTableGridControl.UseEmbeddedNavigator = True
        Me.CoursesTableGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2, Me.GridView3, Me.CardView2})
        '
        'GridView2
        '
        Me.GridView2.ChildGridLevelName = "Students Under Course"
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colcoursename1, Me.colcourseAbbr, Me.colcoursecode, Me.colyears, Me.colcourseunits, Me.colcoursetype, Me.colprogrammes, Me.coltuitionfee, Me.colfaculty, Me.coldepartment})
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus
        GridFormatRule3.ApplyToRow = True
        GridFormatRule3.Column = Me.colcoursecode
        GridFormatRule3.ColumnApplyTo = Me.colcoursecode
        GridFormatRule3.Name = "Format0"
        FormatConditionRuleUniqueDuplicate2.PredefinedName = "Red Text"
        GridFormatRule3.Rule = FormatConditionRuleUniqueDuplicate2
        GridFormatRule4.Column = Me.coltuitionfee
        GridFormatRule4.ColumnApplyTo = Me.colcoursename1
        GridFormatRule4.Name = "Format1"
        FormatConditionRuleTopBottom1.Rank = New Decimal(New Integer() {10, 0, 0, 0})
        GridFormatRule4.Rule = FormatConditionRuleTopBottom1
        GridFormatRule5.Column = Me.coltuitionfee
        GridFormatRule5.ColumnApplyTo = Me.coltuitionfee
        GridFormatRule5.Name = "Format2"
        FormatConditionRuleDataBar1.Appearance.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Bold)
        FormatConditionRuleDataBar1.Appearance.Options.UseFont = True
        FormatConditionRuleDataBar1.PredefinedName = "Mint Gradient"
        GridFormatRule5.Rule = FormatConditionRuleDataBar1
        Me.GridView2.FormatRules.Add(GridFormatRule3)
        Me.GridView2.FormatRules.Add(GridFormatRule4)
        Me.GridView2.FormatRules.Add(GridFormatRule5)
        Me.GridView2.GridControl = Me.CoursesTableGridControl
        Me.GridView2.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "department", Me.coldepartment, "count {0}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "faculty", Me.colfaculty, "count {0}")})
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsBehavior.AllowIncrementalSearch = True
        Me.GridView2.OptionsBehavior.AllowSortAnimation = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView2.OptionsMenu.ShowFooterItem = True
        Me.GridView2.OptionsMenu.ShowGroupSummaryEditorItem = True
        Me.GridView2.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        Me.GridView2.OptionsView.ShowFooter = True
        Me.GridView2.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView2.OptionsView.ShowViewCaption = True
        Me.GridView2.PreviewFieldName = "course name"
        Me.GridView2.RowHeight = 120
        Me.GridView2.RowSeparatorHeight = 3
        Me.GridView2.ViewCaption = "Courses List"
        '
        'colcoursename1
        '
        Me.colcoursename1.AppearanceCell.Options.UseTextOptions = True
        Me.colcoursename1.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colcoursename1.Caption = "Course Title"
        Me.colcoursename1.ColumnEdit = Me.otextEdit
        Me.colcoursename1.FieldName = "course name"
        Me.colcoursename1.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.Alphabetical
        Me.colcoursename1.Name = "colcoursename1"
        Me.colcoursename1.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "course name", "{0} courses")})
        Me.colcoursename1.Visible = True
        Me.colcoursename1.VisibleIndex = 0
        Me.colcoursename1.Width = 97
        '
        'colcourseAbbr
        '
        Me.colcourseAbbr.Caption = "Abbr."
        Me.colcourseAbbr.FieldName = "course Abbr"
        Me.colcourseAbbr.Name = "colcourseAbbr"
        Me.colcourseAbbr.Visible = True
        Me.colcourseAbbr.VisibleIndex = 1
        '
        'colcoursecode
        '
        Me.colcoursecode.Caption = "Course Code"
        Me.colcoursecode.FieldName = "course code"
        Me.colcoursecode.Name = "colcoursecode"
        Me.colcoursecode.Visible = True
        Me.colcoursecode.VisibleIndex = 2
        '
        'colyears
        '
        Me.colyears.Caption = "Duration"
        Me.colyears.ColumnEdit = Me.RepositoryItemSpinEdit1
        Me.colyears.FieldName = "years"
        Me.colyears.Name = "colyears"
        Me.colyears.Visible = True
        Me.colyears.VisibleIndex = 3
        '
        'RepositoryItemSpinEdit1
        '
        Me.RepositoryItemSpinEdit1.AutoHeight = False
        Me.RepositoryItemSpinEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemSpinEdit1.MaxValue = New Decimal(New Integer() {5, 0, 0, 0})
        Me.RepositoryItemSpinEdit1.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.RepositoryItemSpinEdit1.Name = "RepositoryItemSpinEdit1"
        Me.RepositoryItemSpinEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'colcourseunits
        '
        Me.colcourseunits.Caption = "Course Units"
        Me.colcourseunits.ColumnEdit = Me.unitstoken
        Me.colcourseunits.FieldName = "course units"
        Me.colcourseunits.Name = "colcourseunits"
        Me.colcourseunits.Visible = True
        Me.colcourseunits.VisibleIndex = 4
        '
        'unitstoken
        '
        Me.unitstoken.EditMode = DevExpress.XtraEditors.TokenEditMode.Manual
        Me.unitstoken.Name = "unitstoken"
        Me.unitstoken.PopupFilterMode = DevExpress.XtraEditors.TokenEditPopupFilterMode.Contains
        '
        'colcoursetype
        '
        Me.colcoursetype.Caption = "Course Level"
        Me.colcoursetype.ColumnEdit = Me.TYPEEDIT
        Me.colcoursetype.FieldName = "course type"
        Me.colcoursetype.Name = "colcoursetype"
        Me.colcoursetype.Visible = True
        Me.colcoursetype.VisibleIndex = 5
        '
        'TYPEEDIT
        '
        Me.TYPEEDIT.AutoHeight = False
        Me.TYPEEDIT.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TYPEEDIT.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TYPEEDIT.Items.AddRange(New Object() {"Certificate", "Degree", "Diploma", "Masters"})
        Me.TYPEEDIT.Name = "TYPEEDIT"
        Me.TYPEEDIT.Sorted = True
        Me.TYPEEDIT.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'colprogrammes
        '
        Me.colprogrammes.Caption = "Programmes"
        Me.colprogrammes.ColumnEdit = Me.progedit
        Me.colprogrammes.FieldName = "programmes"
        Me.colprogrammes.Name = "colprogrammes"
        Me.colprogrammes.Visible = True
        Me.colprogrammes.VisibleIndex = 6
        '
        'progedit
        '
        Me.progedit.AutoHeight = False
        Me.progedit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.progedit.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.progedit.IncrementalSearch = True
        Me.progedit.Items.AddRange(New DevExpress.XtraEditors.Controls.CheckedListBoxItem() {New DevExpress.XtraEditors.Controls.CheckedListBoxItem("DAY", "DAY"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("EVENING", "EVENING"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("MORNING", "MORNING"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("WEEKEND", "WEEKEND"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("ONLINE", "ONLINE")})
        Me.progedit.Name = "progedit"
        '
        'coltuitionfee
        '
        Me.coltuitionfee.Caption = "Tuition"
        Me.coltuitionfee.ColumnEdit = Me.MoneyEdit
        Me.coltuitionfee.FieldName = "tuition fee"
        Me.coltuitionfee.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.Value
        Me.coltuitionfee.Name = "coltuitionfee"
        Me.coltuitionfee.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Max, "tuition fee", "Highest={0}"), New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Min, "tuition fee", "Lowest={0}")})
        Me.coltuitionfee.Visible = True
        Me.coltuitionfee.VisibleIndex = 7
        '
        'MoneyEdit
        '
        Me.MoneyEdit.AutoHeight = False
        Me.MoneyEdit.DisplayFormat.FormatString = "{0} Ugx"
        Me.MoneyEdit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.MoneyEdit.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.MoneyEdit.Mask.ShowPlaceHolders = False
        Me.MoneyEdit.Name = "MoneyEdit"
        '
        'colfaculty
        '
        Me.colfaculty.Caption = "Faculty"
        Me.colfaculty.ColumnEdit = Me.fLookUp
        Me.colfaculty.FieldName = "faculty"
        Me.colfaculty.Name = "colfaculty"
        Me.colfaculty.Visible = True
        Me.colfaculty.VisibleIndex = 8
        '
        'fLookUp
        '
        Me.fLookUp.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.fLookUp.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.fLookUp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.fLookUp.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("faculty", "faculty", 47, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("department", "department", 76, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.fLookUp.DataSource = Me.CoursesTableBindingSource
        Me.fLookUp.DisplayMember = "faculty"
        Me.fLookUp.ImmediatePopup = True
        Me.fLookUp.KeyMember = "course code"
        Me.fLookUp.Name = "fLookUp"
        Me.fLookUp.NullText = "[No Faculty]"
        Me.fLookUp.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.fLookUp.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.fLookUp.ValueMember = "faculty"
        '
        'coldepartment
        '
        Me.coldepartment.Caption = "Department"
        Me.coldepartment.ColumnEdit = Me.dLookUp
        Me.coldepartment.FieldName = "department"
        Me.coldepartment.Name = "coldepartment"
        Me.coldepartment.Visible = True
        Me.coldepartment.VisibleIndex = 9
        '
        'dLookUp
        '
        Me.dLookUp.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.dLookUp.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dLookUp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.dLookUp.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("department", "department", 76, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[True]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("faculty", "faculty", 47, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.dLookUp.DataSource = Me.CoursesTableBindingSource
        Me.dLookUp.DisplayMember = "department"
        Me.dLookUp.ImmediatePopup = True
        Me.dLookUp.KeyMember = "course code"
        Me.dLookUp.Name = "dLookUp"
        Me.dLookUp.NullText = "[No Department]"
        Me.dLookUp.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.dLookUp.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.dLookUp.ValueMember = "department"
        '
        'GridView3
        '
        Me.GridView3.GridControl = Me.CoursesTableGridControl
        Me.GridView3.Name = "GridView3"
        '
        'SplashScreenManager1
        '
        SplashScreenManager1.ClosingDelay = 500
        '
        'colpaymentdate
        '
        Me.colpaymentdate.Caption = "Payment Date"
        Me.colpaymentdate.ColumnEdit = Me.DateEdit
        Me.colpaymentdate.FieldName = "payment date"
        Me.colpaymentdate.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.DateRange
        Me.colpaymentdate.Name = "colpaymentdate"
        Me.colpaymentdate.Visible = True
        Me.colpaymentdate.VisibleIndex = 6
        Me.colpaymentdate.Width = 103
        '
        'Balance
        '
        Me.Balance.Caption = "Balance"
        Me.Balance.FieldName = "Balance"
        Me.Balance.Name = "Balance"
        Me.Balance.OptionsColumn.AllowEdit = False
        Me.Balance.OptionsColumn.AllowFocus = False
        Me.Balance.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Balance", "SUM={0:0.##}"), New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Min, "Balance", "MIN={0}")})
        Me.Balance.UnboundExpression = "ToInt([total fees]) - [amount paid]"
        Me.Balance.UnboundType = DevExpress.Data.UnboundColumnType.[Integer]
        Me.Balance.Visible = True
        Me.Balance.VisibleIndex = 11
        '
        'NavigationFrame1
        '
        Me.NavigationFrame1.Controls.Add(Me.NavigationPage1)
        Me.NavigationFrame1.Controls.Add(Me.NavigationPage2)
        Me.NavigationFrame1.Controls.Add(Me.NavigationPage4)
        Me.NavigationFrame1.Controls.Add(Me.NavigationPage5)
        Me.NavigationFrame1.Controls.Add(Me.NavigationPage6)
        Me.NavigationFrame1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NavigationFrame1.Location = New System.Drawing.Point(0, 216)
        Me.NavigationFrame1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.NavigationFrame1.Name = "NavigationFrame1"
        Me.NavigationFrame1.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.NavigationPage1, Me.NavigationPage2, Me.NavigationPage4, Me.NavigationPage5, Me.NavigationPage6})
        Me.NavigationFrame1.RibbonAndBarsMergeStyle = DevExpress.XtraBars.Docking2010.Views.RibbonAndBarsMergeStyle.Always
        Me.NavigationFrame1.SelectedPage = Me.NavigationPage5
        Me.NavigationFrame1.Size = New System.Drawing.Size(1694, 742)
        Me.NavigationFrame1.TabIndex = 3
        Me.NavigationFrame1.Text = "NavigationFrame1"
        Me.NavigationFrame1.TransitionType = DevExpress.Utils.Animation.Transitions.PushFade
        '
        'NavigationPage1
        '
        Me.NavigationPage1.Controls.Add(Me.GridSplitContainer1)
        Me.NavigationPage1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.NavigationPage1.Name = "NavigationPage1"
        Me.NavigationPage1.Size = New System.Drawing.Size(1694, 742)
        '
        'GridSplitContainer1
        '
        Me.GridSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridSplitContainer1.Grid = Me.StudentInfoGridControl
        Me.GridSplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.GridSplitContainer1.Name = "GridSplitContainer1"
        Me.GridSplitContainer1.Panel1.Controls.Add(Me.PopupContainerControl1)
        Me.GridSplitContainer1.Panel1.Controls.Add(Me.StudentInfoGridControl)
        Me.GridSplitContainer1.Size = New System.Drawing.Size(1694, 742)
        Me.GridSplitContainer1.TabIndex = 0
        '
        'NavigationPage2
        '
        Me.NavigationPage2.Controls.Add(Me.CoursesTableGridControl)
        Me.NavigationPage2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.NavigationPage2.Name = "NavigationPage2"
        Me.NavigationPage2.Size = New System.Drawing.Size(1694, 742)
        '
        'NavigationPage4
        '
        Me.NavigationPage4.Controls.Add(Me.FlyoutPanel1)
        Me.NavigationPage4.Controls.Add(Me.AccountsTableGridControl)
        Me.NavigationPage4.Name = "NavigationPage4"
        Me.NavigationPage4.Size = New System.Drawing.Size(1694, 742)
        '
        'FlyoutPanel1
        '
        Me.FlyoutPanel1.Controls.Add(Me.FlyoutPanelControl1)
        Me.FlyoutPanel1.Location = New System.Drawing.Point(299, 159)
        Me.FlyoutPanel1.Name = "FlyoutPanel1"
        Me.FlyoutPanel1.Options.AnchorType = DevExpress.Utils.Win.PopupToolWindowAnchor.Center
        Me.FlyoutPanel1.OwnerControl = Me.NavigationFrame1
        Me.FlyoutPanel1.Size = New System.Drawing.Size(578, 270)
        Me.FlyoutPanel1.TabIndex = 2
        '
        'FlyoutPanelControl1
        '
        Me.FlyoutPanelControl1.Controls.Add(Me.DataLayoutControl1)
        Me.FlyoutPanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlyoutPanelControl1.FlyoutPanel = Me.FlyoutPanel1
        Me.FlyoutPanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.FlyoutPanelControl1.Name = "FlyoutPanelControl1"
        Me.FlyoutPanelControl1.Size = New System.Drawing.Size(578, 270)
        Me.FlyoutPanelControl1.TabIndex = 0
        '
        'DataLayoutControl1
        '
        Me.DataLayoutControl1.Controls.Add(Me.TextEdit6)
        Me.DataLayoutControl1.Controls.Add(Me.TextEdit5)
        Me.DataLayoutControl1.Controls.Add(Me.TextEdit4)
        Me.DataLayoutControl1.Controls.Add(Me.SimpleButton2)
        Me.DataLayoutControl1.Controls.Add(Me.SimpleButton1)
        Me.DataLayoutControl1.Controls.Add(Me.SearchLookUpEdit1)
        Me.DataLayoutControl1.Controls.Add(Me.semesterComboBoxEdit)
        Me.DataLayoutControl1.Controls.Add(Me.ComboBoxEdit1)
        Me.DataLayoutControl1.Controls.Add(Me.DateEdit1)
        Me.DataLayoutControl1.Controls.Add(Me.TextEdit1)
        Me.DataLayoutControl1.Controls.Add(Me.TextEdit2)
        Me.DataLayoutControl1.Controls.Add(Me.TextEdit3)
        Me.DataLayoutControl1.Controls.Add(Me.coursetextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.payFieldcombo)
        Me.DataLayoutControl1.DataSource = Me.PaymentTableBindingSource
        Me.DataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataLayoutControl1.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem13})
        Me.DataLayoutControl1.Location = New System.Drawing.Point(2, 2)
        Me.DataLayoutControl1.Name = "DataLayoutControl1"
        Me.DataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1075, 219, 812, 500)
        Me.DataLayoutControl1.OptionsView.AllowHotTrack = True
        Me.DataLayoutControl1.Root = Me.LayoutControlGroup1
        Me.DataLayoutControl1.Size = New System.Drawing.Size(574, 266)
        Me.DataLayoutControl1.TabIndex = 0
        Me.DataLayoutControl1.Text = "DataLayoutControl1"
        '
        'TextEdit6
        '
        Me.TextEdit6.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PaymentTableBindingSource, "Students Name", True))
        Me.TextEdit6.Location = New System.Drawing.Point(128, 33)
        Me.TextEdit6.MenuManager = Me.ribbonControl1
        Me.TextEdit6.Name = "TextEdit6"
        Me.TextEdit6.Size = New System.Drawing.Size(157, 22)
        Me.TextEdit6.StyleController = Me.DataLayoutControl1
        Me.TextEdit6.TabIndex = 17
        '
        'PaymentTableBindingSource
        '
        Me.PaymentTableBindingSource.DataMember = "PaymentTable"
        Me.PaymentTableBindingSource.DataSource = Me.InstituteDataDataSet
        '
        'TextEdit5
        '
        Me.TextEdit5.Location = New System.Drawing.Point(405, 163)
        Me.TextEdit5.MenuManager = Me.ribbonControl1
        Me.TextEdit5.Name = "TextEdit5"
        Me.TextEdit5.Properties.ReadOnly = True
        Me.TextEdit5.Properties.UseReadOnlyAppearance = False
        Me.TextEdit5.Size = New System.Drawing.Size(157, 22)
        Me.TextEdit5.StyleController = Me.DataLayoutControl1
        Me.TextEdit5.TabIndex = 16
        '
        'TextEdit4
        '
        Me.TextEdit4.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PaymentTableBindingSource, "total fees", True))
        Me.TextEdit4.Location = New System.Drawing.Point(405, 137)
        Me.TextEdit4.MenuManager = Me.ribbonControl1
        Me.TextEdit4.Name = "TextEdit4"
        Me.TextEdit4.Properties.DisplayFormat.FormatString = "{0} Ugx"
        Me.TextEdit4.Properties.ReadOnly = True
        Me.TextEdit4.Properties.UseReadOnlyAppearance = False
        Me.TextEdit4.Size = New System.Drawing.Size(157, 22)
        Me.TextEdit4.StyleController = Me.DataLayoutControl1
        Me.TextEdit4.TabIndex = 15
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Location = New System.Drawing.Point(138, 227)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(424, 27)
        Me.SimpleButton2.StyleController = Me.DataLayoutControl1
        Me.SimpleButton2.TabIndex = 14
        Me.SimpleButton2.Text = "Save"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(12, 227)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(122, 27)
        Me.SimpleButton1.StyleController = Me.DataLayoutControl1
        Me.SimpleButton1.TabIndex = 13
        Me.SimpleButton1.Text = "SimpleButton1"
        '
        'SearchLookUpEdit1
        '
        Me.SearchLookUpEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PaymentTableBindingSource, "registration number", True))
        Me.SearchLookUpEdit1.Location = New System.Drawing.Point(128, 59)
        Me.SearchLookUpEdit1.MenuManager = Me.ribbonControl1
        Me.SearchLookUpEdit1.Name = "SearchLookUpEdit1"
        Me.SearchLookUpEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SearchLookUpEdit1.Properties.DataSource = Me.StudentInfoBindingSource
        Me.SearchLookUpEdit1.Properties.DisplayMember = "registration number"
        Me.SearchLookUpEdit1.Properties.NullText = ""
        Me.SearchLookUpEdit1.Properties.PopupView = Me.SearchLookUpEdit1View
        Me.SearchLookUpEdit1.Properties.ValueMember = "registration number"
        Me.SearchLookUpEdit1.Size = New System.Drawing.Size(157, 22)
        Me.SearchLookUpEdit1.StyleController = Me.DataLayoutControl1
        Me.SearchLookUpEdit1.TabIndex = 4
        '
        'SearchLookUpEdit1View
        '
        Me.SearchLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colregistrationnumber4, Me.colStudentsName4, Me.colcoursename3, Me.colProgramme2, Me.colsponsorship2})
        Me.SearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SearchLookUpEdit1View.Name = "SearchLookUpEdit1View"
        Me.SearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colregistrationnumber4
        '
        Me.colregistrationnumber4.FieldName = "registration number"
        Me.colregistrationnumber4.Name = "colregistrationnumber4"
        Me.colregistrationnumber4.OptionsColumn.AllowEdit = False
        Me.colregistrationnumber4.Visible = True
        Me.colregistrationnumber4.VisibleIndex = 1
        '
        'colStudentsName4
        '
        Me.colStudentsName4.FieldName = "Students Name"
        Me.colStudentsName4.Name = "colStudentsName4"
        Me.colStudentsName4.OptionsColumn.AllowEdit = False
        Me.colStudentsName4.Visible = True
        Me.colStudentsName4.VisibleIndex = 0
        '
        'colcoursename3
        '
        Me.colcoursename3.FieldName = "course name"
        Me.colcoursename3.Name = "colcoursename3"
        Me.colcoursename3.OptionsColumn.AllowEdit = False
        Me.colcoursename3.Visible = True
        Me.colcoursename3.VisibleIndex = 2
        '
        'colProgramme2
        '
        Me.colProgramme2.FieldName = "Programme"
        Me.colProgramme2.Name = "colProgramme2"
        Me.colProgramme2.OptionsColumn.AllowEdit = False
        Me.colProgramme2.Visible = True
        Me.colProgramme2.VisibleIndex = 3
        '
        'colsponsorship2
        '
        Me.colsponsorship2.FieldName = "sponsorship"
        Me.colsponsorship2.Name = "colsponsorship2"
        Me.colsponsorship2.OptionsColumn.AllowEdit = False
        Me.colsponsorship2.Visible = True
        Me.colsponsorship2.VisibleIndex = 4
        '
        'semesterComboBoxEdit
        '
        Me.semesterComboBoxEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PaymentTableBindingSource, "semester", True))
        Me.semesterComboBoxEdit.Location = New System.Drawing.Point(128, 85)
        Me.semesterComboBoxEdit.MenuManager = Me.ribbonControl1
        Me.semesterComboBoxEdit.Name = "semesterComboBoxEdit"
        Me.semesterComboBoxEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.semesterComboBoxEdit.Properties.Items.AddRange(New Object() {"ONE", "TWO"})
        Me.semesterComboBoxEdit.Size = New System.Drawing.Size(157, 22)
        Me.semesterComboBoxEdit.StyleController = Me.DataLayoutControl1
        Me.semesterComboBoxEdit.TabIndex = 6
        '
        'ComboBoxEdit1
        '
        Me.ComboBoxEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PaymentTableBindingSource, "academic year", True))
        Me.ComboBoxEdit1.Location = New System.Drawing.Point(405, 85)
        Me.ComboBoxEdit1.MenuManager = Me.ribbonControl1
        Me.ComboBoxEdit1.Name = "ComboBoxEdit1"
        Me.ComboBoxEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ComboBoxEdit1.Properties.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        Me.ComboBoxEdit1.Size = New System.Drawing.Size(157, 22)
        Me.ComboBoxEdit1.StyleController = Me.DataLayoutControl1
        Me.ComboBoxEdit1.TabIndex = 7
        '
        'DateEdit1
        '
        Me.DateEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PaymentTableBindingSource, "payment date", True))
        Me.DateEdit1.EditValue = Nothing
        Me.DateEdit1.Location = New System.Drawing.Point(128, 111)
        Me.DateEdit1.MenuManager = Me.ribbonControl1
        Me.DateEdit1.Name = "DateEdit1"
        Me.DateEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit1.Size = New System.Drawing.Size(157, 22)
        Me.DateEdit1.StyleController = Me.DataLayoutControl1
        Me.DateEdit1.TabIndex = 8
        '
        'TextEdit1
        '
        Me.TextEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PaymentTableBindingSource, "amount paid", True))
        Me.TextEdit1.EditValue = "0"
        Me.TextEdit1.Location = New System.Drawing.Point(128, 137)
        Me.TextEdit1.MenuManager = Me.ribbonControl1
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Properties.Appearance.Options.UseTextOptions = True
        Me.TextEdit1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.TextEdit1.Properties.DisplayFormat.FormatString = "{0} Ugx"
        Me.TextEdit1.Properties.Mask.EditMask = "G"
        Me.TextEdit1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.TextEdit1.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.TextEdit1.Size = New System.Drawing.Size(157, 22)
        Me.TextEdit1.StyleController = Me.DataLayoutControl1
        Me.TextEdit1.TabIndex = 10
        '
        'TextEdit2
        '
        Me.TextEdit2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PaymentTableBindingSource, "bank name", True))
        Me.TextEdit2.Location = New System.Drawing.Point(128, 189)
        Me.TextEdit2.MenuManager = Me.ribbonControl1
        Me.TextEdit2.Name = "TextEdit2"
        Me.TextEdit2.Size = New System.Drawing.Size(157, 22)
        Me.TextEdit2.StyleController = Me.DataLayoutControl1
        Me.TextEdit2.TabIndex = 11
        '
        'TextEdit3
        '
        Me.TextEdit3.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PaymentTableBindingSource, "slip number", True))
        Me.TextEdit3.Location = New System.Drawing.Point(405, 189)
        Me.TextEdit3.MenuManager = Me.ribbonControl1
        Me.TextEdit3.Name = "TextEdit3"
        Me.TextEdit3.Size = New System.Drawing.Size(157, 22)
        Me.TextEdit3.StyleController = Me.DataLayoutControl1
        Me.TextEdit3.TabIndex = 12
        '
        'coursetextEdit
        '
        Me.coursetextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PaymentTableBindingSource, "course name", True))
        Me.coursetextEdit.Location = New System.Drawing.Point(405, 59)
        Me.coursetextEdit.MenuManager = Me.ribbonControl1
        Me.coursetextEdit.Name = "coursetextEdit"
        Me.coursetextEdit.Properties.ReadOnly = True
        Me.coursetextEdit.Properties.UseReadOnlyAppearance = False
        Me.coursetextEdit.Size = New System.Drawing.Size(157, 22)
        Me.coursetextEdit.StyleController = Me.DataLayoutControl1
        Me.coursetextEdit.TabIndex = 5
        '
        'payFieldcombo
        '
        Me.payFieldcombo.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PaymentTableBindingSource, "payment field", True))
        Me.payFieldcombo.Location = New System.Drawing.Point(405, 111)
        Me.payFieldcombo.MenuManager = Me.ribbonControl1
        Me.payFieldcombo.Name = "payFieldcombo"
        Me.payFieldcombo.Properties.AllowMultiSelect = True
        Me.payFieldcombo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.payFieldcombo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.payFieldcombo.Size = New System.Drawing.Size(157, 22)
        Me.payFieldcombo.StyleController = Me.DataLayoutControl1
        Me.payFieldcombo.TabIndex = 9
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.Control = Me.TextEdit6
        Me.LayoutControlItem13.Location = New System.Drawing.Point(0, 21)
        Me.LayoutControlItem13.Name = "LayoutControlItem13"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(277, 26)
        Me.LayoutControlItem13.Text = "Name"
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(113, 16)
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.AllowBorderColorBlending = True
        Me.LayoutControlGroup1.CustomHeaderButtons.AddRange(New DevExpress.XtraEditors.ButtonPanel.IBaseButton() {New DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton(), New DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton()})
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.HeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.BeforeText
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup2})
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(574, 266)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.AllowDrawBackground = False
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.ItemForsemester, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.EmptySpaceItem1, Me.EmptySpaceItem2, Me.SimpleLabelItem1, Me.LayoutControlItem9, Me.LayoutControlItem10, Me.LayoutControlItem11, Me.LayoutControlItem7, Me.LayoutControlItem8, Me.LayoutControlItem12, Me.SimpleSeparator1})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(554, 246)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.SearchLookUpEdit1
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 47)
        Me.LayoutControlItem1.Name = "ItemForregistration number"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(277, 26)
        Me.LayoutControlItem1.Text = "registration number"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(113, 16)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.coursetextEdit
        Me.LayoutControlItem2.Location = New System.Drawing.Point(277, 47)
        Me.LayoutControlItem2.Name = "ItemForcourse name"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(277, 26)
        Me.LayoutControlItem2.Text = "course name"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(113, 16)
        '
        'ItemForsemester
        '
        Me.ItemForsemester.Control = Me.semesterComboBoxEdit
        Me.ItemForsemester.Location = New System.Drawing.Point(0, 73)
        Me.ItemForsemester.Name = "ItemForsemester"
        Me.ItemForsemester.Size = New System.Drawing.Size(277, 26)
        Me.ItemForsemester.Text = "semester"
        Me.ItemForsemester.TextSize = New System.Drawing.Size(113, 16)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.ComboBoxEdit1
        Me.LayoutControlItem3.Location = New System.Drawing.Point(277, 73)
        Me.LayoutControlItem3.Name = "ItemForacademic year"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(277, 26)
        Me.LayoutControlItem3.Text = "academic year"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(113, 16)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.DateEdit1
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 99)
        Me.LayoutControlItem4.Name = "ItemForpayment date"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(277, 26)
        Me.LayoutControlItem4.Text = "payment date"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(113, 16)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.payFieldcombo
        Me.LayoutControlItem5.Location = New System.Drawing.Point(277, 99)
        Me.LayoutControlItem5.Name = "ItemForpayment field"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(277, 26)
        Me.LayoutControlItem5.Text = "payment field"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(113, 16)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.TextEdit1
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 125)
        Me.LayoutControlItem6.Name = "ItemForamount paid"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(277, 52)
        Me.LayoutControlItem6.Text = "amount paid"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(113, 16)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 21)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(554, 26)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(0, 203)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(554, 12)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'SimpleLabelItem1
        '
        Me.SimpleLabelItem1.AllowHotTrack = False
        Me.SimpleLabelItem1.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Bold)
        Me.SimpleLabelItem1.AppearanceItemCaption.Options.UseFont = True
        Me.SimpleLabelItem1.AppearanceItemCaption.Options.UseTextOptions = True
        Me.SimpleLabelItem1.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.SimpleLabelItem1.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.SimpleLabelItem1.Location = New System.Drawing.Point(0, 0)
        Me.SimpleLabelItem1.Name = "SimpleLabelItem1"
        Me.SimpleLabelItem1.Size = New System.Drawing.Size(554, 20)
        Me.SimpleLabelItem1.Text = " "
        Me.SimpleLabelItem1.TextSize = New System.Drawing.Size(113, 16)
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.SimpleButton1
        Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 215)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(126, 31)
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem9.TextVisible = False
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.SimpleButton2
        Me.LayoutControlItem10.Location = New System.Drawing.Point(126, 215)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(428, 31)
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem10.TextVisible = False
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.TextEdit4
        Me.LayoutControlItem11.Location = New System.Drawing.Point(277, 125)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(277, 26)
        Me.LayoutControlItem11.Text = "Fee"
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(113, 16)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.TextEdit2
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 177)
        Me.LayoutControlItem7.Name = "ItemForbank name"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(277, 26)
        Me.LayoutControlItem7.Text = "bank name"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(113, 16)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.TextEdit3
        Me.LayoutControlItem8.Location = New System.Drawing.Point(277, 177)
        Me.LayoutControlItem8.Name = "ItemForslip number"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(277, 26)
        Me.LayoutControlItem8.Text = "slip number"
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(113, 16)
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.TextEdit5
        Me.LayoutControlItem12.Location = New System.Drawing.Point(277, 151)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(277, 26)
        Me.LayoutControlItem12.Text = "Balance"
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(113, 16)
        '
        'SimpleSeparator1
        '
        Me.SimpleSeparator1.AllowHotTrack = False
        Me.SimpleSeparator1.Location = New System.Drawing.Point(0, 20)
        Me.SimpleSeparator1.Name = "SimpleSeparator1"
        Me.SimpleSeparator1.Size = New System.Drawing.Size(554, 1)
        '
        'AccountsTableGridControl
        '
        Me.AccountsTableGridControl.DataSource = Me.PaymentTableBindingSource
        Me.AccountsTableGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AccountsTableGridControl.ExternalRepository = Me.PersistentRepository1
        GridLevelNode4.RelationName = "PaymentTable_OtherFeesTable"
        GridLevelNode8.RelationName = "PaymentTable_OtherFeesTable"
        GridLevelNode12.RelationName = "PaymentTable_OtherFeesTable"
        GridLevelNode14.RelationName = "coursesTable_StudentInfo"
        GridLevelNode13.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode14})
        GridLevelNode13.RelationName = "PaymentTable_coursesTable"
        GridLevelNode11.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode12, GridLevelNode13})
        GridLevelNode11.RelationName = "StudentInfo_PaymentTable"
        GridLevelNode10.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode11})
        GridLevelNode10.RelationName = "coursesTable_StudentInfo"
        GridLevelNode9.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode10})
        GridLevelNode9.RelationName = "PaymentTable_coursesTable"
        GridLevelNode7.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode8, GridLevelNode9})
        GridLevelNode7.RelationName = "StudentInfo_PaymentTable"
        GridLevelNode6.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode7})
        GridLevelNode6.RelationName = "coursesTable_StudentInfo"
        GridLevelNode5.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode6})
        GridLevelNode5.RelationName = "PaymentTable_coursesTable"
        Me.AccountsTableGridControl.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode4, GridLevelNode5})
        Me.AccountsTableGridControl.Location = New System.Drawing.Point(0, 0)
        Me.AccountsTableGridControl.MainView = Me.GridView1
        Me.AccountsTableGridControl.MenuManager = Me.ribbonControl1
        Me.AccountsTableGridControl.Name = "AccountsTableGridControl"
        Me.AccountsTableGridControl.Size = New System.Drawing.Size(1694, 742)
        Me.AccountsTableGridControl.TabIndex = 0
        Me.AccountsTableGridControl.UseDirectXPaint = DevExpress.Utils.DefaultBoolean.[True]
        Me.AccountsTableGridControl.UseEmbeddedNavigator = True
        Me.AccountsTableGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.ChildGridLevelName = "Child"
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colregistrationnumber2, Me.colStudentsName2, Me.colcoursename2, Me.colsemester, Me.colacademicyear, Me.colpaymentdate, Me.colpaymentfield, Me.colamountpaid, Me.coltotalfees, Me.colbankname, Me.colslipnumber, Me.Balance})
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus
        GridFormatRule6.Column = Me.colpaymentdate
        GridFormatRule6.ColumnApplyTo = Me.colpaymentdate
        GridFormatRule6.Name = "Format0"
        FormatConditionRuleDateOccuring2.DateType = CType(((((((((((((DevExpress.XtraEditors.FilterDateType.LaterThisMonth Or DevExpress.XtraEditors.FilterDateType.LaterThisWeek) _
            Or DevExpress.XtraEditors.FilterDateType.Today) _
            Or DevExpress.XtraEditors.FilterDateType.Yesterday) _
            Or DevExpress.XtraEditors.FilterDateType.EarlierThisWeek) _
            Or DevExpress.XtraEditors.FilterDateType.LastWeek) _
            Or DevExpress.XtraEditors.FilterDateType.EarlierThisMonth) _
            Or DevExpress.XtraEditors.FilterDateType.EarlierThisYear) _
            Or DevExpress.XtraEditors.FilterDateType.Empty) _
            Or DevExpress.XtraEditors.FilterDateType.ThisWeek) _
            Or DevExpress.XtraEditors.FilterDateType.MonthAgo1) _
            Or DevExpress.XtraEditors.FilterDateType.MonthAgo2) _
            Or DevExpress.XtraEditors.FilterDateType.MonthAgo3), DevExpress.XtraEditors.FilterDateType)
        FormatConditionRuleDateOccuring2.PredefinedName = "Green Bold Text"
        GridFormatRule6.Rule = FormatConditionRuleDateOccuring2
        GridFormatRule7.Column = Me.Balance
        GridFormatRule7.ColumnApplyTo = Me.Balance
        GridFormatRule7.Name = "Format1"
        FormatConditionRuleDataBar2.PredefinedName = "Mint Gradient"
        GridFormatRule7.Rule = FormatConditionRuleDataBar2
        Me.GridView1.FormatRules.Add(GridFormatRule6)
        Me.GridView1.FormatRules.Add(GridFormatRule7)
        Me.GridView1.GridControl = Me.AccountsTableGridControl
        Me.GridView1.GroupCount = 1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.NewItemRowText = "New Payment..."
        Me.GridView1.OptionsBehavior.AllowIncrementalSearch = True
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsCustomization.AllowColumnMoving = False
        Me.GridView1.OptionsDetail.AutoZoomDetail = True
        Me.GridView1.OptionsDetail.EnableDetailToolTip = True
        Me.GridView1.OptionsMenu.ShowFooterItem = True
        Me.GridView1.OptionsNavigation.EnterMoveNextColumn = True
        Me.GridView1.OptionsPrint.AllowMultilineHeaders = True
        Me.GridView1.OptionsPrint.EnableAppearanceEvenRow = True
        Me.GridView1.OptionsPrint.PrintFilterInfo = True
        Me.GridView1.OptionsSelection.MultiSelect = True
        Me.GridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect
        Me.GridView1.OptionsView.EnableAppearanceOddRow = True
        Me.GridView1.OptionsView.RowAutoHeight = True
        Me.GridView1.OptionsView.ShowChildrenInGroupPanel = True
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupedColumns = True
        Me.GridView1.OptionsView.ShowViewCaption = True
        Me.GridView1.RowSeparatorHeight = 2
        Me.GridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colpaymentdate, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colcoursename2, DevExpress.Data.ColumnSortOrder.Ascending)})
        Me.GridView1.VertScrollTipFieldName = "Students Name"
        Me.GridView1.ViewCaption = "Payment"
        '
        'colregistrationnumber2
        '
        Me.colregistrationnumber2.Caption = "Registration Number"
        Me.colregistrationnumber2.ColumnEdit = Me.reglookUp
        Me.colregistrationnumber2.FieldName = "registration number"
        Me.colregistrationnumber2.Name = "colregistrationnumber2"
        Me.colregistrationnumber2.Visible = True
        Me.colregistrationnumber2.VisibleIndex = 1
        Me.colregistrationnumber2.Width = 162
        '
        'colStudentsName2
        '
        Me.colStudentsName2.Caption = "Student's Name"
        Me.colStudentsName2.ColumnEdit = Me.otextEdit
        Me.colStudentsName2.FieldName = "Students Name"
        Me.colStudentsName2.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.Alphabetical
        Me.colStudentsName2.Name = "colStudentsName2"
        Me.colStudentsName2.Visible = True
        Me.colStudentsName2.VisibleIndex = 2
        Me.colStudentsName2.Width = 204
        '
        'colcoursename2
        '
        Me.colcoursename2.Caption = "Course Name"
        Me.colcoursename2.ColumnEdit = Me.otextEdit
        Me.colcoursename2.FieldName = "course name"
        Me.colcoursename2.Name = "colcoursename2"
        Me.colcoursename2.Visible = True
        Me.colcoursename2.VisibleIndex = 3
        Me.colcoursename2.Width = 201
        '
        'colsemester
        '
        Me.colsemester.Caption = "Semester"
        Me.colsemester.ColumnEdit = Me.otextEdit
        Me.colsemester.FieldName = "semester"
        Me.colsemester.Name = "colsemester"
        Me.colsemester.Visible = True
        Me.colsemester.VisibleIndex = 4
        Me.colsemester.Width = 89
        '
        'colacademicyear
        '
        Me.colacademicyear.Caption = "Year"
        Me.colacademicyear.ColumnEdit = Me.otextEdit
        Me.colacademicyear.FieldName = "academic year"
        Me.colacademicyear.Name = "colacademicyear"
        Me.colacademicyear.Visible = True
        Me.colacademicyear.VisibleIndex = 5
        Me.colacademicyear.Width = 104
        '
        'colpaymentfield
        '
        Me.colpaymentfield.Caption = "Payment Field"
        Me.colpaymentfield.ColumnEdit = Me.telToken
        Me.colpaymentfield.FieldName = "payment field"
        Me.colpaymentfield.Name = "colpaymentfield"
        Me.colpaymentfield.Visible = True
        Me.colpaymentfield.VisibleIndex = 7
        Me.colpaymentfield.Width = 119
        '
        'colamountpaid
        '
        Me.colamountpaid.Caption = "Amount Paid"
        Me.colamountpaid.ColumnEdit = Me.MoneyText
        Me.colamountpaid.FieldName = "amount paid"
        Me.colamountpaid.Name = "colamountpaid"
        Me.colamountpaid.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "amount paid", "SUM={0:0.##} Ugx")})
        Me.colamountpaid.Visible = True
        Me.colamountpaid.VisibleIndex = 8
        Me.colamountpaid.Width = 129
        '
        'coltotalfees
        '
        Me.coltotalfees.Caption = "Total Fees"
        Me.coltotalfees.ColumnEdit = Me.MoneyText
        Me.coltotalfees.FieldName = "total fees"
        Me.coltotalfees.Name = "coltotalfees"
        Me.coltotalfees.Visible = True
        Me.coltotalfees.VisibleIndex = 9
        Me.coltotalfees.Width = 129
        '
        'colbankname
        '
        Me.colbankname.Caption = "Bank Name"
        Me.colbankname.ColumnEdit = Me.banknameCombo
        Me.colbankname.FieldName = "bank name"
        Me.colbankname.Name = "colbankname"
        Me.colbankname.Visible = True
        Me.colbankname.VisibleIndex = 10
        Me.colbankname.Width = 106
        '
        'colslipnumber
        '
        Me.colslipnumber.ColumnEdit = Me.otextEdit
        Me.colslipnumber.FieldName = "slip number"
        Me.colslipnumber.Name = "colslipnumber"
        Me.colslipnumber.Visible = True
        Me.colslipnumber.VisibleIndex = 12
        Me.colslipnumber.Width = 125
        '
        'NavigationPage5
        '
        Me.NavigationPage5.Controls.Add(Me.FlyoutPanel2)
        Me.NavigationPage5.Controls.Add(Me.Year_RegisterGridControl)
        Me.NavigationPage5.Name = "NavigationPage5"
        Me.NavigationPage5.Size = New System.Drawing.Size(1694, 742)
        '
        'FlyoutPanel2
        '
        Me.FlyoutPanel2.Controls.Add(Me.FlyoutPanelControl2)
        Me.FlyoutPanel2.Location = New System.Drawing.Point(214, 133)
        Me.FlyoutPanel2.Name = "FlyoutPanel2"
        Me.FlyoutPanel2.Options.AnchorType = DevExpress.Utils.Win.PopupToolWindowAnchor.Center
        Me.FlyoutPanel2.OptionsButtonPanel.ButtonPanelHeight = 45
        Me.FlyoutPanel2.OptionsButtonPanel.ButtonPanelLocation = DevExpress.Utils.FlyoutPanelButtonPanelLocation.Bottom
        ButtonImageOptions1.SvgImage = CType(resources.GetObject("ButtonImageOptions1.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        ButtonImageOptions2.Image = CType(resources.GetObject("ButtonImageOptions2.Image"), System.Drawing.Image)
        ButtonImageOptions3.SvgImage = CType(resources.GetObject("ButtonImageOptions3.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        ButtonImageOptions4.SvgImage = CType(resources.GetObject("ButtonImageOptions4.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        ButtonImageOptions5.Image = CType(resources.GetObject("ButtonImageOptions5.Image"), System.Drawing.Image)
        ButtonImageOptions6.SvgImage = CType(resources.GetObject("ButtonImageOptions6.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.FlyoutPanel2.OptionsButtonPanel.Buttons.AddRange(New DevExpress.XtraEditors.ButtonPanel.IBaseButton() {New DevExpress.Utils.PeekFormButton("Save", False, ButtonImageOptions1, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, True, Nothing, True, False, True, "Save", -1, False), New DevExpress.Utils.PeekFormButton("Button", False, ButtonImageOptions2, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, True, Nothing, True, False, True, "First", -1, False), New DevExpress.Utils.PeekFormButton("Previous", False, ButtonImageOptions3, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, True, Nothing, True, False, True, "Previous", -1, False), New DevExpress.Utils.PeekFormButton("Next", False, ButtonImageOptions4, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, True, Nothing, True, False, True, "Next", -1, False), New DevExpress.Utils.PeekFormButton("Button", False, ButtonImageOptions5, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, True, Nothing, True, False, True, "Last", -1, False), New DevExpress.Utils.PeekFormButton("Cancel", False, ButtonImageOptions6, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, True, Nothing, True, False, True, "Cancel", -1, True)})
        Me.FlyoutPanel2.OptionsButtonPanel.ShowButtonPanel = True
        Me.FlyoutPanel2.OwnerControl = Me.Year_RegisterGridControl
        Me.FlyoutPanel2.Padding = New System.Windows.Forms.Padding(0, 0, 0, 45)
        Me.FlyoutPanel2.Size = New System.Drawing.Size(650, 276)
        Me.FlyoutPanel2.TabIndex = 1
        '
        'FlyoutPanelControl2
        '
        Me.FlyoutPanelControl2.Controls.Add(Me.DataLayoutControl2)
        Me.FlyoutPanelControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlyoutPanelControl2.FlyoutPanel = Me.FlyoutPanel2
        Me.FlyoutPanelControl2.Location = New System.Drawing.Point(0, 0)
        Me.FlyoutPanelControl2.Name = "FlyoutPanelControl2"
        Me.FlyoutPanelControl2.Size = New System.Drawing.Size(650, 231)
        Me.FlyoutPanelControl2.TabIndex = 0
        '
        'DataLayoutControl2
        '
        Me.DataLayoutControl2.Controls.Add(Me.SearchLookUpEdit2)
        Me.DataLayoutControl2.Controls.Add(Me.HyperLinkEdit1)
        Me.DataLayoutControl2.Controls.Add(Me.FacultyTextEdit)
        Me.DataLayoutControl2.Controls.Add(Me.DepartmentTextEdit)
        Me.DataLayoutControl2.Controls.Add(Me.TextEdit7)
        Me.DataLayoutControl2.Controls.Add(Me.YearComboBoxEdit)
        Me.DataLayoutControl2.Controls.Add(Me.DurationTextEdit)
        Me.DataLayoutControl2.Controls.Add(Me.DateEdit2)
        Me.DataLayoutControl2.Controls.Add(Me.RetakeCheckEdit)
        Me.DataLayoutControl2.Controls.Add(Me.ComboBoxEdit2)
        Me.DataLayoutControl2.Controls.Add(Me.ComboBoxEdit3)
        Me.DataLayoutControl2.Controls.Add(Me.unitsTextEdit)
        Me.DataLayoutControl2.DataSource = Me.Year_RegisterBindingSource
        Me.DataLayoutControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataLayoutControl2.Location = New System.Drawing.Point(2, 2)
        Me.DataLayoutControl2.Name = "DataLayoutControl2"
        Me.DataLayoutControl2.Root = Me.LayoutControlGroup4
        Me.DataLayoutControl2.Size = New System.Drawing.Size(646, 227)
        Me.DataLayoutControl2.TabIndex = 0
        Me.DataLayoutControl2.Text = "DataLayoutControl2"
        '
        'SearchLookUpEdit2
        '
        Me.SearchLookUpEdit2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.Year_RegisterBindingSource, "Registration Number", True))
        Me.SearchLookUpEdit2.Location = New System.Drawing.Point(144, 76)
        Me.SearchLookUpEdit2.MenuManager = Me.ribbonControl1
        Me.SearchLookUpEdit2.Name = "SearchLookUpEdit2"
        Me.SearchLookUpEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SearchLookUpEdit2.Properties.DataSource = Me.StudentInfoBindingSource
        Me.SearchLookUpEdit2.Properties.DisplayMember = "registration number"
        Me.SearchLookUpEdit2.Properties.NullText = ""
        Me.SearchLookUpEdit2.Properties.PopupView = Me.SearchLookUpEdit2View
        Me.SearchLookUpEdit2.Properties.ValueMember = "registration number"
        Me.SearchLookUpEdit2.Size = New System.Drawing.Size(478, 22)
        Me.SearchLookUpEdit2.StyleController = Me.DataLayoutControl2
        Me.SearchLookUpEdit2.TabIndex = 4
        '
        'Year_RegisterBindingSource
        '
        Me.Year_RegisterBindingSource.DataMember = "Year Register"
        Me.Year_RegisterBindingSource.DataSource = Me.InstituteDataDataSet
        '
        'SearchLookUpEdit2View
        '
        Me.SearchLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SearchLookUpEdit2View.Name = "SearchLookUpEdit2View"
        Me.SearchLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SearchLookUpEdit2View.OptionsView.ShowGroupPanel = False
        '
        'HyperLinkEdit1
        '
        Me.HyperLinkEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.Year_RegisterBindingSource, "Students Name", True))
        Me.HyperLinkEdit1.Location = New System.Drawing.Point(144, 102)
        Me.HyperLinkEdit1.MenuManager = Me.ribbonControl1
        Me.HyperLinkEdit1.Name = "HyperLinkEdit1"
        Me.HyperLinkEdit1.Size = New System.Drawing.Size(478, 22)
        Me.HyperLinkEdit1.StyleController = Me.DataLayoutControl2
        Me.HyperLinkEdit1.TabIndex = 5
        '
        'FacultyTextEdit
        '
        Me.FacultyTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.Year_RegisterBindingSource, "Faculty", True))
        Me.FacultyTextEdit.Location = New System.Drawing.Point(144, 128)
        Me.FacultyTextEdit.MenuManager = Me.ribbonControl1
        Me.FacultyTextEdit.Name = "FacultyTextEdit"
        Me.FacultyTextEdit.Size = New System.Drawing.Size(176, 22)
        Me.FacultyTextEdit.StyleController = Me.DataLayoutControl2
        Me.FacultyTextEdit.TabIndex = 6
        '
        'DepartmentTextEdit
        '
        Me.DepartmentTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.Year_RegisterBindingSource, "Department", True))
        Me.DepartmentTextEdit.Location = New System.Drawing.Point(144, 154)
        Me.DepartmentTextEdit.MenuManager = Me.ribbonControl1
        Me.DepartmentTextEdit.Name = "DepartmentTextEdit"
        Me.DepartmentTextEdit.Size = New System.Drawing.Size(176, 22)
        Me.DepartmentTextEdit.StyleController = Me.DataLayoutControl2
        Me.DepartmentTextEdit.TabIndex = 7
        '
        'TextEdit7
        '
        Me.TextEdit7.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.Year_RegisterBindingSource, "Course", True))
        Me.TextEdit7.Location = New System.Drawing.Point(144, 180)
        Me.TextEdit7.MenuManager = Me.ribbonControl1
        Me.TextEdit7.Name = "TextEdit7"
        Me.TextEdit7.Size = New System.Drawing.Size(176, 22)
        Me.TextEdit7.StyleController = Me.DataLayoutControl2
        Me.TextEdit7.TabIndex = 8
        '
        'YearComboBoxEdit
        '
        Me.YearComboBoxEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.Year_RegisterBindingSource, "Year", True))
        Me.YearComboBoxEdit.Location = New System.Drawing.Point(444, 128)
        Me.YearComboBoxEdit.MenuManager = Me.ribbonControl1
        Me.YearComboBoxEdit.Name = "YearComboBoxEdit"
        Me.YearComboBoxEdit.Properties.Appearance.Options.UseTextOptions = True
        Me.YearComboBoxEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.YearComboBoxEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.YearComboBoxEdit.Size = New System.Drawing.Size(178, 22)
        Me.YearComboBoxEdit.StyleController = Me.DataLayoutControl2
        Me.YearComboBoxEdit.TabIndex = 9
        '
        'DurationTextEdit
        '
        Me.DurationTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.Year_RegisterBindingSource, "Duration", True))
        Me.DurationTextEdit.Location = New System.Drawing.Point(444, 154)
        Me.DurationTextEdit.MenuManager = Me.ribbonControl1
        Me.DurationTextEdit.Name = "DurationTextEdit"
        Me.DurationTextEdit.Properties.Appearance.Options.UseTextOptions = True
        Me.DurationTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.DurationTextEdit.Properties.Mask.EditMask = "N0"
        Me.DurationTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.DurationTextEdit.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.DurationTextEdit.Size = New System.Drawing.Size(178, 22)
        Me.DurationTextEdit.StyleController = Me.DataLayoutControl2
        Me.DurationTextEdit.TabIndex = 10
        '
        'DateEdit2
        '
        Me.DateEdit2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.Year_RegisterBindingSource, "Registration Date", True))
        Me.DateEdit2.EditValue = Nothing
        Me.DateEdit2.Location = New System.Drawing.Point(444, 180)
        Me.DateEdit2.MenuManager = Me.ribbonControl1
        Me.DateEdit2.Name = "DateEdit2"
        Me.DateEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit2.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit2.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DateEdit2.Properties.DisplayFormat.FormatString = "dd/MMM/yy"
        Me.DateEdit2.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.DateEdit2.Properties.EditFormat.FormatString = "dd/M/yy"
        Me.DateEdit2.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.DateEdit2.Properties.Mask.EditMask = ""
        Me.DateEdit2.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.DateEdit2.Size = New System.Drawing.Size(178, 22)
        Me.DateEdit2.StyleController = Me.DataLayoutControl2
        Me.DateEdit2.TabIndex = 11
        '
        'RetakeCheckEdit
        '
        Me.RetakeCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.Year_RegisterBindingSource, "Retake", True))
        Me.RetakeCheckEdit.Location = New System.Drawing.Point(24, 76)
        Me.RetakeCheckEdit.MenuManager = Me.ribbonControl1
        Me.RetakeCheckEdit.Name = "RetakeCheckEdit"
        Me.RetakeCheckEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.RetakeCheckEdit.Properties.Caption = "On Retake"
        Me.RetakeCheckEdit.Properties.DisplayValueChecked = "Retake"
        Me.RetakeCheckEdit.Properties.DisplayValueUnchecked = "Not Retake"
        Me.RetakeCheckEdit.Properties.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.RetakeCheckEdit.Properties.ValueChecked = "Retake"
        Me.RetakeCheckEdit.Properties.ValueUnchecked = "Not Retake"
        Me.RetakeCheckEdit.Size = New System.Drawing.Size(598, 24)
        Me.RetakeCheckEdit.StyleController = Me.DataLayoutControl2
        Me.RetakeCheckEdit.TabIndex = 12
        '
        'ComboBoxEdit2
        '
        Me.ComboBoxEdit2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.Year_RegisterBindingSource, "Retake Year", True))
        Me.ComboBoxEdit2.Location = New System.Drawing.Point(144, 104)
        Me.ComboBoxEdit2.MenuManager = Me.ribbonControl1
        Me.ComboBoxEdit2.Name = "ComboBoxEdit2"
        Me.ComboBoxEdit2.Properties.Appearance.Options.UseTextOptions = True
        Me.ComboBoxEdit2.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.ComboBoxEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ComboBoxEdit2.Size = New System.Drawing.Size(478, 22)
        Me.ComboBoxEdit2.StyleController = Me.DataLayoutControl2
        Me.ComboBoxEdit2.TabIndex = 13
        '
        'ComboBoxEdit3
        '
        Me.ComboBoxEdit3.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.Year_RegisterBindingSource, "Retake Semester", True))
        Me.ComboBoxEdit3.Location = New System.Drawing.Point(144, 130)
        Me.ComboBoxEdit3.MenuManager = Me.ribbonControl1
        Me.ComboBoxEdit3.Name = "ComboBoxEdit3"
        Me.ComboBoxEdit3.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ComboBoxEdit3.Size = New System.Drawing.Size(478, 22)
        Me.ComboBoxEdit3.StyleController = Me.DataLayoutControl2
        Me.ComboBoxEdit3.TabIndex = 14
        '
        'unitsTextEdit
        '
        Me.unitsTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.Year_RegisterBindingSource, "units", True))
        Me.unitsTextEdit.Location = New System.Drawing.Point(144, 156)
        Me.unitsTextEdit.MenuManager = Me.ribbonControl1
        Me.unitsTextEdit.Name = "unitsTextEdit"
        Me.unitsTextEdit.Properties.EditMode = DevExpress.XtraEditors.TokenEditMode.TokenList
        Me.unitsTextEdit.Properties.Separators.AddRange(New String() {","})
        Me.unitsTextEdit.Size = New System.Drawing.Size(478, 22)
        Me.unitsTextEdit.StyleController = Me.DataLayoutControl2
        Me.unitsTextEdit.TabIndex = 15
        '
        'LayoutControlGroup4
        '
        Me.LayoutControlGroup4.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup4.GroupBordersVisible = False
        Me.LayoutControlGroup4.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup5})
        Me.LayoutControlGroup4.Name = "LayoutControlGroup4"
        Me.LayoutControlGroup4.Size = New System.Drawing.Size(646, 227)
        Me.LayoutControlGroup4.TextVisible = False
        '
        'LayoutControlGroup5
        '
        Me.LayoutControlGroup5.AllowDrawBackground = False
        Me.LayoutControlGroup5.GroupBordersVisible = False
        Me.LayoutControlGroup5.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.TabbedControlGroup1, Me.SimpleLabelItem2})
        Me.LayoutControlGroup5.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup5.Name = "autoGeneratedGroup0"
        Me.LayoutControlGroup5.Size = New System.Drawing.Size(626, 207)
        '
        'TabbedControlGroup1
        '
        Me.TabbedControlGroup1.Location = New System.Drawing.Point(0, 20)
        Me.TabbedControlGroup1.Name = "TabbedControlGroup1"
        Me.TabbedControlGroup1.SelectedTabPage = Me.LayoutControlGroup7
        Me.TabbedControlGroup1.SelectedTabPageIndex = 0
        Me.TabbedControlGroup1.Size = New System.Drawing.Size(626, 187)
        Me.TabbedControlGroup1.TabPages.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup7, Me.LayoutControlGroup6})
        '
        'LayoutControlGroup7
        '
        Me.LayoutControlGroup7.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem14, Me.LayoutControlItem15, Me.ItemForFaculty, Me.ItemForDepartment, Me.ItemForCourse, Me.ItemForYear, Me.LayoutControlItem16, Me.ItemForDuration})
        Me.LayoutControlGroup7.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup7.Name = "LayoutControlGroup7"
        Me.LayoutControlGroup7.Size = New System.Drawing.Size(602, 131)
        Me.LayoutControlGroup7.TextVisible = False
        '
        'LayoutControlItem14
        '
        Me.LayoutControlItem14.Control = Me.SearchLookUpEdit2
        Me.LayoutControlItem14.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem14.Name = "ItemForRegistration Number"
        Me.LayoutControlItem14.Size = New System.Drawing.Size(602, 26)
        Me.LayoutControlItem14.Text = "Registration Number"
        Me.LayoutControlItem14.TextSize = New System.Drawing.Size(117, 16)
        '
        'LayoutControlItem15
        '
        Me.LayoutControlItem15.Control = Me.HyperLinkEdit1
        Me.LayoutControlItem15.Location = New System.Drawing.Point(0, 26)
        Me.LayoutControlItem15.Name = "ItemForStudents Name"
        Me.LayoutControlItem15.Size = New System.Drawing.Size(602, 26)
        Me.LayoutControlItem15.Text = "Students Name"
        Me.LayoutControlItem15.TextSize = New System.Drawing.Size(117, 16)
        '
        'ItemForFaculty
        '
        Me.ItemForFaculty.Control = Me.FacultyTextEdit
        Me.ItemForFaculty.Location = New System.Drawing.Point(0, 52)
        Me.ItemForFaculty.Name = "ItemForFaculty"
        Me.ItemForFaculty.Size = New System.Drawing.Size(300, 26)
        Me.ItemForFaculty.Text = "Faculty"
        Me.ItemForFaculty.TextSize = New System.Drawing.Size(117, 16)
        '
        'ItemForDepartment
        '
        Me.ItemForDepartment.Control = Me.DepartmentTextEdit
        Me.ItemForDepartment.Location = New System.Drawing.Point(0, 78)
        Me.ItemForDepartment.Name = "ItemForDepartment"
        Me.ItemForDepartment.Size = New System.Drawing.Size(300, 26)
        Me.ItemForDepartment.Text = "Department"
        Me.ItemForDepartment.TextSize = New System.Drawing.Size(117, 16)
        '
        'ItemForCourse
        '
        Me.ItemForCourse.Control = Me.TextEdit7
        Me.ItemForCourse.Location = New System.Drawing.Point(0, 104)
        Me.ItemForCourse.Name = "ItemForCourse"
        Me.ItemForCourse.Size = New System.Drawing.Size(300, 27)
        Me.ItemForCourse.Text = "Course"
        Me.ItemForCourse.TextSize = New System.Drawing.Size(117, 16)
        '
        'ItemForYear
        '
        Me.ItemForYear.Control = Me.YearComboBoxEdit
        Me.ItemForYear.Location = New System.Drawing.Point(300, 52)
        Me.ItemForYear.Name = "ItemForYear"
        Me.ItemForYear.Size = New System.Drawing.Size(302, 26)
        Me.ItemForYear.Text = "Year"
        Me.ItemForYear.TextSize = New System.Drawing.Size(117, 16)
        '
        'LayoutControlItem16
        '
        Me.LayoutControlItem16.Control = Me.DateEdit2
        Me.LayoutControlItem16.Location = New System.Drawing.Point(300, 104)
        Me.LayoutControlItem16.Name = "ItemForRegistration Date"
        Me.LayoutControlItem16.Size = New System.Drawing.Size(302, 27)
        Me.LayoutControlItem16.Text = "Registration Date"
        Me.LayoutControlItem16.TextSize = New System.Drawing.Size(117, 16)
        '
        'ItemForDuration
        '
        Me.ItemForDuration.Control = Me.DurationTextEdit
        Me.ItemForDuration.Location = New System.Drawing.Point(300, 78)
        Me.ItemForDuration.Name = "ItemForDuration"
        Me.ItemForDuration.Size = New System.Drawing.Size(302, 26)
        Me.ItemForDuration.Text = "Duration"
        Me.ItemForDuration.TextSize = New System.Drawing.Size(117, 16)
        '
        'LayoutControlGroup6
        '
        Me.LayoutControlGroup6.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem21, Me.ItemForunits, Me.LayoutControlItem20, Me.ItemForRetake})
        Me.LayoutControlGroup6.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup6.Name = "LayoutControlGroup6"
        Me.LayoutControlGroup6.Size = New System.Drawing.Size(602, 131)
        Me.LayoutControlGroup6.Text = "Retake"
        '
        'LayoutControlItem21
        '
        Me.LayoutControlItem21.Control = Me.ComboBoxEdit3
        Me.LayoutControlItem21.Location = New System.Drawing.Point(0, 54)
        Me.LayoutControlItem21.Name = "LayoutControlItem21"
        Me.LayoutControlItem21.Size = New System.Drawing.Size(602, 26)
        Me.LayoutControlItem21.Text = "Retake Semester"
        Me.LayoutControlItem21.TextSize = New System.Drawing.Size(117, 16)
        '
        'ItemForunits
        '
        Me.ItemForunits.Control = Me.unitsTextEdit
        Me.ItemForunits.Location = New System.Drawing.Point(0, 80)
        Me.ItemForunits.Name = "ItemForunits"
        Me.ItemForunits.Size = New System.Drawing.Size(602, 51)
        Me.ItemForunits.Text = "units"
        Me.ItemForunits.TextSize = New System.Drawing.Size(117, 16)
        '
        'LayoutControlItem20
        '
        Me.LayoutControlItem20.Control = Me.ComboBoxEdit2
        Me.LayoutControlItem20.Location = New System.Drawing.Point(0, 28)
        Me.LayoutControlItem20.Name = "ItemForRetake Year"
        Me.LayoutControlItem20.Size = New System.Drawing.Size(602, 26)
        Me.LayoutControlItem20.Text = "Retake Year"
        Me.LayoutControlItem20.TextSize = New System.Drawing.Size(117, 16)
        '
        'ItemForRetake
        '
        Me.ItemForRetake.Control = Me.RetakeCheckEdit
        Me.ItemForRetake.Location = New System.Drawing.Point(0, 0)
        Me.ItemForRetake.Name = "ItemForRetake"
        Me.ItemForRetake.Size = New System.Drawing.Size(602, 28)
        Me.ItemForRetake.Text = "Retake"
        Me.ItemForRetake.TextSize = New System.Drawing.Size(0, 0)
        Me.ItemForRetake.TextVisible = False
        '
        'SimpleLabelItem2
        '
        Me.SimpleLabelItem2.AllowHotTrack = False
        Me.SimpleLabelItem2.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Bold)
        Me.SimpleLabelItem2.AppearanceItemCaption.Options.UseFont = True
        Me.SimpleLabelItem2.AppearanceItemCaption.Options.UseTextOptions = True
        Me.SimpleLabelItem2.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.SimpleLabelItem2.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.SimpleLabelItem2.Location = New System.Drawing.Point(0, 0)
        Me.SimpleLabelItem2.Name = "SimpleLabelItem2"
        Me.SimpleLabelItem2.Size = New System.Drawing.Size(626, 20)
        Me.SimpleLabelItem2.Text = "New Register"
        Me.SimpleLabelItem2.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.SimpleLabelItem2.TextSize = New System.Drawing.Size(86, 16)
        '
        'Year_RegisterGridControl
        '
        Me.Year_RegisterGridControl.DataSource = Me.Year_RegisterBindingSource
        Me.Year_RegisterGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Year_RegisterGridControl.ExternalRepository = Me.PersistentRepository1
        GridLevelNode16.RelationName = "PaymentTable_OtherFeesTable"
        GridLevelNode20.RelationName = "PaymentTable_OtherFeesTable"
        GridLevelNode24.RelationName = "PaymentTable_OtherFeesTable"
        GridLevelNode25.RelationName = "PaymentTable_coursesTable"
        GridLevelNode23.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode24, GridLevelNode25})
        GridLevelNode23.RelationName = "StudentInfo_PaymentTable"
        GridLevelNode22.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode23})
        GridLevelNode22.RelationName = "coursesTable_StudentInfo"
        GridLevelNode21.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode22})
        GridLevelNode21.RelationName = "PaymentTable_coursesTable"
        GridLevelNode19.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode20, GridLevelNode21})
        GridLevelNode19.RelationName = "StudentInfo_PaymentTable"
        GridLevelNode18.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode19})
        GridLevelNode18.RelationName = "coursesTable_StudentInfo"
        GridLevelNode17.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode18})
        GridLevelNode17.RelationName = "PaymentTable_coursesTable"
        GridLevelNode15.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode16, GridLevelNode17})
        GridLevelNode15.RelationName = "Year Register_PaymentTable"
        GridLevelNode27.RelationName = "PaymentTable_OtherFeesTable"
        GridLevelNode31.RelationName = "PaymentTable_OtherFeesTable"
        GridLevelNode35.RelationName = "PaymentTable_OtherFeesTable"
        GridLevelNode36.RelationName = "PaymentTable_coursesTable"
        GridLevelNode34.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode35, GridLevelNode36})
        GridLevelNode34.RelationName = "StudentInfo_PaymentTable"
        GridLevelNode33.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode34})
        GridLevelNode33.RelationName = "coursesTable_StudentInfo"
        GridLevelNode32.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode33})
        GridLevelNode32.RelationName = "PaymentTable_coursesTable"
        GridLevelNode30.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode31, GridLevelNode32})
        GridLevelNode30.RelationName = "StudentInfo_PaymentTable"
        GridLevelNode29.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode30})
        GridLevelNode29.RelationName = "coursesTable_StudentInfo"
        GridLevelNode28.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode29})
        GridLevelNode28.RelationName = "PaymentTable_coursesTable"
        GridLevelNode26.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode27, GridLevelNode28})
        GridLevelNode26.RelationName = "Year Register_PaymentTable1"
        GridLevelNode39.RelationName = "PaymentTable_OtherFeesTable"
        GridLevelNode43.RelationName = "PaymentTable_OtherFeesTable"
        GridLevelNode46.RelationName = "StudentInfo_PaymentTable"
        GridLevelNode45.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode46})
        GridLevelNode45.RelationName = "coursesTable_StudentInfo"
        GridLevelNode44.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode45})
        GridLevelNode44.RelationName = "PaymentTable_coursesTable"
        GridLevelNode42.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode43, GridLevelNode44})
        GridLevelNode42.RelationName = "StudentInfo_PaymentTable"
        GridLevelNode41.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode42})
        GridLevelNode41.RelationName = "coursesTable_StudentInfo"
        GridLevelNode40.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode41})
        GridLevelNode40.RelationName = "PaymentTable_coursesTable"
        GridLevelNode38.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode39, GridLevelNode40})
        GridLevelNode38.RelationName = "StudentInfo_PaymentTable"
        GridLevelNode37.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode38})
        GridLevelNode37.RelationName = "Year Register_StudentInfo"
        GridLevelNode48.RelationName = "PaymentTable_OtherFeesTable"
        GridLevelNode52.RelationName = "PaymentTable_OtherFeesTable"
        GridLevelNode56.RelationName = "PaymentTable_OtherFeesTable"
        GridLevelNode57.RelationName = "PaymentTable_coursesTable"
        GridLevelNode55.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode56, GridLevelNode57})
        GridLevelNode55.RelationName = "StudentInfo_PaymentTable"
        GridLevelNode54.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode55})
        GridLevelNode54.RelationName = "coursesTable_StudentInfo"
        GridLevelNode53.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode54})
        GridLevelNode53.RelationName = "PaymentTable_coursesTable"
        GridLevelNode51.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode52, GridLevelNode53})
        GridLevelNode51.RelationName = "StudentInfo_PaymentTable"
        GridLevelNode50.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode51})
        GridLevelNode50.RelationName = "coursesTable_StudentInfo"
        GridLevelNode49.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode50})
        GridLevelNode49.RelationName = "PaymentTable_coursesTable"
        GridLevelNode47.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode48, GridLevelNode49})
        GridLevelNode47.RelationName = "Year Register_PaymentTable2"
        Me.Year_RegisterGridControl.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode15, GridLevelNode26, GridLevelNode37, GridLevelNode47})
        Me.Year_RegisterGridControl.Location = New System.Drawing.Point(0, 0)
        Me.Year_RegisterGridControl.MainView = Me.AdvBandedGridView2
        Me.Year_RegisterGridControl.MenuManager = Me.ribbonControl1
        Me.Year_RegisterGridControl.Name = "Year_RegisterGridControl"
        Me.Year_RegisterGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.namesearch, Me.facgrid, Me.deptgrid, Me.coursegrid, Me.regsearch, Me.RepositoryItemCheckEdit1, Me.RepositoryItemDateEdit2})
        Me.Year_RegisterGridControl.Size = New System.Drawing.Size(1694, 742)
        Me.Year_RegisterGridControl.TabIndex = 0
        Me.Year_RegisterGridControl.UseEmbeddedNavigator = True
        Me.Year_RegisterGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.AdvBandedGridView2})
        '
        'AdvBandedGridView2
        '
        Me.AdvBandedGridView2.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand8, Me.gridBand9})
        Me.AdvBandedGridView2.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.colRegistrationNumber3, Me.colStudentsName3, Me.colFaculty1, Me.colDepartment1, Me.colCourse, Me.colYear, Me.colDuration, Me.colRegistrationDate1, Me.colRetake, Me.colRetakeYear, Me.colRetakeSemester, Me.colunits})
        Me.AdvBandedGridView2.GridControl = Me.Year_RegisterGridControl
        Me.AdvBandedGridView2.Name = "AdvBandedGridView2"
        Me.AdvBandedGridView2.OptionsBehavior.ReadOnly = True
        Me.AdvBandedGridView2.OptionsView.ShowViewCaption = True
        Me.AdvBandedGridView2.ViewCaption = "Year Register"
        '
        'GridBand8
        '
        Me.GridBand8.Columns.Add(Me.colRegistrationNumber3)
        Me.GridBand8.Columns.Add(Me.colStudentsName3)
        Me.GridBand8.Columns.Add(Me.colFaculty1)
        Me.GridBand8.Columns.Add(Me.colDepartment1)
        Me.GridBand8.Columns.Add(Me.colCourse)
        Me.GridBand8.Columns.Add(Me.colYear)
        Me.GridBand8.Columns.Add(Me.colDuration)
        Me.GridBand8.Name = "GridBand8"
        Me.GridBand8.VisibleIndex = 0
        Me.GridBand8.Width = 1082
        '
        'colRegistrationNumber3
        '
        Me.colRegistrationNumber3.AutoFillDown = True
        Me.colRegistrationNumber3.ColumnEdit = Me.otextEdit
        Me.colRegistrationNumber3.FieldName = "Registration Number"
        Me.colRegistrationNumber3.Name = "colRegistrationNumber3"
        Me.colRegistrationNumber3.Visible = True
        Me.colRegistrationNumber3.Width = 203
        '
        'colStudentsName3
        '
        Me.colStudentsName3.AutoFillDown = True
        Me.colStudentsName3.ColumnEdit = Me.otextEdit
        Me.colStudentsName3.FieldName = "Students Name"
        Me.colStudentsName3.Name = "colStudentsName3"
        Me.colStudentsName3.Visible = True
        Me.colStudentsName3.Width = 229
        '
        'colFaculty1
        '
        Me.colFaculty1.AutoFillDown = True
        Me.colFaculty1.ColumnEdit = Me.otextEdit
        Me.colFaculty1.FieldName = "Faculty"
        Me.colFaculty1.Name = "colFaculty1"
        Me.colFaculty1.Visible = True
        Me.colFaculty1.Width = 164
        '
        'colDepartment1
        '
        Me.colDepartment1.AutoFillDown = True
        Me.colDepartment1.ColumnEdit = Me.otextEdit
        Me.colDepartment1.FieldName = "Department"
        Me.colDepartment1.Name = "colDepartment1"
        Me.colDepartment1.Visible = True
        Me.colDepartment1.Width = 127
        '
        'colCourse
        '
        Me.colCourse.AutoFillDown = True
        Me.colCourse.ColumnEdit = Me.otextEdit
        Me.colCourse.FieldName = "Course"
        Me.colCourse.Name = "colCourse"
        Me.colCourse.Visible = True
        Me.colCourse.Width = 149
        '
        'colYear
        '
        Me.colYear.AutoFillDown = True
        Me.colYear.FieldName = "Year"
        Me.colYear.Name = "colYear"
        Me.colYear.Visible = True
        Me.colYear.Width = 84
        '
        'colDuration
        '
        Me.colDuration.AutoFillDown = True
        Me.colDuration.FieldName = "Duration"
        Me.colDuration.Name = "colDuration"
        Me.colDuration.Visible = True
        Me.colDuration.Width = 126
        '
        'gridBand9
        '
        Me.gridBand9.Caption = "Retake Registration"
        Me.gridBand9.Columns.Add(Me.colRetake)
        Me.gridBand9.Columns.Add(Me.colRegistrationDate1)
        Me.gridBand9.Columns.Add(Me.colRetakeYear)
        Me.gridBand9.Columns.Add(Me.colRetakeSemester)
        Me.gridBand9.Columns.Add(Me.colunits)
        Me.gridBand9.Name = "gridBand9"
        Me.gridBand9.VisibleIndex = 1
        Me.gridBand9.Width = 462
        '
        'colRetake
        '
        Me.colRetake.AutoFillDown = True
        Me.colRetake.FieldName = "Retake"
        Me.colRetake.Name = "colRetake"
        Me.colRetake.Visible = True
        Me.colRetake.Width = 114
        '
        'colRegistrationDate1
        '
        Me.colRegistrationDate1.AutoFillDown = True
        Me.colRegistrationDate1.FieldName = "Registration Date"
        Me.colRegistrationDate1.Name = "colRegistrationDate1"
        Me.colRegistrationDate1.Visible = True
        Me.colRegistrationDate1.Width = 114
        '
        'colRetakeYear
        '
        Me.colRetakeYear.AutoFillDown = True
        Me.colRetakeYear.FieldName = "Retake Year"
        Me.colRetakeYear.Name = "colRetakeYear"
        Me.colRetakeYear.Visible = True
        Me.colRetakeYear.Width = 114
        '
        'colRetakeSemester
        '
        Me.colRetakeSemester.AutoFillDown = True
        Me.colRetakeSemester.ColumnEdit = Me.otextEdit
        Me.colRetakeSemester.FieldName = "Retake Semester"
        Me.colRetakeSemester.Name = "colRetakeSemester"
        Me.colRetakeSemester.Visible = True
        Me.colRetakeSemester.Width = 120
        '
        'colunits
        '
        Me.colunits.AutoFillDown = True
        Me.colunits.ColumnEdit = Me.telToken
        Me.colunits.FieldName = "units"
        Me.colunits.Name = "colunits"
        Me.colunits.RowIndex = 1
        Me.colunits.Visible = True
        Me.colunits.Width = 462
        '
        'namesearch
        '
        Me.namesearch.AutoHeight = False
        Me.namesearch.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.namesearch.DataSource = Me.StudentInfoBindingSource
        Me.namesearch.DisplayMember = "Students Name"
        Me.namesearch.Name = "namesearch"
        Me.namesearch.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.namesearch.PopupView = Me.RepositoryItemSearchLookUpEdit1View
        Me.namesearch.PopupWidthMode = DevExpress.XtraEditors.PopupWidthMode.ContentWidth
        Me.namesearch.ValueMember = "Students Name"
        '
        'RepositoryItemSearchLookUpEdit1View
        '
        Me.RepositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemSearchLookUpEdit1View.Name = "RepositoryItemSearchLookUpEdit1View"
        Me.RepositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'facgrid
        '
        Me.facgrid.AutoHeight = False
        Me.facgrid.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.facgrid.DataSource = Me.CoursesTableBindingSource
        Me.facgrid.DisplayMember = "faculty"
        Me.facgrid.Name = "facgrid"
        Me.facgrid.PopupView = Me.GridView4
        Me.facgrid.PopupWidthMode = DevExpress.XtraEditors.PopupWidthMode.ContentWidth
        Me.facgrid.ValueMember = "faculty"
        '
        'GridView4
        '
        Me.GridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView4.Name = "GridView4"
        Me.GridView4.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView4.OptionsView.ShowGroupPanel = False
        '
        'deptgrid
        '
        Me.deptgrid.AutoHeight = False
        Me.deptgrid.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deptgrid.DataSource = Me.CoursesTableBindingSource
        Me.deptgrid.DisplayMember = "department"
        Me.deptgrid.Name = "deptgrid"
        Me.deptgrid.PopupView = Me.RepositoryItemGridLookUpEdit2View
        Me.deptgrid.PopupWidthMode = DevExpress.XtraEditors.PopupWidthMode.ContentWidth
        Me.deptgrid.ValueMember = "department"
        '
        'RepositoryItemGridLookUpEdit2View
        '
        Me.RepositoryItemGridLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit2View.Name = "RepositoryItemGridLookUpEdit2View"
        Me.RepositoryItemGridLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit2View.OptionsView.ShowGroupPanel = False
        '
        'coursegrid
        '
        Me.coursegrid.AutoHeight = False
        Me.coursegrid.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.coursegrid.DataSource = Me.CoursesTableBindingSource
        Me.coursegrid.DisplayMember = "course name"
        Me.coursegrid.Name = "coursegrid"
        Me.coursegrid.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.coursegrid.PopupView = Me.GridView5
        Me.coursegrid.PopupWidthMode = DevExpress.XtraEditors.PopupWidthMode.ContentWidth
        Me.coursegrid.ValueMember = "course name"
        '
        'GridView5
        '
        Me.GridView5.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView5.Name = "GridView5"
        Me.GridView5.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView5.OptionsView.ShowGroupPanel = False
        '
        'regsearch
        '
        Me.regsearch.AutoHeight = False
        Me.regsearch.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.regsearch.DataSource = Me.StudentInfoBindingSource
        Me.regsearch.DisplayMember = "registration number"
        Me.regsearch.Name = "regsearch"
        Me.regsearch.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.StartsWith
        Me.regsearch.PopupView = Me.GridView6
        Me.regsearch.PopupWidthMode = DevExpress.XtraEditors.PopupWidthMode.UseEditorWidth
        Me.regsearch.ValueMember = "registration number"
        '
        'GridView6
        '
        Me.GridView6.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView6.Name = "GridView6"
        Me.GridView6.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView6.OptionsView.ShowGroupPanel = False
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'RepositoryItemDateEdit2
        '
        Me.RepositoryItemDateEdit2.AutoHeight = False
        Me.RepositoryItemDateEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit2.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit2.Name = "RepositoryItemDateEdit2"
        '
        'NavigationPage6
        '
        Me.NavigationPage6.Controls.Add(Me.GridControl1)
        Me.NavigationPage6.Controls.Add(Me.OtherFeesTableGridControl)
        Me.NavigationPage6.Name = "NavigationPage6"
        Me.NavigationPage6.Size = New System.Drawing.Size(1694, 742)
        '
        'GridControl1
        '
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView13
        Me.GridControl1.MenuManager = Me.ribbonControl1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1228, 742)
        Me.GridControl1.TabIndex = 1
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView13})
        '
        'GridView13
        '
        Me.GridView13.DetailHeight = 311
        Me.GridView13.GridControl = Me.GridControl1
        Me.GridView13.Name = "GridView13"
        Me.GridView13.OptionsView.ShowFooter = True
        '
        'OtherFeesTableGridControl
        '
        Me.OtherFeesTableGridControl.DataSource = Me.OtherFeesTableBindingSource
        Me.OtherFeesTableGridControl.Dock = System.Windows.Forms.DockStyle.Right
        Me.OtherFeesTableGridControl.Location = New System.Drawing.Point(1228, 0)
        Me.OtherFeesTableGridControl.MainView = Me.GridView12
        Me.OtherFeesTableGridControl.MenuManager = Me.ribbonControl1
        Me.OtherFeesTableGridControl.Name = "OtherFeesTableGridControl"
        Me.OtherFeesTableGridControl.Size = New System.Drawing.Size(466, 742)
        Me.OtherFeesTableGridControl.TabIndex = 0
        Me.OtherFeesTableGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView12})
        '
        'GridView12
        '
        Me.GridView12.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colfield, Me.colfee})
        Me.GridView12.DetailHeight = 311
        Me.GridView12.GridControl = Me.OtherFeesTableGridControl
        Me.GridView12.Name = "GridView12"
        '
        'colfield
        '
        Me.colfield.FieldName = "field"
        Me.colfield.MinWidth = 17
        Me.colfield.Name = "colfield"
        Me.colfield.Visible = True
        Me.colfield.VisibleIndex = 0
        Me.colfield.Width = 66
        '
        'colfee
        '
        Me.colfee.FieldName = "fee"
        Me.colfee.MinWidth = 17
        Me.colfee.Name = "colfee"
        Me.colfee.Visible = True
        Me.colfee.VisibleIndex = 1
        Me.colfee.Width = 66
        '
        'DefaultLookAndFeel1
        '
        Me.DefaultLookAndFeel1.LookAndFeel.SkinName = "The Bezier"
        '
        'DockManager1
        '
        Me.DockManager1.AutoHideContainers.AddRange(New DevExpress.XtraBars.Docking.AutoHideContainer() {Me.hideContainerRight})
        Me.DockManager1.Form = Me
        Me.DockManager1.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl", "DevExpress.XtraBars.Navigation.OfficeNavigationBar", "DevExpress.XtraBars.Navigation.TileNavPane", "DevExpress.XtraBars.TabFormControl"})
        '
        'hideContainerRight
        '
        Me.hideContainerRight.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.hideContainerRight.Controls.Add(Me.DockPanel1)
        Me.hideContainerRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.hideContainerRight.Location = New System.Drawing.Point(1694, 122)
        Me.hideContainerRight.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.hideContainerRight.Name = "hideContainerRight"
        Me.hideContainerRight.Size = New System.Drawing.Size(30, 836)
        '
        'DockPanel1
        '
        Me.DockPanel1.Controls.Add(Me.DockPanel1_Container)
        Me.DockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right
        Me.DockPanel1.ID = New System.Guid("bbd8a0ef-5588-4edc-b8be-efb7d224fbdb")
        Me.DockPanel1.Location = New System.Drawing.Point(1188, 122)
        Me.DockPanel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DockPanel1.Name = "DockPanel1"
        Me.DockPanel1.OriginalSize = New System.Drawing.Size(200, 200)
        Me.DockPanel1.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Right
        Me.DockPanel1.SavedIndex = 0
        Me.DockPanel1.SavedSizeFactor = 1.0R
        Me.DockPanel1.Size = New System.Drawing.Size(200, 659)
        Me.DockPanel1.Text = "DockPanel1"
        Me.DockPanel1.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide
        '
        'DockPanel1_Container
        '
        Me.DockPanel1_Container.Location = New System.Drawing.Point(6, 37)
        Me.DockPanel1_Container.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DockPanel1_Container.Name = "DockPanel1_Container"
        Me.DockPanel1_Container.Size = New System.Drawing.Size(190, 618)
        Me.DockPanel1_Container.TabIndex = 0
        '
        'StudentInfoTableAdapter
        '
        Me.StudentInfoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.coursesTableTableAdapter = Nothing
        Me.TableAdapterManager.OtherFeesTableTableAdapter = Nothing
        Me.TableAdapterManager.PaymentTableTableAdapter = Nothing
        Me.TableAdapterManager.retakeTableTableAdapter = Nothing
        Me.TableAdapterManager.staffTableTableAdapter = Nothing
        Me.TableAdapterManager.StudentInfoTableAdapter = Me.StudentInfoTableAdapter
        Me.TableAdapterManager.unitsTableTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Fathom_Institute.instituteDataDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.Year_RegisterTableAdapter = Nothing
        '
        'CoursesTableTableAdapter
        '
        Me.CoursesTableTableAdapter.ClearBeforeFill = True
        '
        'AdornerUIManager1
        '
        Me.AdornerUIManager1.Elements.Add(Me.Badge1)
        Me.AdornerUIManager1.Elements.Add(Me.Badge2)
        Me.AdornerUIManager1.GuideProperties.ShowGuidesShortcut = New DevExpress.Utils.KeyShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C))
        Me.AdornerUIManager1.Owner = Me
        '
        'Badge1
        '
        Me.Badge1.Appearance.BackColor = System.Drawing.Color.Blue
        Me.Badge1.Appearance.Options.UseBackColor = True
        Me.Badge1.Properties.Location = System.Drawing.ContentAlignment.TopRight
        Me.Badge1.Properties.TrimByParent = DevExpress.Utils.DefaultBoolean.[False]
        Me.Badge1.TargetElement = Me.TileItem2
        '
        'TileItem2
        '
        Me.TileItem2.CurrentFrameIndex = 1
        TileItemElement1.ImageOptions.Image = CType(resources.GetObject("resource.Image1"), System.Drawing.Image)
        TileItemElement1.Text = "Student Database"
        TileItemElement2.Text = "Student Overall Databse."
        TileItemElement2.TextLocation = New System.Drawing.Point(10, 20)
        Me.TileItem2.Elements.Add(TileItemElement1)
        Me.TileItem2.Elements.Add(TileItemElement2)
        TileItemElement3.ImageOptions.Image = CType(resources.GetObject("resource.Image2"), System.Drawing.Image)
        TileItemElement3.Text = "Student Database"
        TileItemFrame1.Elements.Add(TileItemElement3)
        TileItemFrame1.Image = CType(resources.GetObject("TileItemFrame1.Image"), System.Drawing.Image)
        TileItemElement4.ImageOptions.Image = CType(resources.GetObject("resource.Image3"), System.Drawing.Image)
        TileItemElement4.Text = "Student Database"
        TileItemElement5.Text = "Student Overall Databse."
        TileItemElement5.TextLocation = New System.Drawing.Point(10, 20)
        TileItemFrame2.Elements.Add(TileItemElement4)
        TileItemFrame2.Elements.Add(TileItemElement5)
        TileItemFrame2.Image = CType(resources.GetObject("TileItemFrame2.Image"), System.Drawing.Image)
        Me.TileItem2.Frames.Add(TileItemFrame1)
        Me.TileItem2.Frames.Add(TileItemFrame2)
        Me.TileItem2.Id = 1
        Me.TileItem2.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide
        Me.TileItem2.Name = "TileItem2"
        '
        'Badge2
        '
        Me.Badge2.Appearance.BackColor = System.Drawing.Color.Blue
        Me.Badge2.Appearance.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Badge2.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Badge2.Appearance.Options.UseBackColor = True
        Me.Badge2.Appearance.Options.UseBorderColor = True
        Me.Badge2.Properties.Location = System.Drawing.ContentAlignment.TopRight
        Me.Badge2.Properties.TrimByParent = DevExpress.Utils.DefaultBoolean.[False]
        Me.Badge2.TargetElement = Me.TileItem1
        '
        'TileItem1
        '
        Me.TileItem1.CurrentFrameIndex = 1
        TileItemElement16.ImageOptions.Image = CType(resources.GetObject("resource.Image10"), System.Drawing.Image)
        TileItemElement16.Text = "Courses"
        TileItemElement17.Text = "List of courses, units, and Tuition."
        TileItemElement17.TextLocation = New System.Drawing.Point(10, 20)
        Me.TileItem1.Elements.Add(TileItemElement16)
        Me.TileItem1.Elements.Add(TileItemElement17)
        TileItemElement18.ImageOptions.Image = CType(resources.GetObject("resource.Image11"), System.Drawing.Image)
        TileItemElement18.Text = "Courses"
        TileItemFrame7.Elements.Add(TileItemElement18)
        TileItemFrame7.Image = CType(resources.GetObject("TileItemFrame7.Image"), System.Drawing.Image)
        TileItemElement19.ImageOptions.Image = CType(resources.GetObject("resource.Image12"), System.Drawing.Image)
        TileItemElement19.Text = "Courses"
        TileItemElement20.Text = "List of courses, units, and Tuition."
        TileItemElement20.TextLocation = New System.Drawing.Point(10, 20)
        TileItemFrame8.Elements.Add(TileItemElement19)
        TileItemFrame8.Elements.Add(TileItemElement20)
        TileItemFrame8.Image = CType(resources.GetObject("TileItemFrame8.Image"), System.Drawing.Image)
        Me.TileItem1.Frames.Add(TileItemFrame7)
        Me.TileItem1.Frames.Add(TileItemFrame8)
        Me.TileItem1.Id = 2
        Me.TileItem1.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide
        Me.TileItem1.Name = "TileItem1"
        '
        'TileControl1
        '
        Me.TileControl1.AllowItemHover = True
        Me.TileControl1.AllowSelectedItem = True
        Me.TileControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TileControl1.Groups.Add(Me.TileGroup2)
        Me.TileControl1.IndentBetweenItems = 12
        Me.TileControl1.ItemCheckMode = DevExpress.XtraEditors.TileItemCheckMode.[Single]
        Me.TileControl1.LayoutMode = DevExpress.XtraEditors.TileControlLayoutMode.Adaptive
        Me.TileControl1.Location = New System.Drawing.Point(0, 122)
        Me.TileControl1.MaxId = 7
        Me.TileControl1.Name = "TileControl1"
        Me.TileControl1.Padding = New System.Windows.Forms.Padding(8)
        Me.TileControl1.SelectionColor = System.Drawing.Color.Gray
        Me.TileControl1.Size = New System.Drawing.Size(1694, 94)
        Me.TileControl1.TabIndex = 12
        Me.TileControl1.Text = "TileControl1"
        '
        'TileGroup2
        '
        Me.TileGroup2.Items.Add(Me.TileItem2)
        Me.TileGroup2.Items.Add(Me.TileItem5)
        Me.TileGroup2.Items.Add(Me.TileItem3)
        Me.TileGroup2.Items.Add(Me.TileItem1)
        Me.TileGroup2.Items.Add(Me.TileItem4)
        Me.TileGroup2.Name = "TileGroup2"
        '
        'TileItem5
        '
        Me.TileItem5.CurrentFrameIndex = 1
        TileItemElement6.Text = "Yearly Register"
        TileItemElement7.Appearance.Normal.Options.UseTextOptions = True
        TileItemElement7.Appearance.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        TileItemElement7.Appearance.Normal.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        TileItemElement7.Appearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        TileItemElement7.ImageOptions.Image = CType(resources.GetObject("resource.Image4"), System.Drawing.Image)
        TileItemElement7.StretchHorizontal = True
        TileItemElement7.StretchVertical = True
        TileItemElement7.Text = "Register for continuing Students."
        TileItemElement7.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopRight
        TileItemElement7.TextLocation = New System.Drawing.Point(10, 20)
        Me.TileItem5.Elements.Add(TileItemElement6)
        Me.TileItem5.Elements.Add(TileItemElement7)
        TileItemElement8.ImageOptions.Image = CType(resources.GetObject("resource.Image5"), System.Drawing.Image)
        TileItemElement8.Text = "Yearly Register"
        TileItemFrame3.Elements.Add(TileItemElement8)
        TileItemFrame3.Image = CType(resources.GetObject("TileItemFrame3.Image"), System.Drawing.Image)
        TileItemElement9.Text = "Yearly Register"
        TileItemElement10.Appearance.Normal.Options.UseTextOptions = True
        TileItemElement10.Appearance.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        TileItemElement10.Appearance.Normal.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        TileItemElement10.Appearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        TileItemElement10.ColumnIndex = 1
        TileItemElement10.ImageOptions.Image = CType(resources.GetObject("resource.Image6"), System.Drawing.Image)
        TileItemElement10.RowIndex = 1
        TileItemElement10.StretchHorizontal = True
        TileItemElement10.StretchVertical = True
        TileItemElement10.Text = "Register for continuing Students."
        TileItemElement10.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopRight
        TileItemElement10.TextLocation = New System.Drawing.Point(10, 20)
        TileItemFrame4.Elements.Add(TileItemElement9)
        TileItemFrame4.Elements.Add(TileItemElement10)
        Me.TileItem5.Frames.Add(TileItemFrame3)
        Me.TileItem5.Frames.Add(TileItemFrame4)
        Me.TileItem5.Id = 6
        Me.TileItem5.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide
        Me.TileItem5.Name = "TileItem5"
        '
        'TileItem3
        '
        Me.TileItem3.CurrentFrameIndex = 1
        TileItemElement11.ImageOptions.Image = CType(resources.GetObject("resource.Image7"), System.Drawing.Image)
        TileItemElement11.Text = "Payments"
        TileItemElement12.Text = "Tuition and Other fees Payments."
        TileItemElement12.TextLocation = New System.Drawing.Point(10, 20)
        Me.TileItem3.Elements.Add(TileItemElement11)
        Me.TileItem3.Elements.Add(TileItemElement12)
        TileItemElement13.ImageOptions.Image = CType(resources.GetObject("resource.Image8"), System.Drawing.Image)
        TileItemElement13.Text = "Payments"
        TileItemFrame5.Elements.Add(TileItemElement13)
        TileItemFrame5.Image = CType(resources.GetObject("TileItemFrame5.Image"), System.Drawing.Image)
        TileItemElement14.ImageOptions.Image = CType(resources.GetObject("resource.Image9"), System.Drawing.Image)
        TileItemElement14.Text = "Payments"
        TileItemElement15.Text = "Tuition and Other fees Payments."
        TileItemElement15.TextLocation = New System.Drawing.Point(10, 20)
        TileItemFrame6.Elements.Add(TileItemElement14)
        TileItemFrame6.Elements.Add(TileItemElement15)
        TileItemFrame6.Image = CType(resources.GetObject("TileItemFrame6.Image"), System.Drawing.Image)
        Me.TileItem3.Frames.Add(TileItemFrame5)
        Me.TileItem3.Frames.Add(TileItemFrame6)
        Me.TileItem3.Id = 4
        Me.TileItem3.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide
        Me.TileItem3.Name = "TileItem3"
        '
        'TileItem4
        '
        TileItemElement21.ImageOptions.Image = CType(resources.GetObject("resource.Image13"), System.Drawing.Image)
        TileItemElement21.Text = "Accounts"
        Me.TileItem4.Elements.Add(TileItemElement21)
        Me.TileItem4.Id = 5
        Me.TileItem4.ItemSize = DevExpress.XtraEditors.TileItemSize.Small
        Me.TileItem4.Name = "TileItem4"
        '
        'NavigationPage3
        '
        Me.NavigationPage3.Caption = "NavigationPage3"
        Me.NavigationPage3.Name = "NavigationPage3"
        Me.NavigationPage3.Size = New System.Drawing.Size(1561, 760)
        '
        'Year_RegisterTableAdapter
        '
        Me.Year_RegisterTableAdapter.ClearBeforeFill = True
        '
        'PaymentTableTableAdapter
        '
        Me.PaymentTableTableAdapter.ClearBeforeFill = True
        '
        'OtherFeesTableTableAdapter
        '
        Me.OtherFeesTableTableAdapter.ClearBeforeFill = True
        '
        'Form1
        '
        Me.AllowFormGlass = DevExpress.Utils.DefaultBoolean.[True]
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1724, 990)
        Me.Controls.Add(Me.NavigationFrame1)
        Me.Controls.Add(Me.TileControl1)
        Me.Controls.Add(Me.hideContainerRight)
        Me.Controls.Add(Me.RibbonStatusBar1)
        Me.Controls.Add(Me.ribbonControl1)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Form1"
        Me.Ribbon = Me.ribbonControl1
        Me.StatusBar = Me.RibbonStatusBar1
        Me.Text = "Database - YCMA "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.CardView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentInfoGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InstituteDataDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.regedit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.reglookUp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nameLookup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.courseLookup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CoursesTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fieldglookUP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OtherFeesTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.feegLookup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.banknameCombo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MoneyText, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SEmCombo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.yearCombo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.otextEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.photoEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nationCombo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.religionCombo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.studprogcombo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.telToken, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sponsorCombo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.levelCombo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdvBandedGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemPopupContainerEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PopupContainerControl1.ResumeLayout(False)
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.oNedit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.surNedit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fisrtNedit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.regdate.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.regdate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.paperschk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PROGcOMB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.COURSEGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CardView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CoursesTableGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.unitstoken, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TYPEEDIT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.progedit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MoneyEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fLookUp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dLookUp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NavigationFrame1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NavigationFrame1.ResumeLayout(False)
        Me.NavigationPage1.ResumeLayout(False)
        CType(Me.GridSplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GridSplitContainer1.ResumeLayout(False)
        Me.NavigationPage2.ResumeLayout(False)
        Me.NavigationPage4.ResumeLayout(False)
        CType(Me.FlyoutPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlyoutPanel1.ResumeLayout(False)
        CType(Me.FlyoutPanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlyoutPanelControl1.ResumeLayout(False)
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DataLayoutControl1.ResumeLayout(False)
        CType(Me.TextEdit6.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PaymentTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit5.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.semesterComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.coursetextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.payFieldcombo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForsemester, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SimpleLabelItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SimpleSeparator1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccountsTableGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NavigationPage5.ResumeLayout(False)
        CType(Me.FlyoutPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlyoutPanel2.ResumeLayout(False)
        CType(Me.FlyoutPanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlyoutPanelControl2.ResumeLayout(False)
        CType(Me.DataLayoutControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DataLayoutControl2.ResumeLayout(False)
        CType(Me.SearchLookUpEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Year_RegisterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit2View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HyperLinkEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FacultyTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DepartmentTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit7.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.YearComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DurationTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit2.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RetakeCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComboBoxEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComboBoxEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.unitsTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabbedControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForFaculty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForDepartment, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForCourse, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForYear, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForDuration, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForunits, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForRetake, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SimpleLabelItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Year_RegisterGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdvBandedGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.namesearch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.facgrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deptgrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit2View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.coursegrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.regsearch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit2.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NavigationPage6.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OtherFeesTableGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hideContainerRight.ResumeLayout(False)
        Me.DockPanel1.ResumeLayout(False)
        CType(Me.AdornerUIManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private WithEvents ribbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonStatusBar1 As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents NavigationFrame1 As DevExpress.XtraBars.Navigation.NavigationFrame
    Friend WithEvents NavigationPage1 As DevExpress.XtraBars.Navigation.NavigationPage
    Friend WithEvents NavigationPage2 As DevExpress.XtraBars.Navigation.NavigationPage
    Friend WithEvents coursesTab As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents DefaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    Friend WithEvents DockManager1 As DevExpress.XtraBars.Docking.DockManager
    Friend WithEvents DockPanel1 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents hideContainerRight As DevExpress.XtraBars.Docking.AutoHideContainer
    Friend WithEvents InstituteDataDataSet As instituteDataDataSet
    Friend WithEvents StudentInfoBindingSource As BindingSource
    Friend WithEvents StudentInfoTableAdapter As instituteDataDataSetTableAdapters.StudentInfoTableAdapter
    Friend WithEvents GridSplitContainer1 As DevExpress.XtraGrid.GridSplitContainer
    Friend WithEvents StudentInfoGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents TableAdapterManager As instituteDataDataSetTableAdapters.TableAdapterManager
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents CoursesTableBindingSource As BindingSource
    Friend WithEvents CoursesTableTableAdapter As instituteDataDataSetTableAdapters.coursesTableTableAdapter
    Friend WithEvents CoursesTableGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colcoursename1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcoursecode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colyears As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemSpinEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents colcourseunits As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents unitstoken As DevExpress.XtraEditors.Repository.RepositoryItemTokenEdit
    Friend WithEvents colcoursetype As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TYPEEDIT As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents colprogrammes As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents progedit As DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit
    Friend WithEvents coltuitionfee As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MoneyEdit As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents colfaculty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldepartment As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents AdornerUIManager1 As DevExpress.Utils.VisualEffects.AdornerUIManager
    Friend WithEvents Badge1 As DevExpress.Utils.VisualEffects.Badge
    Friend WithEvents Badge2 As DevExpress.Utils.VisualEffects.Badge
    Friend WithEvents dLookUp As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageCategory1 As DevExpress.XtraBars.Ribbon.RibbonPageCategory
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents fLookUp As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemPopupContainerEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit
    Friend WithEvents PopupContainerControl1 As DevExpress.XtraEditors.PopupContainerControl
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents oNedit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents surNedit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents fisrtNedit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem17 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem18 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem19 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents RepositoryItemImageComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents RepositoryItemComboBox2 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents paperschk As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents regdate As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents registerTab As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup3 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents PROGcOMB As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents TileControl1 As DevExpress.XtraEditors.TileControl
    Friend WithEvents TileGroup2 As DevExpress.XtraEditors.TileGroup
    Friend WithEvents TileItem2 As DevExpress.XtraEditors.TileItem
    Friend WithEvents TileItem1 As DevExpress.XtraEditors.TileItem
    Friend WithEvents TileItem3 As DevExpress.XtraEditors.TileItem
    Friend WithEvents TileItem4 As DevExpress.XtraEditors.TileItem
    Friend WithEvents TileItem5 As DevExpress.XtraEditors.TileItem
    Friend WithEvents CardView1 As DevExpress.XtraGrid.Views.Card.CardView
    Friend WithEvents CardView2 As DevExpress.XtraGrid.Views.Card.CardView
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents AdvBandedGridView1 As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
    Friend WithEvents colStudentsName As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colregistrationnumber As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colregistrationdate As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colPhoto As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colnationality As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents coltribe As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colreligion As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents coldateofbirth As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colbirthdistrict As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colresidence As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colProgramme As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colcoursename As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colguardian1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colguardian2 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colguardian1contact As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colguardian2contact As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colnin As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colphonecontact As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colsponsorship As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colemail As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents coldocumentsverified As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colLastAcademicLevel As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents COURSEGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colPhoto1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStudentsName1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colregistrationnumber1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProgramme1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colphonecontact1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsponsorship1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NavigationPage3 As DevExpress.XtraBars.Navigation.NavigationPage
    Friend WithEvents NavigationPage4 As DevExpress.XtraBars.Navigation.NavigationPage
    '  Friend WithEvents AccountsTableBindingSource As BindingSource
    ' Friend WithEvents AccountsTableTableAdapter As instituteDataDataSetTableAdapters.accountsTableTableAdapter
    Friend WithEvents AccountsTableGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents NavigationPage5 As DevExpress.XtraBars.Navigation.NavigationPage
    Friend WithEvents Year_RegisterBindingSource As BindingSource
    Friend WithEvents Year_RegisterTableAdapter As instituteDataDataSetTableAdapters.Year_RegisterTableAdapter
    Friend WithEvents Year_RegisterGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents AdvBandedGridView2 As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
    Friend WithEvents colRegistrationNumber3 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colStudentsName3 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colFaculty1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colDepartment1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colCourse As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colYear As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colDuration As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colRetake As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colRegistrationDate1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colRetakeYear As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colRetakeSemester As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colunits As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents namesearch As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
    Friend WithEvents RepositoryItemSearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RibbonPageGroup4 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents payTab As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup5 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents facgrid As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents deptgrid As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit2View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridBand8 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents regsearch As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
    Friend WithEvents GridView6 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents coursegrid As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView5 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gridBand9 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents RepositoryItemDateEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents yearTab As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup6 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents PaymentTableBindingSource As BindingSource
    Friend WithEvents PaymentTableTableAdapter As instituteDataDataSetTableAdapters.PaymentTableTableAdapter
    Friend WithEvents colregistrationnumber2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStudentsName2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcoursename2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsemester As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colacademicyear As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colpaymentdate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colpaymentfield As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colamountpaid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coltotalfees As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbankname As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colslipnumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PersistentRepository1 As DevExpress.XtraEditors.Repository.PersistentRepository
    Friend WithEvents regedit As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents reglookUp As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
    Friend WithEvents GridView7 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents nameLookup As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
    Friend WithEvents GridView8 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents courseLookup As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
    Friend WithEvents GridView9 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents OtherFeesTableBindingSource As BindingSource
    Friend WithEvents OtherFeesTableTableAdapter As instituteDataDataSetTableAdapters.OtherFeesTableTableAdapter
    Friend WithEvents fieldglookUP As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView10 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents feegLookup As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView11 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents banknameCombo As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents MoneyText As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents SEmCombo As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents yearCombo As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents DateEdit As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents otextEdit As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents Balance As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RibbonPageGroup7 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents NavigationPage6 As DevExpress.XtraBars.Navigation.NavigationPage
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView13 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents OtherFeesTableGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView12 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colfield As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colfee As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gridBand2 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents GridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents gridBand5 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents gridBand3 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents gridBand4 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents gridBand6 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents gridBand7 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents photoEdit As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
    Friend WithEvents nationCombo As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents religionCombo As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents studprogcombo As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents telToken As DevExpress.XtraEditors.Repository.RepositoryItemTokenEdit
    Friend WithEvents sponsorCombo As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents levelCombo As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem5 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup8 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents AccountsTab As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup9 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BarButtonItem6 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem7 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup10 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BarButtonItem8 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem9 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents colcourseAbbr As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FlyoutPanel1 As DevExpress.Utils.FlyoutPanel
    Friend WithEvents FlyoutPanelControl1 As DevExpress.Utils.FlyoutPanelControl
    Friend WithEvents DataLayoutControl1 As DevExpress.XtraDataLayout.DataLayoutControl
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SearchLookUpEdit1 As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents semesterComboBoxEdit As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents ComboBoxEdit1 As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents DateEdit1 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit3 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForsemester As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents SimpleLabelItem1 As DevExpress.XtraLayout.SimpleLabelItem
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents TextEdit5 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit4 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents colregistrationnumber4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStudentsName4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcoursename3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProgramme2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsponsorship2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents TextEdit6 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents coursetextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents payFieldcombo As DevExpress.XtraEditors.CheckedComboBoxEdit
    Friend WithEvents SimpleSeparator1 As DevExpress.XtraLayout.SimpleSeparator
    Friend WithEvents RibbonPageGroup11 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents FlyoutPanel2 As DevExpress.Utils.FlyoutPanel
    Friend WithEvents FlyoutPanelControl2 As DevExpress.Utils.FlyoutPanelControl
    Friend WithEvents DataLayoutControl2 As DevExpress.XtraDataLayout.DataLayoutControl
    Friend WithEvents SearchLookUpEdit2 As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents SearchLookUpEdit2View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents HyperLinkEdit1 As DevExpress.XtraEditors.HyperLinkEdit
    Friend WithEvents FacultyTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DepartmentTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit7 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents YearComboBoxEdit As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents DurationTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DateEdit2 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents RetakeCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ComboBoxEdit2 As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents ComboBoxEdit3 As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents unitsTextEdit As DevExpress.XtraEditors.TokenEdit
    Friend WithEvents LayoutControlGroup4 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup5 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents TabbedControlGroup1 As DevExpress.XtraLayout.TabbedControlGroup
    Friend WithEvents LayoutControlGroup7 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForFaculty As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForDepartment As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForCourse As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForYear As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForDuration As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup6 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem21 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForunits As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem20 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForRetake As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SimpleLabelItem2 As DevExpress.XtraLayout.SimpleLabelItem
End Class
