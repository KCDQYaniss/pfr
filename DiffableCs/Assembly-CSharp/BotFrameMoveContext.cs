//Type is in global namespace

public class BotFrameMoveContext
{
	public Vector3 PrevPosPlayer; //Field offset: 0x10
	public Vector3 PrevPosWay; //Field offset: 0x1C
	public Vector3 TargetPos; //Field offset: 0x28
	public Vector3 DirectionMove; //Field offset: 0x34
	public AbstractBotPath NextTargetPath; //Field offset: 0x40
	public float RemainDist; //Field offset: 0x48
	public int FrameIndex; //Field offset: 0x4C
	public bool Used; //Field offset: 0x50

	public BotFrameMoveContext() { }

}

