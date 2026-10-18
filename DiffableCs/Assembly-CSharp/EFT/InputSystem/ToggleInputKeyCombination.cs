namespace EFT.InputSystem;

public sealed class ToggleInputKeyCombination : InputKeyCombination
{
	private sealed class ContinuousIdlingToggleState : ContinuousIdlingState
	{
		private ToggleInputKeyCombination _keyCombination; //Field offset: 0x18

		public ContinuousIdlingToggleState(ToggleInputKeyCombination keyCombination) { }

		public virtual ECommand GetCommand(float deltaTime) { }

	}

	private sealed class ContinuousPressedToggleState : ContinuousPressedState
	{
		private ToggleInputKeyCombination _keyCombination; //Field offset: 0x18

		public ContinuousPressedToggleState(ToggleInputKeyCombination keyCombination) { }

		protected virtual ECommand GetCommandInternal() { }

	}

	private readonly ECommand _disableCommand; //Field offset: 0x70

	public ToggleInputKeyCombination(EGameKey gameKey, ECommand toggleCommand, ECommand disableCommand, int priority = -1) { }

	public ToggleInputKeyCombination(EGameKey gameKey, ECommand pressingCommand, ECommand toggleCommand, ECommand disableCommand, int priority = -1) { }

	public virtual InputKeyCombination Clone() { }

	public virtual string ToString() { }

}

