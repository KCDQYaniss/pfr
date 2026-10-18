//Type is in global namespace

public class CrawlNode : MoveNode
{
	private float _updatePointTimer; //Field offset: 0x28

	public CrawlNode(BotOwner bot) { }

	private void RestartFind() { }

	public virtual void UpdateNodeByBrain(CoreActionResultParams data) { }

}

