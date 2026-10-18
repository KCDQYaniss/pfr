namespace EFT.InputSystem;

public abstract class InputNodeAbstract : SerializedMonoBehaviour
{
	[SerializeField]
	protected List _children; //Field offset: 0x60
	private readonly List _childrenCache; //Field offset: 0x68

	protected InputNodeAbstract() { }

	public void CheckDuplicateChildren() { }

	protected override void TranslateInput(List commands, ref float[] axes, ref ECursorResult shouldLockCursor) { }

}

