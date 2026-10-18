//Type is in global namespace

public class Crc32
{
	private static uint[] crc_32_tab; //Field offset: 0x0
	private uint _crc32; //Field offset: 0x10

	internal uint CheckSum
	{
		internal get { } //Length: 164
		internal set { } //Length: 4
	}

	private static Crc32() { }

	public Crc32() { }

	internal uint AddToCRC32(int c) { }

	internal uint AddToCRC32(ushort c) { }

	public static uint CRC32Bytes(byte[] bytes) { }

	public static uint CRC32BytesPHP(byte[] bytes) { }

	public static uint CRC32String(string text) { }

	internal uint get_CheckSum() { }

	internal void set_CheckSum(uint value) { }

	private static uint UPDC32(byte octet, uint crc) { }

}

