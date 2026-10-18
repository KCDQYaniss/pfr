//Type is in global namespace

public class MetaXRAcousticGeometryLoadQueue : MonoBehaviour
{
	private struct QueuedItem
	{
		internal MetaXRAcousticGeometry geometry; //Field offset: 0x0
		internal byte[] bytes; //Field offset: 0x8
		internal string sourcePath; //Field offset: 0x10

	}

	private static MetaXRAcousticGeometryLoadQueue _instance; //Field offset: 0x0
	private readonly Queue _queue; //Field offset: 0x20

	public static bool Exist
	{
		 get { } //Length: 230
	}

	public static MetaXRAcousticGeometryLoadQueue Instance
	{
		 get { } //Length: 344
	}

	public MetaXRAcousticGeometryLoadQueue() { }

	public static MetaXRAcousticGeometryLoadQueue Create(Transform parent = null) { }

	public void Enqueue(MetaXRAcousticGeometry geometry, byte[] bytes, string sourcePath) { }

	public static bool get_Exist() { }

	public static MetaXRAcousticGeometryLoadQueue get_Instance() { }

	private void Update() { }

}

