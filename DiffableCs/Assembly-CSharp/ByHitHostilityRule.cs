//Type is in global namespace

public class ByHitHostilityRule : IHostilityRuleBot, IHostilityRulePlayer
{
	public const float VSRF_AGGRESSION_TIME = 120; //Field offset: 0x0

	public override string Name
	{
		 get { } //Length: 49
	}

	public ByHitHostilityRule() { }

	public override BotHostilityStatus EvaluateHostility(BotGroupInnerHostilityData botGroupHostilityData, BotHostilityData botHostilityData) { }

	public override BotHostilityStatus EvaluateHostility(BotGroupInnerHostilityData botGroupHostilityData, PlayerHostilityData playerHostilityData) { }

	public override string get_Name() { }

}

