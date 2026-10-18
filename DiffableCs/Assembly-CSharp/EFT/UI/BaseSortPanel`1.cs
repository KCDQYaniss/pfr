namespace EFT.UI;

public abstract class BaseSortPanel`1 : UIElement
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass7_0
	{
		public BaseSortPanel <>4__this; //Field offset: 0x0
		public TSortProperty sortType; //Field offset: 0x0
		public FilterButton button; //Field offset: 0x0

		public <>c__DisplayClass7_0() { }

		internal void <InitButton>b__0() { }

	}

	private SerializableEnumDictionary _buttons; //Field offset: 0x0
	private FilterButton _currentSortButton; //Field offset: 0x0
	[CompilerGenerated]
	private Action OnSort; //Field offset: 0x0
	private bool _ascending; //Field offset: 0x0

	public event Action OnSort
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	protected BaseSortPanel`1() { }

	[CompilerGenerated]
	public void add_OnSort(Action value) { }

	private void InitButton(TSortProperty sortType, FilterButton button) { }

	private void OnButtonClick(TSortProperty sortType, FilterButton button) { }

	[CompilerGenerated]
	public void remove_OnSort(Action value) { }

	protected void Show(SerializableEnumDictionary buttons, TSortProperty defaultSortingType, bool defaultAscending) { }

}

