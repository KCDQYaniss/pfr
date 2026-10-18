namespace EFT;

[Extension]
public static class MongoIdBinaryConverter
{

	[Extension]
	public static MongoID ReadMongoId(NetworkReader reader) { }

	[Extension]
	public static MongoID ReadMongoId(BinaryReader reader) { }

	[Extension]
	public static Nullable ReadNullableMongoId(NetworkReader reader) { }

	[Extension]
	public static void Serialize(IBitStream stream, ref MongoID mongoID) { }

	[Extension]
	public static void WriteMongoId(NetworkWriter writer, MongoID mongoId) { }

	[Extension]
	public static void WriteMongoId(BinaryWriter writer, MongoID mongoId) { }

	[Extension]
	public static void WriteNullableMongoId(NetworkWriter writer, Nullable mongoId) { }

}

