namespace EFT.UI.Seasons;

public abstract class SeasonRewardPageView`2 : UIElement
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass17_0
	{
		public SeasonRewardPageView <>4__this; //Field offset: 0x0
		public TReward reward; //Field offset: 0x0

		public <>c__DisplayClass17_0() { }

		internal void <ShowReward>b__0() { }

	}

	private readonly BindableEvent _onRewardSelected; //Field offset: 0x0
	[SerializeField]
	private RectTransform[,] _viewContainers; //Field offset: 0x0
	[SerializeField]
	private RectTransform _poolContainer; //Field offset: 0x0
	[CompilerGenerated]
	private IImageLoader <ImageLoader>k__BackingField; //Field offset: 0x0
	private readonly Dictionary _views; //Field offset: 0x0
	private UiElementPool _viewPool; //Field offset: 0x0

	protected private IImageLoader ImageLoader
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public IBindableEvent OnRewardSelected
	{
		 get { } //Length: 5
	}

	protected Vector2Int Size
	{
		 get { } //Length: 160
	}

	protected abstract TRewardView ViewTemplate
	{
		 get { } //Length: 0
	}

	protected SeasonRewardPageView`2() { }

	[CompilerGenerated]
	protected IImageLoader get_ImageLoader() { }

	public IBindableEvent get_OnRewardSelected() { }

	protected Vector2Int get_Size() { }

	protected abstract TRewardView get_ViewTemplate() { }

	protected abstract void InitRewardView(TReward reward, TRewardView view) { }

	[CompilerGenerated]
	private void set_ImageLoader(IImageLoader value) { }

	protected void SetContainerActive(int x, int y, bool active) { }

	public void SetSelection(TReward reward) { }

	protected void Show(IEnumerable rewards, IImageLoader imageLoader) { }

	protected void ShowReward(TReward reward) { }

}

