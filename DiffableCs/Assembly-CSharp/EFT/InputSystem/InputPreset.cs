namespace EFT.InputSystem;

public class InputPreset
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__8_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <UpdateBindings>b__8_0(AxisPair axisPair) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass8_0
	{
		public InputAxisCombination axisCombination; //Field offset: 0x10
		public Func <>9__1; //Field offset: 0x18

		public <>c__DisplayClass8_0() { }

		internal bool <UpdateBindings>b__1(InputKeyCombination keyCombination) { }

	}

	private InputKeyCombination[] _inputKeyCombinations; //Field offset: 0x10
	private InputAxisCombination[] _inputAxisCombinations; //Field offset: 0x18
	private InputCombination[] _workingKeyCombinations; //Field offset: 0x20
	private InputAxisCombination[] _workingAxisCombinations; //Field offset: 0x28
	private IInputUpdater[] _updateInputs; //Field offset: 0x30
	private IInputUpdater[] _laterUpdateInputs; //Field offset: 0x38

	public InputPreset() { }

	public void SetAxis(InputAxisCombination[] axisCombinations) { }

	public void SetCombinations(float doubleClickTimeout, InputKeyCombination[] combinations) { }

	public void UpdateBindings(KeyGroup[] keyGroups, AxisGroup[] axisGroups, float doubleClickTimeout) { }

	public void UpdateInput(List commands, float[] axis, float deltaTime) { }

}

