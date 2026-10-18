namespace FastAnimatorSystem;

public sealed class StateMachine : AbstractInnerStateMachine
{
	internal AbstractInnerStateMachine _parentStateMachine; //Field offset: 0x48

	public virtual AbstractStateMachine ParentStateMachine
	{
		 get { } //Length: 5
	}

	public StateMachine(string name, int hash, int defaultStateHash) { }

	protected virtual void Dispose(bool disposing) { }

	public virtual AbstractStateMachine get_ParentStateMachine() { }

}

