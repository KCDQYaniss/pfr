namespace EFT.UI;

public class TaskRewardsTooltip : Tooltip
{
	[SerializeField]
	private QuestRewardList _rewardsList; //Field offset: 0xA8

	public TaskRewardsTooltip() { }

	public void Show(string title, IEnumerable rewards) { }

}

