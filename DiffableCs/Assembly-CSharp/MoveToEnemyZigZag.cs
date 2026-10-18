//Type is in global namespace

public abstract class MoveToEnemyZigZag : MoveToEnemy
{
	private Vector3 _lastEnemyPos; //Field offset: 0x30
	private float _nextCheck; //Field offset: 0x3C
	private int _lastEnemyId; //Field offset: 0x40

	protected MoveToEnemyZigZag(BotOwner bot) { }

	protected void InPoint() { }

	protected virtual void NotMovingCheck() { }

}

