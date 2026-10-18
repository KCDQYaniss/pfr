namespace System.Buffers.Text;

internal static class Number
{
	private static readonly ulong[] s_rgval64Power10; //Field offset: 0x0
	private static readonly sbyte[] s_rgexp64Power10; //Field offset: 0x8
	private static readonly ulong[] s_rgval64Power10By16; //Field offset: 0x10
	private static readonly short[] s_rgexp64Power10By16; //Field offset: 0x18

	private static Number() { }

	public static void DecimalToNumber(decimal value, ref NumberBuffer number) { }

	public static void RoundNumber(ref NumberBuffer number, int pos) { }

}

