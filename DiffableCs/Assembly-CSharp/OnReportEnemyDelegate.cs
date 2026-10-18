//Type is in global namespace

public sealed class OnReportEnemyDelegate : MulticastDelegate
{

	public OnReportEnemyDelegate(object object, IntPtr method) { }

	public override IAsyncResult BeginInvoke(IPlayer enemy, Vector3 enemyPos, Vector3 weaponRootLast, EEnemyPartVisibleType isVisibleOnlyBySense, BotOwner reporter, AsyncCallback callback, object object) { }

	public override void EndInvoke(IAsyncResult result) { }

	public override void Invoke(IPlayer enemy, Vector3 enemyPos, Vector3 weaponRootLast, EEnemyPartVisibleType isVisibleOnlyBySense, BotOwner reporter) { }

}

