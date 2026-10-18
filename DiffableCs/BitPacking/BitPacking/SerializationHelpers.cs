namespace BitPacking;

[Extension]
public static class SerializationHelpers
{

	[Extension]
	public static void Serialize(IBitStream stream, ref float value, LimitedFloatSerializationSettings settings) { }

	[Extension]
	public static void Serialize(IBitStream stream, ref int value, LimitedIntSerializationSettings settings) { }

}

