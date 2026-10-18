namespace Koenigz.PerfectCulling.EFT;

[PreferBinarySerialization]
public sealed class CullingGroupData : IBinarySerializable
{
	public ushort[] Indices; //Field offset: 0x10
	public ushort RuntimeCullingGroupIdx; //Field offset: 0x18
	public HashSet BuildTimeIndices; //Field offset: 0x20

	public CullingGroupData() { }

	public override void Read(BinaryReader reader) { }

	public override void Write(BinaryWriter writer) { }

}

