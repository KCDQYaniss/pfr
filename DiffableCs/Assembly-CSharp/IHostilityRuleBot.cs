//Type is in global namespace

public interface IHostilityRuleBot
{

	public string Name
	{
		 get { } //Length: 0
	}

	public BotHostilityStatus EvaluateHostility(BotGroupInnerHostilityData botGroupInnerHostilityData, BotHostilityData botHostilityData) { }

	public string get_Name() { }

}

