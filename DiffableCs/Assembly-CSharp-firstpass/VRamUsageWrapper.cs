//Type is in global namespace

public class VRamUsageWrapper
{
	public static ulong maxLocalUsage; //Field offset: 0x0
	private CommandBuffer infoObtainer; //Field offset: 0x10
	public bool gotLocalMemoryInfo; //Field offset: 0x18
	public ulong localBudget; //Field offset: 0x20
	public ulong localCurrentUsage; //Field offset: 0x28
	public ulong localAvailableForReservation; //Field offset: 0x30
	public ulong localCurrentReservation; //Field offset: 0x38
	public bool gotNonLocalMemoryInfo; //Field offset: 0x40
	public ulong nonLocalBudget; //Field offset: 0x48
	public ulong nonLocalCurrentUsage; //Field offset: 0x50
	public ulong nonLocalAvailableForReservation; //Field offset: 0x58
	public ulong nonLocalCurrentReservation; //Field offset: 0x60
	public ulong totalVRAM; //Field offset: 0x68

	public VRamUsageWrapper() { }

	private static IntPtr GetFunc_FetchLocalMemoryInfo() { }

	private static IntPtr GetFunc_FetchNonLocalMemoryInfo() { }

	private static bool GetMemoryInfo(bool isLocal, out ulong budget, out ulong currentUsage, out ulong availableForReservation, out ulong currentReservation) { }

	private static bool GetTotalGPUMemory(out ulong memorySize) { }

	public void Init(Camera camera) { }

	public void Release(Camera camera) { }

	public void Update() { }

}

