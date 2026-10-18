namespace EFT.Hideout;

public sealed class ScavCaseProducer : ItemsProducerBase
{
	private float _discount; //Field offset: 0xE8
	private readonly Item[] _emptyArray; //Field offset: 0xF0
	private readonly FenceTraderInfo _fenceTraderInfo; //Field offset: 0xF8
	[CompilerGenerated]
	private ScavProductVariation <CompleteItemsCountVariation>k__BackingField; //Field offset: 0x100

	public virtual bool CanStart
	{
		 get { } //Length: 3
		 set { } //Length: 3
	}

	public private ScavProductVariation CompleteItemsCountVariation
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public virtual EHideoutNotificationType NotificationType
	{
		 get { } //Length: 6
	}

	public virtual float ReductionCoefficient
	{
		 get { } //Length: 59
	}

	public ScavCaseProducer(FenceTraderInfo fenceTraderInfo) { }

	protected virtual void ApplySkillsAndBuffsOnInit(SkillManager skillManager) { }

	protected virtual Item CreateCompleteItem(BaseHideoutScheme scheme) { }

	public virtual bool get_CanStart() { }

	[CompilerGenerated]
	public ScavProductVariation get_CompleteItemsCountVariation() { }

	public virtual EHideoutNotificationType get_NotificationType() { }

	public virtual float get_ReductionCoefficient() { }

	public virtual void GetItems(string schemeId) { }

	public virtual void InitAreaDataEarly(AreaData data) { }

	protected virtual void InitDetails(AreaData data) { }

	protected virtual void InitProduction(List productions) { }

	public virtual void set_CanStart(bool value) { }

	[CompilerGenerated]
	private void set_CompleteItemsCountVariation(ScavProductVariation value) { }

	private void SetExtraAvailableProductions() { }

	public void UpdateScavCaseDiscount(float value) { }

}

