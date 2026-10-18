//Type is in global namespace

public class AIPlaceRoleChecker : AIPlaceInfoLogic
{
	private BotsController _botsController; //Field offset: 0x20
	public int BotsToRaise; //Field offset: 0x28
	public WildSpawnType TypeToRaise; //Field offset: 0x2C
	public string EventName; //Field offset: 0x30

	public AIPlaceRoleChecker() { }

	[CompilerGenerated]
	private bool <OnBotRemove>b__5_0(BotOwner x) { }

	public virtual void Dispose() { }

	public virtual void Init(AIPlaceInfo aiPlaceInfo, BotsController botsController) { }

	private void OnBotRemove(BotOwner obj) { }

}

