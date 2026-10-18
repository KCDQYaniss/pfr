namespace EFT.Hideout;

public class AreaIcon : UIElement
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__51_1; //Field offset: 0x8
		public static Func <>9__55_0; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal bool <ProducingStartedHandler>b__55_0(ItemsProducerBase p) { }

		internal bool <Show>b__51_1(HideoutDialogEntryPoint dialogEntryPoint) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass51_0
	{
		public GeneratorBehaviour generatorBehaviour; //Field offset: 0x10
		public AreaIcon <>4__this; //Field offset: 0x18

		public <>c__DisplayClass51_0() { }

		internal void <Show>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass51_1
	{
		public ItemsProducerBase producer; //Field offset: 0x10
		public <>c__DisplayClass51_0 CS$<>8__locals1; //Field offset: 0x18

		public <>c__DisplayClass51_1() { }

		internal void <Show>b__2() { }

		internal void <Show>b__3() { }

		internal void <Show>b__4() { }

		internal void <Show>b__5() { }

		internal void <Show>b__6() { }

	}

	private const float FADE_COOLDOWN = 0.3; //Field offset: 0x0
	private const float PRODUCTION_FADE_COOLDOWN = 1; //Field offset: 0x0
	private const float FADE_TO_VALUE = 0.65; //Field offset: 0x0
	[SerializeField]
	private TextMeshProUGUI _currentAreaLevel; //Field offset: 0x70
	[SerializeField]
	private TextMeshProUGUI _nextAreaLevel; //Field offset: 0x78
	[SerializeField]
	private CanvasGroup _iconCanvasGroup; //Field offset: 0x80
	[SerializeField]
	private Image _selectedBorder; //Field offset: 0x88
	[SerializeField]
	private Image _hoverBorder; //Field offset: 0x90
	[SerializeField]
	private Image _areaIconImage; //Field offset: 0x98
	[SerializeField]
	private Image _backgroundImage; //Field offset: 0xA0
	[SerializeField]
	private Image _constructingImage; //Field offset: 0xA8
	[SerializeField]
	private Image _producingImage; //Field offset: 0xB0
	[SerializeField]
	private GameObject _lockedIcon; //Field offset: 0xB8
	[SerializeField]
	private GameObject _unlockedIcon; //Field offset: 0xC0
	[SerializeField]
	private GameObject _readyToUpgradeIcon; //Field offset: 0xC8
	[SerializeField]
	private GameObject _constructingIcon; //Field offset: 0xD0
	[SerializeField]
	private GameObject _upgradingIcon; //Field offset: 0xD8
	[SerializeField]
	private GameObject _producingIcon; //Field offset: 0xE0
	[SerializeField]
	private GameObject _outOfFuelIcon; //Field offset: 0xE8
	[SerializeField]
	private Image _eliteBackgroundImage; //Field offset: 0xF0
	[SerializeField]
	private Sprite _defaultSprite; //Field offset: 0xF8
	[SerializeField]
	private Sprite _readyToPerformSprite; //Field offset: 0x100
	[SerializeField]
	private Sprite _errorSprite; //Field offset: 0x108
	[SerializeField]
	private GameObject _producingProgressState; //Field offset: 0x110
	[SerializeField]
	private GameObject _producingReadyState; //Field offset: 0x118
	[SerializeField]
	private GameObject _dialogAvailableIcon; //Field offset: 0x120
	protected TweenerCore BackImageFade; //Field offset: 0x128
	private List _tweeners; //Field offset: 0x130
	private TweenerCore _producingFade; //Field offset: 0x138
	private TweenerCore _producingFill; //Field offset: 0x140
	private TweenerCore _constructingImageFade; //Field offset: 0x148
	[CompilerGenerated]
	private AreaData <Data>k__BackingField; //Field offset: 0x150

	protected Image BackgroundImage
	{
		 get { } //Length: 8
	}

	protected GameObject ConstructingIcon
	{
		 get { } //Length: 8
	}

	private AreaData Data
	{
		[CompilerGenerated]
		private get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	protected Sprite DefaultSprite
	{
		 get { } //Length: 8
	}

	protected Sprite ErrorSprite
	{
		 get { } //Length: 8
	}

	protected GameObject LockedIcon
	{
		 get { } //Length: 8
	}

	protected GameObject ReadyToUpgradeIcon
	{
		 get { } //Length: 8
	}

	protected GameObject UnlockedIcon
	{
		 get { } //Length: 8
	}

	protected GameObject UpgradingIcon
	{
		 get { } //Length: 8
	}

	public AreaIcon() { }

	[CompilerGenerated]
	private void <SetBackgroundImageSprite>b__66_0() { }

	[CompilerGenerated]
	private void <SetData>b__53_0(bool silent) { }

	[CompilerGenerated]
	private void <SetStatus>b__65_0() { }

	public virtual void Close() { }

	private void GeneratorStateChangedHandler(IGenerator generator, bool value) { }

	protected Image get_BackgroundImage() { }

	protected GameObject get_ConstructingIcon() { }

	[CompilerGenerated]
	private AreaData get_Data() { }

	protected Sprite get_DefaultSprite() { }

	protected Sprite get_ErrorSprite() { }

	protected GameObject get_LockedIcon() { }

	protected GameObject get_ReadyToUpgradeIcon() { }

	protected GameObject get_UnlockedIcon() { }

	protected GameObject get_UpgradingIcon() { }

	private void GetProducedItemsHandler(IEnumerable obj) { }

	private void LightStatusChangedHandler(ELightStatus lightStatus) { }

	private void ProducingCompletedHandler(ItemsProducerBase _, Item[] items, ProducingItemController producingItem) { }

	private void ProducingStartedHandler(ItemsProducerBase _, ProducingItemController item) { }

	private void ProductionSpeedChangedHandler() { }

	[CompilerGenerated]
	private void set_Data(AreaData value) { }

	private void SetBackgroundImageSprite() { }

	protected void SetData(AreaData data) { }

	private void SetHover(bool value) { }

	protected override void SetLevel() { }

	protected void SetLevel(int level) { }

	private void SetSelectedStatus(bool value) { }

	protected override void SetStatus() { }

	public void Show(AreaData data) { }

	private void UpdateProducingTweeners() { }

	private void WorkingStatusChangedHandler() { }

}

