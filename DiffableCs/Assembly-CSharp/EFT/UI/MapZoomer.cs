namespace EFT.UI;

public class MapZoomer : MonoBehaviour
{
	[SerializeField]
	private float minCof; //Field offset: 0x20
	[SerializeField]
	private float maxCof; //Field offset: 0x24
	[SerializeField]
	private float scrollSensitivity; //Field offset: 0x28
	[SerializeField]
	private GameObject _fullMap; //Field offset: 0x30
	[SerializeField]
	private Scrollbar _zoomScroll; //Field offset: 0x38
	private RectTransform _mapTransform; //Field offset: 0x40
	private Vector3 positionDelta; //Field offset: 0x48
	private Vector3 previousScale; //Field offset: 0x54
	private float _minZoom; //Field offset: 0x60
	private float _maxZoom; //Field offset: 0x64
	private float locationCoefficient; //Field offset: 0x68

	public MapZoomer() { }

	private Vector3 CorrectPosition(float h, float v) { }

	private void FixedUpdate() { }

	private void Start() { }

}

