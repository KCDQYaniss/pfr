namespace EFT.UI;

public class RepairWarningStatus : UIElement
{
	[SerializeField]
	private CustomTextMeshProUGUI _label; //Field offset: 0x70

	public RepairWarningStatus() { }

	public virtual void Close() { }

	public void Show(string text) { }

}

