namespace Comfort.Common;

public class SuccessfulResult : IResult
{
	public static readonly IResult New; //Field offset: 0x0
	public static readonly Task Task; //Field offset: 0x8

	public override string Error
	{
		 get { } //Length: 3
	}

	public override int ErrorCode
	{
		 get { } //Length: 3
	}

	public override bool Failed
	{
		 get { } //Length: 3
	}

	public override bool Succeed
	{
		 get { } //Length: 3
	}

	private static SuccessfulResult() { }

	public SuccessfulResult() { }

	public override string get_Error() { }

	public override int get_ErrorCode() { }

	public override bool get_Failed() { }

	public override bool get_Succeed() { }

}

