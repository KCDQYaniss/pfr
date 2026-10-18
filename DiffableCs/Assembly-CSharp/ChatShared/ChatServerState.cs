namespace ChatShared;

public sealed class ChatServerState
{
	[JsonProperty("_id")]
	public string ServerId; //Field offset: 0x10
	public int RegistrationId; //Field offset: 0x18
	public string VersionId; //Field offset: 0x20
	public string Ip; //Field offset: 0x28
	public int Port; //Field offset: 0x30
	public DateTime DateTime; //Field offset: 0x38
	public ChatRoomState[] Chats; //Field offset: 0x40
	public string[] Regions; //Field offset: 0x48

	public ChatServerState() { }

}

