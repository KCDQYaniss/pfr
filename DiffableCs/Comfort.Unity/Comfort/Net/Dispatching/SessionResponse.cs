namespace Comfort.Net.Dispatching;

public struct SessionResponse
{
	public readonly long SessionId; //Field offset: 0x0
	public readonly byte[] Data; //Field offset: 0x8

	public SessionResponse(long sessionId, byte[] data) { }

	public static SessionResponse Load(BinaryReader reader) { }

	public void Save(BinaryWriter writer) { }

}

