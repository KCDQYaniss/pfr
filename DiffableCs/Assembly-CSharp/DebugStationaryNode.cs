//Type is in global namespace

public class DebugStationaryNode : BaseNode
{
	private float _nextCanTake; //Field offset: 0x18
	private bool _sprint; //Field offset: 0x1C
	private Nullable StartPoint; //Field offset: 0x20
	private bool _isTriggerPress; //Field offset: 0x30
	private float _triggerPress; //Field offset: 0x34
	private float _endStayTime; //Field offset: 0x38
	private Aiming _aiming; //Field offset: 0x40

	public DebugStationaryNode(BotOwner bot) { }

	public virtual void Awake() { }

	private void GoToPoint() { }

	protected override void GoToStationary() { }

	private void OutOfStationary() { }

	private void RefreshFind() { }

	private void ShootFrom() { }

	private void TryPressTrigger() { }

	public virtual void UpdateNodeByBrain(CoreActionResultParams data) { }

}

