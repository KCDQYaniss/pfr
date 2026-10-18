//Type is in global namespace

public class AIPlaceLogicEventRaise : AIPlaceInfoLogic
{
	public string EventName; //Field offset: 0x20
	private AIPlaceInfo _aiPlaceInfo; //Field offset: 0x28
	public bool EnterRaise; //Field offset: 0x30
	public bool ExitRaise; //Field offset: 0x31
	public bool OnlyPlayerNotAI; //Field offset: 0x32

	public AIPlaceLogicEventRaise() { }

	public virtual void Dispose() { }

	public virtual void Init(AIPlaceInfo aiPlaceInfo, BotsController botsController) { }

	private void OnPlayerEnter(Player player) { }

	private void OnPlayerExit(Player player) { }

}

