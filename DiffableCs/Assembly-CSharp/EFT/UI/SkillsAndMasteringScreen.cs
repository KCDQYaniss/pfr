namespace EFT.UI;

public class SkillsAndMasteringScreen : UIElement
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass9_0
	{
		public Profile profile; //Field offset: 0x10
		public IHealthController healthController; //Field offset: 0x18
		public InventoryController inventoryController; //Field offset: 0x20
		public IEftSession session; //Field offset: 0x28
		public SkillsAndMasteringScreen <>4__this; //Field offset: 0x30

		public <>c__DisplayClass9_0() { }

		internal void <Show>b__0(SkillsScreen x) { }

		internal void <Show>b__1(MasteringScreen x) { }

		internal void <Show>b__2(SeasonalPerksList x) { }

		internal void <Show>b__3() { }

	}

	internal sealed class SkillsAndMasteringTabController : UIElementTabController
	{
		private readonly Profile _profile; //Field offset: 0x18
		private readonly IEftSession _session; //Field offset: 0x20
		private readonly InventoryController _inventoryController; //Field offset: 0x28
		private readonly IHealthController _healthController; //Field offset: 0x30

		public SkillsAndMasteringTabController(SkillsAndMasteringScreen skillsTab, Profile profile, IEftSession session, InventoryController inventoryController, IHealthController healthController) { }

		public virtual void Show() { }

	}

	[SerializeField]
	private PlayerExperiencePanel _playerExperiencePanel; //Field offset: 0x70
	[SerializeField]
	private SkillsScreen _skillsScreen; //Field offset: 0x78
	[SerializeField]
	private MasteringScreen _masteringScreen; //Field offset: 0x80
	[SerializeField]
	private SeasonalPerksList _seasonalPerksList; //Field offset: 0x88
	[SerializeField]
	private Tab _skillsTab; //Field offset: 0x90
	[SerializeField]
	private Tab _masteringTab; //Field offset: 0x98
	[SerializeField]
	private Tab _seasonalPerksTab; //Field offset: 0xA0
	private TabGroup _skillMasterTabGroup; //Field offset: 0xA8

	public SkillsAndMasteringScreen() { }

	private TabGroup CreateTabGroup(bool isSeasonal) { }

	private void Show(Profile profile, IEftSession session, InventoryController inventoryController, IHealthController healthController) { }

}

