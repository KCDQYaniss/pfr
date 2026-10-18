namespace EFT.InventoryLogic;

public class MagazineTemplate : GearModTemplate
{
	internal struct VisibleRange
	{
		public int Start; //Field offset: 0x0
		public int End; //Field offset: 0x4

		public bool Contains(int stackableItemStackObjectsCount) { }

	}

	[CompilerGenerated]
	private static float <MaxMalfunctionChance>k__BackingField; //Field offset: 0x0
	public int magAnimationIndex; //Field offset: 0x1A0
	public StackSlot[] Cartridges; //Field offset: 0x1A8
	public float LoadUnloadModifier; //Field offset: 0x1B0
	public float CheckTimeModifier; //Field offset: 0x1B4
	public int CheckOverride; //Field offset: 0x1B8
	public EReloadMode ReloadMagType; //Field offset: 0x1BC
	public string VisibleAmmoRangesString; //Field offset: 0x1C0
	public float MalfunctionChance; //Field offset: 0x1C8
	public bool MagazineWithBelt; //Field offset: 0x1CC
	public int BeltMagazineRefreshCount; //Field offset: 0x1D0
	public bool IsMagazineForStationaryWeapon; //Field offset: 0x1D4
	private List _visibleAmmoRanges; //Field offset: 0x1D8

	public private static float MaxMalfunctionChance
	{
		[CompilerGenerated]
		 get { } //Length: 60
		[CompilerGenerated]
		private set { } //Length: 73
	}

	public List VisibleAmmoRanges
	{
		 get { } //Length: 339
	}

	public MagazineTemplate() { }

	[CompilerGenerated]
	public static float get_MaxMalfunctionChance() { }

	public List get_VisibleAmmoRanges() { }

	public virtual void OnInit() { }

	private static List ParseVisibleRangesString(string visibleAmmoRangesString, List defaultVisibleRanges) { }

	[CompilerGenerated]
	private static void set_MaxMalfunctionChance(float value) { }

}

