//Type is in global namespace

public static class MemoryInfo
{
	internal struct ProcessMemoryCounters
	{
		public uint cb; //Field offset: 0x0
		public uint PageFaultCount; //Field offset: 0x4
		public ulong PeakWorkingSetSize; //Field offset: 0x8
		public ulong WorkingSetSize; //Field offset: 0x10
		public ulong QuotaPeakPagedPoolUsage; //Field offset: 0x18
		public ulong QuotaPagedPoolUsage; //Field offset: 0x20
		public ulong QuotaPeakNonPagedPoolUsage; //Field offset: 0x28
		public ulong QuotaNonPagedPoolUsage; //Field offset: 0x30
		public ulong PagefileUsage; //Field offset: 0x38
		public ulong PeakPagefileUsage; //Field offset: 0x40

		public virtual string ToString() { }

	}


	public static ProcessMemoryCounters GetCounters() { }

	private static ProcessMemoryCounters GetCountersInternal() { }

	private static IntPtr GetCurrentProcess() { }

	private static bool GetProcessMemoryInfo(IntPtr hProcess, out ProcessMemoryCounters counters, uint size) { }

}

