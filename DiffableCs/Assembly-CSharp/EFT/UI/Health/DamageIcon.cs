namespace EFT.UI.Health;

public class DamageIcon : UIElement
{
	[SerializeField]
	private Image _icon; //Field offset: 0x70
	private HoverTrigger _hoverTrigger; //Field offset: 0x78
	private SimpleTooltip _tooltip; //Field offset: 0x80
	private string _tooltipText; //Field offset: 0x88

	public DamageIcon() { }

	[CompilerGenerated]
	private void <Awake>b__4_0(PointerEventData arg) { }

	[CompilerGenerated]
	private void <Awake>b__4_1(PointerEventData _) { }

	private void Awake() { }

	public virtual void Close() { }

	public void Show(EDamageResult iconType, List damageList) { }

}

