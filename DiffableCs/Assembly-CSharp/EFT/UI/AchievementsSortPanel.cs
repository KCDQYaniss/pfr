namespace EFT.UI;

public sealed class AchievementsSortPanel : BaseSortPanel
{
	internal sealed class AchievementsSortToButtonDictionary : SerializableEnumDictionary
	{

		public AchievementsSortToButtonDictionary() { }

	}

	[SerializeField]
	private AchievementsSortToButtonDictionary _buttons; //Field offset: 0x90

	public AchievementsSortPanel() { }

	public void Show(EAchievementsSortType defaultSortingType, bool defaultAscending) { }

}

