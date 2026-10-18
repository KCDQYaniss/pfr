namespace EFT.UI.Health;

public class BuffableHealthParameterPanel : HealthParameterPanel
{
	private const string ACTIVE_TRIGGER = "Active"; //Field offset: 0x0
	private static readonly Color PositiveColor; //Field offset: 0x0
	private static readonly Color NegativeColor; //Field offset: 0x10
	[SerializeField]
	private Image _upBuffArrow; //Field offset: 0xA0
	[SerializeField]
	private Image _downBuffArrow; //Field offset: 0xA8
	[SerializeField]
	private TMP_Text _buffValue; //Field offset: 0xB0
	private Animator _upArrowAnimator; //Field offset: 0xB8
	private Animator _downArrowAnimator; //Field offset: 0xC0
	private float _cachedValue; //Field offset: 0xC8
	private Nullable _cachedActiveness; //Field offset: 0xCC
	private bool _inited; //Field offset: 0xCE

	private static BuffableHealthParameterPanel() { }

	public BuffableHealthParameterPanel() { }

	protected virtual void Awake() { }

	public void DisableBuff() { }

	private void Init() { }

	protected override void OnEnable() { }

	public void SetBuffValue(float value, bool active, bool positiveIncrease = true) { }

}

