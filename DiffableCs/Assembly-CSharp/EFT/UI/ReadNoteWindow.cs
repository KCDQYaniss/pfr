namespace EFT.UI;

[UsedImplicitly]
public sealed class ReadNoteWindow : Window
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action <>9__31_1; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal void <Show>b__31_1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass31_0
	{
		public ItemContext itemContext; //Field offset: 0x10
		public ReadNoteWindow <>4__this; //Field offset: 0x18
		public ItemController itemController; //Field offset: 0x20

		public <>c__DisplayClass31_0() { }

		internal void <Show>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass33_0
	{
		public NoteItemModelView noteView; //Field offset: 0x10
		public ReadNoteWindow <>4__this; //Field offset: 0x18

		public <>c__DisplayClass33_0() { }

		internal void <ShowContents>b__0() { }

		internal void <ShowContents>b__1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass39_0
	{
		public NoteItemPageView pageView; //Field offset: 0x10
		public ReadNoteWindow <>4__this; //Field offset: 0x18

		public <>c__DisplayClass39_0() { }

		internal void <CreatePages>b__0() { }

	}

	[CompilerGenerated]
	private struct <ShowContents>d__33 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ReadNoteWindow <>4__this; //Field offset: 0x20
		private YieldAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private const string NOTE_TEMPLATES_PATH = "UI/NoteTemplates/"; //Field offset: 0x0
	private const int MAX_RENDER_SIZE = 1600; //Field offset: 0x0
	private const float FIELD_OF_VIEW = 22; //Field offset: 0x0
	private const double RAD_FOW = 0.3839724354387525; //Field offset: 0x0
	[SerializeField]
	[UsedImplicitly]
	private DefaultUIButton _buttonNextPage; //Field offset: 0xB8
	[SerializeField]
	[UsedImplicitly]
	private DefaultUIButton _buttonPrevPage; //Field offset: 0xC0
	[SerializeField]
	[UsedImplicitly]
	private Toggle _buttonLocalize; //Field offset: 0xC8
	[SerializeField]
	[UsedImplicitly]
	private TextMeshProUGUI _pageCounterField; //Field offset: 0xD0
	[SerializeField]
	[UsedImplicitly]
	private TextMeshProUGUI _pageCounterSizeField; //Field offset: 0xD8
	[SerializeField]
	[UsedImplicitly]
	private LayoutElement _sizeLimiter; //Field offset: 0xE0
	[SerializeField]
	[UsedImplicitly]
	private ScrollRect _scrollRect; //Field offset: 0xE8
	[SerializeField]
	[UsedImplicitly]
	private Transform _itemModelContainer; //Field offset: 0xF0
	[SerializeField]
	[UsedImplicitly]
	private RectTransform _pagesContainer; //Field offset: 0xF8
	[SerializeField]
	[UsedImplicitly]
	private CanvasGroup _localizationCanvasGroup; //Field offset: 0x100
	[SerializeField]
	[UsedImplicitly]
	private NoteItemPageView _pageTemplate; //Field offset: 0x108
	[SerializeField]
	[UsedImplicitly]
	private Camera _camera; //Field offset: 0x110
	[SerializeField]
	[UsedImplicitly]
	private RawImage _cameraImage; //Field offset: 0x118
	[SerializeField]
	[UsedImplicitly]
	private AspectRatioFitter _ratio; //Field offset: 0x120
	[SerializeField]
	[UsedImplicitly]
	private DragRotator _rotator; //Field offset: 0x128
	[SerializeField]
	[UsedImplicitly]
	private Vector2 _defaultRotation; //Field offset: 0x130
	private ItemController _itemController; //Field offset: 0x138
	private NoteItem _item; //Field offset: 0x140
	private NoteItemModelView _noteView; //Field offset: 0x148
	private int _currentPage; //Field offset: 0x150
	private int _pageCount; //Field offset: 0x154
	private bool _localizedMode; //Field offset: 0x158
	private RenderTexture _renderTexture; //Field offset: 0x160
	private readonly Queue _pageCache; //Field offset: 0x168
	private readonly List _activePages; //Field offset: 0x170

	private bool LocalizationMode
	{
		private set { } //Length: 372
	}

	public ReadNoteWindow() { }

	private void AdjustCamera(float camDistance, Vector2 maxSize) { }

	private void CreatePages(NoteItemModelView noteView) { }

	private void CreateRenderTexture(Vector2 size) { }

	private static Bounds GetBounds(GameObject model) { }

	private static ValueTuple GetCameraDistance(GameObject model) { }

	private void LocalizeClickHandler(bool isOn) { }

	private void NextPageHandler() { }

	[UsedImplicitly]
	private void OnRectTransformDimensionsChange() { }

	private void PrewPageHandler() { }

	private void RemoveItemHandler(RemoveItemEventArgs removeItemEventArgs) { }

	private void set_LocalizationMode(bool value) { }

	private void SetupPreview() { }

	public WindowContext Show(NoteItem noteItem, ItemContext itemContext, ItemController itemController) { }

	[AsyncStateMachine(typeof(<ShowContents>d__33))]
	private Task ShowContents() { }

	private void ShowPage(int page) { }

	protected virtual void TranslateAxes(ref float[] axes) { }

	protected virtual ETranslateResult TranslateCommand(ECommand command) { }

}

