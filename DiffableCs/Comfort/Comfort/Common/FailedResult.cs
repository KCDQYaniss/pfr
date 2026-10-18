namespace Comfort.Common;

public class FailedResult : IResult
{
	[CompilerGenerated]
	private string <Error>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private int <ErrorCode>k__BackingField; //Field offset: 0x18

	public private override string Error
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private override int ErrorCode
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public override bool Failed
	{
		 get { } //Length: 3
	}

	public override bool Succeed
	{
		 get { } //Length: 3
	}

	public Task Task
	{
		 get { } //Length: 93
	}

	public FailedResult(string error, int errorCode = 0) { }

	[CompilerGenerated]
	public override string get_Error() { }

	[CompilerGenerated]
	public override int get_ErrorCode() { }

	public override bool get_Failed() { }

	public override bool get_Succeed() { }

	public Task get_Task() { }

	[CompilerGenerated]
	private void set_Error(string value) { }

	[CompilerGenerated]
	private void set_ErrorCode(int value) { }

}

