//Type is in global namespace

public abstract class WithCutDistLayer : BaseLogicLayer
{
	protected bool _enemyIsFar; //Field offset: 0x90
	protected AIPeriodAction _isEnemyFarCheck; //Field offset: 0x98
	private float _periodCanAttackCauseEnemyShot; //Field offset: 0xA0

	private float _distEnemyFar
	{
		private get { } //Length: 58
	}

	protected WithCutDistLayer(BotOwner bot, int priority) { }

	private void CheckOnEnemyFar() { }

	private float get__distEnemyFar() { }

}

