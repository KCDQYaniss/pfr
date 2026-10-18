//Type is in global namespace

public class BotObserveData : BotData
{
	private const float DEG_OFFSET = 33; //Field offset: 0x0
	private const float LARGE_ANGLE_CHANCE = 15; //Field offset: 0x0
	private const float LARGE_ANGLE_COEFFICIENT = 4; //Field offset: 0x0
	private const float SPEED = 15; //Field offset: 0x0
	public Vector3 CoreDirection; //Field offset: 0x18
	private bool isEven; //Field offset: 0x24
	private Vector3 curLookDir; //Field offset: 0x28
	private Vector3 _prevLookDir; //Field offset: 0x34
	private float time; //Field offset: 0x40
	private float totalTimeToTurn; //Field offset: 0x44
	private float targetAngleHorizontal; //Field offset: 0x48
	private float _nextPossibleUpdate; //Field offset: 0x4C
	private BotObserverVertical _vetical; //Field offset: 0x50
	[CompilerGenerated]
	private bool <IsActive>k__BackingField; //Field offset: 0x58

	public private bool IsActive
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public BotObserveData(BotOwner owner) { }

	[CompilerGenerated]
	public bool get_IsActive() { }

	public void Reset() { }

	[CompilerGenerated]
	private void set_IsActive(bool value) { }

	public void SetVector(bool noTimeCheck = false) { }

	public void SetVector(Vector3 direction, float speed = 15) { }

	public void SetVectorToLook(Vector3 dir) { }

	public void Stop() { }

	public void Update() { }

}

