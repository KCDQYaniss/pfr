namespace EFT.UI;

public sealed class CustomizationOfferTooltip : Tooltip
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action <>9__3_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal void <Show>b__3_0(bool _) { }

	}

	[SerializeField]
	private ClothingRequirements _clothingRequirements; //Field offset: 0xA8
	[Header("Configuration")]
	[SerializeField]
	private float _tooltipDelay; //Field offset: 0xB0
	[SerializeField]
	private Vector2 _tooltipOffset; //Field offset: 0xB4

	public CustomizationOfferTooltip() { }

	public void Show(FullOffer offer, Sprite clothingSprite, Profile profile, TraderInfo trader, QuestBook quests, AchievementsBook achievements, Stash stashGrid, OfferRequirements requirements) { }

}

