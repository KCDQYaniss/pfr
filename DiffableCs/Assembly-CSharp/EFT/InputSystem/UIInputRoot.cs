namespace EFT.InputSystem;

public class UIInputRoot : InputNode
{

	public UIInputRoot() { }

	internal void Add(InputNode node) { }

	internal void Remove(InputNode node) { }

	protected virtual ECursorResult ShouldLockCursor() { }

	protected virtual void TranslateAxes(ref float[] axes) { }

	protected virtual ETranslateResult TranslateCommand(ECommand command) { }

}

