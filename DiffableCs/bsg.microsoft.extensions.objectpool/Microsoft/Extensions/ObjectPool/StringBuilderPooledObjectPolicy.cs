namespace Microsoft.Extensions.ObjectPool;

public class StringBuilderPooledObjectPolicy : PooledObjectPolicy
{
	[CompilerGenerated]
	private int <InitialCapacity>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private int <MaximumRetainedCapacity>k__BackingField; //Field offset: 0x14

	public int InitialCapacity
	{
		[CompilerGenerated]
		 get { } //Length: 164
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public int MaximumRetainedCapacity
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public StringBuilderPooledObjectPolicy() { }

	public virtual StringBuilder Create() { }

	[CompilerGenerated]
	public int get_InitialCapacity() { }

	[CompilerGenerated]
	public int get_MaximumRetainedCapacity() { }

	public virtual bool Return(StringBuilder obj) { }

	[CompilerGenerated]
	public void set_InitialCapacity(int value) { }

	[CompilerGenerated]
	public void set_MaximumRetainedCapacity(int value) { }

}

