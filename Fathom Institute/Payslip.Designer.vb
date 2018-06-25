<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class Payslip
    Inherits DevExpress.XtraReports.UI.XtraReport

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim XrSummary1 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim SelectQuery1 As DevExpress.DataAccess.Sql.SelectQuery = New DevExpress.DataAccess.Sql.SelectQuery()
        Dim Column1 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression1 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Table1 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
        Dim Column2 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression2 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column3 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression3 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column4 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression4 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column5 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression5 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column6 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression6 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column7 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression7 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column8 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression8 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column9 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression9 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column10 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression10 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column11 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression11 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Payslip))
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.GroupHeader2 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.GroupFooter1 = New DevExpress.XtraReports.UI.GroupFooterBand()
        Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.GroupFooter2 = New DevExpress.XtraReports.UI.GroupFooterBand()
        Me.detailTable = New DevExpress.XtraReports.UI.XRTable()
        Me.detailTableRow = New DevExpress.XtraReports.UI.XRTableRow()
        Me.quantity = New DevExpress.XtraReports.UI.XRTableCell()
        Me.productName = New DevExpress.XtraReports.UI.XRTableCell()
        Me.unitPrice = New DevExpress.XtraReports.UI.XRTableCell()
        Me.lineTotal = New DevExpress.XtraReports.UI.XRTableCell()
        Me.invoiceInfoTable = New DevExpress.XtraReports.UI.XRTable()
        Me.customerTable = New DevExpress.XtraReports.UI.XRTable()
        Me.vendorTable = New DevExpress.XtraReports.UI.XRTable()
        Me.invoiceInfoTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.invoiceNumberRow = New DevExpress.XtraReports.UI.XRTableRow()
        Me.invoiceDateRow = New DevExpress.XtraReports.UI.XRTableRow()
        Me.invoiceLabel = New DevExpress.XtraReports.UI.XRTableCell()
        Me.invoiceNumber = New DevExpress.XtraReports.UI.XRTableCell()
        Me.invoiceDate = New DevExpress.XtraReports.UI.XRTableCell()
        Me.customerTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.customerNameRow = New DevExpress.XtraReports.UI.XRTableRow()
        Me.customerContactNameRow = New DevExpress.XtraReports.UI.XRTableRow()
        Me.customerAddressRow = New DevExpress.XtraReports.UI.XRTableRow()
        Me.customerCityRow = New DevExpress.XtraReports.UI.XRTableRow()
        Me.customerCountryRow = New DevExpress.XtraReports.UI.XRTableRow()
        Me.toLabel = New DevExpress.XtraReports.UI.XRTableCell()
        Me.customerName = New DevExpress.XtraReports.UI.XRTableCell()
        Me.customerContactName = New DevExpress.XtraReports.UI.XRTableCell()
        Me.customerAddress = New DevExpress.XtraReports.UI.XRTableCell()
        Me.customerCity = New DevExpress.XtraReports.UI.XRTableCell()
        Me.customerCountry = New DevExpress.XtraReports.UI.XRTableCell()
        Me.vendorNameRow = New DevExpress.XtraReports.UI.XRTableRow()
        Me.vendorContactNameRow = New DevExpress.XtraReports.UI.XRTableRow()
        Me.vendorAddressRow = New DevExpress.XtraReports.UI.XRTableRow()
        Me.vendorCityRow = New DevExpress.XtraReports.UI.XRTableRow()
        Me.vendorCountryRow = New DevExpress.XtraReports.UI.XRTableRow()
        Me.vendorPhoneRow = New DevExpress.XtraReports.UI.XRTableRow()
        Me.vendorName = New DevExpress.XtraReports.UI.XRTableCell()
        Me.vendorContactName = New DevExpress.XtraReports.UI.XRTableCell()
        Me.vendorAddress = New DevExpress.XtraReports.UI.XRTableCell()
        Me.vendorCity = New DevExpress.XtraReports.UI.XRTableCell()
        Me.vendorCountry = New DevExpress.XtraReports.UI.XRTableCell()
        Me.vendorPhone = New DevExpress.XtraReports.UI.XRTableCell()
        Me.totalTable = New DevExpress.XtraReports.UI.XRTable()
        Me.totalRow = New DevExpress.XtraReports.UI.XRTableRow()
        Me.totalCaption = New DevExpress.XtraReports.UI.XRTableCell()
        Me.total = New DevExpress.XtraReports.UI.XRTableCell()
        Me.headerTable = New DevExpress.XtraReports.UI.XRTable()
        Me.headerTableRow = New DevExpress.XtraReports.UI.XRTableRow()
        Me.quantityCaption = New DevExpress.XtraReports.UI.XRTableCell()
        Me.productNameCaption = New DevExpress.XtraReports.UI.XRTableCell()
        Me.unitPriceCaption = New DevExpress.XtraReports.UI.XRTableCell()
        Me.lineTotalCaption = New DevExpress.XtraReports.UI.XRTableCell()
        Me.thankYouLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.SqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
        Me.baseControlStyle = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.LineTotalCalcField = New DevExpress.XtraReports.UI.CalculatedField()
        Me.Parameter1 = New DevExpress.XtraReports.Parameters.Parameter()
        CType(Me.detailTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.invoiceInfoTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.customerTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vendorTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.totalTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.headerTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.detailTable})
        Me.Detail.HeightF = 23.0!
        Me.Detail.KeepTogether = True
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.StyleName = "baseControlStyle"
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'TopMargin
        '
        Me.TopMargin.HeightF = 100.0!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.StylePriority.UseBackColor = False
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'BottomMargin
        '
        Me.BottomMargin.HeightF = 75.0!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'GroupHeader2
        '
        Me.GroupHeader2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.invoiceInfoTable, Me.customerTable, Me.vendorTable})
        Me.GroupHeader2.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("InvoiceNumber", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.GroupHeader2.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail
        Me.GroupHeader2.HeightF = 338.0!
        Me.GroupHeader2.Level = 1
        Me.GroupHeader2.Name = "GroupHeader2"
        Me.GroupHeader2.StyleName = "baseControlStyle"
        Me.GroupHeader2.StylePriority.UseBackColor = False
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.totalTable})
        Me.GroupFooter1.GroupUnion = DevExpress.XtraReports.UI.GroupFooterUnion.WithLastDetail
        Me.GroupFooter1.HeightF = 36.80848!
        Me.GroupFooter1.KeepTogether = True
        Me.GroupFooter1.Name = "GroupFooter1"
        Me.GroupFooter1.StyleName = "baseControlStyle"
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.headerTable})
        Me.GroupHeader1.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("slip number", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.GroupHeader1.HeightF = 35.0!
        Me.GroupHeader1.Name = "GroupHeader1"
        Me.GroupHeader1.RepeatEveryPage = True
        Me.GroupHeader1.StyleName = "baseControlStyle"
        '
        'GroupFooter2
        '
        Me.GroupFooter2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.thankYouLabel})
        Me.GroupFooter2.HeightF = 55.0!
        Me.GroupFooter2.KeepTogether = True
        Me.GroupFooter2.Level = 1
        Me.GroupFooter2.Name = "GroupFooter2"
        Me.GroupFooter2.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBandExceptLastEntry
        Me.GroupFooter2.PrintAtBottom = True
        Me.GroupFooter2.StyleName = "baseControlStyle"
        '
        'detailTable
        '
        Me.detailTable.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.detailTable.Name = "detailTable"
        Me.detailTable.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.detailTableRow})
        Me.detailTable.SizeF = New System.Drawing.SizeF(648.8189!, 23.0!)
        Me.detailTable.StylePriority.UseFont = False
        '
        'detailTableRow
        '
        Me.detailTableRow.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.quantity, Me.productName, Me.unitPrice, Me.lineTotal})
        Me.detailTableRow.Name = "detailTableRow"
        Me.detailTableRow.Weight = 10.58R
        '
        'quantity
        '
        Me.quantity.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.quantity.Name = "quantity"
        Me.quantity.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 5, 0, 100.0!)
        Me.quantity.StylePriority.UseBorders = False
        Me.quantity.StylePriority.UsePadding = False
        Me.quantity.StylePriority.UseTextAlignment = False
        Me.quantity.Text = "1"
        Me.quantity.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.quantity.Weight = 0.25872026842754409R
        '
        'productName
        '
        Me.productName.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.productName.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[payment field]")})
        Me.productName.Name = "productName"
        Me.productName.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 5, 0, 100.0!)
        Me.productName.StylePriority.UseBorders = False
        Me.productName.StylePriority.UsePadding = False
        Me.productName.StylePriority.UseTextAlignment = False
        Me.productName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.productName.Weight = 0.78379005807667357R
        '
        'unitPrice
        '
        Me.unitPrice.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.unitPrice.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[amount paid]")})
        Me.unitPrice.Name = "unitPrice"
        Me.unitPrice.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 5, 0, 100.0!)
        Me.unitPrice.StylePriority.UseBorders = False
        Me.unitPrice.StylePriority.UsePadding = False
        Me.unitPrice.StylePriority.UseTextAlignment = False
        Me.unitPrice.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.unitPrice.TextFormatString = "{0:0.00 Ugx}"
        Me.unitPrice.Weight = 0.27596816983094852R
        '
        'lineTotal
        '
        Me.lineTotal.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.lineTotal.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[LineTotalCalcField]")})
        Me.lineTotal.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lineTotal.Name = "lineTotal"
        Me.lineTotal.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 5, 0, 100.0!)
        Me.lineTotal.StylePriority.UseBorders = False
        Me.lineTotal.StylePriority.UseFont = False
        Me.lineTotal.StylePriority.UseForeColor = False
        Me.lineTotal.StylePriority.UsePadding = False
        Me.lineTotal.StylePriority.UseTextAlignment = False
        Me.lineTotal.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.lineTotal.TextFormatString = "{0:0.00 Ugx}"
        Me.lineTotal.Weight = 0.37313127310628086R
        '
        'invoiceInfoTable
        '
        Me.invoiceInfoTable.LocationFloat = New DevExpress.Utils.PointFloat(391.8152!, 10.00001!)
        Me.invoiceInfoTable.Name = "invoiceInfoTable"
        Me.invoiceInfoTable.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 10, 0, 0, 100.0!)
        Me.invoiceInfoTable.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.invoiceInfoTableRow1, Me.invoiceNumberRow, Me.invoiceDateRow})
        Me.invoiceInfoTable.SizeF = New System.Drawing.SizeF(257.1848!, 147.9167!)
        Me.invoiceInfoTable.StylePriority.UsePadding = False
        '
        'customerTable
        '
        Me.customerTable.LocationFloat = New DevExpress.Utils.PointFloat(0!, 172.0!)
        Me.customerTable.Name = "customerTable"
        Me.customerTable.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.customerTableRow1, Me.customerNameRow, Me.customerContactNameRow, Me.customerAddressRow, Me.customerCityRow, Me.customerCountryRow})
        Me.customerTable.SizeF = New System.Drawing.SizeF(299.8237!, 121.4286!)
        '
        'vendorTable
        '
        Me.vendorTable.LocationFloat = New DevExpress.Utils.PointFloat(0!, 10.00001!)
        Me.vendorTable.Name = "vendorTable"
        Me.vendorTable.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.vendorNameRow, Me.vendorContactNameRow, Me.vendorAddressRow, Me.vendorCityRow, Me.vendorCountryRow, Me.vendorPhoneRow})
        Me.vendorTable.SizeF = New System.Drawing.SizeF(352.9487!, 147.9166!)
        '
        'invoiceInfoTableRow1
        '
        Me.invoiceInfoTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.invoiceLabel})
        Me.invoiceInfoTableRow1.Name = "invoiceInfoTableRow1"
        Me.invoiceInfoTableRow1.Weight = 1.0555555987396978R
        '
        'invoiceNumberRow
        '
        Me.invoiceNumberRow.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.invoiceNumber})
        Me.invoiceNumberRow.Name = "invoiceNumberRow"
        Me.invoiceNumberRow.Weight = 0.45833333333333337R
        '
        'invoiceDateRow
        '
        Me.invoiceDateRow.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.invoiceDate})
        Me.invoiceDateRow.Name = "invoiceDateRow"
        Me.invoiceDateRow.Weight = 0.45833333333333337R
        '
        'invoiceLabel
        '
        Me.invoiceLabel.Font = New System.Drawing.Font("Segoe UI", 28.0!, System.Drawing.FontStyle.Bold)
        Me.invoiceLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.invoiceLabel.Name = "invoiceLabel"
        Me.invoiceLabel.StylePriority.UseFont = False
        Me.invoiceLabel.StylePriority.UseForeColor = False
        Me.invoiceLabel.StylePriority.UseTextAlignment = False
        Me.invoiceLabel.Text = "INVOICE"
        Me.invoiceLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomRight
        Me.invoiceLabel.Weight = 1.9362311327613928R
        '
        'invoiceNumber
        '
        Me.invoiceNumber.CanShrink = True
        Me.invoiceNumber.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[slip number]")})
        Me.invoiceNumber.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.invoiceNumber.Name = "invoiceNumber"
        Me.invoiceNumber.StylePriority.UseFont = False
        Me.invoiceNumber.StylePriority.UseForeColor = False
        Me.invoiceNumber.StylePriority.UseTextAlignment = False
        Me.invoiceNumber.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.invoiceNumber.TextFormatString = "INVOICE #{0}"
        Me.invoiceNumber.Weight = 1.9362311327613928R
        '
        'invoiceDate
        '
        Me.invoiceDate.CanShrink = True
        Me.invoiceDate.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[payment date]")})
        Me.invoiceDate.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.invoiceDate.Name = "invoiceDate"
        Me.invoiceDate.StylePriority.UseFont = False
        Me.invoiceDate.StylePriority.UseForeColor = False
        Me.invoiceDate.StylePriority.UseTextAlignment = False
        Me.invoiceDate.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.invoiceDate.TextFormatString = "{0:MMMM d, yyyy}"
        Me.invoiceDate.Weight = 1.9362311327613928R
        '
        'customerTableRow1
        '
        Me.customerTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.toLabel})
        Me.customerTableRow1.Name = "customerTableRow1"
        Me.customerTableRow1.Weight = 1.0R
        '
        'customerNameRow
        '
        Me.customerNameRow.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.customerName})
        Me.customerNameRow.Name = "customerNameRow"
        Me.customerNameRow.Weight = 0.93333357069233469R
        '
        'customerContactNameRow
        '
        Me.customerContactNameRow.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.customerContactName})
        Me.customerContactNameRow.Name = "customerContactNameRow"
        Me.customerContactNameRow.Weight = 0.93333357069233469R
        '
        'customerAddressRow
        '
        Me.customerAddressRow.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.customerAddress})
        Me.customerAddressRow.Name = "customerAddressRow"
        Me.customerAddressRow.Weight = 0.93333357069233469R
        '
        'customerCityRow
        '
        Me.customerCityRow.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.customerCity})
        Me.customerCityRow.Name = "customerCityRow"
        Me.customerCityRow.Weight = 0.93333357069233458R
        '
        'customerCountryRow
        '
        Me.customerCountryRow.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.customerCountry})
        Me.customerCountryRow.Name = "customerCountryRow"
        Me.customerCountryRow.Weight = 0.93333357069233458R
        '
        'toLabel
        '
        Me.toLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.toLabel.Name = "toLabel"
        Me.toLabel.StylePriority.UseFont = False
        Me.toLabel.Text = "TO:"
        Me.toLabel.Weight = 1.3674163189595685R
        '
        'customerName
        '
        Me.customerName.CanShrink = True
        Me.customerName.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Students Name]")})
        Me.customerName.Name = "customerName"
        Me.customerName.StylePriority.UseFont = False
        Me.customerName.StylePriority.UsePadding = False
        Me.customerName.Weight = 1.3674163189595685R
        '
        'customerContactName
        '
        Me.customerContactName.CanShrink = True
        Me.customerContactName.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[registration number]")})
        Me.customerContactName.Name = "customerContactName"
        Me.customerContactName.StylePriority.UseFont = False
        Me.customerContactName.StylePriority.UsePadding = False
        Me.customerContactName.Weight = 1.3674163189595685R
        '
        'customerAddress
        '
        Me.customerAddress.CanShrink = True
        Me.customerAddress.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[course name]")})
        Me.customerAddress.Name = "customerAddress"
        Me.customerAddress.Weight = 1.3674163189595685R
        '
        'customerCity
        '
        Me.customerCity.CanShrink = True
        Me.customerCity.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[bank name]")})
        Me.customerCity.Name = "customerCity"
        Me.customerCity.Weight = 1.3674163189595685R
        '
        'customerCountry
        '
        Me.customerCountry.Name = "customerCountry"
        Me.customerCountry.Text = "CustomerCountry"
        Me.customerCountry.Weight = 1.3674163189595685R
        '
        'vendorNameRow
        '
        Me.vendorNameRow.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.vendorName})
        Me.vendorNameRow.Name = "vendorNameRow"
        Me.vendorNameRow.Weight = 1.9999993498427626R
        '
        'vendorContactNameRow
        '
        Me.vendorContactNameRow.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.vendorContactName})
        Me.vendorContactNameRow.Name = "vendorContactNameRow"
        Me.vendorContactNameRow.Weight = 0.83478272165108858R
        '
        'vendorAddressRow
        '
        Me.vendorAddressRow.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.vendorAddress})
        Me.vendorAddressRow.Name = "vendorAddressRow"
        Me.vendorAddressRow.Weight = 0.83478272165108858R
        '
        'vendorCityRow
        '
        Me.vendorCityRow.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.vendorCity})
        Me.vendorCityRow.Name = "vendorCityRow"
        Me.vendorCityRow.Weight = 0.83478272165108858R
        '
        'vendorCountryRow
        '
        Me.vendorCountryRow.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.vendorCountry})
        Me.vendorCountryRow.Name = "vendorCountryRow"
        Me.vendorCountryRow.Weight = 0.83478272165108858R
        '
        'vendorPhoneRow
        '
        Me.vendorPhoneRow.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.vendorPhone})
        Me.vendorPhoneRow.Name = "vendorPhoneRow"
        Me.vendorPhoneRow.Weight = 0.83478248281783984R
        '
        'vendorName
        '
        Me.vendorName.CanShrink = True
        Me.vendorName.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.vendorName.Name = "vendorName"
        Me.vendorName.StylePriority.UseFont = False
        Me.vendorName.StylePriority.UsePadding = False
        Me.vendorName.Text = "VendorName"
        Me.vendorName.Weight = 2.0R
        '
        'vendorContactName
        '
        Me.vendorContactName.CanShrink = True
        Me.vendorContactName.Name = "vendorContactName"
        Me.vendorContactName.StylePriority.UseFont = False
        Me.vendorContactName.StylePriority.UsePadding = False
        Me.vendorContactName.Text = "VendorContactName"
        Me.vendorContactName.Weight = 2.0R
        '
        'vendorAddress
        '
        Me.vendorAddress.CanShrink = True
        Me.vendorAddress.Name = "vendorAddress"
        Me.vendorAddress.StylePriority.UseFont = False
        Me.vendorAddress.Text = "VendorAddress"
        Me.vendorAddress.Weight = 2.0R
        '
        'vendorCity
        '
        Me.vendorCity.CanShrink = True
        Me.vendorCity.Name = "vendorCity"
        Me.vendorCity.StylePriority.UseFont = False
        Me.vendorCity.Text = "VendorCity"
        Me.vendorCity.Weight = 2.0R
        '
        'vendorCountry
        '
        Me.vendorCountry.CanShrink = True
        Me.vendorCountry.Name = "vendorCountry"
        Me.vendorCountry.Text = "VendorCountry"
        Me.vendorCountry.Weight = 2.0R
        '
        'vendorPhone
        '
        Me.vendorPhone.CanShrink = True
        Me.vendorPhone.Name = "vendorPhone"
        Me.vendorPhone.StylePriority.UseFont = False
        Me.vendorPhone.Text = "VendorPhone"
        Me.vendorPhone.TextFormatString = "Phone: {0}"
        Me.vendorPhone.Weight = 2.0R
        '
        'totalTable
        '
        Me.totalTable.ForeColor = System.Drawing.Color.Black
        Me.totalTable.LocationFloat = New DevExpress.Utils.PointFloat(352.9486!, 0!)
        Me.totalTable.Name = "totalTable"
        Me.totalTable.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.totalRow})
        Me.totalTable.SizeF = New System.Drawing.SizeF(295.8703!, 36.48938!)
        Me.totalTable.StylePriority.UseForeColor = False
        '
        'totalRow
        '
        Me.totalRow.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.totalCaption, Me.total})
        Me.totalRow.Name = "totalRow"
        Me.totalRow.Weight = 1.4R
        '
        'totalCaption
        '
        Me.totalCaption.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.totalCaption.Name = "totalCaption"
        Me.totalCaption.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 10, 0, 0, 100.0!)
        Me.totalCaption.StylePriority.UseFont = False
        Me.totalCaption.StylePriority.UsePadding = False
        Me.totalCaption.StylePriority.UseTextAlignment = False
        Me.totalCaption.Text = "TOTAL DUE"
        Me.totalCaption.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.totalCaption.Weight = 1.336803081098942R
        '
        'total
        '
        Me.total.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.total.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum([LineTotalCalcField])")})
        Me.total.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.total.Name = "total"
        Me.total.StylePriority.UseBorders = False
        Me.total.StylePriority.UseFont = False
        Me.total.StylePriority.UseTextAlignment = False
        XrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.total.Summary = XrSummary1
        Me.total.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.total.TextFormatString = "{0:0.00 Ugx}"
        Me.total.Weight = 0.76960524237933559R
        '
        'headerTable
        '
        Me.headerTable.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.headerTable.Name = "headerTable"
        Me.headerTable.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.headerTableRow})
        Me.headerTable.SizeF = New System.Drawing.SizeF(648.8189!, 34.99997!)
        Me.headerTable.StylePriority.UsePadding = False
        '
        'headerTableRow
        '
        Me.headerTableRow.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.quantityCaption, Me.productNameCaption, Me.unitPriceCaption, Me.lineTotalCaption})
        Me.headerTableRow.Name = "headerTableRow"
        Me.headerTableRow.Weight = 11.5R
        '
        'quantityCaption
        '
        Me.quantityCaption.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.quantityCaption.Name = "quantityCaption"
        Me.quantityCaption.StylePriority.UseBorders = False
        Me.quantityCaption.StylePriority.UseTextAlignment = False
        Me.quantityCaption.Text = "QUANTITY"
        Me.quantityCaption.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.quantityCaption.Weight = 0.25508288983684R
        '
        'productNameCaption
        '
        Me.productNameCaption.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.productNameCaption.Name = "productNameCaption"
        Me.productNameCaption.StylePriority.UseBorders = False
        Me.productNameCaption.StylePriority.UsePadding = False
        Me.productNameCaption.StylePriority.UseTextAlignment = False
        Me.productNameCaption.Text = "DESCRIPTION"
        Me.productNameCaption.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.productNameCaption.Weight = 0.772770542823402R
        '
        'unitPriceCaption
        '
        Me.unitPriceCaption.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.unitPriceCaption.Name = "unitPriceCaption"
        Me.unitPriceCaption.StylePriority.UseBorders = False
        Me.unitPriceCaption.StylePriority.UseTextAlignment = False
        Me.unitPriceCaption.Text = "UNIT PRICE"
        Me.unitPriceCaption.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.unitPriceCaption.Weight = 0.27208840729638217R
        '
        'lineTotalCaption
        '
        Me.lineTotalCaption.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.lineTotalCaption.Name = "lineTotalCaption"
        Me.lineTotalCaption.StylePriority.UseBorders = False
        Me.lineTotalCaption.StylePriority.UseTextAlignment = False
        Me.lineTotalCaption.Text = "TOTAL"
        Me.lineTotalCaption.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.lineTotalCaption.Weight = 0.36788545669295691R
        '
        'thankYouLabel
        '
        Me.thankYouLabel.CanShrink = True
        Me.thankYouLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.thankYouLabel.LocationFloat = New DevExpress.Utils.PointFloat(0!, 20.20835!)
        Me.thankYouLabel.Name = "thankYouLabel"
        Me.thankYouLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.thankYouLabel.SizeF = New System.Drawing.SizeF(648.8189!, 24.99998!)
        Me.thankYouLabel.StylePriority.UseFont = False
        Me.thankYouLabel.StylePriority.UseTextAlignment = False
        Me.thankYouLabel.Text = "THANK YOU FOR YOUR BUSINESS!"
        Me.thankYouLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'SqlDataSource1
        '
        Me.SqlDataSource1.ConnectionName = "instituteDataConnectionStringpay"
        Me.SqlDataSource1.Name = "SqlDataSource1"
        ColumnExpression1.ColumnName = "registration number"
        Table1.Name = "PaymentTable"
        ColumnExpression1.Table = Table1
        Column1.Expression = ColumnExpression1
        ColumnExpression2.ColumnName = "Students Name"
        ColumnExpression2.Table = Table1
        Column2.Expression = ColumnExpression2
        ColumnExpression3.ColumnName = "course name"
        ColumnExpression3.Table = Table1
        Column3.Expression = ColumnExpression3
        ColumnExpression4.ColumnName = "semester"
        ColumnExpression4.Table = Table1
        Column4.Expression = ColumnExpression4
        ColumnExpression5.ColumnName = "academic year"
        ColumnExpression5.Table = Table1
        Column5.Expression = ColumnExpression5
        ColumnExpression6.ColumnName = "payment date"
        ColumnExpression6.Table = Table1
        Column6.Expression = ColumnExpression6
        ColumnExpression7.ColumnName = "payment field"
        ColumnExpression7.Table = Table1
        Column7.Expression = ColumnExpression7
        ColumnExpression8.ColumnName = "amount paid"
        ColumnExpression8.Table = Table1
        Column8.Expression = ColumnExpression8
        ColumnExpression9.ColumnName = "total fees"
        ColumnExpression9.Table = Table1
        Column9.Expression = ColumnExpression9
        ColumnExpression10.ColumnName = "bank name"
        ColumnExpression10.Table = Table1
        Column10.Expression = ColumnExpression10
        ColumnExpression11.ColumnName = "slip number"
        ColumnExpression11.Table = Table1
        Column11.Expression = ColumnExpression11
        SelectQuery1.Columns.Add(Column1)
        SelectQuery1.Columns.Add(Column2)
        SelectQuery1.Columns.Add(Column3)
        SelectQuery1.Columns.Add(Column4)
        SelectQuery1.Columns.Add(Column5)
        SelectQuery1.Columns.Add(Column6)
        SelectQuery1.Columns.Add(Column7)
        SelectQuery1.Columns.Add(Column8)
        SelectQuery1.Columns.Add(Column9)
        SelectQuery1.Columns.Add(Column10)
        SelectQuery1.Columns.Add(Column11)
        SelectQuery1.Name = "PaymentTable"
        SelectQuery1.Tables.Add(Table1)
        Me.SqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {SelectQuery1})
        Me.SqlDataSource1.ResultSchemaSerializable = resources.GetString("SqlDataSource1.ResultSchemaSerializable")
        '
        'baseControlStyle
        '
        Me.baseControlStyle.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.baseControlStyle.Name = "baseControlStyle"
        Me.baseControlStyle.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        '
        'LineTotalCalcField
        '
        Me.LineTotalCalcField.DataMember = "PaymentTable"
        Me.LineTotalCalcField.DisplayName = "LineTotal"
        Me.LineTotalCalcField.Expression = "[amount paid] * 1"
        Me.LineTotalCalcField.FieldType = DevExpress.XtraReports.UI.FieldType.[Decimal]
        Me.LineTotalCalcField.Name = "LineTotalCalcField"
        '
        'Parameter1
        '
        Me.Parameter1.Description = "Parameter1"
        Me.Parameter1.Name = "Parameter1"
        Me.Parameter1.Type = GetType(Date)
        '
        'Payslip
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.GroupHeader2, Me.GroupFooter1, Me.GroupHeader1, Me.GroupFooter2})
        Me.CalculatedFields.AddRange(New DevExpress.XtraReports.UI.CalculatedField() {Me.LineTotalCalcField})
        Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.SqlDataSource1})
        Me.DataMember = "PaymentTable"
        Me.DataSource = Me.SqlDataSource1
        Me.Margins = New System.Drawing.Printing.Margins(101, 100, 100, 75)
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.Parameter1})
        Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {Me.baseControlStyle})
        Me.Version = "17.2"
        CType(Me.detailTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.invoiceInfoTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.customerTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vendorTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.totalTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.headerTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents detailTable As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents detailTableRow As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents quantity As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents productName As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents unitPrice As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents lineTotal As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents GroupHeader2 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents invoiceInfoTable As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents invoiceInfoTableRow1 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents invoiceLabel As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents invoiceNumberRow As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents invoiceNumber As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents invoiceDateRow As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents invoiceDate As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents customerTable As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents customerTableRow1 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents toLabel As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents customerNameRow As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents customerName As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents customerContactNameRow As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents customerContactName As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents customerAddressRow As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents customerAddress As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents customerCityRow As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents customerCity As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents customerCountryRow As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents customerCountry As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents vendorTable As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents vendorNameRow As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents vendorName As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents vendorContactNameRow As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents vendorContactName As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents vendorAddressRow As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents vendorAddress As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents vendorCityRow As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents vendorCity As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents vendorCountryRow As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents vendorCountry As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents vendorPhoneRow As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents vendorPhone As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents GroupFooter1 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents totalTable As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents totalRow As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents totalCaption As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents total As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents headerTable As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents headerTableRow As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents quantityCaption As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents productNameCaption As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents unitPriceCaption As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents lineTotalCaption As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents GroupFooter2 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents thankYouLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents SqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
    Friend WithEvents baseControlStyle As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents LineTotalCalcField As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents Parameter1 As DevExpress.XtraReports.Parameters.Parameter
End Class
