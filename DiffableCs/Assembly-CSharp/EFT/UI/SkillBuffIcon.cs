namespace EFT.UI;

public class SkillBuffIcon : UIElement, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
{
	[SerializeField]
	private Image _image; //Field offset: 0x70
	[SerializeField]
	private Sprite _buffSprite; //Field offset: 0x78
	[SerializeField]
	private Sprite _debuffSprite; //Field offset: 0x80
	private SimpleTooltip _tooltip; //Field offset: 0x88
	private IStimulatorBuff _buff; //Field offset: 0x90

	public SkillBuffIcon() { }

	public virtual void Close() { }

	public override void OnPointerEnter(PointerEventData eventData) { }

	public override void OnPointerExit(PointerEventData eventData) { }

	public void Show(IStimulatorBuff buff) { }

}

