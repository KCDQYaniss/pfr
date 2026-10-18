namespace ChatShared;

[Obfuscation(Exclude = True)]
public class ChatRoomMember
{
	internal class MemberInfo
	{
		public string Nickname; //Field offset: 0x10
		public EChatMemberSide Side; //Field offset: 0x18
		public int Level; //Field offset: 0x1C
		public int PrestigeLevel; //Field offset: 0x20
		public EGameMode PrestigeGameMode; //Field offset: 0x24
		public EMemberCategory MemberCategory; //Field offset: 0x28
		public EMemberCategory SelectedMemberCategory; //Field offset: 0x2C
		public DateTime GlobalMuteTime; //Field offset: 0x30

		public MemberInfo() { }

	}

	[JsonProperty("_id")]
	public string Id; //Field offset: 0x10
	[JsonProperty("aid")]
	public string Aid; //Field offset: 0x18
	public MemberInfo Info; //Field offset: 0x20

	public ChatRoomMember() { }

}

