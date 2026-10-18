namespace System.Runtime.Serialization.Formatters.Binary;

internal sealed class BinaryObjectWithMapTyped
{
	internal BinaryHeaderEnum binaryHeaderEnum; //Field offset: 0x10
	internal int objectId; //Field offset: 0x14
	internal string name; //Field offset: 0x18
	internal int numMembers; //Field offset: 0x20
	internal string[] memberNames; //Field offset: 0x28
	internal BinaryTypeEnum[] binaryTypeEnumA; //Field offset: 0x30
	internal object[] typeInformationA; //Field offset: 0x38
	internal int[] memberAssemIds; //Field offset: 0x40
	internal int assemId; //Field offset: 0x48

	internal BinaryObjectWithMapTyped() { }

	internal BinaryObjectWithMapTyped(BinaryHeaderEnum binaryHeaderEnum) { }

	public override void Read(__BinaryParser input) { }

	internal void Set(int objectId, string name, int numMembers, string[] memberNames, BinaryTypeEnum[] binaryTypeEnumA, object[] typeInformationA, int[] memberAssemIds, int assemId) { }

	public override void Write(__BinaryWriter sout) { }

}

