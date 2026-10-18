//Type is in global namespace

public class BotLoyaltyData : BotData
{
	private readonly Dictionary _shallApplyFollowRequestByLoyalty; //Field offset: 0x18

	public BotLoyaltyData(BotOwner owner) { }

	public void Activate() { }

	public bool CanApply(IPlayer person) { }

	private void CheckNeutral(IPlayer neutral) { }

	public void Dispose() { }

}

