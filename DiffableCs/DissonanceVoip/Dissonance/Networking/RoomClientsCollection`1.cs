namespace Dissonance.Networking;

internal class RoomClientsCollection`1
{
	private class ClientIdComparer : IComparer
	{

		public ClientIdComparer() { }

		public override int Compare(ClientInfo x, ClientInfo y) { }

	}

	private static readonly IComparer ClientComparer; //Field offset: 0x0
	private readonly Dictionary _clientByRoomName; //Field offset: 0x0
	private readonly Dictionary _clientByRoomId; //Field offset: 0x0

	public Dictionary ByName
	{
		 get { } //Length: 5
	}

	private static RoomClientsCollection`1() { }

	public RoomClientsCollection`1() { }

	public void Add(string room, ClientInfo client) { }

	public void Clear() { }

	public int ClientCount() { }

	public Dictionary get_ByName() { }

	public bool Remove(string room, ClientInfo client) { }

	[ContractAnnotation("=> true, clients:notnull; => false, clients:null")]
	public bool TryGetClientsInRoom(string room, out List clients) { }

	[ContractAnnotation("=> true, clients:notnull; => false, clients:null")]
	public bool TryGetClientsInRoom(ushort roomId, out List clients) { }

}

