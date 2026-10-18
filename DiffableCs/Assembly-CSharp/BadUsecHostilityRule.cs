//Type is in global namespace

public class BadUsecHostilityRule : IHostilityRulePlayer
{

	public override string Name
	{
		 get { } //Length: 49
	}

	public BadUsecHostilityRule() { }

	public override BotHostilityStatus EvaluateHostility(BotGroupInnerHostilityData botGroupHostilityData, PlayerHostilityData playerHostilityData) { }

	public override string get_Name() { }

	private bool IsPlayerBadUsec(PlayerHostilityData playerHostilityData) { }

}

