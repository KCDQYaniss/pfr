namespace Mirror;

public static class DeltaCompression
{

	public static void Compress(NetworkWriter writer, long last, long current) { }

	public static void Compress(NetworkWriter writer, Vector3Long last, Vector3Long current) { }

	public static long Decompress(NetworkReader reader, long last) { }

	public static Vector3Long Decompress(NetworkReader reader, Vector3Long last) { }

}

