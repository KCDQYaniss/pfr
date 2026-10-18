namespace EFT.Dialogs;

[JsonConverter(typeof(DialogActionJsonConverter))]
[JsonObject(MemberSerialization::OptIn (1))]
public abstract class DialogAction
{
	[JsonConverter(typeof(EFT.EnumConverter`1<EFT.Dialogs.DialogAction+EActionType>))]
	internal enum EActionType
	{
		DiaryNote = 0,
		AcceptQuest = 1,
		HandoverItem = 2,
		FinishQuest = 3,
		PurchaseService = 4,
		EmbedQuestDialog = 5,
		SetVariable = 6,
		SwitchDialog = 7,
		QuitAction = 8,
		TradingScreenAction = 9,
		QuestsScreenAction = 10,
		SelectSubService = 11,
		SelectQuest = 12,
		PlayerReward = 13,
	}

	[CompilerGenerated]
	private MongoID <Id>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly bool <Queued>k__BackingField; //Field offset: 0x28

	[JsonProperty("id")]
	public private MongoID Id
	{
		[CompilerGenerated]
		 get { } //Length: 21
		[CompilerGenerated]
		private set { } //Length: 98
	}

	public override bool IsQuitAction
	{
		 get { } //Length: 3
	}

	public override bool Queued
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	[JsonProperty("type")]
	public abstract EActionType Type
	{
		 get { } //Length: 0
	}

	protected DialogAction() { }

	[CompilerGenerated]
	public MongoID get_Id() { }

	public override bool get_IsQuitAction() { }

	[CompilerGenerated]
	public override bool get_Queued() { }

	public abstract EActionType get_Type() { }

	[CompilerGenerated]
	private void set_Id(MongoID value) { }

}

