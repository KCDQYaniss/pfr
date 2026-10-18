namespace Microsoft.Extensions.ObjectPool;

public interface IPooledObjectPolicy`1
{

	public T Create() { }

	public bool Return(T obj) { }

}

