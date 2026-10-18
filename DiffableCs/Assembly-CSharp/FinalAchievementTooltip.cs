//Type is in global namespace

public class FinalAchievementTooltip : Tooltip
{
	[SerializeField]
	private TMP_Text _headerLabel; //Field offset: 0xA8
	[SerializeField]
	private TMP_Text _mainLabel; //Field offset: 0xB0

	public FinalAchievementTooltip() { }

	public void Show(string header, string description) { }

}

