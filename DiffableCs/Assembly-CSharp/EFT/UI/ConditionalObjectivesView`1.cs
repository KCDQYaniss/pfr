namespace EFT.UI;

public abstract class ConditionalObjectivesView`1 : UIElement, IConditionalObjectivesView
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__11_0; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal UpdatableBindableList <GetChildConditions>b__11_0(Condition x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass8_0
	{
		public ConditionProgressChecker condition; //Field offset: 0x0
		public ConditionalObjectivesView <>4__this; //Field offset: 0x0

		public <>c__DisplayClass8_0() { }

		internal void <SubscribeConditions>b__0() { }

	}

	[SerializeField]
	protected RectTransform _container; //Field offset: 0x0
	private IConditional _conditional; //Field offset: 0x0
	private ConditionCollection _conditions; //Field offset: 0x0
	private readonly List _unsubscribeActions; //Field offset: 0x0
	protected ItemController ItemController; //Field offset: 0x0
	protected ViewList ViewList; //Field offset: 0x0

	protected ConditionalObjectivesView`1() { }

	public virtual void Close() { }

	public override void CloseView() { }

	protected abstract void CreateViewList(ConditionCollection conditions) { }

	protected static UpdatableBindableList GetChildConditions(ConditionCollection questConditions) { }

	private void OnConditionChangedHandler(ConditionProgressChecker obj) { }

	public override void Show(ConditionalController controller, ItemController itemController, ConditionCollection conditions, IConditional conditional) { }

	private void SubscribeConditions() { }

	private void UpdateConditions(ConditionCollection conditions) { }

}

