namespace Comfort.Common;

public struct Result`1
{
	[CompilerGenerated]
	private T <Value>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private string <Error>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private int <ErrorCode>k__BackingField; //Field offset: 0x0

	public bool Complete
	{
		 get { } //Length: 29
	}

	public string Error
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public int ErrorCode
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public bool Failed
	{
		 get { } //Length: 41
	}

	public bool Succeed
	{
		 get { } //Length: 71
	}

	public T Value
	{
		[CompilerGenerated]
		 get { } //Length: 20
		[CompilerGenerated]
		 set { } //Length: 83
	}

	public Result`1(T value) { }

	public Result`1(T value, string error) { }

	public Result`1(T value, string error, int errorCode) { }

	public bool get_Complete() { }

	[CompilerGenerated]
	public string get_Error() { }

	[CompilerGenerated]
	public int get_ErrorCode() { }

	public bool get_Failed() { }

	public bool get_Succeed() { }

	[CompilerGenerated]
	public T get_Value() { }

	public static Result op_Implicit(T value) { }

	[CompilerGenerated]
	public void set_Error(string value) { }

	[CompilerGenerated]
	public void set_ErrorCode(int value) { }

	[CompilerGenerated]
	public void set_Value(T value) { }

}

