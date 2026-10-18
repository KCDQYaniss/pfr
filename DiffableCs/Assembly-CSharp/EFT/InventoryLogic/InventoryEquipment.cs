namespace EFT.InventoryLogic;

public sealed class InventoryEquipment : CompoundItem
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__20_0; //Field offset: 0x8
		public static Func <>9__21_0; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal string <.ctor>b__20_0(Slot x) { }

		internal float <GetTotalWeight>b__21_0(Slot slot) { }

	}

	public static readonly EquipmentSlot[] AllSlotNames; //Field offset: 0x0
	public static readonly EquipmentSlot[] AllVisualSlotNames; //Field offset: 0x8
	public static readonly EquipmentSlot[] TraderServicesEligibleSlots; //Field offset: 0x10
	private readonly Slot[] _cachedSlots; //Field offset: 0x90
	private readonly EquipmentSlot[] _eliteStrengthNoWeaponsWeight; //Field offset: 0x98
	private IReadOnlyList _containerSlots; //Field offset: 0xA0
	private IReadOnlyList _paymentSlots; //Field offset: 0xA8
	private IReadOnlyList _grenadeThrowingSlots; //Field offset: 0xB0
	public ThrowWeap TopPriorityGrenade; //Field offset: 0xB8

	public virtual bool CanBePickedUp
	{
		 get { } //Length: 3
	}

	public IReadOnlyList ContainerSlots
	{
		 get { } //Length: 350
	}

	public IReadOnlyList GrenadeThrowingSlots
	{
		 get { } //Length: 314
	}

	public virtual bool IsContainer
	{
		 get { } //Length: 3
	}

	public IReadOnlyList PaymentSlots
	{
		 get { } //Length: 378
	}

	private static InventoryEquipment() { }

	public InventoryEquipment(string id, InventoryEquipmentTemplate template) { }

	public virtual bool get_CanBePickedUp() { }

	public IReadOnlyList get_ContainerSlots() { }

	public IReadOnlyList get_GrenadeThrowingSlots() { }

	public virtual bool get_IsContainer() { }

	public IReadOnlyList get_PaymentSlots() { }

	public float GetEquipmentWeight() { }

	public float GetEquipmentWeightEliteSkill() { }

	public Slot GetSlot(EquipmentSlot slotName) { }

	private static float GetTotalWeight(IEnumerable slots) { }

}

