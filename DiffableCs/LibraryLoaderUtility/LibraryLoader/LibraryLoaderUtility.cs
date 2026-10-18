namespace LibraryLoader;

public sealed class LibraryLoaderUtility
{
	private readonly ILogHandler _logger; //Field offset: 0x10

	public LibraryLoaderUtility() { }

	public LibraryLoaderUtility(ILogHandler logger) { }

	private static int FreeLibrary(IntPtr hModule) { }

	public GetFuncResult GetFunction(IntPtr dllPtr, string functionName) { }

	private static IntPtr GetProcAddress(IntPtr hModule, string procName) { }

	private LoadFuncResult InternalGetProcAddress(IntPtr dllPtr, string procName) { }

	public LoadDllResult LoadDll(string path) { }

	private static IntPtr LoadLibraryW(string path) { }

	public int ReleaseDll(IntPtr dllPtr) { }

}

