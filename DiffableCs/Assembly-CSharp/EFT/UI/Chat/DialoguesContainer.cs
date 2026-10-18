namespace EFT.UI.Chat;

public sealed class DialoguesContainer : UIElement
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static LightScrollerDataTypeGetter <>9__17_3; //Field offset: 0x8
		public static Action <>9__17_4; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal Enum <Show>b__17_3(DialogueData dialog) { }

		internal void <Show>b__17_4(DialogueData item, DialogueView view) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass17_0
	{
		public DialoguesContainer <>4__this; //Field offset: 0x10
		public ConvertedBindableList dialogsList; //Field offset: 0x18
		public SocialNetwork social; //Field offset: 0x20

		public <>c__DisplayClass17_0() { }

		internal void <Show>b__0() { }

		internal void <Show>b__1(UpdatableChatDialogue dialog) { }

		internal DialogueView <Show>b__2(DialogueData dialog) { }

		internal void <Show>g__UpdatePlaceholders|5(Nullable selectedOverride = null) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass18_0
	{
		public DialoguesContainer <>4__this; //Field offset: 0x10
		public UpdatableChatDialogue dialogue; //Field offset: 0x18

		public <>c__DisplayClass18_0() { }

		internal void <DialogueDataFromDialogue>b__0(UpdatableChatDialogue view, Vector2 pos) { }

		internal void <DialogueDataFromDialogue>b__1(Vector2 pos) { }

	}

	[CompilerGenerated]
	private static class <>O
	{
		public static Comparison <0>__Comparer; //Field offset: 0x0

	}

	[CompilerGenerated]
	private struct <UpdateDialogueListAsync>d__20 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public DialoguesContainer <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal enum EDialogType
	{
		None = 0,
		Trader = 1,
		User = 2,
	}

	[SerializeField]
	private LightScroller _scroller; //Field offset: 0x70
	[SerializeField]
	private DialogueView _cellViewPrefab; //Field offset: 0x78
	[SerializeField]
	private ChatMessageSendBlock _chatMessageSendBlock; //Field offset: 0x80
	[SerializeField]
	private ChatInvitePlayersPanel _invitePlayersPanel; //Field offset: 0x88
	[SerializeField]
	private GameObject _loader; //Field offset: 0x90
	[SerializeField]
	private GameObject _noDialogsPlaceholder; //Field offset: 0x98
	[SerializeField]
	private SimpleContextMenu _dialogueListContextMenu; //Field offset: 0xA0
	[SerializeField]
	private SimpleContextMenu _channelContextMenu; //Field offset: 0xA8
	[SerializeField]
	private CustomTextMeshProUGUI _dialogueHeaderLabel; //Field offset: 0xB0
	[SerializeField]
	private CustomTextMeshProUGUI _dialogueUsersCountLabel; //Field offset: 0xB8
	[SerializeField]
	private GameObject _showForGroupDialogue; //Field offset: 0xC0
	[SerializeField]
	private GameObject _emptyDialoguesPlaceholder; //Field offset: 0xC8
	private SocialNetwork _social; //Field offset: 0xD0
	private Action _onTransferAll; //Field offset: 0xD8
	private Action _onSelected; //Field offset: 0xE0
	private Action _onRemoved; //Field offset: 0xE8

	public DialoguesContainer() { }

	private bool DialogueDataFromDialogue(UpdatableChatDialogue dialogue, out DialogueData dialogueData) { }

	private void OnDialogueRemovedHandler(UpdatableChatDialogue dialogue) { }

	private void OnDialogueSelectedHandler(bool arg, UpdatableChatDialogue dialogue, DialogueView view) { }

	private void PinButtonPressedHandler(bool status, UpdatableChatDialogue item) { }

	public void Show(SocialNetwork social, Predicate filterPredicate, Action onTransferAll, Action onSelected, Action onRemoved) { }

	private void Update() { }

	[AsyncStateMachine(typeof(<UpdateDialogueListAsync>d__20))]
	private Task UpdateDialogueListAsync() { }

}

