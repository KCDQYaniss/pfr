namespace ChatShared;

public class ChatMessagesList
{
	internal class ChatMessageAttachmentSerializer : ISerializer
	{
		[CompilerGenerated]
		private sealed class <>c
		{
			public static readonly <>c <>9; //Field offset: 0x0
			public static Func <>9__8_0; //Field offset: 0x8

			private static <>c() { }

			public <>c() { }

			internal bool <Deserialize>b__8_0(FlatItem x) { }

		}

		[CompilerGenerated]
		private MongoID <StashId>k__BackingField; //Field offset: 0x10
		[CompilerGenerated]
		private FlatItem[] <Items>k__BackingField; //Field offset: 0x28

		[JsonProperty("data")]
		public private FlatItem[] Items
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			private set { } //Length: 82
		}

		[JsonProperty("stash")]
		public private MongoID StashId
		{
			[CompilerGenerated]
			 get { } //Length: 21
			[CompilerGenerated]
			private set { } //Length: 98
		}

		public ChatMessageAttachmentSerializer() { }

		public override ChatMessageItems Deserialize() { }

		[CompilerGenerated]
		public FlatItem[] get_Items() { }

		[CompilerGenerated]
		public MongoID get_StashId() { }

		public override object Serialize(ChatMessageItems t) { }

		[CompilerGenerated]
		private void set_Items(FlatItem[] value) { }

		[CompilerGenerated]
		private void set_StashId(MongoID value) { }

	}

	internal class ChatMessageParamsSerializer : ISerializer
	{
		[CompilerGenerated]
		private sealed class <>c
		{
			public static readonly <>c <>9; //Field offset: 0x0
			public static Func <>9__6_0; //Field offset: 0x8

			private static <>c() { }

			public <>c() { }

			internal UpdatableChatMember <GetChatMember>b__6_0(string id) { }

		}

		public string Action; //Field offset: 0x10
		public string uid; //Field offset: 0x18
		public string uid2; //Field offset: 0x20
		public string[] users; //Field offset: 0x28
		public UpdatableChatMember profile; //Field offset: 0x30

		public ChatMessageParamsSerializer() { }

		public override ChatMessageParams Deserialize() { }

		private UpdatableChatMember GetChatMember(string memberId) { }

		public override object Serialize(ChatMessageParams t) { }

	}

	internal class DialogueChatMessageSerializer : ISerializer
	{
		[CompilerGenerated]
		private sealed class <>c
		{
			public static readonly <>c <>9; //Field offset: 0x0
			public static Func <>9__13_1; //Field offset: 0x8

			private static <>c() { }

			public <>c() { }

			internal UpdatableChatMember <Deserialize>b__13_1(string id) { }

		}

		public string _id; //Field offset: 0x10
		public string templateId; //Field offset: 0x18
		public ChatMessageSystemData systemData; //Field offset: 0x20
		public int type; //Field offset: 0x28
		public string text; //Field offset: 0x30
		public double dt; //Field offset: 0x38
		public string uid; //Field offset: 0x40
		public bool hasRewards; //Field offset: 0x48
		public long maxStorageTime; //Field offset: 0x50
		public DialogueChatMessage replyTo; //Field offset: 0x58
		public ChatMessageParams params; //Field offset: 0x60
		public ChatMessageItems items; //Field offset: 0x68
		public ProfileChangeEvent[] ProfileChangeEvents; //Field offset: 0x70

		public DialogueChatMessageSerializer() { }

		[CompilerGenerated]
		private DialogueChatMessage <Deserialize>b__13_0() { }

		[CompilerGenerated]
		private void <Deserialize>b__13_2(ProfileChangeEvent event) { }

		public override DialogueChatMessage Deserialize() { }

		public override object Serialize(DialogueChatMessage t) { }

	}

	public DialogueChatMessage[] messages; //Field offset: 0x10
	public UpdatableChatMember[] profiles; //Field offset: 0x18
	public bool hasMessagesWithRewards; //Field offset: 0x20

	public ChatMessagesList() { }

}

