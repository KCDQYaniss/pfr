namespace EFT.UI.Ragfair;

public sealed class OffersUpdatePanel : UIElement
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__16_0; //Field offset: 0x8
		public static Action <>9__16_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal string <Show>b__16_0(int x) { }

		internal void <Show>b__16_1(int _) { }

	}

	private static readonly ReadOnlyCollection _linesCountVariants; //Field offset: 0x0
	[SerializeField]
	private DefaultUIButton _updateButton; //Field offset: 0x70
	[SerializeField]
	private DropDownBox _pagesCountDropdown; //Field offset: 0x78
	[SerializeField]
	private PageButton _pageButton; //Field offset: 0x80
	[SerializeField]
	private RectTransform _buttonsContainer; //Field offset: 0x88
	[SerializeField]
	private Button _previousPageButton; //Field offset: 0x90
	[SerializeField]
	private Button _nextPageButton; //Field offset: 0x98
	[SerializeField]
	private Button _firstPageButton; //Field offset: 0xA0
	[SerializeField]
	private Button _lastPageButton; //Field offset: 0xA8
	private readonly List _buttons; //Field offset: 0xB0
	private int _currentPage; //Field offset: 0xB8
	private int _pageCount; //Field offset: 0xBC
	private Action _onUpdate; //Field offset: 0xC0
	private Action _onPageClicked; //Field offset: 0xC8
	private bool _isInit; //Field offset: 0xD0

	private static OffersUpdatePanel() { }

	public OffersUpdatePanel() { }

	[CompilerGenerated]
	private void <Init>b__17_0() { }

	[CompilerGenerated]
	private void <Init>b__17_1() { }

	[CompilerGenerated]
	private void <Init>b__17_2() { }

	[CompilerGenerated]
	private void <Init>b__17_3() { }

	[CompilerGenerated]
	private void <Init>b__17_4() { }

	private void Awake() { }

	private void Init() { }

	public void Show(int onePageCount, int currentPage, int pageCount, Action onUpdate, Action onPageClicked) { }

	private void ShowButtons(int currentPage) { }

}

