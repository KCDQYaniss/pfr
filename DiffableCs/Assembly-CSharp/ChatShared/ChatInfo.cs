namespace ChatShared;

[Obfuscation(Exclude = True)]
public class ChatInfo
{
	public string Id; //Field offset: 0x10
	public string Name; //Field offset: 0x18
	public ChatRoomMember[] Members; //Field offset: 0x20

	public ChatInfo() { }

}

