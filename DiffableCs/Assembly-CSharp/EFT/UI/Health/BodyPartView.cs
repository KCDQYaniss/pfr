namespace EFT.UI.Health;

public sealed class BodyPartView : UIElement
{
	private const float HEALTHBAR_FILL_TIME = 1; //Field offset: 0x0
	[SerializeField]
	private CustomTextMeshProUGUI _valueText; //Field offset: 0x70
	[SerializeField]
	private Image _healthBar; //Field offset: 0x78
	[SerializeField]
	private Image _healthBarBorder; //Field offset: 0x80
	[SerializeField]
	private Image _image; //Field offset: 0x88
	[SerializeField]
	private Image _brokenCross; //Field offset: 0x90
	[SerializeField]
	private EffectsPanel _effectsPanel; //Field offset: 0x98
	[SerializeField]
	private DamagePanel _damagePanel; //Field offset: 0xA0
	[SerializeField]
	private HealthBarButton _button; //Field offset: 0xA8
	private Color _normalBorderColor; //Field offset: 0xB0
	private IHealthController _healthController; //Field offset: 0xC0
	private EBodyPart _bodyPart; //Field offset: 0xC8
	private float _oldValue; //Field offset: 0xCC
	private bool _firstUpdate; //Field offset: 0xD0

	public BodyPartView() { }

	private void Awake() { }

	public void SetEffectsFilter(IEnumerable effectsFilter) { }

	public void Show(IHealthController healthController, EBodyPart bodyPart, SimpleTooltip tooltip, DamageHistory damageHistory = null) { }

	private void Update() { }

}

