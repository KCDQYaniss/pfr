namespace EFT.Dialogs;

public sealed class DialogPurchaseServiceAction : DialogNotifiedAction
{
	[CompilerGenerated]
	private ETraderServiceType <ServiceType>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private string <SubServiceId>k__BackingField; //Field offset: 0x40

	public virtual bool Queued
	{
		 get { } //Length: 3
	}

	[JsonProperty("serviceType")]
	public private ETraderServiceType ServiceType
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	[JsonProperty("subServiceId")]
	public private string SubServiceId
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public virtual EActionType Type
	{
		 get { } //Length: 6
	}

	public DialogPurchaseServiceAction(ETraderServiceType serviceType, string subServiceId) { }

	public DialogPurchaseServiceAction() { }

	public virtual bool get_Queued() { }

	[CompilerGenerated]
	public ETraderServiceType get_ServiceType() { }

	[CompilerGenerated]
	public string get_SubServiceId() { }

	public virtual EActionType get_Type() { }

	[CompilerGenerated]
	private void set_ServiceType(ETraderServiceType value) { }

	[CompilerGenerated]
	private void set_SubServiceId(string value) { }

	public virtual string ToString() { }

}

