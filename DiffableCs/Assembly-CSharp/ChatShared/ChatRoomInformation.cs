namespace ChatShared;

public class ChatRoomInformation
{
	[JsonProperty("_id")]
	public string Id; //Field offset: 0x10
	public float deleteTime; //Field offset: 0x18
	public int type; //Field offset: 0x1C
	public DialogueChatMessage message; //Field offset: 0x20
	public int new; //Field offset: 0x28
	public int attachmentsNew; //Field offset: 0x2C
	public bool pinned; //Field offset: 0x30
	public string Owner; //Field offset: 0x38
	public string Name; //Field offset: 0x40
	public UpdatableChatMember[] Users; //Field offset: 0x48

	public ChatRoomInformation() { }

}

