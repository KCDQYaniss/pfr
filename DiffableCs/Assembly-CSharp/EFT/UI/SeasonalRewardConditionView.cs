namespace EFT.UI;

public sealed class SeasonalRewardConditionView : ConditionProgressView
{
	private const string QUEST_CONDITION_KEY = "SeasonalRewards/ConditionQuest{0}"; //Field offset: 0x0
	private const string HIDEOUT_AREA_CONDITION_KEY = "SeasonalRewards/ConditionHideoutArea{0}{1}"; //Field offset: 0x0
	private const string LEVEL_CONDITION_KEY = "SeasonalRewards/ConditionLevel{0}"; //Field offset: 0x0
	[SerializeField]
	private GameObject _checkbox; //Field offset: 0xC8
	[SerializeField]
	private Color _readyColor; //Field offset: 0xD0
	[SerializeField]
	private Color _notReadyColor; //Field offset: 0xE0

	protected virtual bool HideTargetValueWhenEmpty
	{
		 get { } //Length: 3
	}

	public SeasonalRewardConditionView() { }

	protected virtual bool get_HideTargetValueWhenEmpty() { }

	protected virtual void GetConditionLocalization(Condition condition, out string typeName, out string nameText, out string value) { }

	protected virtual void OnStateUpdated() { }

	public void Show(Condition condition, SeasonalReward seasonalReward = null) { }

	protected virtual bool TryGetCurrentValue(ConditionProgressChecker progress, out double count) { }

}

