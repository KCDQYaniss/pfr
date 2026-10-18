//Type is in global namespace

public struct BotMoveByMiddleGraphPathResult
{
	public bool Success; //Field offset: 0x0
	public MiddleGraphPoint StartGraphPoint; //Field offset: 0x8
	public MiddleGraphPoint TargetGraphPoint; //Field offset: 0x10
	public MiddleGraphPoint[] DirectGraphPath; //Field offset: 0x18
	public MiddleGraphPoint[] DetourGraphPath; //Field offset: 0x20
	public Vector3[] NavMeshWaypoints; //Field offset: 0x28
	public string FailReason; //Field offset: 0x30

}

