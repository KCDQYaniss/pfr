namespace EFT.UI;

public sealed class GrenadeSelector : UIInputNode
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Comparison <>9__20_0; //Field offset: 0x8
		public static Func <>9__20_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal int <GetSortedGrenadeTemplateIds>b__20_0(ThrowWeapTemplate x, ThrowWeapTemplate y) { }

		internal MongoID <GetSortedGrenadeTemplateIds>b__20_1(ThrowWeapTemplate grenade) { }

	}

	private sealed class GrenadeDictionaryComparator : Comparer
	{

		public GrenadeDictionaryComparator() { }

		public virtual int Compare(MongoID grenadeOne, MongoID grenadeTwo) { }

	}

	private static IEnumerable _sortedGrenadeTemplateIds; //Field offset: 0x0
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
	private readonly List _grenadeViews; //Field offset: 0xB8
	private readonly SortedDictionary _grenadesDictionary; //Field offset: 0xC0
	private readonly List _containersCache; //Field offset: 0xC8
	private int _selectedGrenadeIndex; //Field offset: 0xD0
	private TaskCompletionSource _taskSource; //Field offset: 0xD8

	public bool IsShown
	{
		 get { } //Length: 12
	}

	private int SelectedGrenadeIndex
	{
		private get { } //Length: 7
		private set { } //Length: 73
	}

	public GrenadeSelector() { }

	private void ApplyGrenadeView(FastAccessGrenadeGridItemView view) { }

	private void Awake() { }

	public virtual void Close() { }

	public bool get_IsShown() { }

	private int get_SelectedGrenadeIndex() { }

	[CanBeNull]
	public ThrowWeap GetGrenade() { }

	private void GetSortedGrenadeTemplateIds() { }

	private void RemoveGrenadeView(int index) { }

	private void SelectNext() { }

	private void SelectPrev() { }

	private void set_SelectedGrenadeIndex(int value) { }

	private void SetResult(ThrowWeap result) { }

	private void SetSelectedState(int index, bool isSelected) { }

	protected virtual ECursorResult ShouldLockCursor() { }

	public Task ShowGrenades(ThrowWeap priorityGrenade, InventoryController inventoryController, Vector2 screenPosition, InsuranceCompany insurance) { }

	protected virtual void TranslateAxes(ref float[] axes) { }

	protected virtual ETranslateResult TranslateCommand(ECommand command) { }

	private void UpdateSelection(int prevSelectionIndex, int currentSelectionIndex) { }

}

