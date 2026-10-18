namespace EFT.UI;

[UsedImplicitly]
public sealed class NoteItemModelView : SerializedMonoBehaviour, IDisposable
{
	[SerializeField]
	[UsedImplicitly]
	private List _pages; //Field offset: 0x60
	[SerializeField]
	[UsedImplicitly]
	private Vector2Int _windowSize; //Field offset: 0x68
	[SerializeField]
	[UsedImplicitly]
	private Vector3 _offset; //Field offset: 0x70

	public Vector3 Offset
	{
		 get { } //Length: 19
	}

	public int PageCount
	{
		 get { } //Length: 65
	}

	public IEnumerable Pages
	{
		 get { } //Length: 5
	}

	public Vector2Int WindowSize
	{
		 get { } //Length: 5
	}

	public NoteItemModelView() { }

	private void Close() { }

	public override void Dispose() { }

	public Vector3 get_Offset() { }

	public int get_PageCount() { }

	public IEnumerable get_Pages() { }

	public Vector2Int get_WindowSize() { }

	public void Show(int page = 0) { }

}

