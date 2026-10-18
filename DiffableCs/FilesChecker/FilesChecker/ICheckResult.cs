namespace FilesChecker;

public interface ICheckResult
{

	public TimeSpan ElapsedTime
	{
		 get { } //Length: 0
	}

	public Exception Exception
	{
		 get { } //Length: 0
	}

	public TimeSpan get_ElapsedTime() { }

	public Exception get_Exception() { }

}

