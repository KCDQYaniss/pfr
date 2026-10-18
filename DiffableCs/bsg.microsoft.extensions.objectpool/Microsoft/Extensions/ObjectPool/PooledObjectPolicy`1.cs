namespace Microsoft.Extensions.ObjectPool;

public abstract class PooledObjectPolicy`1 : IPooledObjectPolicy
{

	protected PooledObjectPolicy`1() { }

	public abstract T Create() { }

	public abstract bool Return(T obj) { }

}

