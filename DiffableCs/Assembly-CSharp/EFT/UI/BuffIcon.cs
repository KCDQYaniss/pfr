namespace EFT.UI;

public sealed class BuffIcon : BuffThumb, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
{
	[SerializeField]
	private Image _icon; //Field offset: 0x80
	[SerializeField]
	private Image _background; //Field offset: 0x88
	[SerializeField]
	private Sprite _normalBackgroundSprite; //Field offset: 0x90
	[SerializeField]
	private Sprite _eliteBackgroundSprite; //Field offset: 0x98
	private SimpleTooltip _tooltip; //Field offset: 0xA0

	public BuffIcon() { }

	public static string GetBuffDescription(Buff buff) { }

	[CanBeNull]
	private static Sprite LoadBuffIcon(Buff buff) { }

	public override void OnPointerEnter(PointerEventData eventData) { }

	public override void OnPointerExit(PointerEventData eventData) { }

	public void Show(Buff buff, Skill skill) { }

	public void UpdateBuff() { }

}

