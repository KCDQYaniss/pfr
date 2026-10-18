namespace Dissonance.Networking;

internal interface IClientCollection`1
{

	[ContractAnnotation("=> true, info:notnull; => false, info:null")]
	public bool TryGetClientInfoById(ushort clientId, out ClientInfo info) { }

	[ContractAnnotation("=> true, info:notnull; => false, info:null")]
	public bool TryGetClientInfoByName(string clientName, out ClientInfo info) { }

	[ContractAnnotation("=> true, clients:notnull; => false, clients:null")]
	public bool TryGetClientsInRoom(string room, out List clients) { }

	[ContractAnnotation("=> true, clients:notnull; => false, clients:null")]
	public bool TryGetClientsInRoom(ushort roomId, out List clients) { }

}

