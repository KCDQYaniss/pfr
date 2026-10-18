//Type is in global namespace

public class FinalRewardView : PrestigeRewardView
{

	public FinalRewardView() { }

	protected virtual bool TryOverrideName(PrestigeReward reward, out string newName) { }

	protected virtual bool TryOverrideRewardType(PrestigeReward reward, out string newName) { }

}

