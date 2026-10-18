//Type is in global namespace

public class ObjectVisibility
{
	[Flags]
	internal enum CheckType
	{
		Distance = 1,
		Frustrum = 2,
	}

	[SerializeField]
	internal struct Settings
	{
		public CheckType check; //Field offset: 0x0
		public float sqrDistance; //Field offset: 0x4

	}

	private Transform _transform; //Field offset: 0x10
	private Renderer[] _renderers; //Field offset: 0x18
	private Camera _camera; //Field offset: 0x20
	private Settings _settings; //Field offset: 0x28

	public bool IsInDistance
	{
		 get { } //Length: 389
	}

	public bool IsInFrustrumView
	{
		 get { } //Length: 316
	}

	public bool IsVisible
	{
		 get { } //Length: 332
	}

	public ObjectVisibility(Camera camera, GameObject gameObject, Settings settings) { }

	public bool get_IsInDistance() { }

	public bool get_IsInFrustrumView() { }

	public bool get_IsVisible() { }

}

