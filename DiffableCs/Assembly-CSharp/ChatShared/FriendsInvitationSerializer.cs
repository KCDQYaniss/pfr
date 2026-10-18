namespace ChatShared;

public class FriendsInvitationSerializer : ISerializer
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__5_0; //Field offset: 0x8
		public static Func <>9__5_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal UpdatableChatMember <Deserialize>b__5_0(string id) { }

		internal UpdatableChatMember <Deserialize>b__5_1(string id) { }

	}

	[JsonProperty("_id")]
	public string _id; //Field offset: 0x10
	[JsonProperty("from")]
	public string from; //Field offset: 0x18
	[JsonProperty("to")]
	public string to; //Field offset: 0x20
	[JsonProperty("date")]
	public double date; //Field offset: 0x28
	[JsonProperty("profile")]
	public UpdatableChatMember profile; //Field offset: 0x30

	public FriendsInvitationSerializer() { }

	public override FriendsInvitation Deserialize() { }

	public override object Serialize(FriendsInvitation t) { }

}

