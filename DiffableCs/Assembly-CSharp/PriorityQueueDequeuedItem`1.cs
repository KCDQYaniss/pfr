//Type is in global namespace

[IsReadOnly]
public struct PriorityQueueDequeuedItem`1
{
	[CompilerGenerated]
	private readonly T <Data>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private readonly float <Priority>k__BackingField; //Field offset: 0x0

	public T Data
	{
		[CompilerGenerated]
		 get { } //Length: 4
	}

	public float Priority
	{
		[CompilerGenerated]
		 get { } //Length: 6
	}

	public PriorityQueueDequeuedItem`1(T data, float priority) { }

	public void Deconstruct(out T data, out float priority) { }

	[CompilerGenerated]
	public T get_Data() { }

	[CompilerGenerated]
	public float get_Priority() { }

}

