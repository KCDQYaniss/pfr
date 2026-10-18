namespace Microsoft.Extensions.ObjectPool;

public class DefaultPooledObjectPolicy`1 : PooledObjectPolicy
{

	public DefaultPooledObjectPolicy`1() { }

	public virtual T Create() { }

	public virtual bool Return(T obj) { }

}

