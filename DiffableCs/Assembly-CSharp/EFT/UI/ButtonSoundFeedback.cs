namespace EFT.UI;

public class ButtonSoundFeedback : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerClickHandler
{
	[SerializeField]
	private bool _onPointerEnterSound; //Field offset: 0x20
	[SerializeField]
	private EUISoundType _hoverSound; //Field offset: 0x24
	[SerializeField]
	private bool _onPointerClickSound; //Field offset: 0x28
	[SerializeField]
	private EUISoundType _clickSound; //Field offset: 0x2C

	public ButtonSoundFeedback() { }

	protected override bool CanPlaySound() { }

	public override void OnPointerClick(PointerEventData eventData) { }

	protected void PlayClickSound() { }

	private override void UnityEngine.EventSystems.IPointerEnterHandler.OnPointerEnter(PointerEventData eventData) { }

}

