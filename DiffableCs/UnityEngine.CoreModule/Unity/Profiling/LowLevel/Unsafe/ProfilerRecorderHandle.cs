namespace Unity.Profiling.LowLevel.Unsafe;

[IsReadOnly]
[UsedByNativeCode]
public struct ProfilerRecorderHandle
{
	internal readonly ulong handle; //Field offset: 0x0

	public bool Valid
	{
		 get { } //Length: 17
	}

	internal static ProfilerRecorderHandle Get(ProfilerCategory category, string statName) { }

	public bool get_Valid() { }

	[NativeMethod(IsThreadSafe = True)]
	internal static ProfilerRecorderHandle GetByName(ProfilerCategory category, string name) { }

	[NativeMethod(IsThreadSafe = True)]
	internal static ProfilerRecorderHandle GetByName__Unmanaged(ProfilerCategory category, byte* name, int nameLen) { }

	private static void GetByName__Unmanaged_Injected(ref ProfilerCategory category, byte* name, int nameLen, out ProfilerRecorderHandle ret) { }

	private static void GetByName_Injected(ref ProfilerCategory category, string name, out ProfilerRecorderHandle ret) { }

	public static ProfilerRecorderDescription GetDescription(ProfilerRecorderHandle handle) { }

	[NativeMethod(IsThreadSafe = True)]
	private static ProfilerRecorderDescription GetDescriptionInternal(ProfilerRecorderHandle handle) { }

	private static void GetDescriptionInternal_Injected(ref ProfilerRecorderHandle handle, out ProfilerRecorderDescription ret) { }

}

