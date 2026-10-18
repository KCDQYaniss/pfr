namespace Unity.Collections;

[BurstCompile]
[GenerateTestsForBurstCompatibility]
[GenerateTestsForBurstCompatibility]
[GenerateTestsForBurstCompatibility]
public static class xxHash3
{
	public static class Hash128Long_00000A71$BurstDirectCall
	{
		private static IntPtr Pointer; //Field offset: 0x0
		private static IntPtr DeferredCompilation; //Field offset: 0x8

		private static Hash128Long_00000A71$BurstDirectCall() { }

		public static void Constructor() { }

		private static IntPtr GetFunctionPointer() { }

		[BurstDiscard]
		private static void GetFunctionPointerDiscard(ref IntPtr unnamed_param_0) { }

		public static void Initialize() { }

		public static void Invoke(byte* input, byte* dest, long length, byte* secret, out uint4 result) { }

	}

	internal sealed class Hash128Long_00000A71$PostfixBurstDelegate : MulticastDelegate
	{

		public Hash128Long_00000A71$PostfixBurstDelegate(object unnamed_param_0, IntPtr unnamed_param_1) { }

		public override IAsyncResult BeginInvoke(byte* input, byte* dest, long length, byte* secret, out uint4 result, AsyncCallback unnamed_param_5, object unnamed_param_6) { }

		public override void EndInvoke(IAsyncResult unnamed_param_0) { }

		public override void Invoke(byte* input, byte* dest, long length, byte* secret, out uint4 result) { }

	}

	public static class Hash64Long_00000A6A$BurstDirectCall
	{
		private static IntPtr Pointer; //Field offset: 0x0
		private static IntPtr DeferredCompilation; //Field offset: 0x8

		private static Hash64Long_00000A6A$BurstDirectCall() { }

		public static void Constructor() { }

		private static IntPtr GetFunctionPointer() { }

		[BurstDiscard]
		private static void GetFunctionPointerDiscard(ref IntPtr unnamed_param_0) { }

		public static void Initialize() { }

		public static ulong Invoke(byte* input, byte* dest, long length, byte* secret) { }

	}

	internal sealed class Hash64Long_00000A6A$PostfixBurstDelegate : MulticastDelegate
	{

		public Hash64Long_00000A6A$PostfixBurstDelegate(object unnamed_param_0, IntPtr unnamed_param_1) { }

		public override IAsyncResult BeginInvoke(byte* input, byte* dest, long length, byte* secret, AsyncCallback unnamed_param_4, object unnamed_param_5) { }

		public override ulong EndInvoke(IAsyncResult unnamed_param_0) { }

		public override ulong Invoke(byte* input, byte* dest, long length, byte* secret) { }

	}

	[GenerateTestsForBurstCompatibility]
	internal struct StreamingState
	{
		private struct StreamingStateData
		{
			public ulong Acc; //Field offset: 0x0
			public byte Buffer; //Field offset: 0x40
			public int IsHash64; //Field offset: 0x140
			public int BufferedSize; //Field offset: 0x144
			public int NbStripesSoFar; //Field offset: 0x148
			public long TotalLength; //Field offset: 0x150
			public ulong Seed; //Field offset: 0x158
			public byte SecretKey; //Field offset: 0x160
			public byte _PadEnd; //Field offset: 0x21C

		}

		private static readonly int SECRET_LIMIT; //Field offset: 0x0
		private static readonly int NB_STRIPES_PER_BLOCK; //Field offset: 0x4
		private static readonly int INTERNAL_BUFFER_SIZE; //Field offset: 0x8
		private static readonly int INTERNAL_BUFFER_STRIPES; //Field offset: 0xC
		private StreamingStateData State; //Field offset: 0x0

		private ulong* Acc
		{
			[DebuggerStepThrough]
			private get { } //Length: 4
		}

		private byte* Buffer
		{
			[DebuggerStepThrough]
			private get { } //Length: 5
		}

		private byte* SecretKey
		{
			[DebuggerStepThrough]
			private get { } //Length: 8
		}

		private static StreamingState() { }

		public StreamingState(bool isHash64, ulong seed = 0) { }

		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		[Conditional("UNITY_DOTS_DEBUG")]
		private void CheckKeySize(int isHash64) { }

		private void ConsumeStripes(ulong* acc, ref int nbStripesSoFar, byte* input, long totalStripes, byte* secret, int isHash64) { }

		public uint4 DigestHash128() { }

		public uint2 DigestHash64() { }

		private void DigestLong(ulong* acc, byte* secret, int isHash64) { }

		[DebuggerStepThrough]
		private ulong* get_Acc() { }

		[DebuggerStepThrough]
		private byte* get_Buffer() { }

		[DebuggerStepThrough]
		private byte* get_SecretKey() { }

		public void Reset(bool isHash64, ulong seed = 0) { }

		public void Update(void* input, int length) { }

		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
		public void Update(in T input) { }

	}

	private struct ulong2
	{
		public ulong x; //Field offset: 0x0
		public ulong y; //Field offset: 0x8

		public ulong2(ulong x, ulong y) { }

	}

	private const int STRIPE_LEN = 64; //Field offset: 0x0
	private const int MIDSIZE_STARTOFFSET = 3; //Field offset: 0x0
	private const int MIDSIZE_MAX = 240; //Field offset: 0x0
	private const ulong PRIME64_5 = 2870177450012600261; //Field offset: 0x0
	private const ulong PRIME64_4 = 9650029242287828579; //Field offset: 0x0
	private const ulong PRIME64_3 = 1609587929392839161; //Field offset: 0x0
	private const ulong PRIME64_2 = 14029467366897019727; //Field offset: 0x0
	private const ulong PRIME64_1 = 11400714785074694791; //Field offset: 0x0
	private const uint PRIME32_5 = 374761393; //Field offset: 0x0
	private const int MIDSIZE_LASTOFFSET = 17; //Field offset: 0x0
	private const uint PRIME32_3 = 3266489917; //Field offset: 0x0
	private const uint PRIME32_1 = 2654435761; //Field offset: 0x0
	private const int BLOCK_LEN = 1024; //Field offset: 0x0
	private const int NB_ROUNDS = 16; //Field offset: 0x0
	private const int SECRET_LASTACC_START = 7; //Field offset: 0x0
	private const int SECRET_KEY_MIN_SIZE = 136; //Field offset: 0x0
	private const int SECRET_KEY_SIZE = 192; //Field offset: 0x0
	private const int SECRET_CONSUME_RATE = 8; //Field offset: 0x0
	private const int ACC_NB = 8; //Field offset: 0x0
	private const uint PRIME32_2 = 2246822519; //Field offset: 0x0
	private const int SECRET_MERGEACCS_START = 11; //Field offset: 0x0

	private static ulong Avalanche(ulong h64) { }

	private static ulong AvalancheH64(ulong h64) { }

	internal static void Avx2Accumulate(ulong* acc, byte* input, byte* dest, byte* secret, long nbStripes, int isHash64) { }

	internal static void Avx2Accumulate512(ulong* acc, byte* input, byte* dest, byte* secret) { }

	internal static void Avx2HashLongInternalLoop(ulong* acc, byte* input, byte* dest, long length, byte* secret, int isHash64) { }

	internal static void Avx2ScrambleAcc(ulong* acc, byte* secret) { }

	internal static void DefaultAccumulate(ulong* acc, byte* input, byte* dest, byte* secret, long nbStripes, int isHash64) { }

	internal static void DefaultAccumulate512(ulong* acc, byte* input, byte* dest, byte* secret, int isHash64) { }

	private static void DefaultHashLongInternalLoop(ulong* acc, byte* input, byte* dest, long length, byte* secret, int isHash64) { }

	internal static void DefaultScrambleAcc(ulong* acc, byte* secret) { }

	internal static void EncodeSecretKey(byte* dst, byte* secret, ulong seed) { }

	public static uint4 Hash128(void* input, void* destination, long length, ulong seed) { }

	public static uint4 Hash128(void* input, long length, ulong seed) { }

	public static uint4 Hash128(void* input, void* destination, long length) { }

	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
	public static uint4 Hash128(in T input) { }

	public static uint4 Hash128(void* input, long length) { }

	internal static void Hash128Internal(byte* input, byte* dest, long length, byte* secret, ulong seed, out uint4 result) { }

	private static void Hash128Len0To16(byte* input, long length, byte* secret, ulong seed, out uint4 result) { }

	private static void Hash128Len129To240(byte* input, long length, byte* secret, ulong seed, out uint4 result) { }

	private static void Hash128Len17To128(byte* input, long length, byte* secret, ulong seed, out uint4 result) { }

	private static void Hash128Len1To3(byte* input, long length, byte* secret, ulong seed, out uint4 result) { }

	private static void Hash128Len4To8(byte* input, long len, byte* secret, ulong seed, out uint4 result) { }

	private static void Hash128Len9To16(byte* input, long len, byte* secret, ulong seed, out uint4 result) { }

	[BurstCompile]
	private static void Hash128Long(byte* input, byte* dest, long length, byte* secret, out uint4 result) { }

	[BurstCompile]
	public static void Hash128Long$BurstManaged(byte* input, byte* dest, long length, byte* secret, out uint4 result) { }

	public static uint2 Hash64(void* input, long length) { }

	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
	public static uint2 Hash64(in T input) { }

	public static uint2 Hash64(void* input, long length, ulong seed) { }

	internal static ulong Hash64Internal(byte* input, byte* dest, long length, byte* secret, ulong seed) { }

	private static ulong Hash64Len0To16(byte* input, long length, byte* secret, ulong seed) { }

	private static ulong Hash64Len129To240(byte* input, long length, byte* secret, ulong seed) { }

	private static ulong Hash64Len17To128(byte* input, long length, byte* secret, ulong seed) { }

	private static ulong Hash64Len1To3(byte* input, long len, byte* secret, ulong seed) { }

	private static ulong Hash64Len4To8(byte* input, long length, byte* secret, ulong seed) { }

	private static ulong Hash64Len9To16(byte* input, long length, byte* secret, ulong seed) { }

	[BurstCompile]
	private static ulong Hash64Long(byte* input, byte* dest, long length, byte* secret) { }

	[BurstCompile]
	public static ulong Hash64Long$BurstManaged(byte* input, byte* dest, long length, byte* secret) { }

	internal static ulong MergeAcc(ulong* acc, byte* secret, ulong start) { }

	private static ulong Mix16(byte* input, byte* secret, ulong seed) { }

	private static ulong Mix2Acc(ulong acc0, ulong acc1, byte* secret) { }

	private static ulong2 Mix32(ulong2 acc, byte* input_1, byte* input_2, byte* secret, ulong seed) { }

	private static ulong Mul128Fold64(ulong lhs, ulong rhs) { }

	private static ulong Mul32To64(uint x, uint y) { }

	private static uint Read32LE(void* addr) { }

	private static void Read32LE(void* addr, uint value) { }

	private static ulong Read64LE(void* addr) { }

	private static uint RotL32(uint x, int r) { }

	private static ulong RotL64(ulong x, int r) { }

	private static ulong rrmxmx(ulong h64, ulong length) { }

	private static uint Swap32(uint x) { }

	private static ulong Swap64(ulong x) { }

	internal static uint2 ToUint2(ulong u) { }

	internal static uint4 ToUint4(ulong ul0, ulong ul1) { }

	private static void Write64LE(void* addr, ulong value) { }

	private static ulong XorShift64(ulong v64, int shift) { }

}

