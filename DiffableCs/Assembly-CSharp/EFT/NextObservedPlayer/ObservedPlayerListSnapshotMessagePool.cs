namespace EFT.NextObservedPlayer;

public static class ObservedPlayerListSnapshotMessagePool
{
	private const int INIT_POOL_CAPACITY = 256; //Field offset: 0x0
	private const int INIT_LIST_CAPACITY = 64; //Field offset: 0x0
	private static readonly Pool _pool; //Field offset: 0x0

	private static ObservedPlayerListSnapshotMessagePool() { }

	public static ObservedPlayerListSnapshotMessagePooled Get() { }

	private static ObservedPlayerListSnapshotMessagePooled Init() { }

	public static void Return(ObservedPlayerListSnapshotMessagePooled instance) { }

}

