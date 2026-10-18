namespace EFT.InputSystem;

public sealed class InputAxis : IGameKey, IInputUpdater
{
	private static readonly Dictionary _axisPool; //Field offset: 0x0
	private readonly string _axisName; //Field offset: 0x10
	private readonly float _deadZone; //Field offset: 0x18
	private readonly float _sensitivity; //Field offset: 0x1C
	private readonly float _sign; //Field offset: 0x20
	private IInputUpdater _gameAxis; //Field offset: 0x28
	[CompilerGenerated]
	private InputCombination <InUseBy>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private bool <ReleaseNextFrame>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private EKeyPress <Press>k__BackingField; //Field offset: 0x3C

	public override InputCombination InUseBy
	{
		[CompilerGenerated]
		 get { } //Length: 76
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public override bool IsAxis
	{
		 get { } //Length: 3
	}

	public override EKeyPress Press
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public override bool ReleaseNextFrame
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	private static InputAxis() { }

	private InputAxis(string axisName, float sign, float deadZone, float sensitivity) { }

	[CompilerGenerated]
	public override InputCombination get_InUseBy() { }

	public override bool get_IsAxis() { }

	[CompilerGenerated]
	public override EKeyPress get_Press() { }

	[CompilerGenerated]
	public override bool get_ReleaseNextFrame() { }

	public IInputUpdater GetActualAxis() { }

	public static InputAxis GetAxis(string axisName, bool positiveAxis, float deadZone, float sensitivity) { }

	public virtual int GetHashCode() { }

	public override float GetValue() { }

	private void RenewUpdater(string axisName) { }

	[CompilerGenerated]
	public override void set_InUseBy(InputCombination value) { }

	[CompilerGenerated]
	public override void set_Press(EKeyPress value) { }

	[CompilerGenerated]
	public override void set_ReleaseNextFrame(bool value) { }

	public virtual string ToString() { }

	public override void Update() { }

}

