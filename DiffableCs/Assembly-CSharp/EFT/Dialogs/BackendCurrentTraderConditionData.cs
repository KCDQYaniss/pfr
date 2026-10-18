namespace EFT.Dialogs;

public sealed class BackendCurrentTraderConditionData : BackendDialogNodeConditionData
{
	[CompilerGenerated]
	private MongoID <TraderId>k__BackingField; //Field offset: 0x28

	[JsonProperty("traderId")]
	public private MongoID TraderId
	{
		[CompilerGenerated]
		 get { } //Length: 21
		[CompilerGenerated]
		private set { } //Length: 98
	}

	public virtual EConditionType Type
	{
		 get { } //Length: 6
	}

	public BackendCurrentTraderConditionData() { }

	[CompilerGenerated]
	public MongoID get_TraderId() { }

	public virtual EConditionType get_Type() { }

	[CompilerGenerated]
	private void set_TraderId(MongoID value) { }

	public virtual DialogCondition ToDialogCondition() { }

}

