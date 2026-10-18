namespace ComponentAce.Compression.Libs.zlib;

internal static class Pools
{
	private sealed class ZStream9CompressionLevelPooledObjectPolicy : PooledObjectPolicy
	{

		public ZStream9CompressionLevelPooledObjectPolicy() { }

		public virtual ZStream Create() { }

		public virtual bool Return(ZStream obj) { }

	}

	public static readonly ArrayPool BytesPool; //Field offset: 0x0
	public static readonly ObjectPool MemoryStreamPool; //Field offset: 0x8
	public static readonly DefaultObjectPool StreamsPool; //Field offset: 0x10

	private static Pools() { }

}

