//Type is in global namespace

public class BotArtillerySuppress : AbstractSuppressStationary
{
	private readonly List _blockedPositions; //Field offset: 0x28
	private readonly float BLOCKED_SDIST; //Field offset: 0x30
	private readonly int MAX_BLOCKED_COUNT; //Field offset: 0x34

	public virtual bool Usable
	{
		 get { } //Length: 3
	}

	public BotArtillerySuppress(BotSuppressStationary suppressStationary, BotOwner owner) { }

	public virtual bool CanStartSuppressAt(Vector3 pos) { }

	public virtual bool CanStartSupressEnemy(EnemyInfo enemy) { }

	public virtual bool get_Usable() { }

	public virtual void StopExternal(Vector3 badPos) { }

}

