namespace EFT.UI.Gestures;

public abstract class GesturesBindAlignment : MonoBehaviour, ICanChangeAlignment
{
	[SerializeField]
	protected RectTransform BindRoot; //Field offset: 0x20
	[SerializeField]
	protected Image HotkeyImage; //Field offset: 0x28
	[SerializeField]
	private CustomTextMeshProUGUI _textField; //Field offset: 0x30
	[SerializeField]
	private Sprite _leftHotkeySprite; //Field offset: 0x38
	[SerializeField]
	private Sprite _rightHotkeySprite; //Field offset: 0x40

	protected GesturesBindAlignment() { }

	public override void AlignToBottom() { }

	public override void AlignToCenter() { }

	public override void AlignToLeft() { }

	public override void AlignToRight() { }

	public override void AlignToTop() { }

	private static void FlipLayoutRelatingToX(RectTransform rectTransform) { }

	private static bool IsOnRightSide(RectTransform rectTransform) { }

	private void MoveHotkeyToLeft() { }

	private void MoveHotkeyToRight() { }

}

