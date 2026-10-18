namespace Sirenix.Serialization;

public sealed class Vector2DictionaryKeyPathProvider : BaseDictionaryKeyPathProvider
{

	public virtual string ProviderID
	{
		 get { } //Length: 49
	}

	public Vector2DictionaryKeyPathProvider() { }

	public virtual int Compare(Vector2 x, Vector2 y) { }

	public virtual string get_ProviderID() { }

	public virtual Vector2 GetKeyFromPathString(string pathStr) { }

	public virtual string GetPathStringFromKey(Vector2 key) { }

}

