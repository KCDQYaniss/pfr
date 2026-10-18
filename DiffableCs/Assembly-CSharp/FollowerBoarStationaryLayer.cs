//Type is in global namespace

public class FollowerBoarStationaryLayer : StationaryWithSuppressLayer
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass5_0
	{
		public EnemyInfo enemy; //Field offset: 0x10

		public <>c__DisplayClass5_0() { }

		internal Vector3 <CheckingWantStartSuppress>b__0() { }

	}

	private float _nextTimeCheck; //Field offset: 0xA0
	private IBossAskingForSuppress _bossSuppresser; //Field offset: 0xA8
	private bool _boosFound; //Field offset: 0xB0
	private bool _isSubs; //Field offset: 0xB1

	public FollowerBoarStationaryLayer(BotOwner bot, int priority) { }

	private bool BossWannaSuppress() { }

	private void CheckingWantStartSuppress() { }

	public virtual void Dispose() { }

	protected virtual AICoreActionEnd EndRunToEnemy() { }

	protected virtual AICoreActionEnd EndSuppressStationary() { }

	protected virtual void ManualUpdate() { }

	public virtual string Name() { }

	protected virtual void OnActivate() { }

	private void OnBossFinded(IBossToFollow obj) { }

	public virtual bool ShallUseNow() { }

}

