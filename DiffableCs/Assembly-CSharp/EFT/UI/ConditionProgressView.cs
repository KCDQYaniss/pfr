namespace EFT.UI;

public abstract class ConditionProgressView : UIElement
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass19_0
	{
		public ConditionProgressChecker progress; //Field offset: 0x10
		public ConditionProgressView <>4__this; //Field offset: 0x18

		public <>c__DisplayClass19_0() { }

		internal void <Show>b__0() { }

	}

	[SerializeField]
	private TMP_Text _conditionName; //Field offset: 0x70
	[SerializeField]
	private TMP_Text _targetValue; //Field offset: 0x78
	[SerializeField]
	private TMP_Text _currentValue; //Field offset: 0x80
	[SerializeField]
	private Graphic[] _valueObjects; //Field offset: 0x88
	private IConditional _conditional; //Field offset: 0x90
	private Condition _condition; //Field offset: 0x98
	private Color _colorReady; //Field offset: 0xA0
	private Color _colorNotReady; //Field offset: 0xB0
	private bool _complete; //Field offset: 0xC0

	protected bool Complete
	{
		 get { } //Length: 8
	}

	protected Condition CurrentCondition
	{
		 get { } //Length: 8
	}

	protected IConditional CurrentConditional
	{
		 get { } //Length: 8
	}

	protected override bool HideTargetValueWhenEmpty
	{
		 get { } //Length: 3
	}

	protected override bool HideValueObjectsWhenEmpty
	{
		 get { } //Length: 3
	}

	protected ConditionProgressView() { }

	protected bool get_Complete() { }

	protected Condition get_CurrentCondition() { }

	protected IConditional get_CurrentConditional() { }

	protected override bool get_HideTargetValueWhenEmpty() { }

	protected override bool get_HideValueObjectsWhenEmpty() { }

	protected override void GetConditionLocalization(Condition condition, out string typeName, out string nameText, out string value) { }

	protected override void OnStateUpdated() { }

	private void SetStaticState() { }

	protected void Show(IConditional conditional, Condition condition, Color colorReady, Color colorNotReady) { }

	protected override bool TryGetCurrentValue(ConditionProgressChecker progress, out double count) { }

	private void UpdateProgress(ConditionProgressChecker progress) { }

}

