namespace EFT.InputSystem;

public abstract class InputNode : InputNodeAbstract
{
	internal enum ETranslateResult
	{
		Ignore = 0,
		Block = 1,
		BlockAll = 2,
	}

	private static readonly HashSet _alwaysIgnoreCommands; //Field offset: 0x0

	private static InputNode() { }

	protected InputNode() { }

	public void Add(InputNode inputNode) { }

	protected static ETranslateResult GetDefaultBlockResult(ECommand command) { }

	protected void RecacheChildren() { }

	public void Remove(InputNode inputNode) { }

	protected abstract ECursorResult ShouldLockCursor() { }

	protected abstract void TranslateAxes(ref float[] axes) { }

	protected abstract ETranslateResult TranslateCommand(ECommand command) { }

	protected virtual void TranslateInput(List commands, ref float[] axes, ref ECursorResult shouldLockCursor) { }

}

