namespace EFT.UI;

public sealed class QuestProgressView : UIElement
{
	[SerializeField]
	private CustomTextMeshProUGUI _percentages; //Field offset: 0x70
	[SerializeField]
	private Image _progress; //Field offset: 0x78

	public QuestProgressView() { }

	public void Show(Quest quest) { }

}

