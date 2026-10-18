//Type is in global namespace

public interface IHostilityRulePlayer
{

	public string Name
	{
		 get { } //Length: 0
	}

	public BotHostilityStatus EvaluateHostility(BotGroupInnerHostilityData botGroupInnerHostilityData, PlayerHostilityData playerHostilityData) { }

	public string get_Name() { }

}

