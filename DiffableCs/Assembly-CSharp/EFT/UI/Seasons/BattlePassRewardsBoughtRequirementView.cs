namespace EFT.UI.Seasons;

public sealed class BattlePassRewardsBoughtRequirementView : BattlePassBaseRewardRequirementView
{
	private BattlePassPage _page; //Field offset: 0x90

	protected virtual int CurrentCount
	{
		 get { } //Length: 32
	}

	protected virtual ERequirementState CurrentState
	{
		 get { } //Length: 78
	}

	protected virtual string LocalizedText
	{
		 get { } //Length: 365
	}

	protected virtual int MaxCount
	{
		 get { } //Length: 51
	}

	public BattlePassRewardsBoughtRequirementView() { }

	protected virtual int get_CurrentCount() { }

	protected virtual ERequirementState get_CurrentState() { }

	protected virtual string get_LocalizedText() { }

	protected virtual int get_MaxCount() { }

	public void Show(BattlePassReward reward) { }

}

