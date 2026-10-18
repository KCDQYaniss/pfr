//Type is in global namespace

public class DebugGrenadeNode : BaseNode
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass14_0
	{
		public GameObject tr; //Field offset: 0x10

		public <>c__DisplayClass14_0() { }

		internal Vector3 <FindTrg>b__0() { }

	}

	protected const float UPDATE_TIME = 1; //Field offset: 0x0
	protected Func shootPoint; //Field offset: 0x18
	protected Vector3 positionToMove; //Field offset: 0x20
	private float _updatePointTimer; //Field offset: 0x2C
	private float _recalThrowDelta; //Field offset: 0x30
	private bool isObjectsFind; //Field offset: 0x34
	private bool _fastMode; //Field offset: 0x35
	private bool _come; //Field offset: 0x36
	private List allPossibleAngs; //Field offset: 0x38
	private float _nextCheck; //Field offset: 0x40

	public DebugGrenadeNode(BotOwner bot) { }

	private void FindTrg() { }

	private void MoveToPoint() { }

	private void TryThrowNow() { }

	public virtual void UpdateNodeByBrain(CoreActionResultParams data) { }

}

