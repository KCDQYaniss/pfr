namespace Diz.Jobs;

internal class JobAwaitable : IJobAwaitable
{
	private JobYield _jobYield; //Field offset: 0x10
	private bool _runSynchronously; //Field offset: 0x18

	public JobAwaitable() { }

	public override IJobAwaiter GetAwaiter() { }

	public JobAwaitable Init(JobYield jobYield, bool runSynchronously) { }

}

