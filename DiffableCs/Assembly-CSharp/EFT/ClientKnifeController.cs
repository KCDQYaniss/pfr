namespace EFT;

internal sealed class ClientKnifeController : KnifeController
{
	public KnifePacket KnifePacket; //Field offset: 0x120

	public ClientKnifeController() { }

	public virtual void BrakeCombo() { }

	protected virtual void CompassStateHandler(bool isActive) { }

	internal static ClientKnifeController Create(ClientPlayer player, KnifeComponent knife) { }

	internal static Task CreateAsync(ClientPlayer player, string itemId) { }

	public virtual void ExamineWeapon() { }

	public virtual bool MakeAlternativeKick() { }

	public virtual bool MakeKnifeKick() { }

	protected virtual PlayerHitInfo ProcessHit(KnifeRaycastHit hit, BallisticCollider ballisticCollider) { }

	public virtual void SetInventoryOpened(bool opened) { }

	public virtual void ShowGesture(EInteraction gesture) { }

}

