//Type is in global namespace

[ExecuteAlways]
public class FakeInteriorTODController : MonoBehaviour
{
	private static readonly int _layerIndexOffsetId; //Field offset: 0x0
	private const float THRESHOLD = 0.001; //Field offset: 0x0
	private static readonly int _emissionMultiplierId; //Field offset: 0x4
	private float _timeElapsed; //Field offset: 0x20
	private bool _isDay; //Field offset: 0x24
	private bool _isNight; //Field offset: 0x25
	private float _layerIndexOffset; //Field offset: 0x28
	[SerializeField]
	private Vector2 _minMaxEmissionMultiplier; //Field offset: 0x2C
	[Range(0.01, 3)]
	[SerializeField]
	private float _switchDuration; //Field offset: 0x34
	[SerializeField]
	private Vector2 _dayTimeRange; //Field offset: 0x38

	private static FakeInteriorTODController() { }

	public FakeInteriorTODController() { }

	private bool InRange(float value) { }

	private void LateUpdate() { }

	private void UpdateEmission(float value, bool isDay, bool isNight) { }

}

