namespace EFT.UI;

public sealed class ClothingRequirements : UIElement
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static UnityAction <>9__10_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal void <SetupExternalObtainButtonTooltip>b__10_0() { }

	}

	[CompilerGenerated]
	private static class <>O
	{
		public static UnityAction <0>__CloseTooltip; //Field offset: 0x0
		public static Action <1>__CloseTooltip; //Field offset: 0x8

	}

	[SerializeField]
	private Image _clothingImage; //Field offset: 0x70
	[SerializeField]
	private TextMeshProUGUI _suiteName; //Field offset: 0x78
	[SerializeField]
	private TextMeshProUGUI _suiteDescription; //Field offset: 0x80
	[SerializeField]
	private GameObject _externalObtain; //Field offset: 0x88
	[SerializeField]
	private GameObject _internalObtain; //Field offset: 0x90
	[SerializeField]
	private SkillsAndLevelsRequirementsPanel _skillsAndLevelsRow; //Field offset: 0x98
	[SerializeField]
	private DefaultUIButton _externalObtainButton; //Field offset: 0xA0
	private Profile _profile; //Field offset: 0xA8
	private string _expansionsOfferUrl; //Field offset: 0xB0

	public ClothingRequirements() { }

	public virtual void Close() { }

	private void HandleExternalObtainButtonClick() { }

	private void SetupExternalObtainButtonTooltip() { }

	public void Show(FullOffer offer, Sprite clothingSprite, Profile profile, TraderInfo trader, QuestBook quests, AchievementsBook achievements, Stash stashGrid, OfferRequirements requirements, Action onAvailableChanged) { }

}

