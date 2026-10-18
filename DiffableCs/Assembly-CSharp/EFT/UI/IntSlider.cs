namespace EFT.UI;

public class IntSlider : MonoBehaviour, IValueUpdatable
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass12_0
	{
		public int outValue; //Field offset: 0x10
		public IntSlider <>4__this; //Field offset: 0x18

		public <>c__DisplayClass12_0() { }

		internal void <Awake>b__0(string value) { }

	}

	[SerializeField]
	private Slider _slider; //Field offset: 0x20
	[SerializeField]
	private CustomTextMeshProInputField _valueInput; //Field offset: 0x28
	[SerializeField]
	private GameObject _notchTemplate; //Field offset: 0x30
	[SerializeField]
	private GameObject _notchNotAvailableTemplate; //Field offset: 0x38
	[SerializeField]
	private RectTransform _notchContainer; //Field offset: 0x40
	private readonly List _notches; //Field offset: 0x48
	private int _currentValue; //Field offset: 0x50
	private int _minValue; //Field offset: 0x54
	private int _maxValue; //Field offset: 0x58
	private bool _allowZero; //Field offset: 0x5C

	private int Delta
	{
		private get { } //Length: 9
	}

	public IntSlider() { }

	private void Awake() { }

	public override void Bind(Action valueChanged) { }

	private void ClearNotches() { }

	public override int CurrentValue() { }

	public void Focus() { }

	private int get_Delta() { }

	public void Show(int minSliderValue, int maxSliderValue, int minValue, int maxValue, int currentValue, bool allowZero = false) { }

	private void SliderValueChanged(float value) { }

	private void TextValueChanged(string text) { }

	public override void UpdateValue(int value, bool sendCallback = true, Nullable min = null, Nullable max = null) { }

}

