namespace Microsoft.Extensions.Logging;

[IsReadOnly]
[Nullable(0)]
[NullableContext(2)]
public struct EventId : IEquatable
{
	[CompilerGenerated]
	private readonly int <Id>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private readonly string <Name>k__BackingField; //Field offset: 0x8

	public int Id
	{
		[CompilerGenerated]
		 get { } //Length: 3
	}

	public string Name
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public EventId(int id, string name = null) { }

	public override bool Equals(EventId other) { }

	public virtual bool Equals(object obj) { }

	[CompilerGenerated]
	public int get_Id() { }

	[CompilerGenerated]
	public string get_Name() { }

	public virtual int GetHashCode() { }

	public static EventId op_Implicit(int i) { }

	[NullableContext(1)]
	public virtual string ToString() { }

}

