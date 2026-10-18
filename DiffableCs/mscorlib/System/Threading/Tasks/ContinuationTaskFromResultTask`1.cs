namespace System.Threading.Tasks;

internal sealed class ContinuationTaskFromResultTask`1 : Task
{
	private Task m_antecedent; //Field offset: 0x0

	public ContinuationTaskFromResultTask`1(Task antecedent, Delegate action, object state, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions) { }

	internal virtual void InnerInvoke() { }

}

