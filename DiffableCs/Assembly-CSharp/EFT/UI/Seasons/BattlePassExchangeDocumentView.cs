namespace EFT.UI.Seasons;

public sealed class BattlePassExchangeDocumentView : UIElement, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IPointerEnterHandler, IPointerExitHandler
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__29_2; //Field offset: 0x8
		public static Func <>9__39_0; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal int <Show>b__29_2(BattlePassItem item) { }

		internal bool <UpdateIcon>b__39_0(Image icon) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass29_0
	{
		public IBindableList items; //Field offset: 0x10
		public IBindableListWithEvent selectedDocuments; //Field offset: 0x18
		public BattlePassDocumentScheme document; //Field offset: 0x20
		public BattlePassExchangeDocumentView <>4__this; //Field offset: 0x28

		public <>c__DisplayClass29_0() { }

		internal void <Show>b__0(BattlePassItem _) { }

		internal bool <Show>b__3(BattlePassDocumentScheme scheme) { }

		internal void <Show>g__UpdateCount|1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass32_0
	{
		public BattlePassExchangeDocumentView <>4__this; //Field offset: 0x10
		public Item item; //Field offset: 0x18

		public <>c__DisplayClass32_0() { }

		internal void <ShowInternal>b__0() { }

	}

	[CompilerGenerated]
	private struct <UpdateIcon>d__39 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BattlePassExchangeDocumentView <>4__this; //Field offset: 0x20
		public ImageData image; //Field offset: 0x28
		public IImageLoader imageLoader; //Field offset: 0x30
		private Image <firstIcon>5__2; //Field offset: 0x38
		private CancellationToken <cancellationToken>5__3; //Field offset: 0x40
		private TaskAwaiter <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal struct BattlePassDocumentStatePair
	{
		public EDocumentPresentSubState StateType; //Field offset: 0x0
		public GameObject Target; //Field offset: 0x8

	}

	internal enum EDocumentPresentSubState
	{
		DefaultPresented = 0,
		Selected = 1,
		Disabled = 2,
	}

	private enum EDocumentState
	{
		Loading = 0,
		Present = 1,
	}

	private const float COUNT_PUNCH_DURATION = 0.15; //Field offset: 0x0
	private const float PRESS_SCALE_DURATION = 0.08; //Field offset: 0x0
	private const float PRESS_SCALE = 0.97; //Field offset: 0x0
	private static readonly Vector3 COUNT_PUNCH_SCALE; //Field offset: 0x0
	[SerializeField]
	private Button _button; //Field offset: 0x70
	[SerializeField]
	private Image[] _icons; //Field offset: 0x78
	[SerializeField]
	public TMP_Text[] _countFields; //Field offset: 0x80
	[SerializeField]
	private GameObject _chooseOnOtherSideIcon; //Field offset: 0x88
	[SerializeField]
	private GameObject _chooseOnOtherSide; //Field offset: 0x90
	[SerializeField]
	private GameObject _presentState; //Field offset: 0x98
	[SerializeField]
	private GameObject _loadingState; //Field offset: 0xA0
	[SerializeField]
	private BattlePassDocumentStatePair[] _exchangeStates; //Field offset: 0xA8
	private Nullable _setSelectedOnOtherSideLastState; //Field offset: 0xB0
	private EDocumentPresentSubState _presentLastState; //Field offset: 0xB4
	private BattlePassDocumentScheme _documentScheme; //Field offset: 0xB8
	[SerializeField]
	private EUISoundType _clickSound; //Field offset: 0xC0
	[SerializeField]
	private EUISoundType _hoverSound; //Field offset: 0xC4
	private LayoutElement _layoutElement; //Field offset: 0xC8
	private readonly BindableEvent _onClick; //Field offset: 0xD0
	private int _count; //Field offset: 0xD8

	public int Count
	{
		 set { } //Length: 741
	}

	public LayoutElement LayoutElement
	{
		 get { } //Length: 393
	}

	public IBindableEvent OnClick
	{
		 get { } //Length: 8
	}

	private static BattlePassExchangeDocumentView() { }

	public BattlePassExchangeDocumentView() { }

	public virtual void Close() { }

	public LayoutElement get_LayoutElement() { }

	public IBindableEvent get_OnClick() { }

	private void OnButtonClicked(Item item) { }

	public override void OnPointerDown(PointerEventData eventData) { }

	public override void OnPointerEnter(PointerEventData _) { }

	public override void OnPointerExit(PointerEventData eventData) { }

	public override void OnPointerUp(PointerEventData eventData) { }

	public void set_Count(int value) { }

	public void SetPresentState(EDocumentPresentSubState subState) { }

	public void SetSelectedOnOtherSide(bool state) { }

	private void SetState(EDocumentState state) { }

	public void Show(BattlePassDocumentScheme target, IImageLoader imageLoader) { }

	public void Show(BattlePassItemExchangeSettings exchangeSettings, IImageLoader imageLoader) { }

	public void Show(BattlePassController controller, BattlePassDocumentScheme document, IBindableListWithEvent selectedDocuments, IImageLoader imageLoader) { }

	private void ShowInternal(Item item, ImageData image, int count, IImageLoader imageLoader) { }

	private void TryPlayButtonSound(EUISoundType soundType) { }

	[AsyncStateMachine(typeof(<UpdateIcon>d__39))]
	private Task UpdateIcon(ImageData image, IImageLoader imageLoader) { }

}

