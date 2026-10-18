namespace Microsoft.Extensions.ObjectPool;

public class LeakTrackingObjectPoolProvider : ObjectPoolProvider
{
	private readonly ObjectPoolProvider _inner; //Field offset: 0x10

	public LeakTrackingObjectPoolProvider(ObjectPoolProvider inner) { }

	public virtual ObjectPool Create(IPooledObjectPolicy policy) { }

}

