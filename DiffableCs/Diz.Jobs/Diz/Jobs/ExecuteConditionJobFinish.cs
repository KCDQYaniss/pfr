namespace Diz.Jobs;

internal class ExecuteConditionJobFinish : IConditionExecutor
{
	private JobYield _jobYield; //Field offset: 0x10
	public bool JobFinished; //Field offset: 0x18
	public bool HasExecution; //Field offset: 0x19

	public ExecuteConditionJobFinish() { }

	public override bool CanExecute(JobContinuation continuation) { }

	public override void Execute(ref JobContinuation continuation) { }

	public void Init(JobYield jobYield) { }

}

