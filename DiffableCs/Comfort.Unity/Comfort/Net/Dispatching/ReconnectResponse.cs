namespace Comfort.Net.Dispatching;

public struct ReconnectResponse
{
	public ulong Received; //Field offset: 0x0

	public static ReconnectResponse Load(BinaryReader reader) { }

	public void Save(BinaryWriter writer) { }

}

