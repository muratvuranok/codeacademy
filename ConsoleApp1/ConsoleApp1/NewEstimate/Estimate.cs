using PRO.SharedKernel.Domain.Administrator.CRMDomain;
using PRO.SharedKernel.Domain.Application.CommonDomain;
using PRO.SharedKernel.Domain.Application.NewEstimate;
using PRO.SharedKernel.Domain.Application.NewEstimate.Enums;
using PRO.SharedKernel.Domain.Application.ProjectDomain;
using PRO.SharedKernel.Domain.Membership.AccountDomain;
using PRO.SharedKernel.Infrastructure.DbProvider.EFCore.Aggregates;
using System.Text;

namespace PRO.SharedKernel.Domain.Application.NewEstimateDomain;
public partial class Estimate : Entity<Guid>, ISoftDelete, ITransactionDate, ITenant
{
    #region Properties

    public PublishTypes PublishType { get; set; }
    public Guid AccountId { get; set; }
    public virtual Account Account { get; set; } = null!;
    public Guid UserId { get; set; }
    public virtual User User { get; set; } = null!;
    public Guid? EstimateSearchId { get; set; }
    public EstimateSearch? EstimateSearch { get; set; }


    public virtual ICollection<EstimateNote> EstimateNotes { get; set; }
    public virtual ICollection<EstimateGroup> EstimateGroups { get; set; }
    public virtual ICollection<EstimateContact> EstimateContacts { get; set; }
    public virtual ICollection<EstimateCategory> EstimateCategories { get; set; }
    public virtual ICollection<EstimateAttachment> EstimateAttachments { get; set; }
    public virtual ICollection<EstimatePaymentSchedule> EstimatePaymentSchedules { get; set; }


    #region Estimates

    public DateTime? CreatedDate { get; set; }
    public DateTime? UpdatedDate { get; set; }

    public string? Address { get; set; }

    public int? LeadId { get; private set; }
    public Lead? Lead { get; private set; }
    public int? ProjectId { get; private set; }
    public Project? Project { get; private set; }
    public string? ReferenceNumber { get; set; }

    public byte? StatusId { get; set; }
    public EstimateStatus? EstimateStatus { get; set; }
    public string? Title { get; set; }


    public string? Description { get; set; }
    public DateTime? EstimateDate { get; set; }
    public DateTime? DeletedDate { get; set; }
    public DeleteTypes? DeleteType { get; set; }
    #endregion

    #region General Info
    public bool? GeneralShowClientNameShow { get; set; }
    public bool? GeneralShowClientPhoneShow { get; set; }
    public bool? GeneralShowCompanyLogoShow { get; set; }
    public bool? GeneralShowClientEmailShow { get; set; }
    public bool? GeneralShowCompanyPhoneShow { get; set; }
    public bool? GeneralShowCompanyEmailShow { get; set; }
    public bool? GeneralShowEstimateDateShow { get; set; }
    public bool? GeneralShowEstimateTitleShow { get; set; }
    public bool? GeneralShowClientAddressShow { get; set; }
    public bool? GeneralShowClientCompanyShow { get; set; }
    public bool? GeneralShowCompanyAddressShow { get; set; }
    public bool? GeneralShowEstimateAddressShow { get; set; }
    public bool? GeneralShowEstimateDescriptionShow { get; set; }
    #endregion

    #region Overview
    public bool? OverviewShow { get; set; }
    public bool? OverviewLaborShow { get; set; }
    public bool? OverviewTotalShow { get; set; }
    public bool? OverviewMaterialShow { get; set; }
    public bool? OverviewAllowanceShow { get; set; }
    public bool? OverviewGrandTotalShow { get; set; }
    public bool? OverviewCategoryNameShow { get; set; }
    public byte? OverviewMaterialTypeShow { get; set; }
    public bool? OverviewCategoryTotalShow { get; set; }
    public bool? OverviewOptionalTaskAmountShow { get; set; }

    public string? OverviewCustomTitle { get; set; }
    public string? OverviewCustomDescription { get; set; }
    #endregion

    #region Totals

    public Guid? TaxId { get; set; }
    public Tax? Tax { get; set; }


    public byte? OverheadType { get; set; }
    public bool? OverheadEnabled { get; set; }
    public decimal? OverheadAmount { get; set; }
    public bool? OverheadAddToLabor { get; set; }
    public bool? OverheadTaxIncluded { get; set; }
    public decimal? OverheadPercentage { get; set; }

    public bool? TaxEnabled { get; set; }
    public byte? TaxOverrideType { get; set; }
    public bool? TaxBeforeDiscount { get; set; }
    public decimal? TaxOverrideAmount { get; set; }
    public decimal? TaxOverridePercentage { get; set; }

    public bool? LaborTaxIncluded { get; set; }
    public bool? MaterialTaxIncluded { get; set; }

    public byte? DiscountType { get; set; }
    public bool? DiscountEnabled { get; set; }
    public decimal? DiscountAmount { get; set; }
    public decimal? DiscountPercentage { get; set; }
    #endregion

    #region Appropvals

    public Guid? ManagerUserId { get; set; }
    public User? ManagerUser { get; set; }

    public bool? IsEstimateManagerApprovalActive { get; set; }
    public bool? IsEstimateClientApprovalActive { get; set; }
    public bool? IsContractManagerApprovalActive { get; set; }
    #endregion

    #region Template 
    public PdfTemplates? TemplateStyle { get; set; }
    public string? HeaderColor { get; set; }
    public string? SubheaderColor { get; set; }
    public string? TextColor { get; set; }
    public string? BackgroundColor { get; set; }
    public string? FontFamily { get; set; }
    #endregion

    #region ScopeOfWork
    public bool? ScopeOfWorkTask { get; set; }
    public bool? ScopeOfWorkShow { get; set; }
    public bool? ScopeOfWorkLabor { get; set; }
    public bool? ScopeOfWorkGroups { get; set; }
    public bool? ScopeOfWorkMaterial { get; set; }
    public byte? ScopeOfWorkSequence { get; set; }
    public bool? ScopeOfWorkSubGroups { get; set; }
    public bool? ScopeOfWorkTaskNotes { get; set; }
    public byte? ScopeOfWorkPhotosView { get; set; }
    public bool? ScopeOfWorkTaskPhotos { get; set; }
    public bool? ScopeOfWorkCategories { get; set; }
    public bool? ScopeOfWorkTaskDetails { get; set; }
    public bool? ScopeOfWorkTaskCostCode { get; set; }
    public bool? ScopeOfWorkTaskQuantity { get; set; }
    public byte? ScopeOfWorkMaterialType { get; set; }
    public string? ScopeOfWorkCustomTitle { get; set; }
    public bool? ScopeOfWorkTaskLocations { get; set; }
    public bool? ScopeOfWorkTaskAllColumns { get; set; }
    public byte? ScopeOfWorkPhotosLocation { get; set; }
    public string? ScopeOfWorkCustomDescription { get; set; }
    #endregion

    #region Material List
    public bool? MaterialListShow { get; set; }
    public bool? MaterialListMarkup { get; set; }
    public bool? MaterialListAmount { get; set; }
    public byte? MaterialListSequence { get; set; }
    public bool? MaterialListUnitCost { get; set; }
    public bool? MaterialListQuantity { get; set; }
    public bool? MaterialListAllowance { get; set; }
    public bool? MaterialListBaseTotal { get; set; }
    public bool? MaterialListFurnishedBy { get; set; }
    public byte? MaterialListMaterialType { get; set; }
    public string? MaterialListCustomTitle { get; set; }
    public byte? MaterialListFurnishedType { get; set; }
    public byte? MaterialListAllowanceType { get; set; }
    public string? MaterialListCustomDescription { get; set; }
    #endregion

    #region Payment Schedule

    public bool? PaymentShow { get; set; }
    public byte? PaymentSequence { get; set; }
    public byte? PaymentFinalType { get; set; }
    public string? PaymentCustomTitle { get; set; }
    public decimal? PaymentFinalAmount { get; set; }
    public decimal? PaymentFinalPercentage { get; set; }
    public string? PaymentCustomDescription { get; set; }
    public decimal? PaymentDepositPercentage { get; set; }
    public decimal? PaymentDepositMaximumAmount { get; set; }
    #endregion

    #region Project Duration
    public bool? DurationShow { get; set; }
    public string? DurationText { get; set; }
    public byte? DurationSequence { get; set; }
    public byte? DurationMaximumType { get; set; }
    public byte? DurationMinimumType { get; set; }
    public string? DurationCustomTitle { get; set; }
    public short? DurationFieldWorkers { get; set; }
    public byte? DurationWorkHoursPerDay { get; set; }
    public byte? DurationWorkDaysPerWeek { get; set; }
    public decimal? DurationMinimumAmount { get; set; }
    public decimal? DurationMaximumAmount { get; set; }
    public string? DurationCustomDescription { get; set; }
    public decimal? DurationMinimumPercentage { get; set; }
    public decimal? DurationMaximumPercentage { get; set; }
    #endregion

    #region Notes
    public bool? NoteShow { get; set; }
    public byte? NoteSequence { get; set; }
    public string? NoteCustomTitle { get; set; }
    public string? NoteCustomDescription { get; set; }
    #endregion

    #region Terms
    public bool? TermShow { get; set; }
    public byte? TermSequence { get; set; }
    public string? TermCustomTitle { get; set; }
    public string? TermCustomDescription { get; set; }
    #endregion

    #region Inclusion Exclusion
    public bool? ExclusionShow { get; set; }
    public byte? ExclusionSequence { get; set; }
    public string? ExclusionCustomTitle { get; set; }
    public string? ExclusionCustomDescription { get; set; }
    #endregion

    #region Attachment
    public bool? AttachmentShow { get; set; }
    public byte? AttachmentSequence { get; set; }
    public string? AttachmentCustomTitle { get; set; }
    public string? AttachmentCustomDescription { get; set; }
    #endregion

    #region Signature
    public Guid? CompanySignatureId { get; set; }
    public Signature? CompanySignature { get; set; }

    public bool? SignatureShow { get; set; }
    public byte? SignatureSequence { get; set; }
    public string? SignatureCustomTitle { get; set; }
    public string? SignatureCustomDescription { get; set; }
    public bool? SignatureCompanyShow { get; set; }
    #endregion

    #endregion

    #region Constructor
    public Estimate()
    {
        this.EstimateNotes = new HashSet<EstimateNote>();
        this.EstimateGroups = new HashSet<EstimateGroup>();
        this.EstimateContacts = new HashSet<EstimateContact>();
        this.EstimateCategories = new HashSet<EstimateCategory>();
        this.EstimateAttachments = new HashSet<EstimateAttachment>();
        this.EstimatePaymentSchedules = new HashSet<EstimatePaymentSchedule>();
    }

    public Estimate(
        PublishTypes publishTypes,
        string referanceNumber,
        Estimate defaultEstimate) : this()
    {

        this.PublishType = publishTypes;
        this.ReferenceNumber = referanceNumber;

        // General Info
        this.GeneralShowClientNameShow = defaultEstimate.GeneralShowClientNameShow;
        this.GeneralShowClientPhoneShow = defaultEstimate.GeneralShowClientPhoneShow;
        this.GeneralShowCompanyLogoShow = defaultEstimate.GeneralShowCompanyLogoShow;
        this.GeneralShowClientEmailShow = defaultEstimate.GeneralShowClientEmailShow;
        this.GeneralShowCompanyPhoneShow = defaultEstimate.GeneralShowCompanyPhoneShow;
        this.GeneralShowCompanyEmailShow = defaultEstimate.GeneralShowCompanyEmailShow;
        this.GeneralShowEstimateDateShow = defaultEstimate.GeneralShowEstimateDateShow;
        this.GeneralShowEstimateTitleShow = defaultEstimate.GeneralShowEstimateTitleShow;
        this.GeneralShowClientAddressShow = defaultEstimate.GeneralShowClientAddressShow;
        this.GeneralShowClientCompanyShow = defaultEstimate.GeneralShowClientCompanyShow;
        this.GeneralShowCompanyAddressShow = defaultEstimate.GeneralShowCompanyAddressShow;
        this.GeneralShowEstimateAddressShow = defaultEstimate.GeneralShowEstimateAddressShow;
        this.GeneralShowEstimateDescriptionShow = defaultEstimate.GeneralShowEstimateDescriptionShow;

        // Overview
        this.OverviewShow = defaultEstimate.OverviewShow;
        this.OverviewLaborShow = defaultEstimate.OverviewLaborShow;
        this.OverviewTotalShow = defaultEstimate.OverviewTotalShow;
        this.OverviewCustomTitle = defaultEstimate.OverviewCustomTitle;
        this.OverviewMaterialShow = defaultEstimate.OverviewMaterialShow;
        this.OverviewAllowanceShow = defaultEstimate.OverviewAllowanceShow;
        this.OverviewGrandTotalShow = defaultEstimate.OverviewGrandTotalShow;
        this.OverviewCategoryNameShow = defaultEstimate.OverviewCategoryNameShow;
        this.OverviewMaterialTypeShow = defaultEstimate.OverviewMaterialTypeShow;
        this.OverviewCategoryTotalShow = defaultEstimate.OverviewCategoryTotalShow;
        this.OverviewCustomDescription = defaultEstimate.OverviewCustomDescription;
        this.OverviewOptionalTaskAmountShow = defaultEstimate.OverviewOptionalTaskAmountShow;

        // Totals 
        this.TaxId = defaultEstimate.PublishType == PublishTypes.Global ? null : defaultEstimate.TaxId;

        this.TaxEnabled = defaultEstimate.TaxEnabled;
        this.DiscountType = defaultEstimate.DiscountType;
        this.OverheadType = defaultEstimate.OverheadType;
        this.OverheadAmount = defaultEstimate.OverheadAmount;
        this.DiscountAmount = defaultEstimate.DiscountAmount;
        this.DiscountEnabled = defaultEstimate.DiscountEnabled;
        this.TaxOverrideType = defaultEstimate.TaxOverrideType;
        this.OverheadEnabled = defaultEstimate.OverheadEnabled;
        this.LaborTaxIncluded = defaultEstimate.LaborTaxIncluded;
        this.TaxBeforeDiscount = defaultEstimate.TaxBeforeDiscount;
        this.TaxOverrideAmount = defaultEstimate.TaxOverrideAmount;
        this.OverheadAddToLabor = defaultEstimate.OverheadAddToLabor;
        this.OverheadPercentage = defaultEstimate.OverheadPercentage;
        this.DiscountPercentage = defaultEstimate.DiscountPercentage;
        this.OverheadTaxIncluded = defaultEstimate.OverheadTaxIncluded;
        this.MaterialTaxIncluded = defaultEstimate.MaterialTaxIncluded;
        this.TaxOverridePercentage = defaultEstimate.TaxOverridePercentage;

        // Appropvals 
        this.ManagerUserId = defaultEstimate.ManagerUserId;
        this.IsEstimateClientApprovalActive = defaultEstimate.IsEstimateClientApprovalActive;
        this.IsEstimateManagerApprovalActive = defaultEstimate.IsEstimateManagerApprovalActive;
        this.IsContractManagerApprovalActive = defaultEstimate.IsContractManagerApprovalActive;


        // Template 
        this.TextColor = defaultEstimate.TextColor;
        this.FontFamily = defaultEstimate.FontFamily;
        this.HeaderColor = defaultEstimate.HeaderColor;
        this.TemplateStyle = defaultEstimate.TemplateStyle;
        this.SubheaderColor = defaultEstimate.SubheaderColor;
        this.BackgroundColor = defaultEstimate.BackgroundColor;

        // Scope Of Work 
        this.ScopeOfWorkTask = defaultEstimate.ScopeOfWorkTask;
        this.ScopeOfWorkShow = defaultEstimate.ScopeOfWorkShow;
        this.ScopeOfWorkLabor = defaultEstimate.ScopeOfWorkLabor;
        this.ScopeOfWorkGroups = defaultEstimate.ScopeOfWorkGroups;
        this.ScopeOfWorkMaterial = defaultEstimate.ScopeOfWorkMaterial;
        this.ScopeOfWorkSequence = defaultEstimate.ScopeOfWorkSequence;
        this.ScopeOfWorkSubGroups = defaultEstimate.ScopeOfWorkSubGroups;
        this.ScopeOfWorkTaskNotes = defaultEstimate.ScopeOfWorkTaskNotes;
        this.ScopeOfWorkPhotosView = defaultEstimate.ScopeOfWorkPhotosView;
        this.ScopeOfWorkTaskPhotos = defaultEstimate.ScopeOfWorkTaskPhotos;
        this.ScopeOfWorkCategories = defaultEstimate.ScopeOfWorkCategories;
        this.ScopeOfWorkTaskDetails = defaultEstimate.ScopeOfWorkTaskDetails;
        this.ScopeOfWorkCustomTitle = defaultEstimate.ScopeOfWorkCustomTitle;
        this.ScopeOfWorkTaskCostCode = defaultEstimate.ScopeOfWorkTaskCostCode;
        this.ScopeOfWorkTaskQuantity = defaultEstimate.ScopeOfWorkTaskQuantity;
        this.ScopeOfWorkMaterialType = defaultEstimate.ScopeOfWorkMaterialType;
        this.ScopeOfWorkTaskLocations = defaultEstimate.ScopeOfWorkTaskLocations;
        this.ScopeOfWorkTaskAllColumns = defaultEstimate.ScopeOfWorkTaskAllColumns;
        this.ScopeOfWorkPhotosLocation = defaultEstimate.ScopeOfWorkPhotosLocation;
        this.ScopeOfWorkCustomDescription = defaultEstimate.ScopeOfWorkCustomDescription;

        // Material List
        this.MaterialListShow = defaultEstimate.MaterialListShow;
        this.MaterialListMarkup = defaultEstimate.MaterialListMarkup;
        this.MaterialListAmount = defaultEstimate.MaterialListAmount;
        this.MaterialListSequence = defaultEstimate.MaterialListSequence;
        this.MaterialListUnitCost = defaultEstimate.MaterialListUnitCost;
        this.MaterialListQuantity = defaultEstimate.MaterialListQuantity;
        this.MaterialListAllowance = defaultEstimate.MaterialListAllowance;
        this.MaterialListBaseTotal = defaultEstimate.MaterialListBaseTotal;
        this.MaterialListFurnishedBy = defaultEstimate.MaterialListFurnishedBy;
        this.MaterialListMaterialType = defaultEstimate.MaterialListMaterialType;
        this.MaterialListCustomTitle = defaultEstimate.MaterialListCustomTitle;
        this.MaterialListFurnishedType = defaultEstimate.MaterialListFurnishedType;
        this.MaterialListAllowanceType = defaultEstimate.MaterialListAllowanceType;
        this.MaterialListCustomDescription = defaultEstimate.MaterialListCustomDescription;


        // Payment Schedule
        this.PaymentShow = defaultEstimate.PaymentShow;
        this.PaymentSequence = defaultEstimate.PaymentSequence;
        this.PaymentFinalType = defaultEstimate.PaymentFinalType;
        this.PaymentCustomTitle = defaultEstimate.PaymentCustomTitle;
        this.PaymentFinalAmount = defaultEstimate.PaymentFinalAmount;
        this.PaymentFinalPercentage = defaultEstimate.PaymentFinalPercentage;
        this.PaymentCustomDescription = defaultEstimate.PaymentCustomDescription;
        this.PaymentDepositPercentage = defaultEstimate.PaymentDepositPercentage;
        this.PaymentDepositMaximumAmount = defaultEstimate.PaymentDepositMaximumAmount;


        // Project Duration 
        this.DurationShow = defaultEstimate.DurationShow;
        this.DurationText = defaultEstimate.DurationText;
        this.DurationSequence = defaultEstimate.DurationSequence;
        this.DurationMaximumType = defaultEstimate.DurationMaximumType;
        this.DurationMinimumType = defaultEstimate.DurationMinimumType;
        this.DurationCustomTitle = defaultEstimate.DurationCustomTitle;
        this.DurationFieldWorkers = defaultEstimate.DurationFieldWorkers;
        this.DurationMinimumAmount = defaultEstimate.DurationMinimumAmount;
        this.DurationMaximumAmount = defaultEstimate.DurationMaximumAmount;
        this.DurationWorkHoursPerDay = defaultEstimate.DurationWorkHoursPerDay;
        this.DurationWorkDaysPerWeek = defaultEstimate.DurationWorkDaysPerWeek;
        this.DurationCustomDescription = defaultEstimate.DurationCustomDescription;
        this.DurationMinimumPercentage = defaultEstimate.DurationMinimumPercentage;
        this.DurationMaximumPercentage = defaultEstimate.DurationMaximumPercentage;


        // Notes
        this.NoteShow = defaultEstimate.NoteShow;
        this.NoteSequence = defaultEstimate.NoteSequence;
        this.NoteCustomTitle = defaultEstimate.NoteCustomTitle;
        this.NoteCustomDescription = defaultEstimate.NoteCustomDescription;


        // Term
        this.TermShow = defaultEstimate.TermShow;
        this.TermSequence = defaultEstimate.TermSequence;
        this.TermCustomTitle = defaultEstimate.TermCustomTitle;
        this.TermCustomDescription = defaultEstimate.TermCustomDescription;


        // Inclusion Exclusion
        this.ExclusionShow = defaultEstimate.ExclusionShow;
        this.ExclusionSequence = defaultEstimate.ExclusionSequence;
        this.ExclusionCustomTitle = defaultEstimate.ExclusionCustomTitle;
        this.ExclusionCustomDescription = defaultEstimate.ExclusionCustomDescription;


        // Attachment
        this.AttachmentShow = defaultEstimate.AttachmentShow;
        this.AttachmentSequence = defaultEstimate.AttachmentSequence;
        this.AttachmentCustomTitle = defaultEstimate.AttachmentCustomTitle;
        this.AttachmentCustomDescription = defaultEstimate.AttachmentCustomDescription;


        // Signature
        this.SignatureShow = defaultEstimate.SignatureShow;
        this.SignatureSequence = defaultEstimate.SignatureSequence;
        this.SignatureCustomTitle = defaultEstimate.SignatureCustomTitle;
        this.SignatureCompanyShow = defaultEstimate.SignatureCompanyShow;
        this.SignatureCustomDescription = defaultEstimate.SignatureCustomDescription;
    }

    #endregion

    #region Public Methods
      
    public void UpdateInfo() { }
    public void UpdateTerm () { }
    public void UpdateNote () { }
    public void UpdateTotal() { }
    public void UpdateTemplate() { }
    public void UpdateOverview() { }
    public void UpdateAppropval() { }
    public void UpdateSignature() { }
    public void UpdateEstimate () { }
    public void UpdateAttachment() { }
    public void UpdateScopeOfWork() { }
    public void UpdateMaterialList() { }
    public void UpdatePaymentSchedule() { }
    public void UpdateProjectDuration () { }
    public void UpdateInclusionExclusion() { }



    public string GetSearchValue()
    {
        StringBuilder builder = new StringBuilder();
        // Must be top level
        builder.AppendWith(this.ReferenceNumber, afterText: " ");
        builder.AppendWith(this.Description, afterText: " ");
        builder.AppendWith(this.Title, afterText: " ");
        builder.AppendWith(this.Address, afterText: " ");

        // TODO: Contact bilgileri nasıl gelecek :) güzel soru


        return builder.ToStr();
    }
     
    public void Delete()
    {
        this.DeletedDate = DateTime.UtcNow;
        this.DeleteType = DeleteTypes.Trash;
    }
    public void DeleteForever()
    {
        this.DeletedDate = DateTime.UtcNow;
        this.DeleteType = DeleteTypes.Forever;
    }
    public void Recover()
    {
        this.DeletedDate = null;
        this.DeleteType = DeleteTypes.Active;
    }
    #endregion
}
