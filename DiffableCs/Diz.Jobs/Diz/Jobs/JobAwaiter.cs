namespace Diz.Jobs;

internal class JobAwaiter : IJobAwaiter, INotifyCompletion
{
	private JobYield _jobYield; //Field offset: 0x10
	private bool _runSynchronously; //Field offset: 0x18

	public override bool IsCompleted
	{
		 get { } //Length: 5
	}

	public JobAwaiter() { }

	public override bool get_IsCompleted() { }

	public override void GetResult() { }

	public JobAwaiter Init(JobYield jobYield, bool runSynchronously) { }

	public override void OnCompleted(Action continuation) { }

}

