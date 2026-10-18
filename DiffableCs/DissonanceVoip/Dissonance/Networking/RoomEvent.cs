namespace Dissonance.Networking;

public struct RoomEvent
{
	public string PlayerName; //Field offset: 0x0
	public string Room; //Field offset: 0x8
	public bool Joined; //Field offset: 0x10
	internal ReadOnlyCollection Rooms; //Field offset: 0x18

	internal RoomEvent(string name, string room, bool joined, ReadOnlyCollection rooms) { }

}

