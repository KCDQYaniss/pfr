namespace EFT.UI.Prestige;

[Obfuscation(Exclude = True)]
[UsedImplicitly]
public sealed class PrestigeScreen : UIElement
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass27_0
	{
		public PrestigeTemplate template; //Field offset: 0x10

		public <>c__DisplayClass27_0() { }

		internal bool <SelectNextPrestige>b__0(PrestigeStatusData data) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass28_0
	{
		public PrestigeTemplate prestigeTemplate; //Field offset: 0x10
		public PrestigeScreen <>4__this; //Field offset: 0x18

		public <>c__DisplayClass28_0() { }

		internal void <CreateLevels>g__LevelClickHandler|1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass28_1
	{
		public PrestigeLevelView levelView; //Field offset: 0x10
		public <>c__DisplayClass28_0 CS$<>8__locals1; //Field offset: 0x18

		public <>c__DisplayClass28_1() { }

		internal void <CreateLevels>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass29_0
	{
		public PrestigeLevel prestigeLevel; //Field offset: 0x10
		public PrestigeScreen <>4__this; //Field offset: 0x18

		public <>c__DisplayClass29_0() { }

		internal void <SelectPrestige>b__0() { }

		internal void <SelectPrestige>g__StatusChangedHandler|1(PrestigeLevel changedPrestige, bool _) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass31_0
	{
		public TweenerCore tween; //Field offset: 0x10

		public <>c__DisplayClass31_0() { }

		internal void <ShowLevels>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass32_0
	{
		public PrestigeConditionView conditionView; //Field offset: 0x10
		public PrestigeScreen <>4__this; //Field offset: 0x18

		public <>c__DisplayClass32_0() { }

		internal void <ShowConditions>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass33_0
	{
		public PrestigeReward reward; //Field offset: 0x10
		public PrestigeScreen <>4__this; //Field offset: 0x18

		public <>c__DisplayClass33_0() { }

		internal void <ShowRewards>g__RewardSelectionHandler|1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass33_1
	{
		public PrestigeRewardView rewardView; //Field offset: 0x10
		public <>c__DisplayClass33_0 CS$<>8__locals1; //Field offset: 0x18

		public <>c__DisplayClass33_1() { }

		internal void <ShowRewards>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass33_2
	{
		public GameObject spacer; //Field offset: 0x10

		public <>c__DisplayClass33_2() { }

		internal void <ShowRewards>b__2() { }

	}

	internal sealed class InventoryPrestigeTabController : UIElementTabController
	{
		private readonly Profile _profile; //Field offset: 0x18
		private readonly PrestigeController _prestigeController; //Field offset: 0x20
		private readonly InventoryController _inventoryController; //Field offset: 0x28
		private readonly IEftSession _session; //Field offset: 0x30

		public InventoryPrestigeTabController(Profile profile, PrestigeController prestigeController, InventoryController inventoryController, IEftSession session, PrestigeScreen prestigeScreen) { }

		public virtual void Show() { }

	}

	private const float HIGHLIGHT_ANIMATION_DURATION = 0.5; //Field offset: 0x0
	[SerializeField]
	private TMP_Text _obtainErrorField; //Field offset: 0x70
	[SerializeField]
	private DefaultUiButtonNewStyle _obtainPrestige; //Field offset: 0x78
	[SerializeField]
	private Image _levelIcon; //Field offset: 0x80
	[SerializeField]
	private Transform _levelHighlight; //Field offset: 0x88
	[SerializeField]
	private RectTransform _levelViewsContainer; //Field offset: 0x90
	[SerializeField]
	private PrestigeLevelView _levelViewTemplate; //Field offset: 0x98
	private readonly Dictionary _levelViews; //Field offset: 0xA0
	private readonly Queue _levelViewsPool; //Field offset: 0xA8
	[SerializeField]
	private Transform _conditionViewsContainer; //Field offset: 0xB0
	[SerializeField]
	private PrestigeConditionView _conditionsViewTemplate; //Field offset: 0xB8
	private readonly Queue _conditionViewsPool; //Field offset: 0xC0
	private readonly CompositeDisposable _levelDisposable; //Field offset: 0xC8
	[SerializeField]
	private GridLayoutGroup _rewardViewsContainer; //Field offset: 0xD0
	[SerializeField]
	private PrestigeRewardView _rewardViewTemplate; //Field offset: 0xD8
	private readonly List _rewardViews; //Field offset: 0xE0
	private readonly Queue _rewardViewsPool; //Field offset: 0xE8
	[SerializeField]
	private PrestigeRewardDetailsView _rewardDetails; //Field offset: 0xF0
	private Profile _profile; //Field offset: 0xF8
	private PrestigeController _prestigeController; //Field offset: 0x100
	private InventoryController _inventoryController; //Field offset: 0x108
	private IEftSession _session; //Field offset: 0x110
	[CanBeNull]
	private PrestigeTemplate _nextPrestige; //Field offset: 0x118
	private PrestigeTemplate _currentPrestige; //Field offset: 0x120
	private PrestigeReward _currentReward; //Field offset: 0x128

	public PrestigeScreen() { }

	[CompilerGenerated]
	private void <Show>b__26_0() { }

	private void CreateLevels(PrestigeSettings settings) { }

	private void ObtainPrestigeHandler() { }

	private void SelectNextPrestige() { }

	private void SelectPrestige(PrestigeTemplate prestige) { }

	private void Show(Profile profile, PrestigeController prestigeController, InventoryController inventoryController, IEftSession session) { }

	private void ShowConditions(PrestigeLevel prestige) { }

	private void ShowLevels(PrestigeTemplate prestige, bool firstPass) { }

	private void ShowRewards(PrestigeTemplate prestige) { }

	private void UpdateClaimButton(PrestigeLevel prestige) { }

}

