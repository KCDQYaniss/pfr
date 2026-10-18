namespace EFT.UI;

public sealed class SeasonalPerksList : UIElement
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass15_0
	{
		public Profile profile; //Field offset: 0x10
		public SeasonalPerksList <>4__this; //Field offset: 0x18

		public <>c__DisplayClass15_0() { }

		internal void <Show>b__0() { }

	}

	[Header("Common")]
	[SerializeField]
	private SeasonalCommonPerkView _commonPerkTemplate; //Field offset: 0x70
	[SerializeField]
	private Transform _commonPerksContainer; //Field offset: 0x78
	[SerializeField]
	private GameObject _commonPerksGO; //Field offset: 0x80
	[Header("Personal Positive")]
	[SerializeField]
	private SeasonalPersonalPerkView _personalPerkTemplate; //Field offset: 0x88
	[SerializeField]
	private Transform _positivePerksContainer; //Field offset: 0x90
	[SerializeField]
	private GameObject _positivePerksGO; //Field offset: 0x98
	[Header("Personal Negative")]
	[SerializeField]
	private Transform _negativePerksContainer; //Field offset: 0xA0
	[SerializeField]
	private GameObject _negativePerksGO; //Field offset: 0xA8
	private readonly Dictionary _commonPerkViews; //Field offset: 0xB0
	private readonly Dictionary _personalPerkViews; //Field offset: 0xB8
	private PerkManager _perkManager; //Field offset: 0xC0
	private IImageLoader _imageLoader; //Field offset: 0xC8
	private IEnumerable _commonPerks; //Field offset: 0xD0
	private IEnumerable _personalPerks; //Field offset: 0xD8

	public SeasonalPerksList() { }

	private void Awake() { }

	private void Refresh() { }

	private static void SetSectionActive(GameObject sectionObject, Transform sectionContainer, bool active) { }

	public void Show(Profile profile, IImageLoader imageLoader) { }

	private void ShowCommonPerk(CommonPerk perk) { }

	private void ShowPersonalPerk(PersonalPerk perk) { }

}

