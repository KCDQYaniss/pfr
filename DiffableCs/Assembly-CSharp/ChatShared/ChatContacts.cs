namespace ChatShared;

public class ChatContacts
{
	[JsonProperty("friends")]
	public UpdatableChatMember[] EftFriends; //Field offset: 0x10
	[JsonProperty("ignore")]
	public string[] Ignore; //Field offset: 0x18
	[JsonProperty("inIgnoreList")]
	public string[] InIgnoreList; //Field offset: 0x20
	[JsonProperty("incomingRequestList")]
	public FriendsInvitation[] IncomingRequestList; //Field offset: 0x28
	[JsonProperty("sentRequestList")]
	public FriendsInvitation[] SentRequestList; //Field offset: 0x30
	[JsonProperty("steamFriendList")]
	public UpdatableChatMember[] SteamFriendList; //Field offset: 0x38

	public ChatContacts() { }

}

