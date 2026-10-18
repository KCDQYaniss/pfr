namespace EFT.UI.Seasons;

public sealed class BattlePassRewardPageControlsView : UIElement
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass17_0
	{
		public IBattlePassPage page; //Field offset: 0x10
		public BattlePassRewardPageControlsView <>4__this; //Field offset: 0x18

		public <>c__DisplayClass17_0() { }

		internal void <InitMarkers>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass17_1
	{
		public BattlePassPageMarkerView marker; //Field offset: 0x10
		public <>c__DisplayClass17_0 CS$<>8__locals1; //Field offset: 0x18

		public <>c__DisplayClass17_1() { }

		internal void <InitMarkers>b__1() { }

	}

	private readonly BindableEvent _onPageSelected; //Field offset: 0x70
	[SerializeField]
	private BattlePassPageMarkerView _pageMarkerTemplate; //Field offset: 0x78
	[SerializeField]
	private RectTransform _pageMarkerContainer; //Field offset: 0x80
	[SerializeField]
	private Button _backButton; //Field offset: 0x88
	[SerializeField]
	private Button _forwardButton; //Field offset: 0x90
	[SerializeField]
	private ButtonShortcutInputNode _backShortcut; //Field offset: 0x98
	[SerializeField]
	private ButtonShortcutInputNode _forwardShortcut; //Field offset: 0xA0
	[SerializeField]
	private TMP_Text _pageNumberField; //Field offset: 0xA8
	private BattlePass _battlePass; //Field offset: 0xB0
	private IBattlePassPage _previousPage; //Field offset: 0xB8
	private IBattlePassPage _currentPage; //Field offset: 0xC0
	private IBattlePassPage _nextPage; //Field offset: 0xC8
	private int _pageCount; //Field offset: 0xD0
	private readonly List _markers; //Field offset: 0xD8

	public IBindableEvent OnPageSelected
	{
		 get { } //Length: 5
	}

	public BattlePassRewardPageControlsView() { }

	[CompilerGenerated]
	private void <InitButtons>b__18_0() { }

	[CompilerGenerated]
	private void <InitButtons>b__18_1() { }

	[CompilerGenerated]
	private void <InitButtons>b__18_2() { }

	[CompilerGenerated]
	private void <InitButtons>b__18_3() { }

	public IBindableEvent get_OnPageSelected() { }

	private void InitButtons() { }

	private void InitMarkers() { }

	private void InvokePageSelect(IBattlePassPage page) { }

	public void SetPage(IBattlePassPage page) { }

	public void Show(BattlePass battlePass) { }

}

