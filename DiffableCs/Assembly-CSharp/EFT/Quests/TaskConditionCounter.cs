namespace EFT.Quests;

public sealed class TaskConditionCounter
{
	[CompilerGenerated]
	private Action OnValueChanged; //Field offset: 0x10
	public readonly MongoID Id; //Field offset: 0x18
	public readonly string Type; //Field offset: 0x30
	private readonly string _sourceId; //Field offset: 0x38
	private int _value; //Field offset: 0x40
	public Condition Template; //Field offset: 0x48
	public IConditional Conditional; //Field offset: 0x50

	public event Action OnValueChanged
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public string SourceId
	{
		 get { } //Length: 80
	}

	public int Value
	{
		 get { } //Length: 4
		 set { } //Length: 36
	}

	public TaskConditionCounter(TaskConditionCounterDescriptor descriptor) { }

	public TaskConditionCounter(IConditional source, Condition template) { }

	[CompilerGenerated]
	public void add_OnValueChanged(Action value) { }

	public string get_SourceId() { }

	public int get_Value() { }

	[CompilerGenerated]
	public void remove_OnValueChanged(Action value) { }

	public void Reset() { }

	public void set_Value(int value) { }

	public virtual string ToString() { }

}

