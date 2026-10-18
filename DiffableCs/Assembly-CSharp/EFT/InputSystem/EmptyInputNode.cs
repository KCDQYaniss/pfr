namespace EFT.InputSystem;

public class EmptyInputNode : InputNode
{

	public EmptyInputNode() { }

	public void AddChildNode(InputNode node) { }

	public void RemoveChildNode(InputNode node) { }

	protected virtual ECursorResult ShouldLockCursor() { }

	protected virtual void TranslateAxes(ref float[] axes) { }

	protected virtual ETranslateResult TranslateCommand(ECommand command) { }

}

