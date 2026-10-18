//Type is in global namespace

public class ArmorDummy : MonoBehaviour
{
	[Header("Armor class [1..10]")]
	public int ArmorClass; //Field offset: 0x20
	public float Durability; //Field offset: 0x24
	public int MaxDurability; //Field offset: 0x28
	public int MaxHealth; //Field offset: 0x2C
	public float Health; //Field offset: 0x30
	public Renderer[] Body; //Field offset: 0x38
	public CustomTextMeshProUGUI PopupText; //Field offset: 0x40
	public RectTransform ArmorImage; //Field offset: 0x48
	public RectTransform HealthImage; //Field offset: 0x50
	public BallisticCollider Coolider; //Field offset: 0x58
	public Transform PivotBars; //Field offset: 0x60
	public RectTransform Panel; //Field offset: 0x68

	public ArmorDummy() { }

	public void CooliderOnOnHitAction(DamageInfo damageInfo) { }

	private void Start() { }

	private void Update() { }

}

