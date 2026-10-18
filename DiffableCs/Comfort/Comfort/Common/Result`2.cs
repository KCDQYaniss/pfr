namespace Comfort.Common;

public struct Result`2
{
	[CompilerGenerated]
	private T0 <Value0>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private T1 <Value1>k__BackingField; //Field offset: 0x0
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
		 get { } //Length: 89
	}

	public T0 Value0
	{
		[CompilerGenerated]
		 get { } //Length: 3
		[CompilerGenerated]
		 set { } //Length: 3
	}

	public T1 Value1
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public Result`2(T0 value0, T1 value1) { }

	public bool get_Complete() { }

	[CompilerGenerated]
	public string get_Error() { }

	[CompilerGenerated]
	public int get_ErrorCode() { }

	public bool get_Failed() { }

	public bool get_Succeed() { }

	[CompilerGenerated]
	public T0 get_Value0() { }

	[CompilerGenerated]
	public T1 get_Value1() { }

	[CompilerGenerated]
	public void set_Error(string value) { }

	[CompilerGenerated]
	public void set_ErrorCode(int value) { }

	[CompilerGenerated]
	public void set_Value0(T0 value) { }

	[CompilerGenerated]
	public void set_Value1(T1 value) { }

}

