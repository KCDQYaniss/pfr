namespace EFT;

public sealed class OnPlayerDead : MulticastDelegate
{

	public OnPlayerDead(object object, IntPtr method) { }

	public override IAsyncResult BeginInvoke(Player player, IPlayer lastAggressor, DamageInfo damageInfo, EBodyPart part, AsyncCallback callback, object object) { }

	public override void EndInvoke(IAsyncResult result) { }

	public override void Invoke(Player player, IPlayer lastAggressor, DamageInfo damageInfo, EBodyPart part) { }

}

