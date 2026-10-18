namespace EFT.Dialogs;

public sealed class ServiceAvailableCondition : DialogCondition
{
	[CompilerGenerated]
	private ETraderServiceType <ServiceType>k__BackingField; //Field offset: 0x10

	[JsonProperty("serviceType")]
	public private ETraderServiceType ServiceType
	{
		[CompilerGenerated]
		 get { } //Length: 164
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public virtual EDialogConditionType Type
	{
		 get { } //Length: 6
	}

	public ServiceAvailableCondition() { }

	public ServiceAvailableCondition(ETraderServiceType serviceType) { }

	[CompilerGenerated]
	public ETraderServiceType get_ServiceType() { }

	public virtual EDialogConditionType get_Type() { }

	[CompilerGenerated]
	private void set_ServiceType(ETraderServiceType value) { }

	public virtual bool Test(IDialogContext context) { }

}

