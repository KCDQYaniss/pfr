namespace EFT.InputSystem;

public class InputAxisCombination : InputCombination
{
	private abstract class AxisCombinationState
	{
		private const float START_CALCULATION_VALUE = 1000; //Field offset: 0x0
		public readonly InputAxisCombination AxisCombination; //Field offset: 0x10
		[CompilerGenerated]
		private float <Value>k__BackingField; //Field offset: 0x18

		public float Value
		{
			[CompilerGenerated]
			 get { } //Length: 6
			[CompilerGenerated]
			 set { } //Length: 6
		}

		public AxisCombinationState(InputAxisCombination axisCombination) { }

		protected float CalculateCurrentValue(EUseSide side) { }

		[CompilerGenerated]
		public float get_Value() { }

		protected override EUseSide GetKeysStatus(out EKeyPress keysStatus) { }

		[CompilerGenerated]
		protected void set_Value(float value) { }

		public abstract void Update() { }

		private void СalculateForSingleAxisGroup(IGameKey[] axisGroup, ref float calculationValue) { }

	}

	private abstract class AxisWithKeysState : AxisCombinationState
	{

		public AxisWithKeysState(InputAxisCombination axisCombination) { }

		protected virtual EUseSide GetKeysStatus(out EKeyPress keysStatus) { }

		protected void HandleKeys(EUseSide useSide) { }

		protected void UnhandleKeys() { }

	}

	private enum EAxisState
	{
		JustAxis = 0,
		WithKeysIdling = 1,
		WithKeysPressed = 2,
	}

	[Flags]
	private enum EUseSide
	{
		None = 0,
		Positive = 1,
		Negative = 2,
	}

	private class IdlingState : AxisWithKeysState
	{

		public IdlingState(InputAxisCombination axisCombination) { }

		public virtual void Update() { }

	}

	private class JustAxisState : AxisCombinationState
	{

		public JustAxisState(InputAxisCombination axisCombination) { }

		public virtual void Update() { }

	}

	private class KeysPressedState : AxisWithKeysState
	{

		public KeysPressedState(InputAxisCombination axisCombination) { }

		public virtual void Update() { }

	}

	public readonly EAxis GameAxis; //Field offset: 0x20
	public readonly int IntAxis; //Field offset: 0x24
	public readonly EGameKey Modificator; //Field offset: 0x28
	private IGameKey[] modificatorKeys; //Field offset: 0x30
	private IGameKey[] commonKeys; //Field offset: 0x38
	private int positiveIndex; //Field offset: 0x40
	private KeyValuePair[] axises; //Field offset: 0x48
	private readonly AxisCombinationState[] _states; //Field offset: 0x50
	private AxisCombinationState _state; //Field offset: 0x58

	public InputAxisCombination(EAxis gameAxis) { }

	public InputAxisCombination(EAxis gameAxis, EGameKey modificator) { }

	private void ChangeState(EAxisState state) { }

	public InputAxisCombination Clone() { }

	public virtual int GetInputCount() { }

	public float GetValue() { }

	public virtual bool IsLowerPriority(InputCombination combination) { }

	public virtual ECommand UpdateCommand(float deltaTime) { }

	public void UpdateInput(IGameKey[] positiveAxis, IGameKey[] negativeAxis, List keys, List modificator) { }

}

