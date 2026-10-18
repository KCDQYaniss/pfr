//Type is in global namespace

public class DebugPathController
{
	public int MaxCount; //Field offset: 0x10
	public int _curIndex; //Field offset: 0x14
	public List Elements; //Field offset: 0x18
	private DebugPathElement _last; //Field offset: 0x20

	public DebugPathController() { }

	public void AddWay(AbstractBotPath path, Vector3 pos) { }

	public void DrawLastWay() { }

}

