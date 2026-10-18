namespace EFT.Quests;

[Obfuscation(Exclude = True)]
public sealed class ConditionLocationTrigger : ConditionOneTarget
{

	[DefaultValue(ELocationTriggerState::Complete (1))]
	[JsonProperty("state", DefaultValueHandling = DefaultValueHandling::Ignore (1))]
	public ELocationTriggerState state
	{
		 get { } //Length: 32
		 set { } //Length: 27
	}

	public ConditionLocationTrigger() { }

	public ELocationTriggerState get_state() { }

	public void set_state(ELocationTriggerState value) { }

}

