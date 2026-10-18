namespace Unity.Burst.LowLevel;

[NativeHeader("Runtime/Burst/Burst.h")]
[NativeHeader("Runtime/Burst/BurstDelegateCache.h")]
[StaticAccessor("BurstCompilerService::Get()", StaticAccessorType::Arrow (1))]
internal static class BurstCompilerService
{
	internal enum BurstLogType
	{
		Info = 0,
		Warning = 1,
		Error = 2,
	}


	[FreeFunction(IsThreadSafe = True)]
	public static int CompileAsyncDelegateMethod(object delegateMethod, string compilerOptions) { }

	[FreeFunction(IsThreadSafe = True)]
	public static void* GetAsyncCompiledAsyncDelegateMethod(int userID) { }

	[ThreadSafe]
	public static uint GetCurrentExecutionMode() { }

	[ThreadSafe]
	public static string GetDisassembly(MethodInfo m, string compilerOptions) { }

	[ThreadSafe]
	public static void* GetOrCreateSharedMemory(ref Hash128 key, uint size_of, uint alignment) { }

	public static bool LoadBurstLibrary(string fullPathToLibBurstGenerated) { }

	[FreeFunction("DefaultBurstLogCallback", True)]
	public static void Log(void* userData, BurstLogType logType, byte* message, byte* filename, int lineNumber) { }

	[FreeFunction("DefaultBurstRuntimeLogCallback", True)]
	public static void RuntimeLog(void* userData, BurstLogType logType, byte* message, byte* filename, int lineNumber) { }

	[ThreadSafe]
	public static void SetCurrentExecutionMode(uint environment) { }

}

