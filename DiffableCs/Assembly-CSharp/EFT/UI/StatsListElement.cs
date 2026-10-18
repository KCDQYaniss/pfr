namespace EFT.UI;

public class StatsListElement : MonoBehaviour
{
	[SerializeField]
	private CustomTextMeshProUGUI _caption; //Field offset: 0x20
	[SerializeField]
	private CustomTextMeshProUGUI _statFieldId; //Field offset: 0x28
	[SerializeField]
	private CustomTextMeshProUGUI _xp; //Field offset: 0x30
	[SerializeField]
	private CustomTextMeshProUGUI _value; //Field offset: 0x38
	[SerializeField]
	private Image _xpIcon; //Field offset: 0x40

	public StatsListElement() { }

	public void Show(StatInfo statInfo) { }

	public void Show(string caption) { }

	public void Show(string statFieldId, string xp, string value) { }

}

