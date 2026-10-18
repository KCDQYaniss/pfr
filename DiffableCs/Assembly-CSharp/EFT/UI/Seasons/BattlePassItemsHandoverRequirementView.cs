namespace EFT.UI.Seasons;

public sealed class BattlePassItemsHandoverRequirementView : BattlePassBaseRewardRequirementView
{
	private int _maxCount; //Field offset: 0x90
	private BattlePassReward _reward; //Field offset: 0x98

	protected virtual int CurrentCount
	{
		 get { } //Length: 45
	}

	protected virtual ERequirementState CurrentState
	{
		 get { } //Length: 36
	}

	protected virtual string LocalizedText
	{
		 get { } //Length: 153
	}

	protected virtual int MaxCount
	{
		 get { } //Length: 7
	}

	protected virtual bool ShowCount
	{
		 get { } //Length: 3
	}

	public BattlePassItemsHandoverRequirementView() { }

	protected virtual int get_CurrentCount() { }

	protected virtual ERequirementState get_CurrentState() { }

	protected virtual string get_LocalizedText() { }

	protected virtual int get_MaxCount() { }

	protected virtual bool get_ShowCount() { }

	public void Show(BattlePassReward reward) { }

}

