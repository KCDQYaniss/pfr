namespace FastAnimatorSystem;

public abstract class AbstractInnerStateMachine : AbstractStateMachine
{
	internal readonly List _StatesMachines; //Field offset: 0x30
	internal readonly List _states; //Field offset: 0x38
	private readonly int _defaultStateHash; //Field offset: 0x40

	public int DefaultStateHash
	{
		 get { } //Length: 4
	}

	public abstract AbstractStateMachine ParentStateMachine
	{
		 get { } //Length: 0
	}

	public int StatesCount
	{
		 get { } //Length: 65
	}

	public int StatesMachinesCount
	{
		 get { } //Length: 65
	}

	protected AbstractInnerStateMachine(string name, int hash, int defaultStateHash) { }

	protected virtual void Dispose(bool disposing) { }

	public AbstractAnimatorControllerState FindDefaultState() { }

	private AbstractAnimatorControllerState FindDefaultStateRec(AbstractInnerStateMachine stateMachine) { }

	public int get_DefaultStateHash() { }

	public abstract AbstractStateMachine get_ParentStateMachine() { }

	public int get_StatesCount() { }

	public int get_StatesMachinesCount() { }

	public AbstractAnimatorControllerState GetState(int index) { }

	public AbstractInnerStateMachine GetStateMachine(int index) { }

	public IEnumerable GetStateMachinesEnumerator() { }

	public IEnumerable GetStatesEnumerator() { }

	public virtual void ResetCache() { }

}

