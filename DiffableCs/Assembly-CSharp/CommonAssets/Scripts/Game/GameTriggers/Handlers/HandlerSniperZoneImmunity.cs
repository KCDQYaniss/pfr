namespace CommonAssets.Scripts.Game.GameTriggers.Handlers;

public sealed class HandlerSniperZoneImmunity : BaseTriggerHandler
{
	private enum ETargetAction
	{
		Add = 1,
		Remove = 2,
	}

	[SerializeField]
	private PlayersWithImmuneToSniperFire _playersWithImmune; //Field offset: 0x28
	[SerializeField]
	private ETargetAction _targetAction; //Field offset: 0x30

	public HandlerSniperZoneImmunity() { }

	private void OnTriggerEvent(TriggerEvent triggerEvent) { }

	private void Start() { }

}

