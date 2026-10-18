//Type is in global namespace

public class BotMGSuppress : AbstractSuppressStationary
{

	public virtual bool Usable
	{
		 get { } //Length: 3
	}

	public BotMGSuppress(BotSuppressStationary suppressStationary, BotOwner owner) { }

	public virtual bool CanStartSuppressAt(Vector3 enemyPos) { }

	public virtual bool CanStartSupressEnemy(EnemyInfo enemy) { }

	public virtual bool get_Usable() { }

	public virtual void StopExternal(Vector3 badPos) { }

}

