namespace FastAnimatorSystem;

public sealed class LayerStateMachine : AbstractInnerStateMachine
{
	internal FastAnimatorController _parentAnimatorController; //Field offset: 0x48
	public float LayerWeight; //Field offset: 0x50

	public virtual AbstractStateMachine ParentStateMachine
	{
		 get { } //Length: 5
	}

	public LayerStateMachine(string name, int hash, int defaultStateHash) { }

	protected virtual void Dispose(bool disposing) { }

	public virtual AbstractStateMachine get_ParentStateMachine() { }

	public virtual string ToString() { }

}

