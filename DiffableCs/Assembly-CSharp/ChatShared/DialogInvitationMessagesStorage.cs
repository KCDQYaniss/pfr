namespace ChatShared;

public sealed class DialogInvitationMessagesStorage
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass7_0
	{
		public string questId; //Field offset: 0x10

		public <>c__DisplayClass7_0() { }

		internal bool <RemoveMessageDataByQuestId>b__0(DialogInvitationMessageData data) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass9_0
	{
		public EDialogEntryPoint entryPoint; //Field offset: 0x10

		public <>c__DisplayClass9_0() { }

		internal bool <TraderHasDialogueWithStartMethod>b__0(DialogInvitationMessageData messageData) { }

	}

	private static readonly Lazy _instance; //Field offset: 0x0
	private readonly Dictionary _traderDialogInvitationMessagesData; //Field offset: 0x10

	public bool HasAnyMessages
	{
		 get { } //Length: 154
	}

	public static DialogInvitationMessagesStorage Instance
	{
		 get { } //Length: 121
	}

	private static DialogInvitationMessagesStorage() { }

	public DialogInvitationMessagesStorage() { }

	public void AddMessageData(DialogInvitationMessageData data) { }

	public void Clear() { }

	public bool get_HasAnyMessages() { }

	public static DialogInvitationMessagesStorage get_Instance() { }

	public Nullable GetFirstInvitationWithStartMethod(EDialogEntryPoint entryPoint) { }

	public List GetMessagesDataBySenderId(string traderId) { }

	public void RemoveMessageDataByQuestId(string traderId, string questId) { }

	public bool TraderHasDialogueWithStartMethod(string traderId, EDialogEntryPoint entryPoint, out List messageDataList) { }

	public bool TraderHasMessageData(string traderId) { }

}

