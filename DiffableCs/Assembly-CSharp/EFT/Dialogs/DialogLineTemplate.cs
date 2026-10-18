namespace EFT.Dialogs;

[JsonObject(MemberSerialization::OptIn (1))]
public sealed class DialogLineTemplate
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__15_0; //Field offset: 0x8
		public static Func <>9__15_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal string <GetLocalizedLineDescription>b__15_0(SubtitleParams s) { }

		internal bool <GetLocalizedLineDescription>b__15_1(string s) { }

	}

	[JsonConverter(typeof(EFT.EnumConverter`1<EFT.Dialogs.DialogLineTemplate+EDialogLineIconType>))]
	internal enum EDialogLineIconType
	{
		QuestionMark = 0,
		QuestIcon = 1,
		Suitcase = 2,
		IndexFinger = 3,
		CheckMark = 4,
		OpenPalm = 5,
		BackArrow = 6,
		ForwardArrow = 7,
		QuitIcon = 8,
		DialogBubble = 9,
		ShoppingCart = 10,
		BtrItemsDeliveryService = 11,
		PlayerTaxiService = 12,
		BtrBotCoverIcon = 13,
		ZryachiyAidIcon = 14,
		ExUsecLoyaltyIcon = 15,
		CultistsAidIcon = 16,
		ChapterAccidentalWitness = 17,
		ChapterAlreadyHere = 18,
		ChapterBatya = 19,
		ChapterBlueFire = 20,
		ChapterFallingSkies = 21,
		ChapterLabyrinth = 22,
		ChapterLadyHeart = 23,
		ChapterTicket = 24,
		ChapterTour = 25,
		ChapterUnknown = 26,
	}

	[JsonConverter(typeof(EFT.EnumConverter`1<EFT.Dialogs.DialogLineTemplate+ESaveStateType>))]
	internal enum ESaveStateType
	{
		Dialog = 0,
		Session = 1,
		Profile = 2,
	}

	[JsonProperty("Id")]
	public readonly MongoID Id; //Field offset: 0x10
	[JsonProperty("TraderId")]
	public readonly Nullable TraderId; //Field offset: 0x28
	[JsonProperty("DialogSide")]
	public readonly EDialogSide DialogSide; //Field offset: 0x48
	[JsonProperty("AnimationData")]
	public CombinedAnimationData AnimationData; //Field offset: 0x50
	[JsonProperty("Actions")]
	public readonly IReadOnlyList Actions; //Field offset: 0x58
	[JsonProperty("Trigger")]
	public readonly DialogMainConditionGroup Trigger; //Field offset: 0x60
	[JsonProperty("IconType")]
	public readonly EDialogLineIconType IconType; //Field offset: 0x68
	[JsonProperty("ConfirmationKey")]
	public readonly string ConfirmationKey; //Field offset: 0x70

	public string DescriptionLocalized
	{
		 get { } //Length: 7
	}

	public DialogLineTemplate(MongoID id, EDialogSide dialogSide, EDialogLineIconType iconType = 0, DialogMainConditionGroup trigger = null, IReadOnlyList actions = null, CombinedAnimationData animationData = null) { }

	public DialogLineTemplate(BackendDialogNodeData data, DialogMainConditionGroup trigger, IReadOnlyList actions) { }

	[JsonConstructor]
	private DialogLineTemplate() { }

	public string get_DescriptionLocalized() { }

	private string GetLocalizedLineDescription() { }

}

