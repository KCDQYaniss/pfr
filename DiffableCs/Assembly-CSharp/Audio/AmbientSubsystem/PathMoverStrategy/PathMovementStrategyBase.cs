namespace Audio.AmbientSubsystem.PathMoverStrategy;

public abstract class PathMovementStrategyBase : IPathMovementStrategy
{
	protected readonly MonoBehaviour Behaviour; //Field offset: 0x10
	protected readonly IPositionTranslator PosTranslator; //Field offset: 0x18
	protected readonly Vector3[] Points; //Field offset: 0x20
	protected readonly float TotalSegmentLength; //Field offset: 0x28
	protected float Speed; //Field offset: 0x2C
	private int _currentRndIndex; //Field offset: 0x30
	private Vector3 _currentPoint; //Field offset: 0x34
	private readonly float[] _segmentLengths; //Field offset: 0x40
	[CompilerGenerated]
	private Action MovementCompleted; //Field offset: 0x48
	[CompilerGenerated]
	private bool <IsCompleted>k__BackingField; //Field offset: 0x50

	public override event Action MovementCompleted
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public private override bool IsCompleted
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public abstract EMovementStrategy MovementStrategy
	{
		 get { } //Length: 0
	}

	protected PathMovementStrategyBase(MonoBehaviour behaviour, IPositionTranslator posTranslator, Vector3[] points, float[] segmentLengths, float totalLength) { }

	[CompilerGenerated]
	public override void add_MovementCompleted(Action value) { }

	public override void Execute() { }

	[CompilerGenerated]
	public override bool get_IsCompleted() { }

	public abstract EMovementStrategy get_MovementStrategy() { }

	protected Vector3 GetPointByArcLength(float arcLength) { }

	protected Vector3 GetRandomPoint() { }

	protected abstract void OnExecute(Action onDone = null) { }

	private void OnMovementCompleted() { }

	[CompilerGenerated]
	public override void remove_MovementCompleted(Action value) { }

	protected override void ResetParameters(bool resetPosition = false) { }

	[CompilerGenerated]
	private void set_IsCompleted(bool value) { }

	public override void SetSpeed(float duration) { }

	private void ShufflePoints() { }

	public override void Stop(bool resetPosition = false) { }

}

