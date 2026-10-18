namespace Microsoft.Extensions.ObjectPool;

public class DefaultObjectPoolProvider : ObjectPoolProvider
{
	[CompilerGenerated]
	private int <MaximumRetained>k__BackingField; //Field offset: 0x10

	public int MaximumRetained
	{
		[CompilerGenerated]
		 get { } //Length: 164
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public DefaultObjectPoolProvider() { }

	public virtual ObjectPool Create(IPooledObjectPolicy policy) { }

	[CompilerGenerated]
	public int get_MaximumRetained() { }

	[CompilerGenerated]
	public void set_MaximumRetained(int value) { }

}

