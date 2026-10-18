namespace EFT;

public class TacticalRangeFinderController : MonoBehaviour
{
	private enum DistanceOutputFormat
	{
		FourDigits = 0,
		ThreeDigitsAndDot = 1,
	}

	[SerializeField]
	private DistanceOutputFormat _distanceOutputFormat; //Field offset: 0x20
	[SerializeField]
	private string _noDistanceText; //Field offset: 0x28
	[SerializeField]
	private float _delayInSecsBetweenCasts; //Field offset: 0x30
	[SerializeField]
	private Canvas _canvas; //Field offset: 0x38
	[SerializeField]
	private TMP_Text _textOnDisplay; //Field offset: 0x40
	[SerializeField]
	private Transform _boneToCastRay; //Field offset: 0x48
	[SerializeField]
	private float _rayStartOffset; //Field offset: 0x50
	[SerializeField]
	private float _maxCastDistance; //Field offset: 0x54
	[SerializeField]
	private float _cullDistance; //Field offset: 0x58
	[SerializeField]
	private LayerMask _mask; //Field offset: 0x5C
	private float _timeSinceLastDelay; //Field offset: 0x60
	private readonly CustomSampler _profiler; //Field offset: 0x68

	public TacticalRangeFinderController() { }

	private void MeasureDistance() { }

	private void OnDisable() { }

	private void OnEnable() { }

	private void Update() { }

}

