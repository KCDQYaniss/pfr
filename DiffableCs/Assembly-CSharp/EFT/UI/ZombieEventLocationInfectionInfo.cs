namespace EFT.UI;

public class ZombieEventLocationInfectionInfo : UIElement
{
	[SerializeField]
	private TMP_Text _label; //Field offset: 0x70
	[SerializeField]
	private Image _icon; //Field offset: 0x78
	[SerializeField]
	private Sprite _yellowSprite; //Field offset: 0x80
	[SerializeField]
	private Sprite _redSprite; //Field offset: 0x88
	[SerializeField]
	private Color _yellowColor; //Field offset: 0x90
	[SerializeField]
	private Color _redColor; //Field offset: 0xA0

	public ZombieEventLocationInfectionInfo() { }

	public void SetInfection(int infection, int redThreat) { }

}

