namespace Comfort.Communication.Core;

public struct CommunicationId
{
	public static readonly CommunicationId None; //Field offset: 0x0
	public readonly long RegistryId; //Field offset: 0x0
	public readonly long Index; //Field offset: 0x8

	private static CommunicationId() { }

	public CommunicationId(long registryId, long index) { }

	public static CommunicationId Deserialize(BinaryReader reader) { }

	public void Serialize(BinaryWriter writer) { }

	public bool Valid() { }

}

