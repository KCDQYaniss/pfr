//Type is in global namespace

public class NavMeshCutController
{
	private List _cutElements; //Field offset: 0x10
	private BotsController _botsController; //Field offset: 0x18
	public Action OnCutComplete; //Field offset: 0x20

	public NavMeshCutController() { }

	public void Dispose() { }

	public void Init(BotsController botsController, BotZone[] botZones) { }

	private void OnBotRemove(BotOwner bot) { }

}

