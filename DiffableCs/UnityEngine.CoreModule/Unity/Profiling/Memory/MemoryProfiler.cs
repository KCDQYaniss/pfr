namespace Unity.Profiling.Memory;

[NativeHeader("Modules/Profiler/Runtime/MemorySnapshotManager.h")]
public static class MemoryProfiler
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action m_SnapshotFinished; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action m_SaveScreenshotToDisk; //Field offset: 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action CreatingMetadata; //Field offset: 0x10

	public static event Action CreatingMetadata
	{
		[CompilerGenerated]
		 add { } //Length: 304
		[CompilerGenerated]
		 remove { } //Length: 304
	}

	[CompilerGenerated]
	public static void add_CreatingMetadata(Action value) { }

	[RequiredByNativeCode]
	private static void FinalizeSnapshot(string path, bool result) { }

	[RequiredByNativeCode]
	private static byte[] PrepareMetadata() { }

	[CompilerGenerated]
	public static void remove_CreatingMetadata(Action value) { }

	[RequiredByNativeCode]
	private static void SaveScreenshotToDisk(string path, bool result, IntPtr pixelsPtr, int pixelsCount, TextureFormat format, int width, int height) { }

	internal static int WriteIntToByteArray(byte[] array, int offset, int value) { }

	internal static int WriteStringToByteArray(byte[] array, int offset, string value) { }

}

