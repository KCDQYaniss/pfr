namespace EFT.UI;

public sealed class ConditionCharacteristicsSlider : UIElement
{
	[SerializeField]
	private Image _border; //Field offset: 0x70
	[SerializeField]
	private Image _currentDurabilityImage; //Field offset: 0x78
	[SerializeField]
	private Image _selectedDurabilityImage; //Field offset: 0x80
	[SerializeField]
	private Image _maximumDirabilityImage; //Field offset: 0x88
	[SerializeField]
	private Image _maximumDurabilityRemovedImage; //Field offset: 0x90
	[SerializeField]
	private Image _maxDegradation; //Field offset: 0x98
	[SerializeField]
	private Slider _durabilitySlider; //Field offset: 0xA0
	[SerializeField]
	private TMP_Text _durabilityLabel; //Field offset: 0xA8
	[SerializeField]
	private Button _maximumSliderValueButton; //Field offset: 0xB0
	[SerializeField]
	private Color _criticalColor; //Field offset: 0xB8
	[SerializeField]
	private Color _defaultColor; //Field offset: 0xC8
	private float _selectedDurability; //Field offset: 0xD8
	[CompilerGenerated]
	private Action OnSliderValueChangedEvent; //Field offset: 0xE0
	private Vector2 _range; //Field offset: 0xE8
	private IRepairStrategy _repairStrategy; //Field offset: 0xF0

	public event Action OnSliderValueChangedEvent
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	private float CurrentDurability
	{
		private get { } //Length: 81
	}

	private float MaxDurability
	{
		private get { } //Length: 81
	}

	public float RealCurrentDurability
	{
		 get { } //Length: 168
	}

	private int TemplateDurability
	{
		private get { } //Length: 81
	}

	public float Value
	{
		 get { } //Length: 131
		 set { } //Length: 202
	}

	public ConditionCharacteristicsSlider() { }

	[CompilerGenerated]
	private void <Awake>b__28_0() { }

	[CompilerGenerated]
	public void add_OnSliderValueChangedEvent(Action value) { }

	private void Awake() { }

	private float get_CurrentDurability() { }

	private float get_MaxDurability() { }

	public float get_RealCurrentDurability() { }

	private int get_TemplateDurability() { }

	public float get_Value() { }

	[CompilerGenerated]
	public void remove_OnSliderValueChangedEvent(Action value) { }

	public void set_Value(float value) { }

	public void SetSliderActive(bool value) { }

	public void SetSliderInteractable(bool value) { }

	public void SetSliderValues(bool setAnchors = true) { }

	public void Show(IRepairStrategy repairStrategy) { }

	public void UpdateDegradationPrediction(Vector2 range, bool setMaxValue) { }

	private void UpdateValue(float value) { }

}

