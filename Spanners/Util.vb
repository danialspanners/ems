Imports BusinessRules
Imports DataAccess

Public Class Util

    Private CategoryBusinessRules As New BusinessRules.CategoryBusRules.CategoryBusLogic
    Private CommonBusinessRules As New BusinessRules.CommonBusRules.CommonLogic
    Private ConsultantBusinessRules As New BusinessRules.ConsultantBusRules.ConsultantBusLogic
    Private CurrencyBusinessRules As New BusinessRules.CurrencyBusRules.CurrencyBusLogic
    Private CustomerBusinessRules As New BusinessRules.CustomerBusRules.CustomerBusLogic
    Private DeliveryNoteBusinessRules As New BusinessRules.DeliveryNoteBusRules.DeliveryNoteBusLogic
    Private DrawingBusinessRules As New BusinessRules.DrawingBusRules.DrawingBusLogic
    Private LVBBusinessRules As New BusinessRules.LVBBusRules.LVBBusLogic
    Private LVBContractBusinessRules As New BusinessRules.LVBBusRules.LVBContractBusLogic
    Private LVBLineBusinessRules As New BusinessRules.LVBBusRules.LVBLineBusLogic
    Private ManProdBusinessRules As New BusinessRules.ManProdBusRules.ManProdBusLogic
    Private ManProdSupBusinessRules As New BusinessRules.ManProdSupBusRules.ManProdSupBusLogic
    Private ManUOMBusinessRules As New BusinessRules.ManUOMBusRules.ManUOMBusLogic
    Private ManUserProfileBusinessRules As New BusinessRules.ManUserProfileBusRules.ManUserProfileLogic
    Private OGBBusinessRules As New BusinessRules.OGBBusRules.OGBBusLogic
    Private OGBContractBusinessRules As New BusinessRules.OGBBusRules.OGBContractBusLogic
    Private POBusinessRules As New BusinessRules.POBusRules.POBusLogic
    Private POHeaderBusinessRules As New BusinessRules.POBusRules.POHeaderBusLogic
    Private POLineBusinessRules As New BusinessRules.POBusRules.POLineBusLogic
    Private PRBusinessRules As New BusinessRules.PRBusRules.PRBusLogic
    Private PRHeaderBusinessRules As New BusinessRules.PRBusRules.PRHeaderBusLogic
    Private PRlineBusinessRules As New BusinessRules.PRBusRules.PRLineBusLogic
    Private QABusinessRules As New BusinessRules.QABusRules.QABusLogic
    Private ReservedStockBusinessRules As New BusinessRules.ReservedStockRules.ReservedStockLogic
    Private SalesBusinessRules As New BusinessRules.SaleBusRules.SaleBusLogic
    Private StockBusinessRules As New BusinessRules.StockRules.StockLogic
    Private SupplierBusinessRules As New BusinessRules.SupplierBusRules.SupplierBusLogic
    Private BoxCategoryBusinessRules As New BusinessRules.SystemBusRules.BoxCategoryBusLogic
    Private BrandBusinessRules As New BusinessRules.SystemBusRules.BrandBusLogic
    Private ColorBusinessRules As New BusinessRules.SystemBusRules.ColorBusLogic
    Private SystemConsultantBusinessRules As New BusinessRules.SystemBusRules.ConsultantBusLogic
    Private SystemCurrencyBusinessRules As New BusinessRules.SystemBusRules.CurrencyBusLogic
    Private DeliveryBusinessRules As New BusinessRules.SystemBusRules.DeliveryTermsBusLogic
    Private DepartmentBusinessRules As New BusinessRules.SystemBusRules.Department
    Private DocumentNumberBusinessRules As New BusinessRules.SystemBusRules.DocumentNumberBusLogic
    Private DrawingNoBusinessRules As New BusinessRules.SystemBusRules.DrawingNoBusLogic
    Private EnclosureBusinessRules As New BusinessRules.SystemBusRules.EnclosureBusLogic
    Private KeyBusinessRules As New BusinessRules.SystemBusRules.KeyBusLogic
    Private LVBBoxBusinessRules As New BusinessRules.SystemBusRules.LVBBoxBusLogic
    Private MaterialBusinessRules As New BusinessRules.SystemBusRules.MaterialBusLogic
    Private OfficerInChargeBusinessRules As New BusinessRules.SystemBusRules.OfficerInChargeBusLogic
    Private PaymentTermsBusinessRules As New BusinessRules.SystemBusRules.PaymentTermsBusLogic
    Private PriceIncludeBusinessRules As New BusinessRules.SystemBusRules.PriceIncludeBusLogic
    Private ProjectBusinessRules As New BusinessRules.SystemBusRules.ProjectBusLogic
    Private SectionBusinessRules As New BusinessRules.SystemBusRules.SectionBusLogic
    Private SpecialBusinessRules As New BusinessRules.SystemBusRules.SpecialBusLogic
    Private UserGroupBusinessRules As New BusinessRules.SystemBusRules.UserGroup
    Private WHAreaBusinessRules As New BusinessRules.WHAreaBusRules.WHAreaClss
    Private WHBusinessRules As New BusinessRules.WHBusRules.WHBusLogic
    Private WHLocationBusinessRules As New BusinessRules.WHLocationBusRules.WHLocationClss
    Private WorkOrderBusinessRules As New BusinessRules.WorkOrderBusRules.WorkLogicBusLogic
    Private WorkPlanBusinessRules

    Public ReadOnly Property CategoryBizRules() As BusinessRules.CategoryBusRules.CategoryBusLogic
        Get
            Return CategoryBusinessRules
        End Get
    End Property
    Public ReadOnly Property CommonBizRules() As BusinessRules.CommonBusRules.CommonLogic
        Get
            Return CommonBusinessRules
        End Get
    End Property
    Public ReadOnly Property ConsultantBizRules() As BusinessRules.ConsultantBusRules.ConsultantBusLogic
        Get
            Return ConsultantBusinessRules
        End Get
    End Property
    Public ReadOnly Property CurrencyBizRules() As BusinessRules.CurrencyBusRules.CurrencyBusLogic
        Get
            Return CurrencyBusinessRules
        End Get
    End Property
    Public ReadOnly Property CustomerBizRules() As BusinessRules.CustomerBusRules.CustomerBusLogic
        Get
            Return CustomerBusinessRules
        End Get
    End Property
    Public ReadOnly Property DeliveryNoteBizRules() As BusinessRules.DeliveryNoteBusRules.DeliveryNoteBusLogic
        Get
            Return DeliveryNoteBusinessRules
        End Get
    End Property
    Public ReadOnly Property DrawingBizRules() As BusinessRules.DrawingBusRules.DrawingBusLogic
        Get
            Return DrawingBusinessRules
        End Get
    End Property
    Public ReadOnly Property LVBBizRules() As BusinessRules.LVBBusRules.LVBBusLogic
        Get
            Return LVBBusinessRules
        End Get
    End Property
    Public ReadOnly Property LVBContractBizRules() As BusinessRules.LVBBusRules.LVBContractBusLogic
        Get
            Return LVBContractBusinessRules
        End Get
    End Property
    Public ReadOnly Property LVBLineBizRules() As BusinessRules.LVBBusRules.LVBLineBusLogic
        Get
            Return LVBLineBusinessRules
        End Get
    End Property
    Public ReadOnly Property ManProdBizRules() As BusinessRules.ManProdBusRules.ManProdBusLogic
        Get
            Return ManProdBusinessRules
        End Get
    End Property
    Public ReadOnly Property ManProdSupBizRules() As BusinessRules.ManProdSupBusRules.ManProdSupBusLogic
        Get
            Return ManProdSupBusinessRules
        End Get
    End Property
    Public ReadOnly Property ManUOMBizRules() As BusinessRules.ManUOMBusRules.ManUOMBusLogic
        Get
            Return ManUOMBusinessRules
        End Get
    End Property
    Public ReadOnly Property ManUserProfileBizRules() As BusinessRules.ManUserProfileBusRules.ManUserProfileLogic
        Get
            Return ManUserProfileBusinessRules
        End Get
    End Property
    Public ReadOnly Property OGBBizRules() As BusinessRules.OGBBusRules.OGBBusLogic
        Get
            Return OGBBusinessRules
        End Get
    End Property
    Public ReadOnly Property OGBContractBizRules() As BusinessRules.OGBBusRules.OGBContractBusLogic
        Get
            Return OGBContractBusinessRules
        End Get
    End Property
    Public ReadOnly Property POBizRules() As BusinessRules.POBusRules.POBusLogic
        Get
            Return POBusinessRules
        End Get
    End Property
    Public ReadOnly Property POHeaderBizRules() As BusinessRules.POBusRules.POHeaderBusLogic
        Get
            Return POHeaderBusinessRules
        End Get
    End Property
    Public ReadOnly Property POLineBizRules() As BusinessRules.POBusRules.POLineBusLogic
        Get
            Return POLineBusinessRules
        End Get
    End Property
    Public ReadOnly Property PRBizRules() As BusinessRules.PRBusRules.PRBusLogic
        Get
            Return PRBusinessRules
        End Get
    End Property
    Public ReadOnly Property PRHeaderBizRules() As BusinessRules.PRBusRules.PRHeaderBusLogic
        Get
            Return PRHeaderBusinessRules
        End Get
    End Property
    Public ReadOnly Property PRlineBizRules() As BusinessRules.PRBusRules.PRLineBusLogic
        Get
            Return PRlineBusinessRules
        End Get
    End Property
    Public ReadOnly Property QABizRules() As BusinessRules.QABusRules.QABusLogic
        Get
            Return QABusinessRules
        End Get
    End Property
    Public ReadOnly Property ReservedStockBizRules() As BusinessRules.ReservedStockRules.ReservedStockLogic
        Get
            Return ReservedStockBusinessRules
        End Get
    End Property
    Public ReadOnly Property SalesBizRules() As BusinessRules.SaleBusRules.SaleBusLogic
        Get
            Return SalesBusinessRules
        End Get
    End Property
    Public ReadOnly Property StockBizRules() As BusinessRules.StockRules.StockLogic
        Get
            Return StockBusinessRules
        End Get
    End Property
    Public ReadOnly Property SupplierBizRules() As BusinessRules.SupplierBusRules.SupplierBusLogic
        Get
            Return SupplierBusinessRules
        End Get
    End Property
    Public ReadOnly Property BoxCategoryBizRules() As BusinessRules.SystemBusRules.BoxCategoryBusLogic
        Get
            Return BoxCategoryBusinessRules
        End Get
    End Property
    Public ReadOnly Property BrandBizRules() As BusinessRules.SystemBusRules.BrandBusLogic
        Get
            Return BrandBusinessRules
        End Get
    End Property
    Public ReadOnly Property ColorBizRules() As BusinessRules.SystemBusRules.ColorBusLogic
        Get
            Return ColorBusinessRules
        End Get
    End Property
    Public ReadOnly Property SystemConsultantBizRules() As BusinessRules.SystemBusRules.ConsultantBusLogic
        Get
            Return SystemConsultantBusinessRules
        End Get
    End Property
    Public ReadOnly Property SystemCurrencyBizRules() As BusinessRules.SystemBusRules.CurrencyBusLogic
        Get
            Return SystemCurrencyBusinessRules
        End Get
    End Property
    Public ReadOnly Property DeliveryBizRules() As BusinessRules.SystemBusRules.DeliveryTermsBusLogic
        Get
            Return DeliveryBusinessRules
        End Get
    End Property
    Public ReadOnly Property DepartmentBizRules() As BusinessRules.SystemBusRules.Department
        Get
            Return DepartmentBusinessRules
        End Get
    End Property
    Public ReadOnly Property DocumentNumberBizRules() As BusinessRules.SystemBusRules.DocumentNumberBusLogic
        Get
            Return DocumentNumberBusinessRules
        End Get
    End Property
    Public ReadOnly Property DrawingNoBizRules() As BusinessRules.SystemBusRules.DrawingNoBusLogic
        Get
            Return DrawingNoBusinessRules
        End Get
    End Property
    Public ReadOnly Property EnclosureBizRules() As BusinessRules.SystemBusRules.EnclosureBusLogic
        Get
            Return EnclosureBusinessRules
        End Get
    End Property
    Public ReadOnly Property KeyBizRules() As BusinessRules.SystemBusRules.KeyBusLogic
        Get
            Return KeyBusinessRules
        End Get
    End Property
    Public ReadOnly Property LVBBoxBizRules() As BusinessRules.SystemBusRules.LVBBoxBusLogic
        Get
            Return LVBBoxBusinessRules
        End Get
    End Property
    Public ReadOnly Property MaterialBizRules() As BusinessRules.SystemBusRules.MaterialBusLogic
        Get
            Return MaterialBusinessRules
        End Get
    End Property
    Public ReadOnly Property OfficerInChargeBizRules() As BusinessRules.SystemBusRules.OfficerInChargeBusLogic
        Get
            Return OfficerInChargeBusinessRules
        End Get
    End Property
    Public ReadOnly Property PaymentTermsBizRules() As BusinessRules.SystemBusRules.PaymentTermsBusLogic
        Get
            Return PaymentTermsBusinessRules
        End Get
    End Property
    Public ReadOnly Property PriceIncludeBizRules() As BusinessRules.SystemBusRules.PriceIncludeBusLogic
        Get
            Return PriceIncludeBusinessRules
        End Get
    End Property
    Public ReadOnly Property ProjectBizRules() As BusinessRules.SystemBusRules.ProjectBusLogic
        Get
            Return ProjectBusinessRules
        End Get
    End Property
    Public ReadOnly Property SectionBizRules() As BusinessRules.SystemBusRules.SectionBusLogic
        Get
            Return SectionBusinessRules
        End Get
    End Property
    Public ReadOnly Property SpecialBizRules() As BusinessRules.SystemBusRules.SpecialBusLogic
        Get
            Return SpecialBusinessRules
        End Get
    End Property
    Public ReadOnly Property UserGroupBizRules() As BusinessRules.SystemBusRules.UserGroup
        Get
            Return UserGroupBusinessRules
        End Get
    End Property
    Public ReadOnly Property WHAreaBizRules() As BusinessRules.WHAreaBusRules.WHAreaClss
        Get
            Return WHAreaBusinessRules
        End Get
    End Property
    Public ReadOnly Property WHBizRules() As BusinessRules.WHBusRules.WHBusLogic
        Get
            Return WHBusinessRules
        End Get
    End Property
    Public ReadOnly Property WHLocationBizRules() As BusinessRules.WHLocationBusRules.WHLocationClss
        Get
            Return WHLocationBusinessRules
        End Get
    End Property
    Public ReadOnly Property WorkOrderBizRules() As BusinessRules.WorkOrderBusRules.WorkLogicBusLogic
        Get
            Return WorkOrderBusinessRules
        End Get
    End Property
    Public ReadOnly Property WorkPlanBizRules() As BusinessRules.WorkPlanBusRules.WorkPlanBusLogic
        Get
            Return WorkPlanBusinessRules
        End Get
    End Property

    Public Sub New()
        CategoryBusinessRules = New BusinessRules.CategoryBusRules.CategoryBusLogic
        CommonBusinessRules = New BusinessRules.CommonBusRules.CommonLogic
        ConsultantBusinessRules = New BusinessRules.ConsultantBusRules.ConsultantBusLogic
        CurrencyBusinessRules = New BusinessRules.CurrencyBusRules.CurrencyBusLogic
        CustomerBusinessRules = New BusinessRules.CustomerBusRules.CustomerBusLogic
        DeliveryNoteBusinessRules = New BusinessRules.DeliveryNoteBusRules.DeliveryNoteBusLogic
        DrawingBusinessRules = New BusinessRules.DrawingBusRules.DrawingBusLogic
        LVBBusinessRules = New BusinessRules.LVBBusRules.LVBBusLogic
        LVBContractBusinessRules = New BusinessRules.LVBBusRules.LVBContractBusLogic
        LVBLineBusinessRules = New BusinessRules.LVBBusRules.LVBLineBusLogic
        ManProdBusinessRules = New BusinessRules.ManProdBusRules.ManProdBusLogic
        ManProdSupBusinessRules = New BusinessRules.ManProdSupBusRules.ManProdSupBusLogic
        ManUOMBusinessRules = New BusinessRules.ManUOMBusRules.ManUOMBusLogic
        ManUserProfileBusinessRules = New BusinessRules.ManUserProfileBusRules.ManUserProfileLogic
        OGBBusinessRules = New BusinessRules.OGBBusRules.OGBBusLogic
        OGBContractBusinessRules = New BusinessRules.OGBBusRules.OGBContractBusLogic
        POBusinessRules = New BusinessRules.POBusRules.POBusLogic
        POHeaderBusinessRules = New BusinessRules.POBusRules.POHeaderBusLogic
        POLineBusinessRules = New BusinessRules.POBusRules.POLineBusLogic
        PRBusinessRules = New BusinessRules.PRBusRules.PRBusLogic
        PRHeaderBusinessRules = New BusinessRules.PRBusRules.PRHeaderBusLogic
        PRlineBusinessRules = New BusinessRules.PRBusRules.PRLineBusLogic
        QABusinessRules = New BusinessRules.QABusRules.QABusLogic
        ReservedStockBusinessRules = New BusinessRules.ReservedStockRules.ReservedStockLogic
        SalesBusinessRules = New BusinessRules.SaleBusRules.SaleBusLogic
        StockBusinessRules = New BusinessRules.StockRules.StockLogic
        SupplierBusinessRules = New BusinessRules.SupplierBusRules.SupplierBusLogic
        BoxCategoryBusinessRules = New BusinessRules.SystemBusRules.BoxCategoryBusLogic
        BrandBusinessRules = New BusinessRules.SystemBusRules.BrandBusLogic
        ColorBusinessRules = New BusinessRules.SystemBusRules.ColorBusLogic
        SystemConsultantBusinessRules = New BusinessRules.SystemBusRules.ConsultantBusLogic
        SystemCurrencyBusinessRules = New BusinessRules.SystemBusRules.CurrencyBusLogic
        DeliveryBusinessRules = New BusinessRules.SystemBusRules.DeliveryTermsBusLogic
        DepartmentBusinessRules = New BusinessRules.SystemBusRules.Department
        DocumentNumberBusinessRules = New BusinessRules.SystemBusRules.DocumentNumberBusLogic
        DrawingNoBusinessRules = New BusinessRules.SystemBusRules.DrawingNoBusLogic
        EnclosureBusinessRules = New BusinessRules.SystemBusRules.EnclosureBusLogic
        KeyBusinessRules = New BusinessRules.SystemBusRules.KeyBusLogic
        LVBBoxBusinessRules = New BusinessRules.SystemBusRules.LVBBoxBusLogic
        MaterialBusinessRules = New BusinessRules.SystemBusRules.MaterialBusLogic
        OfficerInChargeBusinessRules = New BusinessRules.SystemBusRules.OfficerInChargeBusLogic
        PaymentTermsBusinessRules = New BusinessRules.SystemBusRules.PaymentTermsBusLogic
        PriceIncludeBusinessRules = New BusinessRules.SystemBusRules.PriceIncludeBusLogic
        ProjectBusinessRules = New BusinessRules.SystemBusRules.ProjectBusLogic
        SectionBusinessRules = New BusinessRules.SystemBusRules.SectionBusLogic
        SpecialBusinessRules = New BusinessRules.SystemBusRules.SpecialBusLogic
        UserGroupBusinessRules = New BusinessRules.SystemBusRules.UserGroup
        WHAreaBusinessRules = New BusinessRules.WHAreaBusRules.WHAreaClss
        WHBusinessRules = New BusinessRules.WHBusRules.WHBusLogic
        WHLocationBusinessRules = New BusinessRules.WHLocationBusRules.WHLocationClss
        WorkOrderBusinessRules = New BusinessRules.WorkOrderBusRules.WorkLogicBusLogic
        WorkPlanBusinessRules = New BusinessRules.WorkPlanBusRules.WorkPlanBusLogic
    End Sub

End Class
