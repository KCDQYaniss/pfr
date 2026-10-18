namespace FastAnimatorSystem;

public class FastAnimatorController : AbstractStateMachine
{
	[CompilerGenerated]
	private sealed class <>c__21`1
	{
		public static readonly <>c__21 <>9; //Field offset: 0x0
		public static Func <>9__21_0; //Field offset: 0x0

		private static <>c__21`1() { }

		public <>c__21`1() { }

		internal IEnumerable <GetBehaviors>b__21_0(AbstractState s) { }

	}

	private readonly string _unityAnimatorControllerObjectHash; //Field offset: 0x30
	internal List _parameters; //Field offset: 0x38
	internal List _layerStateMachines; //Field offset: 0x40
	[CompilerGenerated]
	private List <AllStates>k__BackingField; //Field offset: 0x48

	public private List AllStates
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public int LayersCount
	{
		 get { } //Length: 65
	}

	public int ParametersCount
	{
		 get { } //Length: 65
	}

	public string UnityAnimatorControllerObjectHash
	{
		 get { } //Length: 76
	}

	public FastAnimatorController(string name, int hash, string unityAnimatorControllerObjectHash) { }

	protected virtual void Dispose(bool disposing) { }

	public AnimatorParameter FindParameter(int nameHash) { }

	public AnimatorParameter FindParameter(string name) { }

	[CompilerGenerated]
	public List get_AllStates() { }

	public int get_LayersCount() { }

	public int get_ParametersCount() { }

	public string get_UnityAnimatorControllerObjectHash() { }

	private int GetAllStateCountRec(AbstractInnerStateMachine stateMachine) { }

	public T[] GetBehaviors() { }

	public LayerStateMachine GetLayerStateMachine(int layerIndex) { }

	public IEnumerable GetLayerStateMachinesEnumerator() { }

	public AnimatorParameter GetParameter(int parameterIndex) { }

	public IEnumerable GetParameters() { }

	public void RefreshAllStates() { }

	private void RefreshAllStatesRec(AbstractInnerStateMachine stateMachine) { }

	public virtual void ResetCache() { }

	[CompilerGenerated]
	private void set_AllStates(List value) { }

}

