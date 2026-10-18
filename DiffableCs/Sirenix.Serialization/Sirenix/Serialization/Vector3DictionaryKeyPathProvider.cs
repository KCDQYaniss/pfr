namespace Sirenix.Serialization;

public sealed class Vector3DictionaryKeyPathProvider : BaseDictionaryKeyPathProvider
{

	public virtual string ProviderID
	{
		 get { } //Length: 49
	}

	public Vector3DictionaryKeyPathProvider() { }

	public virtual int Compare(Vector3 x, Vector3 y) { }

	public virtual string get_ProviderID() { }

	public virtual Vector3 GetKeyFromPathString(string pathStr) { }

	public virtual string GetPathStringFromKey(Vector3 key) { }

}

