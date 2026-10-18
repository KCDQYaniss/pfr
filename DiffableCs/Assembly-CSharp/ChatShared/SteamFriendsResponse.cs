namespace ChatShared;

public class SteamFriendsResponse
{
	[JsonProperty("steamFriendList")]
	public UpdatableChatMember[] SteamFriendList; //Field offset: 0x10

	public SteamFriendsResponse() { }

}

