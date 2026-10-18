namespace EFT.Dialogs;

public sealed class BackendHasNewQuestsConditionData : BackendDialogNodeConditionData
{
	[CompilerGenerated]
	private MongoID <TraderId>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private bool <HasHewQuest>k__BackingField; //Field offset: 0x40

	[JsonProperty("value")]
	public private bool HasHewQuest
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

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

	public BackendHasNewQuestsConditionData() { }

	[CompilerGenerated]
	public bool get_HasHewQuest() { }

	[CompilerGenerated]
	public MongoID get_TraderId() { }

	public virtual EConditionType get_Type() { }

	[CompilerGenerated]
	private void set_HasHewQuest(bool value) { }

	[CompilerGenerated]
	private void set_TraderId(MongoID value) { }

	public virtual DialogCondition ToDialogCondition() { }

}

