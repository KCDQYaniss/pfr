namespace Comfort.Net.Dispatching;

public struct ConnectResponse
{
	public readonly long ConnectionId; //Field offset: 0x0
	public readonly SessionResponse SessionResponse; //Field offset: 0x8

	public ConnectResponse(long connectionId, SessionResponse sessionResponse) { }

	public static ConnectResponse Load(BinaryReader reader) { }

	public void Save(BinaryWriter writer) { }

}

