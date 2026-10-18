namespace EFT.InputSystem;

public class InputKeyCombination : InputCombination
{
	private sealed class ClickIdlingState : KeyCombinationState
	{

		public ClickIdlingState(InputKeyCombination keyCombination) { }

		public virtual ECommand GetCommand(float deltaTime) { }

	}

	private sealed class ClickWaitForReleaseState : WaitForReleaseState
	{

		public ClickWaitForReleaseState(InputKeyCombination keyCombination) { }

		protected virtual EKeyState GetBaseState() { }

	}

	internal class ContinuousIdlingState : KeyCombinationState
	{

		public ContinuousIdlingState(InputKeyCombination keyCombination) { }

		protected bool CanProcess() { }

		public virtual ECommand GetCommand(float deltaTime) { }

	}

	internal class ContinuousPressedState : KeyCombinationState
	{

		public ContinuousPressedState(InputKeyCombination keyCombination) { }

		public virtual ECommand GetCommand(float deltaTime) { }

	}

	private sealed class DoubleClickIdlingState : KeyCombinationState
	{

		public DoubleClickIdlingState(InputKeyCombination keyCombination) { }

		public virtual ECommand GetCommand(float deltaTime) { }

	}

	internal enum EKeyState
	{
		ClickIdling = 0,
		ClickWaitForRelease = 1,
		ContinuousIdling = 2,
		ContinuousPressed = 3,
		LongTapPressed = 4,
		LongTapWaitForRelease = 5,
		ReleaseIdling = 6,
		ReleasePressed = 7,
		ReleaseStuck = 8,
		DoubleClickIdling = 9,
		WaitingForFirstRelease = 10,
		WaitingForSecondPress = 11,
		WaitingForSecondRelease = 12,
	}

	private sealed class EmptyState : KeyCombinationState
	{

		public EmptyState(InputKeyCombination keyCombination) { }

		public virtual ECommand GetCommand(float deltaTime) { }

	}

	internal abstract class KeyCombinationState
	{
		protected readonly InputKeyCombination KeyCombination; //Field offset: 0x10

		protected KeyCombinationState(InputKeyCombination keyCombination) { }

		public override void Enter() { }

		public abstract ECommand GetCommand(float deltaTime) { }

		protected override ECommand GetCommandInternal() { }

		protected bool GetKeysStatus(out EKeyPress keysStatus) { }

		protected void HandleKeys(bool justForThisFrame) { }

		protected void HandleNotUsedKeys(bool justForThisFrame) { }

		protected void UnhandleKeys(Nullable restoreValue = null) { }

	}

	private abstract class LongActionState : KeyCombinationState
	{

		protected LongActionState(InputKeyCombination keyCombination) { }

		protected bool TimeIsOut(float deltaTime) { }

	}

	private sealed class LongTapPressedState : LongActionState
	{

		public LongTapPressedState(InputKeyCombination keyCombination) { }

		public virtual void Enter() { }

		public virtual ECommand GetCommand(float deltaTime) { }

	}

	private sealed class LongTapWaitForReleaseState : WaitForReleaseState
	{

		public LongTapWaitForReleaseState(InputKeyCombination keyCombination) { }

		protected virtual EKeyState GetBaseState() { }

	}

	private sealed class ReleaseIdlingState : KeyCombinationState
	{

		public ReleaseIdlingState(InputKeyCombination keyCombination) { }

		public virtual ECommand GetCommand(float deltaTime) { }

	}

	private sealed class ReleasePressedState : KeyCombinationState
	{

		public ReleasePressedState(InputKeyCombination keyCombination) { }

		public virtual ECommand GetCommand(float deltaTime) { }

	}

	private sealed class ReleaseStuckState : KeyCombinationState
	{

		public ReleaseStuckState(InputKeyCombination keyCombination) { }

		public virtual ECommand GetCommand(float deltaTime) { }

	}

	private abstract class WaitForReleaseState : KeyCombinationState
	{

		protected WaitForReleaseState(InputKeyCombination keyCombination) { }

		protected abstract EKeyState GetBaseState() { }

		public virtual ECommand GetCommand(float deltaTime) { }

	}

	private sealed class WaitingForFirstReleaseState : LongActionState
	{

		public WaitingForFirstReleaseState(InputKeyCombination keyCombination) { }

		public virtual void Enter() { }

		public virtual ECommand GetCommand(float deltaTime) { }

	}

	private sealed class WaitingForSecondPressState : LongActionState
	{

		public WaitingForSecondPressState(InputKeyCombination keyCombination) { }

		public virtual ECommand GetCommand(float deltaTime) { }

	}

	private sealed class WaitingForSecondReleaseState : LongActionState
	{

		public WaitingForSecondReleaseState(InputKeyCombination keyCombination) { }

		public virtual ECommand GetCommand(float deltaTime) { }

	}

	private KeyCombinationState _state; //Field offset: 0x20
	protected readonly KeyCombinationState[] States; //Field offset: 0x28
	public float DoubleClickTimeout; //Field offset: 0x30
	private float _doubleClickTimeLeft; //Field offset: 0x34
	public readonly EGameKey GameKey; //Field offset: 0x38
	public IGameKey[] InputKeys; //Field offset: 0x40
	public EPressType Type; //Field offset: 0x48
	private ECommand _currentCommand; //Field offset: 0x4C
	protected ECommand _continuousCommand; //Field offset: 0x50
	protected ECommand _defaultCommand; //Field offset: 0x54
	protected bool _differentCommandOnContinuous; //Field offset: 0x58
	private bool _calculateFullHash; //Field offset: 0x59
	private int _checkHash; //Field offset: 0x5C
	public int KeysHash; //Field offset: 0x60
	public Action OnSetKeys; //Field offset: 0x68

	public bool CalculateFullHash
	{
		 get { } //Length: 5
		 set { } //Length: 169
	}

	protected ECommand Command
	{
		 get { } //Length: 4
	}

	public InputKeyCombination(EGameKey gameKey, ECommand command, int priority = -1) { }

	protected void ChangeState(EKeyState nextStateName) { }

	public override InputKeyCombination Clone() { }

	public bool get_CalculateFullHash() { }

	protected ECommand get_Command() { }

	public virtual int GetInputCount() { }

	protected void HandleDifferentCommandOnContinuous() { }

	public virtual bool IsLowerPriority(InputCombination combination) { }

	private void RecalculateHash(bool fullHash) { }

	public void set_CalculateFullHash(bool value) { }

	public virtual string ToString() { }

	public virtual ECommand UpdateCommand(float deltaTime) { }

	public void UpdateInput(List inputKeys, EPressType pressType) { }

}

