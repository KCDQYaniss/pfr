namespace Comfort.Common;

public interface IResult
{

	public string Error
	{
		 get { } //Length: 0
	}

	public int ErrorCode
	{
		 get { } //Length: 0
	}

	public bool Failed
	{
		 get { } //Length: 0
	}

	public bool Succeed
	{
		 get { } //Length: 0
	}

	public string get_Error() { }

	public int get_ErrorCode() { }

	public bool get_Failed() { }

	public bool get_Succeed() { }

}

