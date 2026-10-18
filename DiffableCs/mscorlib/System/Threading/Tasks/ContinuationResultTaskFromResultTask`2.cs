namespace System.Threading.Tasks;

internal sealed class ContinuationResultTaskFromResultTask`2 : Task
{
	private Task m_antecedent; //Field offset: 0x0

	public ContinuationResultTaskFromResultTask`2(Task antecedent, Delegate function, object state, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions) { }

	internal virtual void InnerInvoke() { }

}

