//Type is in global namespace

public class NoSuppressData : AbstractSuppressStationary
{

	public virtual bool Usable
	{
		 get { } //Length: 3
	}

	public NoSuppressData(BotSuppressStationary suppressStationary, BotOwner owner) { }

	public virtual bool CanStartSuppressAt(Vector3 enemyPos) { }

	public virtual bool CanStartSupressEnemy(EnemyInfo memoryGoalEnemy) { }

	public virtual bool get_Usable() { }

	public virtual bool IsReady() { }

	public virtual void StopExternal(Vector3 badPos) { }

}

