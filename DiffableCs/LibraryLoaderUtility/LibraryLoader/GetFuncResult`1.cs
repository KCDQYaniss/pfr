namespace LibraryLoader;

[IsReadOnly]
public struct GetFuncResult`1
{
	public readonly int ErrorCode; //Field offset: 0x0
	public readonly T FuncDelegate; //Field offset: 0x0

	public bool HasError
	{
		 get { } //Length: 7
	}

	public GetFuncResult`1(Delegate funcDelegate, int errorCode) { }

	public bool get_HasError() { }

}

