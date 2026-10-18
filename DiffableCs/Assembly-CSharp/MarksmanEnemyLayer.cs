//Type is in global namespace

public class MarksmanEnemyLayer : WithCutDistLayer
{
	private float _nextCheckShoot; //Field offset: 0xA8
	private bool _canLay; //Field offset: 0xAC

	private bool EnemyCanHit
	{
		private get { } //Length: 122
	}

	public MarksmanEnemyLayer(BotOwner bot, int priority, bool canLay = true) { }

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

