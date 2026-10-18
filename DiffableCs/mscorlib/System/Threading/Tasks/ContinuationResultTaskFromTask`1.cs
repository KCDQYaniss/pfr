namespace System.Threading.Tasks;

internal sealed class ContinuationResultTaskFromTask`1 : Task
{
	private Task m_antecedent; //Field offset: 0x0

	public ContinuationResultTaskFromTask`1(Task antecedent, Delegate function, object state, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions) { }

	internal virtual void InnerInvoke() { }

}

