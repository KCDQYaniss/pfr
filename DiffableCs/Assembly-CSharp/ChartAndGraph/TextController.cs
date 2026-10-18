namespace ChartAndGraph;

[ExecuteInEditMode]
[RequireComponent(typeof(ChartItem))]
public class TextController : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass22_0
	{
		public TextController <>4__this; //Field offset: 0x10
		public float scale; //Field offset: 0x18

		public <>c__DisplayClass22_0() { }

		internal bool <ApplyTextPosition>b__0(BillboardText x) { }

	}

	private const float PreviousScale = -1; //Field offset: 0x0
	public Camera Camera; //Field offset: 0x20
	public float PlaneDistance; //Field offset: 0x28
	private Canvas _canvas; //Field offset: 0x30
	private bool _invalidated; //Field offset: 0x38
	private AnyChart _privateParent; //Field offset: 0x40
	private readonly List _textList; //Field offset: 0x48

	internal AnyChart Parent
	{
		internal get { } //Length: 5
		internal set { } //Length: 496
	}

	private Canvas SafeCanvas
	{
		private get { } //Length: 26
	}

	internal List Text
	{
		internal get { } //Length: 5
	}

	public TextController() { }

	public void AddText(BillboardText billboard) { }

	public void ApplyTextPosition() { }

	private Camera AssignCamera(Camera cam) { }

	private void Canvas_willRenderCanvases() { }

	public void DestroyAll() { }

	private Camera EnsureCamera() { }

	private void EnsureCanvas() { }

	internal AnyChart get_Parent() { }

	private Canvas get_SafeCanvas() { }

	internal List get_Text() { }

	private void OnDestroy() { }

	internal void set_Parent(AnyChart value) { }

	private void Start() { }

}

