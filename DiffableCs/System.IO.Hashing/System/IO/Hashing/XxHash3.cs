namespace System.IO.Hashing;

public sealed class XxHash3 : NonCryptographicHashAlgorithm
{
	private State _state; //Field offset: 0x18

	public XxHash3() { }

	public XxHash3(long seed) { }

	public virtual void Append(ReadOnlySpan source) { }

	[CLSCompliant(False)]
	public ulong GetCurrentHashAsUInt64() { }

	private static ulong HashLength0To16(byte* source, uint length, ulong seed) { }

	private static ulong HashLength129To240(byte* source, uint length, ulong seed) { }

	private static ulong HashLength17To128(byte* source, uint length, ulong seed) { }

	private static ulong HashLength1To3(byte* source, uint length, ulong seed) { }

	private static ulong HashLength4To8(byte* source, uint length, ulong seed) { }

	private static ulong HashLength9To16(byte* source, uint length, ulong seed) { }

	private static ulong HashLengthOver240(byte* source, uint length, ulong seed) { }

	[CLSCompliant(False)]
	public static ulong HashToUInt64(ReadOnlySpan source, long seed = 0) { }

	public virtual void Reset() { }

}

