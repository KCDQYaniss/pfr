namespace EFT.Dialogs;

public sealed class BackendServiceAvailableConditionData : BackendDialogNodeConditionData
{
	[CompilerGenerated]
	private ETraderServiceType <ServiceType>k__BackingField; //Field offset: 0x28

	[JsonProperty("serviceType")]
	public private ETraderServiceType ServiceType
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public virtual EConditionType Type
	{
		 get { } //Length: 6
	}

	public BackendServiceAvailableConditionData() { }

	[CompilerGenerated]
	public ETraderServiceType get_ServiceType() { }

	public virtual EConditionType get_Type() { }

	[CompilerGenerated]
	private void set_ServiceType(ETraderServiceType value) { }

	public virtual DialogCondition ToDialogCondition() { }

}

