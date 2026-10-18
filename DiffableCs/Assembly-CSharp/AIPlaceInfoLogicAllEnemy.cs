//Type is in global namespace

public class AIPlaceInfoLogicAllEnemy : AIPlaceInfoLogic
{
	public List EnemyList; //Field offset: 0x20
	private bool _enemyForAll; //Field offset: 0x28
	private readonly HashSet _enemyHash; //Field offset: 0x30
	private AIPlaceInfo _aiPlaceInfo; //Field offset: 0x38
	private BotsController _botsController; //Field offset: 0x40
	private readonly List _affectableBots; //Field offset: 0x48

	public AIPlaceInfoLogicAllEnemy() { }

	public void Dispose() { }

	public virtual void Init(AIPlaceInfo aiPlaceInfo, BotsController botsController) { }

	private void OnBotAdd(BotOwner botOwner) { }

	private void OnBotRemove(BotOwner botOwner) { }

	private void OnPlayerEnter(Player player) { }

}

