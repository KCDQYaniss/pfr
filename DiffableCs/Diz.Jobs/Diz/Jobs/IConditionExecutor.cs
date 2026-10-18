namespace Diz.Jobs;

internal interface IConditionExecutor
{

	public bool CanExecute(JobContinuation continuation) { }

	public void Execute(ref JobContinuation continuation) { }

}

