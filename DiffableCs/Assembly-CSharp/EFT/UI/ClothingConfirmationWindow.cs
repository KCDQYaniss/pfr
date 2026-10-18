namespace EFT.UI;

public sealed class ClothingConfirmationWindow : Window
{
	[SerializeField]
	private DefaultUIButton _unlockButton; //Field offset: 0xB8
	[SerializeField]
	private ClothingRequirements _requirements; //Field offset: 0xC0

	protected virtual bool DragEnabled
	{
		 get { } //Length: 3
	}

	public ClothingConfirmationWindow() { }

	private void Accept() { }

	protected virtual void Awake() { }

	private void ChangeUnlockButtonAvailability(bool availableStatus) { }

	protected virtual bool get_DragEnabled() { }

	public DialogWindowContext Show(FullOffer offer, Profile profile, TraderInfo trader, QuestBook quests, AchievementsBook achievements, OfferRequirements requirements, Stash stashGrid, Sprite clothingSprite) { }

}

