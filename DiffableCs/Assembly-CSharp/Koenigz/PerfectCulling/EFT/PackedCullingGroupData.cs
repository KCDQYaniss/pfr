namespace Koenigz.PerfectCulling.EFT;

public sealed class PackedCullingGroupData
{
	public ushort numIndices; //Field offset: 0x10
	public byte[] compressedIndexArray; //Field offset: 0x18

	public long Size
	{
		 get { } //Length: 50
	}

	public PackedCullingGroupData() { }

	public long get_Size() { }

}

