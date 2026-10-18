namespace Sirenix.Serialization;

public interface IDictionaryKeyPathProvider`1 : IDictionaryKeyPathProvider
{

	public int Compare(T x, T y) { }

	public T GetKeyFromPathString(string pathStr) { }

	public string GetPathStringFromKey(T key) { }

}

