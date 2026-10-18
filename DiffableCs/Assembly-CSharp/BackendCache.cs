//Type is in global namespace

internal sealed class BackendCache : IBackendCache, IDisposable
{
	private class CacheEntry
	{
		[CompilerGenerated]
		private string <ETag>k__BackingField; //Field offset: 0x10
		[CompilerGenerated]
		private object <Data>k__BackingField; //Field offset: 0x18

		public object Data
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			 set { } //Length: 82
		}

		public string ETag
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			 set { } //Length: 82
		}

		public CacheEntry() { }

		[CompilerGenerated]
		public object get_Data() { }

		[CompilerGenerated]
		public string get_ETag() { }

		[CompilerGenerated]
		public void set_Data(object value) { }

		[CompilerGenerated]
		public void set_ETag(string value) { }

	}

	private readonly ConcurrentDictionary _cache; //Field offset: 0x10

	internal BackendCache(string dir) { }

	public override void Dispose() { }

	private string GetKey(string cacheId) { }

	public override void Save(string cacheId, T data, string etag) { }

	public override bool TryGet(string cacheId, out T data, out string etag) { }

}

