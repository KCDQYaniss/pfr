namespace ChatShared;

public class UpdatableChatMemberSerializer : ChatRoomMember, ISerializer
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__1_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal UpdatableChatMember <EFT.ISerializer<ChatShared.UpdatableChatMember>.Deserialize>b__1_0(string id) { }

	}

	[JsonProperty("pinned")]
	public Nullable pinned; //Field offset: 0x28

	public UpdatableChatMemberSerializer() { }

	private override UpdatableChatMember EFT.ISerializer<ChatShared.UpdatableChatMember>.Deserialize() { }

	public override object Serialize(UpdatableChatMember t) { }

}

