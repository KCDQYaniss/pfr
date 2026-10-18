namespace EFT.UI;

public sealed class BuffPanel : BuffThumb
{
	[SerializeField]
	private BuffIcon _icon; //Field offset: 0x80
	[SerializeField]
	private CustomTextMeshProUGUI _description; //Field offset: 0x88

	public BuffPanel() { }

	public void Show(Skill skill, Buff buff) { }

	public void UpdateBuff() { }

}

