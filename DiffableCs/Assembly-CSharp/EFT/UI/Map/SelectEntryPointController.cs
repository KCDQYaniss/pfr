namespace EFT.UI.Map;

public class SelectEntryPointController
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__5_0; //Field offset: 0x8
		public static Func <>9__9_0; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal int <.ctor>b__9_0(EntryPoint x) { }

		internal bool <get_SelectedPoint>b__5_0(EntryPoint x) { }

	}

	private int _selectedIndex; //Field offset: 0x10
	private bool _allowSelection; //Field offset: 0x14
	private List _entryPoints; //Field offset: 0x18
	private EntryPoint _selectedPoint; //Field offset: 0x20

	public EntryPoint LastPoint
	{
		 get { } //Length: 63
	}

	public private EntryPoint SelectedPoint
	{
		 get { } //Length: 637
		private set { } //Length: 82
	}

	public SelectEntryPointController(bool allowSelection, EntryPoint[] points) { }

	public void Free() { }

	public EntryPoint get_LastPoint() { }

	public EntryPoint get_SelectedPoint() { }

	public void Select(EntryPoint point) { }

	public void SelectNext() { }

	public void SelectPrev() { }

	private void set_SelectedPoint(EntryPoint value) { }

}

