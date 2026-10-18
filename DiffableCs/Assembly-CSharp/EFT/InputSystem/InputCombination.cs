namespace EFT.InputSystem;

public abstract class InputCombination
{
	public const int SIMULTANEOUS_FIRST_PRIORITY = -2; //Field offset: 0x0
	public const int NO_SPECIAL_PRIORITY = -1; //Field offset: 0x0
	public static EKeyPress[,] MergeMatrix; //Field offset: 0x0
	public int Order; //Field offset: 0x10
	public bool IsImportant; //Field offset: 0x14
	[CompilerGenerated]
	private int <Priority>k__BackingField; //Field offset: 0x18

	public int Priority
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	private static InputCombination() { }

	protected InputCombination() { }

	[CompilerGenerated]
	public int get_Priority() { }

	public abstract int GetInputCount() { }

	public override bool IsLowerPriority(InputCombination combination) { }

	[CompilerGenerated]
	protected void set_Priority(int value) { }

	public abstract ECommand UpdateCommand(float deltaTime) { }

}

