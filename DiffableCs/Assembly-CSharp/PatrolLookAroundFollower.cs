//Type is in global namespace

public class PatrolLookAroundFollower : BotData, IPatrolLook
{
	private readonly BotObserveData _botObserveData; //Field offset: 0x18
	private Vector3 _baseLook; //Field offset: 0x20
	private float _nextLookPoint; //Field offset: 0x2C
	private readonly PatrollingData data; //Field offset: 0x30

	public PatrolLookAroundFollower(BotOwner owner, PatrollingData data, BotObserveData botObserveData) { }

	public override void SetComeToPoint() { }

	public override void SetDefault(bool max) { }

	public override void Update() { }

}

