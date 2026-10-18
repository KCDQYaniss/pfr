namespace EFT.UI.Health;

public class HealthParameterPanel : MonoBehaviour
{
	[SerializeField]
	private TMP_Text _currentValue; //Field offset: 0x20
	[SerializeField]
	private TMP_Text _maxValue; //Field offset: 0x28
	[SerializeField]
	private Image _statusOkGlow; //Field offset: 0x30
	[SerializeField]
	private Image _glow; //Field offset: 0x38
	[SerializeField]
	private Image _icon; //Field offset: 0x40
	[SerializeField]
	private Color _warningColor; //Field offset: 0x48
	[SerializeField]
	private Color _alternativeWarningColor; //Field offset: 0x58
	[SerializeField]
	private int _minimalStringLength; //Field offset: 0x68
	[SerializeField]
	private Color _additionalZerosColor; //Field offset: 0x6C
	private float _cachedWarningThreshold; //Field offset: 0x7C
	private float _cachedRoundValue; //Field offset: 0x80
	private float _cachedCurrentValue; //Field offset: 0x84
	private float _cachedMaxValue; //Field offset: 0x88
	private Color _defaultColor; //Field offset: 0x8C

	public HealthParameterPanel() { }

	protected override void Awake() { }

	private bool IsStateChanged(ValueStruct value, float warningThreshold, int roundValue) { }

	public void SetParameterValue(ValueStruct value, float warningThreshold, int roundValue, bool countFromTop = false, bool forceUpdate = false) { }

	public void SetWarningColor(bool display, bool useAlternative) { }

}

