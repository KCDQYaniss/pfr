namespace ChatShared;

public class UpdatableChatDialogue : IUpdatable
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__37_0; //Field offset: 0x8
		public static Func <>9__41_0; //Field offset: 0x10
		public static Func <>9__41_1; //Field offset: 0x18
		public static Comparison <>9__43_1; //Field offset: 0x20

		private static <>c() { }

		public <>c() { }

		internal bool <.ctor>b__41_0(UpdatableChatMember x) { }

		internal UpdatableChatMember <.ctor>b__41_1(string id) { }

		internal bool <get_AnyRewardMessage>b__37_0(DialogueChatMessage x) { }

		internal int <UpdateDialogMessages>b__43_1(DialogueChatMessage a, DialogueChatMessage b) { }

	}

	public BindableEvent OnDialogueSelected; //Field offset: 0x10
	public BindableEvent OnDialogueRemoved; //Field offset: 0x18
	public BindableEvent OnDialoguePinStatusChanged; //Field offset: 0x20
	public BindableEvent OnLastMessageUpdated; //Field offset: 0x28
	public BindableEvent OnDialogueLoadingStatus; //Field offset: 0x30
	public BindableEvent OnDialogueAttachmentsChanged; //Field offset: 0x38
	public string _id; //Field offset: 0x40
	public EMessageType Type; //Field offset: 0x48
	public DialogueChatMessage Message; //Field offset: 0x50
	public Nullable DeleteTime; //Field offset: 0x58
	public int New; //Field offset: 0x68
	public int AttachmentsNew; //Field offset: 0x6C
	public UpdatableChatMember Profile; //Field offset: 0x70
	public string Owner; //Field offset: 0x78
	public string Name; //Field offset: 0x80
	public bool Pinned; //Field offset: 0x88
	public UpdatableBindableList ActiveUsers; //Field offset: 0x90
	public LinkedList SessionMentionedUsers; //Field offset: 0x98
	public UpdatableBindableList ChatMessages; //Field offset: 0xA0
	public Nullable DialogueInvitationMessageData; //Field offset: 0xA8
	private bool _hasMessagesWithRewards; //Field offset: 0xF0
	[CompilerGenerated]
	private bool <MessagesLoaded>k__BackingField; //Field offset: 0xF1
	[CompilerGenerated]
	private bool <FullyRead>k__BackingField; //Field offset: 0xF2
	[CompilerGenerated]
	private bool <Updating>k__BackingField; //Field offset: 0xF3

	public bool AnyRewardMessage
	{
		 get { } //Length: 386
	}

	public private bool FullyRead
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public bool HasMessagesWithRewards
	{
		 get { } //Length: 8
		 set { } //Length: 65
	}

	public bool IsMultiUsersDialog
	{
		 get { } //Length: 113
	}

	public private bool MessagesLoaded
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public private bool Updating
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public UpdatableChatDialogue() { }

	public UpdatableChatDialogue(ChatRoomInformation info, UpdatableChatMember playerMember, UpdatableBindableList messages = null) { }

	[CompilerGenerated]
	private void <UpdateDialogMessages>b__43_0(Result result) { }

	public bool CanSendMessage(bool isFriend, out string error) { }

	public override bool Compare(UpdatableChatDialogue other) { }

	public bool get_AnyRewardMessage() { }

	[CompilerGenerated]
	public bool get_FullyRead() { }

	public bool get_HasMessagesWithRewards() { }

	public bool get_IsMultiUsersDialog() { }

	[CompilerGenerated]
	public bool get_MessagesLoaded() { }

	[CompilerGenerated]
	public bool get_Updating() { }

	private List MergeUniqueMessages(DialogueChatMessage[] newMessages) { }

	public void RemoveDialogue() { }

	private void RemoveDuplicateMessages() { }

	public void SelectDialogue(bool value) { }

	[CompilerGenerated]
	private void set_FullyRead(bool value) { }

	public void set_HasMessagesWithRewards(bool value) { }

	[CompilerGenerated]
	private void set_MessagesLoaded(bool value) { }

	[CompilerGenerated]
	private void set_Updating(bool value) { }

	private static void TryAddUniqueMessage(List uniqueMessages, HashSet seenIds, DialogueChatMessage message) { }

	public void UpdateDialogMessages(ISocial session, double time) { }

	public override void UpdateFromAnotherItem(UpdatableChatDialogue other) { }

}

