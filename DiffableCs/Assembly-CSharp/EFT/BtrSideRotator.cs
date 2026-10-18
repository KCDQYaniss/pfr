namespace EFT;

public sealed class BtrSideRotator : ICustomRotator
{
	private const float SPEED = 6; //Field offset: 0x0
	private const float TIME_TO_APPLY = 1; //Field offset: 0x0
	private BTRSide _btrSide; //Field offset: 0x10
	private bool _useGoOutPoints; //Field offset: 0x18
	private Quaternion _lastRotation; //Field offset: 0x1C
	private float _timeToApply; //Field offset: 0x2C

	public override bool IsValid
	{
		 get { } //Length: 203
	}

	public BtrSideRotator() { }

	public override bool get_IsValid() { }

	public override Quaternion GetRotation() { }

	public void Init(BTRSide btrSide, EPlayerBtrState btrState, Nullable intermediateRotation = null, Nullable timeToApply = null) { }

	private Quaternion RotationInternal() { }

}

