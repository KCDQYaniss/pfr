namespace Diz.Jobs;

public interface IJobAwaiter : INotifyCompletion
{

	public bool IsCompleted
	{
		 get { } //Length: 0
	}

	public bool get_IsCompleted() { }

	public void GetResult() { }

}

