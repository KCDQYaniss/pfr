namespace EFT.UI;

public class PocketMapMarker : MonoBehaviour, IPointerClickHandler, IEventSystemHandler, IPointerEnterHandler, IPointerExitHandler
{
	[SerializeField]
	private Image _image; //Field offset: 0x20
	[SerializeField]
	private CustomTextMeshProUGUI _note; //Field offset: 0x28
	[SerializeField]
	private RectTransform _noteBack; //Field offset: 0x30
	[SerializeField]
	private Image _shadow; //Field offset: 0x38
	[SerializeField]
	private SpriteMap _spriteMap; //Field offset: 0x40
	public MapMarker Marker; //Field offset: 0x48
	private PocketMapMarkerManager _manager; //Field offset: 0x50

	public PocketMapMarker() { }

	public void Init(MapMarker marker, PocketMapMarkerManager manager) { }

	public override void OnPointerClick(PointerEventData eventData) { }

	public override void OnPointerEnter(PointerEventData eventData) { }

	public override void OnPointerExit(PointerEventData eventData) { }

	public void ShowNote(bool value) { }

	private void Start() { }

}

