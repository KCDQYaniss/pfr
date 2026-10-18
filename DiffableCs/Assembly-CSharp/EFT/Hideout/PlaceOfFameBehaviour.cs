namespace EFT.Hideout;

public class PlaceOfFameBehaviour : AreaBehaviour, ITooltipHideoutArea
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__10_0; //Field offset: 0x8
		public static Func <>9__11_0; //Field offset: 0x10
		public static Func <>9__11_1; //Field offset: 0x18

		private static <>c() { }

		public <>c() { }

		internal bool <CalculateExpBonus>b__11_0(Item i) { }

		internal DogtagComponent <CalculateExpBonus>b__11_1(Item dogtagItem) { }

		internal bool <ConfigureBonusesCustom>b__10_0(Bonus bonus) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass11_0
	{
		public DogtagComponent dogtag; //Field offset: 0x10

		public <>c__DisplayClass11_0() { }

		internal bool <CalculateExpBonus>b__2(UpdatableChatMember f) { }

	}

	private CompoundItem _stash; //Field offset: 0x68
	private double _calculatedExpBonus; //Field offset: 0x70
	private int _playerMaxLevel; //Field offset: 0x78
	private float _expForLevelOneDogtag; //Field offset: 0x7C

	public PlaceOfFameBehaviour() { }

	[CompilerGenerated]
	private bool <IsContainerOfItemIsLocalStash>b__9_0(Item parent) { }

	private void CalculateExpBonus() { }

	public virtual void ConfigureBonusesCustom(ref RelatedBonuses relatedBonuses, ELevelType levelType) { }

	protected virtual void Init(AreaData data) { }

	private bool IsContainerOfItemIsLocalStash(IContainer container) { }

	private void OnItemAdded(AddItemEventArgs addInfo) { }

	private void OnItemRemoved(RemoveItemEventArgs removeInfo) { }

	public virtual void ReleaseSubscriptions() { }

	public override bool TryGetTooltipText(out string tooltip) { }

	private void TryReCalculateBonuses(Item item, IContainer itemContainer, CommandStatus status) { }

}

