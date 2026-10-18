namespace EFT.UI;

public class CharacteristicPanel : CompactCharacteristicPanel
{
	private const float COMPARE_BLINK_PERIOD = 0.5; //Field offset: 0x0
	private const float COMPARE_BLINK_MIN_ALPHA = 0.2; //Field offset: 0x0
	private const float COMPARE_BLINK_MAX_ALPHA = 0.6; //Field offset: 0x0
	private const float COMPARE_BLINK_DELTA_ALPHA = 0.40000004; //Field offset: 0x0
	[SerializeField]
	protected Image Border; //Field offset: 0xF0
	[SerializeField]
	protected Image Current; //Field offset: 0xF8
	[SerializeField]
	protected Image Delta; //Field offset: 0x100
	[SerializeField]
	protected Image CompareDelta; //Field offset: 0x108
	[SerializeField]
	protected Color CurrentColor; //Field offset: 0x110
	[SerializeField]
	protected Color LowColor; //Field offset: 0x120
	[SerializeField]
	protected Color SubColor; //Field offset: 0x130
	[SerializeField]
	protected Color AddColor; //Field offset: 0x140
	[SerializeField]
	protected Sprite AddSprite; //Field offset: 0x150
	[SerializeField]
	protected Sprite SubSprite; //Field offset: 0x158
	private Color _actualCompareColor; //Field offset: 0x160
	private float _compareAlpha; //Field offset: 0x170
	private float _compareAlphaBackup; //Field offset: 0x174

	public CharacteristicPanel() { }

	public virtual void SetValues() { }

	public void Show(Item item) { }

	private void Update() { }

}

