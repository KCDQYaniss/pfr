namespace UnityEngine.Profiling;

[MovedFrom("UnityEngine")]
[NativeHeader("Runtime/Profiler/MemoryProfiler.h")]
[NativeHeader("Runtime/ScriptingBackend/ScriptingApi.h")]
[NativeHeader("Runtime/Profiler/ScriptBindings/Profiler.bindings.h")]
[NativeHeader("Runtime/Utilities/MemoryUtilities.h")]
[NativeHeader("Runtime/Allocator/MemoryManager.h")]
[NativeHeader("Runtime/Profiler/Profiler.h")]
[UsedByNativeCode]
public sealed class Profiler
{

	public static int areaCount
	{
		 get { } //Length: 376
	}

	public static bool enableBinaryLog
	{
		[NativeMethod(Name = "ProfilerBindings::SetBinaryLogEnabled", IsFreeFunction = True)]
		 set { } //Length: 78
	}

	public static bool enabled
	{
		[NativeConditional("ENABLE_PROFILER")]
		[NativeMethod(Name = "profiler_is_enabled", IsFreeFunction = True, IsThreadSafe = True)]
		 get { } //Length: 69
		[NativeMethod(Name = "ProfilerBindings::SetProfilerEnabled", IsFreeFunction = True)]
		 set { } //Length: 78
	}

	[StaticAccessor("ProfilerBindings", StaticAccessorType::DoubleColon (2))]
	public static string logFile
	{
		 set { } //Length: 78
	}

	public static int get_areaCount() { }

	[NativeConditional("ENABLE_PROFILER")]
	[NativeMethod(Name = "profiler_is_enabled", IsFreeFunction = True, IsThreadSafe = True)]
	public static bool get_enabled() { }

	[NativeMethod(Name = "scripting_gc_get_heap_size", IsFreeFunction = True)]
	public static long GetMonoHeapSizeLong() { }

	[NativeMethod(Name = "scripting_gc_get_used_size", IsFreeFunction = True)]
	public static long GetMonoUsedSizeLong() { }

	[NativeConditional("ENABLE_MEMORY_MANAGER")]
	[NativeMethod(Name = "GetTotalAllocatedMemory")]
	[StaticAccessor("GetMemoryManager()", StaticAccessorType::Dot (0))]
	public static long GetTotalAllocatedMemoryLong() { }

	[NativeConditional("ENABLE_MEMORY_MANAGER")]
	[NativeMethod(Name = "GetTotalReservedMemory")]
	[StaticAccessor("GetMemoryManager()", StaticAccessorType::Dot (0))]
	public static long GetTotalReservedMemoryLong() { }

	[NativeConditional("ENABLE_MEMORY_MANAGER")]
	[NativeMethod(Name = "GetTotalUnusedReservedMemory")]
	[StaticAccessor("GetMemoryManager()", StaticAccessorType::Dot (0))]
	public static long GetTotalUnusedReservedMemoryLong() { }

	[NativeMethod(Name = "ProfilerBindings::SetBinaryLogEnabled", IsFreeFunction = True)]
	public static void set_enableBinaryLog(bool value) { }

	[NativeMethod(Name = "ProfilerBindings::SetProfilerEnabled", IsFreeFunction = True)]
	public static void set_enabled(bool value) { }

	public static void set_logFile(string value) { }

}

