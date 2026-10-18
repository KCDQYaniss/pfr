namespace Diz.Jobs;

internal class ExecuteConditionGeneral : IConditionExecutor
{
	private Func _condition; //Field offset: 0x10

	public ExecuteConditionGeneral(Func condition) { }

	public override bool CanExecute(JobContinuation continuation) { }

	public override void Execute(ref JobContinuation continuation) { }

}

