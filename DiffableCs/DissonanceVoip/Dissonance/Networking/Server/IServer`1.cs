namespace Dissonance.Networking.Server;

internal interface IServer`1
{

	public uint SessionId
	{
		 get { } //Length: 0
	}

	public void AddClient(ClientInfo client) { }

	public uint get_SessionId() { }

	public void SendReliable(TPeer connection, ArraySegment packet) { }

	public void SendReliable(List connections, ArraySegment packet) { }

	public void SendUnreliable(List connections, ArraySegment packet) { }

}

