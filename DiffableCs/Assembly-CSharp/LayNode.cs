//Type is in global namespace

public class LayNode : BaseNode
{
	private readonly Aiming _aiming; //Field offset: 0x18
	private float _nextCheckTryLay; //Field offset: 0x20
	private float _nextCheckLookUpdate; //Field offset: 0x24
	private bool _canRotate; //Field offset: 0x28
	private float _nextLookToEnemyUpdate; //Field offset: 0x2C

	public LayNode(BotOwner bot) { }

	private void LookNormal() { }

	public virtual void UpdateNodeByBrain(CoreActionResultParams data) { }

}

