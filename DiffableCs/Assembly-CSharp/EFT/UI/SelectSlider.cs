namespace EFT.UI;

public sealed class SelectSlider : UIElement, IValueUpdatable
{
	[SerializeField]
	private Slider _slider; //Field offset: 0x70
	[SerializeField]
	private TextMeshProUGUI _valueText; //Field offset: 0x78
	[SerializeField]
	private GameObject _notchTemplate; //Field offset: 0x80
	[SerializeField]
	private RectTransform _notchContainer; //Field offset: 0x88
	private readonly List _notches; //Field offset: 0x90
	private Action _onValueChanged; //Field offset: 0x98
	private Func _valuesGetter; //Field offset: 0xA0
	private bool _isPrepareToShow; //Field offset: 0xA8
	private string[] _values; //Field offset: 0xB0

	public SelectSlider() { }

	[CompilerGenerated]
	private void <Awake>b__9_0(float val) { }

	private void Awake() { }

	public override void Bind(Action valueChanged) { }

	private void ClearNotches() { }

	public override int CurrentValue() { }

	internal void SetLabelText(string text) { }

	public void Show(string[] values) { }

	public void Show(Func values) { }

	public override void UpdateValue(int value, bool sendCallback = true, Nullable min = null, Nullable max = null) { }

	private void UpdateValues() { }

}

