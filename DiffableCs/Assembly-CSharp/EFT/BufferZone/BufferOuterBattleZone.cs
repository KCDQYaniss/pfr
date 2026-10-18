namespace EFT.BufferZone;

public class BufferOuterBattleZone : MonoBehaviour, IPhysicsTrigger
{
	private readonly BindableList _playersInZone; //Field offset: 0x20
	private readonly BindableList _playersDeadInZone; //Field offset: 0x28

	public override string Description
	{
		 get { } //Length: 49
	}

	public BufferOuterBattleZone() { }

	public override string get_Description() { }

	private override bool IPhysicsTrigger.get_enabled() { }

	private override void IPhysicsTrigger.OnTriggerEnter(Collider col) { }

	private override void IPhysicsTrigger.OnTriggerExit(Collider col) { }

	private override void IPhysicsTrigger.set_enabled(bool value) { }

	public bool IsPlayerDyingInZone(Player player) { }

	public bool IsPlayerInZone(Player player) { }

	private void OnPlayerDeadOrUnspawn(Player player) { }

}

