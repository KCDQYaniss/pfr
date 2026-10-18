namespace Microsoft.Extensions.ObjectPool;

public abstract class ObjectPoolProvider
{

	protected ObjectPoolProvider() { }

	public abstract ObjectPool Create(IPooledObjectPolicy policy) { }

	public ObjectPool Create() { }

}

