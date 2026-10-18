namespace EFT.InputSystem;

public sealed class InputKey : IGameKey, IInputUpdater
{
	private static readonly Dictionary _pool; //Field offset: 0x0
	public readonly KeyCode Key; //Field offset: 0x10
	[CompilerGenerated]
	private InputCombination <InUseBy>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private bool <ReleaseNextFrame>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private EKeyPress <Press>k__BackingField; //Field offset: 0x24

	public override InputCombination InUseBy
	{
		[CompilerGenerated]
		 get { } //Length: 5
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

	private static InputKey() { }

	private InputKey(KeyCode key) { }

	[CompilerGenerated]
	public override InputCombination get_InUseBy() { }

	public override bool get_IsAxis() { }

	[CompilerGenerated]
	public override EKeyPress get_Press() { }

	[CompilerGenerated]
	public override bool get_ReleaseNextFrame() { }

	public virtual int GetHashCode() { }

	public static InputKey GetKey(KeyCode key, bool ignorePool = false) { }

	public override float GetValue() { }

	[CompilerGenerated]
	public override void set_InUseBy(InputCombination value) { }

	[CompilerGenerated]
	public override void set_Press(EKeyPress value) { }

	[CompilerGenerated]
	public override void set_ReleaseNextFrame(bool value) { }

	public virtual string ToString() { }

	public override void Update() { }

}

