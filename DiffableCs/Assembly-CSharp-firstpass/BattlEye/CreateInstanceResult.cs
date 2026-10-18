namespace BattlEye;

public struct CreateInstanceResult
{
	public int LoadDllError; //Field offset: 0x0
	public int LoadInitFuncError; //Field offset: 0x4
	public int LoadGetVerFuncError; //Field offset: 0x8

	public bool HasError
	{
		 get { } //Length: 22
	}

	public bool get_HasError() { }

	public string ToErrorString() { }

}

