namespace EFT;

public class GroupInviteResponse
{
	[JsonProperty("requestId")]
	public string requestId; //Field offset: 0x10
	[JsonProperty("invitedMember")]
	public GroupPlayer groupPlayer; //Field offset: 0x18

	public GroupInviteResponse() { }

}

