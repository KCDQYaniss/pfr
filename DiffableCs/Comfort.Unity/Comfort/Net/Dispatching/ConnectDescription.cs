namespace Comfort.Net.Dispatching;

public struct ConnectDescription
{
	public string TransportEdition; //Field offset: 0x0
	public string ConnectEdition; //Field offset: 0x8
	public string ClientId; //Field offset: 0x10
	public string VersionId; //Field offset: 0x18

	public static ConnectDescription Read(BinaryReader reader) { }

	public void Write(BinaryWriter writer) { }

}

