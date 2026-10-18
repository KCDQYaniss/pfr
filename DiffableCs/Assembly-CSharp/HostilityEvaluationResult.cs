//Type is in global namespace

public struct HostilityEvaluationResult
{
	public BotHostilityStatus Hostility; //Field offset: 0x0
	public string Rule; //Field offset: 0x8

	public HostilityEvaluationResult(BotHostilityStatus result, string reason) { }

}

