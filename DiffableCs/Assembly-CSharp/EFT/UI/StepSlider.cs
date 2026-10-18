namespace EFT.UI;

public class StepSlider : MonoBehaviour, IValueUpdatable
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass15_0
	{
		public int value; //Field offset: 0x10

		public <>c__DisplayClass15_0() { }

		internal int <GetIndexOfClosest>b__0(int x, int y) { }

	}

	[SerializeField]
	private Slider _slider; //Field offset: 0x20
	[SerializeField]
	private CustomTextMeshProInputField _valueInput; //Field offset: 0x28
	[SerializeField]
	private GameObject _notchTemplate; //Field offset: 0x30
	[SerializeField]
	private RectTransform _notchContainer; //Field offset: 0x38
	private readonly List _notches; //Field offset: 0x40
	private readonly List _realValues; //Field offset: 0x48
	private int _minValue; //Field offset: 0x50
	private int _maxValue; //Field offset: 0x54
	private int _oneNotchValue; //Field offset: 0x58
	private int _currentValue; //Field offset: 0x5C

	public StepSlider() { }

	[CompilerGenerated]
	private void <Awake>b__10_0(float arg) { }

	[CompilerGenerated]
	private void <Awake>b__10_1(string arg) { }

	[CompilerGenerated]
	private void <Awake>b__10_2(string value) { }

	private void Awake() { }

	public override void Bind(Action valueChanged) { }

	private static int Ceil(decimal value) { }

	private void CreateNotch(int value) { }

	public override float CurrentValue() { }

	public void Focus() { }

	private int GetIndexOfClosest(IList list, int value) { }

	private void Reset() { }

	private void SetCurrentValue(int realValue, float sliderValue) { }

	public void Show(int minValue, int maxValue, int currentValue) { }

	public override void UpdateValue(float value, bool sendCallback = true, Nullable min = null, Nullable max = null) { }

}

