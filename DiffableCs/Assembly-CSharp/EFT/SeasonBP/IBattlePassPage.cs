namespace EFT.SeasonBP;

public interface IBattlePassPage : IDisposable
{

	public bool CanBuy
	{
		 get { } //Length: 0
	}

	public int Index
	{
		 get { } //Length: 0
	}

	public IBindableEvent OnRewardClaimed
	{
		 get { } //Length: 0
	}

	public int RequirementCount
	{
		 get { } //Length: 0
	}

	public IReadOnlyCollection Rewards
	{
		 get { } //Length: 0
	}

	public int RewardsClaimed
	{
		 get { } //Length: 0
	}

	public bool get_CanBuy() { }

	public int get_Index() { }

	public IBindableEvent get_OnRewardClaimed() { }

	public int get_RequirementCount() { }

	public IReadOnlyCollection get_Rewards() { }

	public int get_RewardsClaimed() { }

}

