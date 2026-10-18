//Type is in global namespace

public class BoarSniperEnemyLayer : BoarFightAbstractLayer
{
	private float _nextCheckShoot; //Field offset: 0xC0

	private bool EnemyCanHit
	{
		private get { } //Length: 134
	}

	public BoarSniperEnemyLayer(BotOwner bot, int priority) { }

	protected virtual AICoreActionEnd EndDogFight() { }

	protected virtual AICoreActionEnd EndHoldPosition() { }

	protected virtual AICoreActionEnd EndLayNode() { }

	protected virtual AICoreActionEnd EndRunToCover() { }

	protected virtual AICoreActionEnd EndShootFromPlace() { }

	private bool get_EnemyCanHit() { }

	public virtual AICoreActionResult GetDecision() { }

	public virtual string Name() { }

	public virtual bool ShallUseNow() { }

}

