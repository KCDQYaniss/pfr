namespace EFT.UI;

public sealed class AmmoSelector : UIInputNode
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass19_0
	{
		public Weapon weapon; //Field offset: 0x10
		public InventoryController controller; //Field offset: 0x18
		public Magazine currentMagazine; //Field offset: 0x20

		public <>c__DisplayClass19_0() { }

		internal bool <FindAmmoForWeapon>b__6(Ammo ammo) { }

		internal bool <FindAmmoForWeapon>b__7(Ammo ammo) { }

		internal bool <FindAmmoForWeapon>b__9(Ammo x) { }

		internal IEnumerable <FindAmmoForWeapon>g__GetChamberAmmo|1() { }

		internal IEnumerable <FindAmmoForWeapon>g__GetMagazines|0() { }

		internal IEnumerable <FindAmmoForWeapon>g__GetRevolverAmmo|2() { }

		internal IEnumerable <FindAmmoForWeapon>g__GetUnderbarrelAmmo|3() { }

		internal IEnumerable <FindAmmoForWeapon>g__GetUsableAmmo|4() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass19_1
	{
		public Slot magazineSlot; //Field offset: 0x10
		public <>c__DisplayClass19_0 CS$<>8__locals1; //Field offset: 0x18

		public <>c__DisplayClass19_1() { }

		internal bool <FindAmmoForWeapon>b__5(Magazine mag) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass19_2
	{
		public Launcher ubWeapon; //Field offset: 0x10

		public <>c__DisplayClass19_2() { }

		internal bool <FindAmmoForWeapon>b__8(Ammo ammo) { }

	}

	[SerializeField]
	private LayoutElement _cancelView; //Field offset: 0x80
	[SerializeField]
	private Image _cancelBackground; //Field offset: 0x88
	[SerializeField]
	private Vector2 _arrowOffset; //Field offset: 0x90
	[SerializeField]
	private Color _normalCancelColor; //Field offset: 0x98
	[SerializeField]
	private Color _selectedCancelColor; //Field offset: 0xA8
	private readonly List _magazinesViews; //Field offset: 0xB8
	private readonly List _magazines; //Field offset: 0xC0
	private int _selectedMagIndex; //Field offset: 0xC8
	private TaskCompletionSource _taskSource; //Field offset: 0xD0

	public bool IsShown
	{
		 get { } //Length: 12
	}

	private int SelectedMagIndex
	{
		private get { } //Length: 7
		private set { } //Length: 73
	}

	public AmmoSelector() { }

	private void AddMagView(GridItemView view, Item magazine) { }

	public virtual void Close() { }

	private static IEnumerable FindAmmoForWeapon(InventoryController controller, Weapon weapon) { }

	public bool get_IsShown() { }

	private int get_SelectedMagIndex() { }

	[CanBeNull]
	public Item GetSelectedMagazine() { }

	private void RemoveMagView(int index) { }

	private void SelectNext() { }

	private void SelectPrev() { }

	private void set_SelectedMagIndex(int value) { }

	private void SetResult(Item result) { }

	private void SetSelectedState(int index, bool isSelected) { }

	protected virtual ECursorResult ShouldLockCursor() { }

	public Task ShowAcceptableMags(IEnumerable foundMags, InventoryController inventoryController, Vector2 screenPosition, InsuranceCompany insurance) { }

	protected virtual void TranslateAxes(ref float[] axes) { }

	protected virtual ETranslateResult TranslateCommand(ECommand command) { }

	public static bool TryFindAmmoForWeapon(InventoryController controller, Weapon weapon, out IEnumerable result) { }

	private void UpdateSelection(int prevSelectionIndex, int currentSelectionIndex) { }

}

