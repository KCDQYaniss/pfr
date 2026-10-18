namespace Microsoft.Extensions.ObjectPool;

public class DefaultObjectPool`1 : ObjectPool
{
	[CompilerGenerated]
	private struct <>c__DisplayClass6_0
	{
		public IPooledObjectPolicy policy; //Field offset: 0x0

	}

	[DebuggerDisplay("{Element}")]
	internal struct ObjectWrapper
	{
		public T Element; //Field offset: 0x0

	}

	readonly ObjectWrapper[] _items; //Field offset: 0x0
	readonly IPooledObjectPolicy _policy; //Field offset: 0x0
	readonly bool _isDefaultPolicy; //Field offset: 0x0
	 T _firstItem; //Field offset: 0x0
	readonly PooledObjectPolicy _fastPolicy; //Field offset: 0x0

	public DefaultObjectPool`1(IPooledObjectPolicy policy) { }

	public DefaultObjectPool`1(IPooledObjectPolicy policy, int maximumRetained) { }

	[CompilerGenerated]
	internal static bool <.ctor>g__IsDefaultPolicy|6_0(ref <>c__DisplayClass6_0 unnamed_param_0) { }

	private T Create() { }

	public virtual T Get() { }

	public virtual void Return(T obj) { }

}

