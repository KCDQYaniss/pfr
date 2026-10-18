namespace EFT;

internal sealed class ClientQuickKnifeKickController : QuickKnifeKickController
{
	public KnifePacket KnifePacket; //Field offset: 0x108

	public ClientQuickKnifeKickController() { }

	internal static ClientQuickKnifeKickController Create(ClientPlayer player, KnifeComponent knife) { }

	internal static Task CreateAsync(ClientPlayer player, string itemId) { }

	protected virtual PlayerHitInfo ProcessHit(KnifeRaycastHit hit, BallisticCollider ballisticCollider) { }

}

