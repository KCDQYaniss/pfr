namespace EFT.Utilities;

public static class CpuAffinityHelper
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__11_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <SetAffinityToLogicalCoresEnabled>b__11_0(SYSTEM_LOGICAL_PROCESSOR_INFORMATION information) { }

	}

	private struct CACHE_DESCRIPTOR
	{
		public byte Level; //Field offset: 0x0
		public byte Associativity; //Field offset: 0x1
		public ushort LineSize; //Field offset: 0x2
		public uint Size; //Field offset: 0x4
		public PROCESSOR_CACHE_TYPE Type; //Field offset: 0x8

	}

	internal enum LOGICAL_PROCESSOR_RELATIONSHIP
	{
		RelationProcessorCore = 0,
		RelationNumaNode = 1,
		RelationCache = 2,
		RelationProcessorPackage = 3,
		RelationGroup = 4,
		RelationAll = 65535,
	}

	private struct NUMANODE
	{
		public uint NodeNumber; //Field offset: 0x0

	}

	private enum PROCESSOR_CACHE_TYPE
	{
		CacheUnified = 0,
		CacheInstruction = 1,
		CacheData = 2,
		CacheTrace = 3,
	}

	private struct PROCESSORCORE
	{
		public byte Flags; //Field offset: 0x0

	}

	private struct SYSTEM_LOGICAL_PROCESSOR_INFORMATION
	{
		public UIntPtr ProcessorMask; //Field offset: 0x0
		public LOGICAL_PROCESSOR_RELATIONSHIP Relationship; //Field offset: 0x8
		public SYSTEM_LOGICAL_PROCESSOR_INFORMATION_UNION ProcessorInformation; //Field offset: 0x10

	}

	private struct SYSTEM_LOGICAL_PROCESSOR_INFORMATION_UNION
	{
		public PROCESSORCORE ProcessorCore; //Field offset: 0x0
		public NUMANODE NumaNode; //Field offset: 0x0
		public CACHE_DESCRIPTOR Cache; //Field offset: 0x0
		private ulong Reserved1; //Field offset: 0x0
		private ulong Reserved2; //Field offset: 0x8

	}

	private const int ERROR_INSUFFICIENT_BUFFER = 122; //Field offset: 0x0

	private static bool GetLogicalProcessorInformation(IntPtr buffer, ref uint returnLength) { }

	private static SYSTEM_LOGICAL_PROCESSOR_INFORMATION[] GetLogicalProcessorInformationBuffer() { }

	private static int GetProcessAffinityMask(int hProcess, ref int lpProcessAffinityMask, ref int systemAffinityMask) { }

	public static void SetAffinityToLogicalCoresEnabled(bool enabled) { }

	private static bool SetProcessAffinityMask(IntPtr hProcess, UIntPtr dwProcessAffinityMask) { }

}

