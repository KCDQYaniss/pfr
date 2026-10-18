namespace Microsoft.Extensions.ObjectPool;

public abstract class ObjectPool`1
{

	protected ObjectPool`1() { }

	public abstract T Get() { }

	public abstract void Return(T obj) { }

}

