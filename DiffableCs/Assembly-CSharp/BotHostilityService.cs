//Type is in global namespace

public class BotHostilityService
{
	private List hostilityRulePlayer; //Field offset: 0x10
	private List hostilityRuleBot; //Field offset: 0x18

	public BotHostilityService(BotBTRService btrService) { }

	public HostilityEvaluationResult EvaluateHostility(BotGroupInnerHostilityData botGroupInnerHostilityData, BotHostilityData botHostilityData) { }

	public HostilityEvaluationResult EvaluateHostility(BotGroupInnerHostilityData botGroupInnerHostilityData, PlayerHostilityData playerHostilityData) { }

}

