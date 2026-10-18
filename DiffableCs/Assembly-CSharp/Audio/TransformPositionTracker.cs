namespace Audio;

public sealed class TransformPositionTracker : ITransformTracker
{
	private Transform _positionTracker; //Field offset: 0x10
	private Vector3 _positionTrackerOffset; //Field offset: 0x18
	[CompilerGenerated]
	private bool <IsPositionTracked>k__BackingField; //Field offset: 0x24
	[CompilerGenerated]
	private Vector3 <Position>k__BackingField; //Field offset: 0x28

	public private override bool IsPositionTracked
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private override Vector3 Position
	{
		[CompilerGenerated]
		 get { } //Length: 19
		[CompilerGenerated]
		private set { } //Length: 16
	}

	public TransformPositionTracker() { }

	[CompilerGenerated]
	public override bool get_IsPositionTracked() { }

	[CompilerGenerated]
	public override Vector3 get_Position() { }

	[CompilerGenerated]
	private void set_IsPositionTracked(bool value) { }

	[CompilerGenerated]
	private void set_Position(Vector3 value) { }

	public override void StartTracking(Transform tracker, Vector3 positionOffset = null) { }

	public override void StopTracking() { }

	public override void UpdatePosition() { }

}

