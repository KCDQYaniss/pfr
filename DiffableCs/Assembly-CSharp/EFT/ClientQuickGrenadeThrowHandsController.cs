namespace EFT;

internal sealed class ClientQuickGrenadeThrowHandsController : QuickGrenadeThrowHandsController
{
	public GrenadePacket GrenadePacket; //Field offset: 0xE8

	public ClientQuickGrenadeThrowHandsController() { }

	protected virtual void Cook() { }

	internal static ClientQuickGrenadeThrowHandsController Create(ClientPlayer player, ThrowWeap item) { }

	internal static Task CreateAsync(ClientPlayer player, string itemId) { }

	protected virtual void ThrowGrenade(float timeSinceSafetyLevelRemoved, Vector3 position, Quaternion rotation, Vector3 force, bool lowThrow) { }

}

