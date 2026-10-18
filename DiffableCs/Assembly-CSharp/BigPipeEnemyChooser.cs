//Type is in global namespace

public class BigPipeEnemyChooser : BotEnemyChooser
{
	private EnemyInfo _lastChoose; //Field offset: 0x28
	private BigPipeBotWeaponSelector _bigPipeBotWeaponSelector; //Field offset: 0x30
	private bool _isInited; //Field offset: 0x38
	private float _nextPeriodRefresh; //Field offset: 0x3C

	public BigPipeEnemyChooser(BotOwner owner) { }

	protected virtual float CalcWeight(float dist, EnemyInfo enemyInfo) { }

	public virtual void Dispose() { }

	public virtual EnemyInfo FindDangerEnemy() { }

	private void OnBotStateChange(EBotState obj) { }

	private void OnTriggerPressed() { }

	private void PeriodRefresh() { }

}

