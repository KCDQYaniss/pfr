namespace EFT.UI.Health;

public class InventoryScreenHealthPanel : UIElement
{
	[SerializeField]
	private HealthParametersPanel _parametersPanel; //Field offset: 0x70
	[SerializeField]
	private GameObject _silhouette; //Field offset: 0x78
	[SerializeField]
	private BodyPartView _head; //Field offset: 0x80
	[SerializeField]
	private BodyPartView _chest; //Field offset: 0x88
	[SerializeField]
	private BodyPartView _stomach; //Field offset: 0x90
	[SerializeField]
	private BodyPartView _leftArm; //Field offset: 0x98
	[SerializeField]
	private BodyPartView _rightArm; //Field offset: 0xA0
	[SerializeField]
	private BodyPartView _leftLeg; //Field offset: 0xA8
	[SerializeField]
	private BodyPartView _rightLeg; //Field offset: 0xB0
	[SerializeField]
	private GameObject _damageLegend; //Field offset: 0xB8
	private readonly Dictionary _bodyPartsViews; //Field offset: 0xC0
	private SimpleTooltip _tooltip; //Field offset: 0xC8

	public InventoryScreenHealthPanel() { }

	private void Awake() { }

	public void SetParametersVisibility(bool value) { }

	public void Show(IHealthController healthController, Inventory inventory, SkillManager skillManager, DamageHistory damageHistory = null) { }

}

