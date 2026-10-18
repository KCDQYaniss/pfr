namespace System.Diagnostics;

[IsReadOnly]
public struct ActivityLink : IEquatable
{
	private readonly TagsLinkedList _tags; //Field offset: 0x0
	[CompilerGenerated]
	private readonly ActivityContext <Context>k__BackingField; //Field offset: 0x8

	public ActivityContext Context
	{
		[CompilerGenerated]
		 get { } //Length: 29
	}

	[Nullable(new IL2CPP_TYPE_U1[] {2, 0, 1, 2})]
	public IEnumerable Tags
	{
		 get { } //Length: 4
	}

	[NullableContext(2)]
	public virtual bool Equals(object obj) { }

	public override bool Equals(ActivityLink value) { }

	[CompilerGenerated]
	public ActivityContext get_Context() { }

	public IEnumerable get_Tags() { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(ActivityLink left, ActivityLink right) { }

}

