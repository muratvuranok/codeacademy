using PRO.SharedKernel.Domain.Application.NewEstimate;
using PRO.SharedKernel.Domain.Application.NewEstimate.Enums;
using System.Text;

namespace PRO.SharedKernel.Domain.Application.NewEstimateDomain;
public partial class Estimate : Entity<Guid> 
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

    public bool? IsEstimateClientApprovalActive { get; set; }
    public bool? IsEstimateManagerApprovalActive { get; set; }
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
 
