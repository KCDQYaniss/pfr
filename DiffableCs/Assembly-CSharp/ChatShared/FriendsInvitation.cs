namespace ChatShared;

public class FriendsInvitation
{
	[JsonProperty("_id")]
	public string _id; //Field offset: 0x10
	[JsonProperty("from")]
	public UpdatableChatMember From; //Field offset: 0x18
	[JsonProperty("to")]
	public UpdatableChatMember To; //Field offset: 0x20
	[JsonProperty("date")]
	public double Date; //Field offset: 0x28
	[JsonProperty("profile")]
	public UpdatableChatMember Profile; //Field offset: 0x30

	public FriendsInvitation() { }

}

