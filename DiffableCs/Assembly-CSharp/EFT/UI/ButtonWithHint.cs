namespace EFT.UI;

public class ButtonWithHint : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
{
	[SerializeField]
	private Button _button; //Field offset: 0x20
	[SerializeField]
	private TextMeshProUGUI _label; //Field offset: 0x28
	private Action _onClick; //Field offset: 0x30

	public ButtonWithHint() { }

	[CompilerGenerated]
	private void <Awake>b__3_0() { }

	private void Awake() { }

	public override void OnPointerEnter(PointerEventData eventData) { }

	public override void OnPointerExit(PointerEventData eventData) { }

	public void Show(Action onClick) { }

}

