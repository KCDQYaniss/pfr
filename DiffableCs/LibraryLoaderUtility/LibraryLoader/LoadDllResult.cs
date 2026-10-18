namespace LibraryLoader;

[IsReadOnly]
public struct LoadDllResult
{
	public readonly IntPtr DllPtr; //Field offset: 0x0
	public readonly int ErrorCode; //Field offset: 0x8

	public bool HasError
	{
		 get { } //Length: 8
	}

	public LoadDllResult(IntPtr dllPtr, int errorCode) { }

	public bool get_HasError() { }

}

