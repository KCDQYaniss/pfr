//Type is in global namespace

public class DebugPathElement
{
	public Vector3 BotPosAtStart; //Field offset: 0x10
	public AbstractBotPath Path; //Field offset: 0x20
	public float CreateTime; //Field offset: 0x28
	public string CallstackPathComeFrom; //Field offset: 0x30

	public DebugPathElement() { }

	public void DebugDraw() { }

}

