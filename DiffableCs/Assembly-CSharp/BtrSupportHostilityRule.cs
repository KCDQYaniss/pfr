//Type is in global namespace

public class BtrSupportHostilityRule : IHostilityRulePlayer, IHostilityRuleBot
{
	private BotBTRService _btrService; //Field offset: 0x10
	private BtrController _btrController; //Field offset: 0x18

	public override string Name
	{
		 get { } //Length: 49
	}

	public BtrSupportHostilityRule(BotBTRService service, BtrController btrController) { }

	public override BotHostilityStatus EvaluateHostility(BotGroupInnerHostilityData botGroupHostilityData, BotHostilityData botHostilityData) { }

	public override BotHostilityStatus EvaluateHostility(BotGroupInnerHostilityData botGroupHostilityData, PlayerHostilityData playerHostilityData) { }

	public override string get_Name() { }

}

