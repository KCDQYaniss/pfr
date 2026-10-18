namespace MultiFlare;

public class ProFlareAtlas : ScriptableObject
{
	internal struct Container
	{
		[FormerlySerializedAs("name")]
		[SerializeField]
		private string _name; //Field offset: 0x0
		[FormerlySerializedAs("UV")]
		[SerializeField]
		private Rect _rect; //Field offset: 0x8

		public string Name
		{
			 get { } //Length: 4
		}

		public Rect UvRect
		{
			 get { } //Length: 11
		}

		public string get_Name() { }

		public Rect get_UvRect() { }

	}

	[FormerlySerializedAs("elementsList")]
	[SerializeField]
	private Container[] _containers; //Field offset: 0x18

	public IEnumerable GetAll
	{
		 get { } //Length: 5
	}

	public ProFlareAtlas() { }

	public IEnumerable get_GetAll() { }

	public Rect GetUvRectByIndex(int index) { }

}

