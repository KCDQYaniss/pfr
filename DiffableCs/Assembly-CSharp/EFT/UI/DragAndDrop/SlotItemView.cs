namespace EFT.UI.DragAndDrop;

public class SlotItemView : GridItemView
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Predicate <>9__24_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <UpdateInfo>b__24_0(ItemAttribute x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass24_0
	{
		public Mastering mastered; //Field offset: 0x10

		public <>c__DisplayClass24_0() { }

		internal float <UpdateInfo>b__1() { }

	}

	private const float DURABILITY_THRESHOLD = 10; //Field offset: 0x0
	[SerializeField]
	protected Image BackgroundPattern; //Field offset: 0x2E0
	[SerializeField]
	protected Image BackgroundShadow; //Field offset: 0x2E8
	[SerializeField]
	private Slider _masteringSlider; //Field offset: 0x2F0
	[SerializeField]
	private Image _masteringIcon; //Field offset: 0x2F8
	[SerializeField]
	private DurabilitySlider _durabilitySlider; //Field offset: 0x300
	[SerializeField]
	private TextMeshProUGUI _masteringLabel; //Field offset: 0x308
	[SerializeField]
	private GameObject _masteringParent; //Field offset: 0x310
	private ItemAttribute _durabilityItemAttribute; //Field offset: 0x318
	private bool _showWeaponSkills; //Field offset: 0x320
	private bool _showResource; //Field offset: 0x321
	private SkillManager _skills; //Field offset: 0x328
	private bool _isSpecSlotLayout; //Field offset: 0x330
	private bool _isBeingExaminated; //Field offset: 0x331

	protected virtual string ValueFormat
	{
		 get { } //Length: 87
	}

	public SlotItemView() { }

	private static void AlignTransform(RectTransform rectTransform) { }

	public static SlotItemView Create(Item item, ItemContext sourceContext, ItemController itemController, IItemOwner itemOwner, ItemUiContext itemUiContext, SkillManager skills, InsuranceCompany insurance, WishlistManager wishlistStorage) { }

	protected virtual string get_ValueFormat() { }

	protected SlotItemView NewSlotItemView(Item item, ItemContext sourceContext, ItemRotation rotation, ItemController itemController, IItemOwner itemOwner, ItemUiContext itemUiContext, SkillManager skills, InsuranceCompany insurance, WishlistManager wishlistStorage) { }

	protected virtual void OnBeingExaminedChanged(bool isBeingExamined) { }

	protected virtual void OnItemAdded(AddItemEventArgs eventArgs) { }

	private void UpdateDurabilitySlider() { }

	public virtual void UpdateInfo() { }

	protected virtual void UpdateInfoVisibility(bool visible) { }

	private void UpdateSlotType(bool forcedRedraw) { }

	protected virtual void UpdateStaticInfo() { }

	private void ValidateDurability() { }

	private void ValidateMastering() { }

}

