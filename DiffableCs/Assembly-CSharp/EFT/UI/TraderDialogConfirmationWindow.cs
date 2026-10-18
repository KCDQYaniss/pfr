namespace EFT.UI;

public sealed class TraderDialogConfirmationWindow : DialogWindow
{
	[SerializeField]
	private Image _leftImage; //Field offset: 0xD8
	[SerializeField]
	private Image _rightImage; //Field offset: 0xE0
	[SerializeField]
	private Image _leftMask; //Field offset: 0xE8
	[SerializeField]
	private Image _rightMask; //Field offset: 0xF0
	[SerializeField]
	private TextMeshProUGUI _confirmationText; //Field offset: 0xF8
	[SerializeField]
	private DialogConfirmationWindowConfig _confirmationConfig; //Field offset: 0x100
	[SerializeField]
	private float _maskFadeDuration; //Field offset: 0x108
	[SerializeField]
	private float _maskAlpha; //Field offset: 0x10C

	protected virtual bool DragEnabled
	{
		 get { } //Length: 3
	}

	public TraderDialogConfirmationWindow() { }

	private void ApplyEntry(Entry entry) { }

	private void FadeMask(Image mask, float toAlpha) { }

	protected virtual bool get_DragEnabled() { }

	private void OnAcceptHoverIn() { }

	private void OnAcceptHoverOut() { }

	private void OnCancelHoverIn() { }

	private void OnCancelHoverOut() { }

	public DialogWindowContext Show(string selectionKey) { }

}

