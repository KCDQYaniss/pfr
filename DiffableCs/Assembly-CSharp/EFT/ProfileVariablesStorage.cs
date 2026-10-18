namespace EFT;

public sealed class ProfileVariablesStorage
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass10_0
	{
		public ProfileVariablesStorage <>4__this; //Field offset: 0x10
		public MongoID groupVariableId; //Field offset: 0x18

		public <>c__DisplayClass10_0() { }

		internal void <RegisterGroupVariable>g__NewVariableChangedHandler|0(int variableValue) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass7_0
	{
		public ProfileVariablesStorage <>4__this; //Field offset: 0x10
		public MongoID variableId; //Field offset: 0x18

		public <>c__DisplayClass7_0() { }

		internal void <SetVariableValue>g__NewVariableChangedHandler|0(int variableValue) { }

	}

	private readonly Dictionary _profileVariables; //Field offset: 0x10
	[CompilerGenerated]
	private Action OnVariableChanged; //Field offset: 0x18

	public event Action OnVariableChanged
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public IEnumerable VariableIds
	{
		 get { } //Length: 73
	}

	public ProfileVariablesStorage(Dictionary variableValues) { }

	[CompilerGenerated]
	public void add_OnVariableChanged(Action value) { }

	public IEnumerable get_VariableIds() { }

	public int GetVariableValue(MongoID variableId) { }

	private void RegisterGroupVariable(MongoID groupVariableId, IReadOnlyList variables) { }

	[CompilerGenerated]
	public void remove_OnVariableChanged(Action value) { }

	public void SetVariableValue(MongoID variableId, int value) { }

	public Dictionary ToDescriptor() { }

	private void VariableChangedHandler(MongoID id, int variableValue) { }

}

