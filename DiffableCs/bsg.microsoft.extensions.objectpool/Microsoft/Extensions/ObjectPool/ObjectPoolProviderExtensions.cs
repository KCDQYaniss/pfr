namespace Microsoft.Extensions.ObjectPool;

[Extension]
public static class ObjectPoolProviderExtensions
{

	[Extension]
	public static ObjectPool CreateStringBuilderPool(ObjectPoolProvider provider) { }

	[Extension]
	public static ObjectPool CreateStringBuilderPool(ObjectPoolProvider provider, int initialCapacity, int maximumRetainedCapacity) { }

}

