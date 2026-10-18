//Type is in global namespace

public interface IBackendCache : IDisposable
{

	public void Save(string cacheId, T data, string etag) { }

	public bool TryGet(string cacheId, out T data, out string etag) { }

}

