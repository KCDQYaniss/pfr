//Type is in global namespace

public sealed class DurabilitySlider : Slider
{
	[SerializeField]
	private Image _background; //Field offset: 0x168
	[SerializeField]
	private Sprite _backgroundDangerZone; //Field offset: 0x170
	[SerializeField]
	private Sprite _backgroundDefault; //Field offset: 0x178
	[SerializeField]
	private Image _fill; //Field offset: 0x180
	[SerializeField]
	private Image _fillWear; //Field offset: 0x188
	[SerializeField]
	private Sprite _fillDangerZone; //Field offset: 0x190
	[SerializeField]
	private Sprite _fillDefault; //Field offset: 0x198
	[SerializeField]
	private GameObject _glow; //Field offset: 0x1A0
	[SerializeField]
	private GameObject _repairRequiredIcon; //Field offset: 0x1A8
	[CompilerGenerated]
	private float <DurabilityThreshold>k__BackingField; //Field offset: 0x1B0
	private bool _showDurability; //Field offset: 0x1B4

	private float DurabilityThreshold
	{
		[CompilerGenerated]
		private get { } //Length: 9
		[CompilerGenerated]
		private set { } //Length: 9
	}

	public bool ShowDurability
	{
		 set { } //Length: 352
	}

	public DurabilitySlider() { }

	protected virtual void Awake() { }

	[CompilerGenerated]
	private float get_DurabilityThreshold() { }

	internal void Init(RepairableComponent repairable, float durabilityThreshold) { }

	[CompilerGenerated]
	private void set_DurabilityThreshold(float value) { }

	public void set_ShowDurability(bool value) { }

	private void SetDangerZone(bool inDangerZone) { }

	internal void UpdateValue(float durability) { }

}

