namespace EFT.Dialogs;

[JsonConverter(typeof(BackendDialogNodeConditionJsonConverter))]
public abstract class BackendDialogNodeConditionData
{
	[JsonConverter(typeof(EFT.EnumConverter`1<EFT.Dialogs.BackendDialogNodeConditionData+EConditionType>))]
	internal enum EConditionType
	{
		VariableValue = 0,
		QuestStatus = 1,
		QuestConditionStatus = 2,
		TraderReputation = 3,
		HasNewQuests = 4,
		ServiceAvailable = 5,
		CurrentTrader = 6,
		CompletableItem = 7,
	}

	[CompilerGenerated]
	private MongoID <Id>k__BackingField; //Field offset: 0x10

	[JsonProperty("id")]
	public private MongoID Id
	{
		[CompilerGenerated]
		 get { } //Length: 21
		[CompilerGenerated]
		private set { } //Length: 98
	}

	public abstract EConditionType Type
	{
		 get { } //Length: 0
	}

	protected BackendDialogNodeConditionData() { }

	[CompilerGenerated]
	public MongoID get_Id() { }

	public abstract EConditionType get_Type() { }

	[CompilerGenerated]
	private void set_Id(MongoID value) { }

	public abstract DialogCondition ToDialogCondition() { }

}

