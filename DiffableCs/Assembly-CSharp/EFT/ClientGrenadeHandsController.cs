namespace EFT;

internal sealed class ClientGrenadeHandsController : GrenadeHandsController
{
	public GrenadePacket GrenadePacket; //Field offset: 0x100

	public ClientGrenadeHandsController() { }

	public virtual void ActualDrop(Result controller, float animationSpeed, Action callback, bool fastDrop) { }

	public virtual bool CanThrow() { }

	public virtual void ChangeFireMode(EFireMode fireMode) { }

	protected virtual void CompassStateHandler(bool isActive) { }

	protected virtual void Cook() { }

	internal static ClientGrenadeHandsController Create(ClientPlayer player, ThrowWeap item) { }

	internal static Task CreateAsync(ClientPlayer player, string itemId) { }

	public virtual void ExamineWeapon() { }

	public virtual void HighThrow() { }

	public virtual void LowThrow() { }

	public virtual void PlantTripwire() { }

	public virtual void PullRingForHighThrow() { }

	public virtual void PullRingForLowThrow() { }

	public virtual void SetInventoryOpened(bool opened) { }

	public virtual void ShowGesture(EInteraction gesture) { }

	protected virtual void ThrowGrenade(float timeSinceSafetyLevelRemoved, Vector3 position, Quaternion rotation, Vector3 force, bool lowThrow) { }

}

