namespace ChatShared;

public sealed class DialogueChatMessage : IUpdatable
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__23_0; //Field offset: 0x8
		public static Func <>9__25_0; //Field offset: 0x10
		public static Func <>9__30_0; //Field offset: 0x18

		private static <>c() { }

		public <>c() { }

		internal string <.cctor>b__47_0(ChatMessageSystemData data) { }

		internal string <.cctor>b__47_1(ChatMessageSystemData data) { }

		internal string <.cctor>b__47_2(ChatMessageSystemData data) { }

		internal string <.cctor>b__47_3(ChatMessageSystemData data) { }

		internal string <.cctor>b__47_4(ChatMessageSystemData data) { }

		internal string <.cctor>b__47_5(ChatMessageSystemData data) { }

		internal bool <get_AnyNonQuestItems>b__23_0(Item item) { }

		internal bool <get_AnyQuestItems>b__25_0(Item item) { }

		internal bool <get_HasProfileEvents>b__30_0(ProfileChangeEvent event) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass39_0
	{
		public ChatMessageSystemData data; //Field offset: 0x10

		public <>c__DisplayClass39_0() { }

		internal string <ResolveTags>b__0(Match match) { }

	}

	internal class ChatMessageParams
	{
		public EMessageParamsAction Action; //Field offset: 0x10
		public UpdatableChatMember Member; //Field offset: 0x18
		public UpdatableChatMember[] Users; //Field offset: 0x20

		public ChatMessageParams() { }

	}

	public const string RICH_TEXT_TAG = "<.*?>"; //Field offset: 0x0
	private const string LINK_COLOR = "#4db1d0"; //Field offset: 0x0
	private static readonly Regex _tagsRegex; //Field offset: 0x0
	private static readonly IReadOnlyDictionary _tagValues; //Field offset: 0x8
	public string _id; //Field offset: 0x10
	public string templateId; //Field offset: 0x18
	public ChatMessageSystemData systemData; //Field offset: 0x20
	public EMessageType Type; //Field offset: 0x28
	public string Text; //Field offset: 0x30
	public DateTime LocalDateTime; //Field offset: 0x38
	public DateTime UtcDateTime; //Field offset: 0x40
	public UpdatableChatMember Member; //Field offset: 0x48
	public DialogueChatMessage ReplyTo; //Field offset: 0x50
	public ChatMessageParams Params; //Field offset: 0x58
	public long MaxStorageTime; //Field offset: 0x60
	public ChatMessageItems Items; //Field offset: 0x68
	public ProfileChangeEvent[] ProfileChangeEvents; //Field offset: 0x70
	public bool HasRewards; //Field offset: 0x78
	public bool IsFirstMessageOfTheDate; //Field offset: 0x79
	public BindableEvent UpdateRewardStatus; //Field offset: 0x80

	public bool AnyItems
	{
		 get { } //Length: 132
	}

	public bool AnyNonQuestItems
	{
		 get { } //Length: 445
	}

	public bool AnyQuestItems
	{
		 get { } //Length: 445
	}

	public bool DisplayRewardStatus
	{
		 get { } //Length: 325
	}

	public DateTime ExpirationTime
	{
		 get { } //Length: 188
	}

	public bool HasProfileEvents
	{
		 get { } //Length: 484
	}

	public bool ParseLocalizationForMessage
	{
		 get { } //Length: 71
	}

	public string SystemText
	{
		 get { } //Length: 468
	}

	private static DialogueChatMessage() { }

	public DialogueChatMessage() { }

	public override bool Compare(DialogueChatMessage other) { }

	public static DialogueChatMessage FindOrCreate(string id, Func constructor) { }

	public bool get_AnyItems() { }

	public bool get_AnyNonQuestItems() { }

	public bool get_AnyQuestItems() { }

	public bool get_DisplayRewardStatus() { }

	public DateTime get_ExpirationTime() { }

	public bool get_HasProfileEvents() { }

	public bool get_ParseLocalizationForMessage() { }

	public string get_SystemText() { }

	public string ParsedText() { }

	public string ParsedText(string startingValue, EViewRule viewRule) { }

	private static string ResolveTags(string text, ChatMessageSystemData data) { }

	private static string ShortLink(string color, string link) { }

	public DialogueChatMessage ToSystemMessage() { }

	public DialogueChatMessage ToSystemMessageWithParams() { }

	public override void UpdateFromAnotherItem(DialogueChatMessage other) { }

}

