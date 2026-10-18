namespace LibraryLoader;

[IsReadOnly]
public struct LoadFuncResult
{
	public readonly IntPtr FuncPtr; //Field offset: 0x0
	public readonly int ErrorCode; //Field offset: 0x8

	public bool HasError
	{
		 get { } //Length: 8
	}

	public LoadFuncResult(IntPtr funcPtr, int errorCode) { }

	public bool get_HasError() { }

}

