namespace EFT.Achievements;

public sealed class HiddenAchievementsSummaryView : UIElement
{
	[SerializeField]
	private TMP_Text _totalText; //Field offset: 0x70
	[SerializeField]
	private LocalizedText _descriptionText; //Field offset: 0x78

	public HiddenAchievementsSummaryView() { }

	public void Show(int hiddenAchievementsCount) { }

}

