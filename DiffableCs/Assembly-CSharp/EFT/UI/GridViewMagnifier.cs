namespace EFT.UI;

public sealed class GridViewMagnifier : MonoBehaviour
{
	[SerializeField]
	private GridView _gridView; //Field offset: 0x20
	[SerializeField]
	private ScrollRect _scrollRect; //Field offset: 0x28
	private Nullable _cachedRect; //Field offset: 0x30
	private RectTransform _scrollRectTransform; //Field offset: 0x48
	private Vector2 _previousPosition; //Field offset: 0x50
	private LayoutElement _gridLayout; //Field offset: 0x58

	public GridViewMagnifier() { }

	[CompilerGenerated]
	private void <Awake>b__5_0(Vector2 position) { }

	[CompilerGenerated]
	private void <InitGridView>b__6_0() { }

	private void Awake() { }

	private void CorrectGridSize() { }

	public void InitGridView(GridView gridView) { }

	private void OnDisable() { }

	private void ProceedMagnify(bool calculate, bool forceMagnify) { }

	private void Update() { }

}

