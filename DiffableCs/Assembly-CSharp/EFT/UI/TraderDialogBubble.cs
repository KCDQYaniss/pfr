namespace EFT.UI;

[UsedImplicitly]
public sealed class TraderDialogBubble : UIElement
{
	[SerializeField]
	private TMP_Text _speakerNameField; //Field offset: 0x70
	[SerializeField]
	private TMP_Text _text; //Field offset: 0x78

	public TraderDialogBubble() { }

	public void Show(DialogHistoryLine line) { }

}

