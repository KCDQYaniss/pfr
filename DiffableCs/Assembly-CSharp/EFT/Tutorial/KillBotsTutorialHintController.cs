namespace EFT.Tutorial;

public sealed class KillBotsTutorialHintController : BaseTriggerZoneTutorialHintController
{
	private readonly Dictionary _botsInArea; //Field offset: 0x38
	private readonly int _botTriggerId; //Field offset: 0x40
	private int _botsKilled; //Field offset: 0x44
	private bool _playerInTriggerZone; //Field offset: 0x48

	public KillBotsTutorialHintController(TutorialHintData hint, Player player, Action showHint, Action closeHint, string botTriggerZoneKey) { }

	private void BotEnterTrigger(int botRaidId) { }

	private void BotOnOnPlayerDead(Player bot, IPlayer lastaggressor, DamageInfo damageinfo, EBodyPart part) { }

	public virtual void Dispose() { }

	private void PlayerEnterTriggerZone(int triggerId) { }

	private void PlayerExitTriggerZone(int triggerId) { }

	protected virtual void TriggerZoneEventHandler(TriggerEvent triggerEvent) { }

}

