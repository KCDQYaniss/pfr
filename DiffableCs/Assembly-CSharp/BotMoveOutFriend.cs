//Type is in global namespace

public class BotMoveOutFriend : BotData
{
	private float _nextCheckDistPos; //Field offset: 0x18
	private float _dontUseStop; //Field offset: 0x1C
	private float _offsetDist; //Field offset: 0x20
	private float _sDistToMoveOut; //Field offset: 0x24
	private int MAX_TO_CHECK_CLOSE; //Field offset: 0x28

	public float DontUseStop
	{
		 get { } //Length: 6
	}

	public BotMoveOutFriend(BotOwner owner) { }

	public float get_DontUseStop() { }

	private static bool IsVector3Finite(Vector3 v) { }

	private Vector3 ResolveMoveOutDirection(Vector3 normDir, Vector3 dirFromFriend) { }

	public void UpdateMoveOutFriend() { }

}

