namespace EFT.UI.Health;

public sealed class HealthBarButton : UIElement, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IDropHandler, IPointerClickHandler
{
	private static readonly int _highlighted; //Field offset: 0x0
	private static readonly int _normal; //Field offset: 0x4
	[SerializeField]
	private Animator _animator; //Field offset: 0x70
	private EBodyPart _bodyPart; //Field offset: 0x78
	private IHealthController _healthController; //Field offset: 0x80
	private ItemUiContext _uiContext; //Field offset: 0x88

	private static HealthBarButton() { }

	public HealthBarButton() { }

	private void OnDraggingStop() { }

	public override void OnDrop(PointerEventData eventData) { }

	public override void OnPointerClick(PointerEventData eventData) { }

	public override void OnPointerEnter(PointerEventData eventData) { }

	public override void OnPointerExit(PointerEventData eventData) { }

	public void Show(IHealthController healthController, EBodyPart bodyPart) { }

}

