//Type is in global namespace

public class BotMoverDebug : BotData
{
	private struct DebugImpostorStruct
	{
		public Vector3 WayPos; //Field offset: 0x0
		public Vector3 Pos; //Field offset: 0xC
		public Vector3 StartPos; //Field offset: 0x18
		public EBotLinkResult Type; //Field offset: 0x24

	}

	private const int MAX_POS_COUNT = 100; //Field offset: 0x0
	private int _curIndex; //Field offset: 0x18
	private readonly DebugImpostorStruct[] _debugPos; //Field offset: 0x20

	public BotMoverDebug(BotOwner owner) { }

	public void AddDebugPos(EBotLinkResult debugType, Vector3 startPos, Vector3 realWorldPos, Vector3 originalWayPos) { }

	public void CantFindWayErrorTraceLog() { }

	public void OnDrawGizmosPrevWay() { }

	private void SetGizmosColor(EBotLinkResult type) { }

}

