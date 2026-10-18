namespace Comfort.Net.Dispatching;

public struct AttachResponse
{
	public readonly long Token; //Field offset: 0x0

	public AttachResponse(long token) { }

	public static AttachResponse Load(BinaryReader reader) { }

	public void Save(BinaryWriter writer) { }

}

