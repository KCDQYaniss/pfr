namespace Dissonance;

public struct RoomMembership
{
	private readonly string _name; //Field offset: 0x0
	private readonly ushort _roomId; //Field offset: 0x8
	internal int Count; //Field offset: 0xC

	public ushort RoomId
	{
		 get { } //Length: 5
	}

	[NotNull]
	public string RoomName
	{
		 get { } //Length: 4
	}

	internal RoomMembership(string name, int count) { }

	public ushort get_RoomId() { }

	public string get_RoomName() { }

}

