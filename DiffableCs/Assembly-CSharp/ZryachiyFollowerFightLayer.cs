//Type is in global namespace

public class ZryachiyFollowerFightLayer : ZryachiyAbstractLayer
{
	private float _lastTimeHitTarget; //Field offset: 0xB0
	private bool _doNoHitTransition; //Field offset: 0xB4
	private bool _comeToClose; //Field offset: 0xB5

	private float _lastTimeShootTarget
	{
		private get { } //Length: 40
	}

	public ZryachiyFollowerFightLayer(BotOwner bot, int priority) { }

	public virtual void Dispose() { }

	protected virtual AICoreActionEnd EndCrawlNode() { }

	protected virtual AICoreActionEnd EndLayNode() { }

	protected virtual AICoreActionEnd EndRunToCover() { }

	protected virtual AICoreActionEnd EndRunToEnemy() { }

	private float get__lastTimeShootTarget() { }

	public virtual AICoreActionResult GetDecision() { }

	public virtual string Name() { }

	private void OnHitTarget(IPlayer arg1, DamageInfo arg2, EBodyPart arg3) { }

	private void OnKillTarget(string arg1, DamageInfo arg2) { }

	public virtual bool ShallUseNow() { }

}

