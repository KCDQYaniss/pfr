namespace System.IO.Hashing;

internal static class XxHashShared
{
	internal struct State
	{
		[CompilerGenerated]
		[UnsafeValueType]
		internal struct <Accumulators>e__FixedBuffer
		{
			public ulong FixedElementField; //Field offset: 0x0

		}

		[CompilerGenerated]
		[UnsafeValueType]
		internal struct <Buffer>e__FixedBuffer
		{
			public byte FixedElementField; //Field offset: 0x0

		}

		[CompilerGenerated]
		[UnsafeValueType]
		internal struct <Secret>e__FixedBuffer
		{
			public byte FixedElementField; //Field offset: 0x0

		}

		[FixedBuffer(typeof(ulong), 8)]
		internal <Accumulators>e__FixedBuffer Accumulators; //Field offset: 0x0
		[FixedBuffer(typeof(byte), 192)]
		internal <Secret>e__FixedBuffer Secret; //Field offset: 0x40
		[FixedBuffer(typeof(byte), 256)]
		internal <Buffer>e__FixedBuffer Buffer; //Field offset: 0x100
		internal uint BufferedCount; //Field offset: 0x200
		internal ulong StripesProcessedInCurrentBlock; //Field offset: 0x208
		internal ulong TotalLength; //Field offset: 0x210
		internal ulong Seed; //Field offset: 0x218

	}


	public static ReadOnlySpan DefaultSecret
	{
		 get { } //Length: 86
	}

	private static void Accumulate(ulong* accumulators, byte* source, byte* secret, int stripesToProcess, bool scramble = false, int blockCount = 1) { }

	public static void Accumulate512(ulong* accumulators, byte* source, byte* secret) { }

	private static void Accumulate512Inlined(ulong* accumulators, byte* source, byte* secret) { }

	public static void Append(ref State state, ReadOnlySpan source) { }

	public static ulong Avalanche(ulong hash) { }

	public static void ConsumeStripes(ulong* accumulators, ref ulong stripesSoFar, ulong stripesPerBlock, byte* source, ulong stripes, byte* secret) { }

	public static void CopyAccumulators(ref State state, ulong* accumulators) { }

	public static void DeriveSecretFromSeed(byte* destinationSecret, ulong seed) { }

	public static void DigestLong(ref State state, ulong* accumulators, byte* secret) { }

	public static ReadOnlySpan get_DefaultSecret() { }

	public static void HashInternalLoop(ulong* accumulators, byte* source, uint length, byte* secret) { }

	public static void Initialize(ref State state, ulong seed) { }

	public static void InitializeAccumulators(ulong* accumulators) { }

	public static ulong MergeAccumulators(ulong* accumulators, byte* secret, ulong start) { }

	public static ulong Mix16Bytes(byte* source, ulong secretLow, ulong secretHigh, ulong seed) { }

	public static ulong Multiply32To64(uint v1, uint v2) { }

	public static ulong Multiply64To128(ulong left, ulong right, out ulong lower) { }

	public static ulong Multiply64To128ThenFold(ulong left, ulong right) { }

	public static uint ReadUInt32LE(byte* data) { }

	public static ulong ReadUInt64LE(byte* data) { }

	public static void Reset(ref State state) { }

	public static ulong Rrmxmx(ulong hash, uint length) { }

	private static void ScrambleAccumulators(ulong* accumulators, byte* secret) { }

	private static void WriteUInt64LE(byte* data, ulong value) { }

	public static ulong XorShift(ulong value, int shift) { }

}

