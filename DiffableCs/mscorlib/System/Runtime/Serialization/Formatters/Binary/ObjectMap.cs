namespace System.Runtime.Serialization.Formatters.Binary;

internal sealed class ObjectMap
{
	internal string objectName; //Field offset: 0x10
	internal Type objectType; //Field offset: 0x18
	internal BinaryTypeEnum[] binaryTypeEnumA; //Field offset: 0x20
	internal object[] typeInformationA; //Field offset: 0x28
	internal Type[] memberTypes; //Field offset: 0x30
	internal string[] memberNames; //Field offset: 0x38
	internal ReadObjectInfo objectInfo; //Field offset: 0x40
	internal bool isInitObjectInfo; //Field offset: 0x48
	internal ObjectReader objectReader; //Field offset: 0x50
	internal int objectId; //Field offset: 0x58
	internal BinaryAssemblyInfo assemblyInfo; //Field offset: 0x60

	internal ObjectMap(string objectName, Type objectType, string[] memberNames, ObjectReader objectReader, int objectId, BinaryAssemblyInfo assemblyInfo) { }

	internal ObjectMap(string objectName, string[] memberNames, BinaryTypeEnum[] binaryTypeEnumA, object[] typeInformationA, int[] memberAssemIds, ObjectReader objectReader, int objectId, BinaryAssemblyInfo assemblyInfo, SizedArray assemIdToAssemblyTable) { }

	internal static ObjectMap Create(string name, Type objectType, string[] memberNames, ObjectReader objectReader, int objectId, BinaryAssemblyInfo assemblyInfo) { }

	internal static ObjectMap Create(string name, string[] memberNames, BinaryTypeEnum[] binaryTypeEnumA, object[] typeInformationA, int[] memberAssemIds, ObjectReader objectReader, int objectId, BinaryAssemblyInfo assemblyInfo, SizedArray assemIdToAssemblyTable) { }

	internal ReadObjectInfo CreateObjectInfo(ref SerializationInfo si, ref object[] memberData) { }

}

