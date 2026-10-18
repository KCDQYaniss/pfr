namespace Microsoft.Extensions.ObjectPool;

[Extension]
public static class ObjectPool
{

	public static ObjectPool Create(IPooledObjectPolicy policy = null) { }

	[Extension]
	public static void Preallocate(ObjectPool pool, int count) { }

}

