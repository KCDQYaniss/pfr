namespace UnityEngine.UIElements;

public class Column
{
	public class UxmlObjectFactory`1 : UxmlObjectFactory
	{

		public UxmlObjectFactory`1() { }

	}

	public class UxmlObjectTraits`1 : UxmlObjectTraits
	{
		[CompilerGenerated]
		private sealed class <>c__DisplayClass15_0
		{
			public VisualTreeAsset asset; //Field offset: 0x0

			public <>c__DisplayClass15_0() { }

			internal VisualElement <Init>b__0() { }

		}

		[CompilerGenerated]
		private sealed class <>c__DisplayClass15_1
		{
			public VisualTreeAsset asset; //Field offset: 0x0

			public <>c__DisplayClass15_1() { }

			internal VisualElement <Init>b__1() { }

		}

		private UxmlStringAttributeDescription m_Name; //Field offset: 0x0
		private UxmlStringAttributeDescription m_Text; //Field offset: 0x0
		private UxmlBoolAttributeDescription m_Visible; //Field offset: 0x0
		private UxmlStringAttributeDescription m_Width; //Field offset: 0x0
		private UxmlStringAttributeDescription m_MinWidth; //Field offset: 0x0
		private UxmlStringAttributeDescription m_MaxWidth; //Field offset: 0x0
		private UxmlBoolAttributeDescription m_Stretch; //Field offset: 0x0
		private UxmlBoolAttributeDescription m_Sortable; //Field offset: 0x0
		private UxmlBoolAttributeDescription m_Optional; //Field offset: 0x0
		private UxmlBoolAttributeDescription m_Resizable; //Field offset: 0x0
		private UxmlStringAttributeDescription m_HeaderTemplateId; //Field offset: 0x0
		private UxmlStringAttributeDescription m_CellTemplateId; //Field offset: 0x0

		public UxmlObjectTraits`1() { }

		public virtual void Init(ref T obj, IUxmlAttributes bag, CreationContext cc) { }

		private static Length ParseLength(string str, Length defaultValue) { }

	}

	private static readonly string k_InvalidTemplateError; //Field offset: 0x0
	private string m_Name; //Field offset: 0x10
	private string m_Title; //Field offset: 0x18
	private Background m_Icon; //Field offset: 0x20
	private bool m_Visible; //Field offset: 0x40
	private Length m_Width; //Field offset: 0x44
	private Length m_MinWidth; //Field offset: 0x4C
	private Length m_MaxWidth; //Field offset: 0x54
	private float m_DesiredWidth; //Field offset: 0x5C
	private bool m_Stretchable; //Field offset: 0x60
	private bool m_Sortable; //Field offset: 0x61
	private bool m_Optional; //Field offset: 0x62
	private bool m_Resizable; //Field offset: 0x63
	private Func m_MakeHeader; //Field offset: 0x68
	private Action m_BindHeader; //Field offset: 0x70
	private Action m_UnbindHeader; //Field offset: 0x78
	private Action m_DestroyHeader; //Field offset: 0x80
	private Func m_MakeCell; //Field offset: 0x88
	private Action m_BindCell; //Field offset: 0x90
	private Action m_UnbindCellItem; //Field offset: 0x98
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action <destroyCell>k__BackingField; //Field offset: 0xA0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Columns <collection>k__BackingField; //Field offset: 0xA8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action changed; //Field offset: 0xB0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action resized; //Field offset: 0xB8

	internal event Action changed
	{
		[CompilerGenerated]
		internal add { } //Length: 278
		[CompilerGenerated]
		internal remove { } //Length: 278
	}

	internal event Action resized
	{
		[CompilerGenerated]
		internal add { } //Length: 278
		[CompilerGenerated]
		internal remove { } //Length: 278
	}

	public Action bindCell
	{
		 get { } //Length: 8
	}

	public Action bindHeader
	{
		 get { } //Length: 5
	}

	public internal Columns collection
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		internal set { } //Length: 82
	}

	internal float desiredWidth
	{
		internal get { } //Length: 6
		internal set { } //Length: 48
	}

	public Action destroyCell
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public Action destroyHeader
	{
		 get { } //Length: 8
	}

	internal int displayIndex
	{
		internal get { } //Length: 214
	}

	public Background icon
	{
		 get { } //Length: 19
	}

	internal int index
	{
		internal get { } //Length: 227
	}

	public Func makeCell
	{
		 get { } //Length: 8
		 set { } //Length: 191
	}

	public Func makeHeader
	{
		 get { } //Length: 5
		 set { } //Length: 176
	}

	public Length maxWidth
	{
		 get { } //Length: 5
		 set { } //Length: 95
	}

	public Length minWidth
	{
		 get { } //Length: 5
		 set { } //Length: 95
	}

	public string name
	{
		 get { } //Length: 5
		 set { } //Length: 188
	}

	public bool optional
	{
		 get { } //Length: 5
		 set { } //Length: 52
	}

	public bool resizable
	{
		 get { } //Length: 5
		 set { } //Length: 52
	}

	public bool sortable
	{
		 get { } //Length: 5
		 set { } //Length: 52
	}

	public bool stretchable
	{
		 get { } //Length: 5
		 set { } //Length: 52
	}

	public string title
	{
		 get { } //Length: 5
		 set { } //Length: 191
	}

	public Action unbindCell
	{
		 get { } //Length: 8
	}

	public Action unbindHeader
	{
		 get { } //Length: 5
	}

	public bool visible
	{
		 get { } //Length: 5
		 set { } //Length: 52
	}

	internal int visibleIndex
	{
		internal get { } //Length: 214
	}

	public Length width
	{
		 get { } //Length: 5
		 set { } //Length: 150
	}

	private static Column() { }

	public Column() { }

	[CompilerGenerated]
	internal void add_changed(Action value) { }

	[CompilerGenerated]
	internal void add_resized(Action value) { }

	public Action get_bindCell() { }

	public Action get_bindHeader() { }

	[CompilerGenerated]
	public Columns get_collection() { }

	internal float get_desiredWidth() { }

	[CompilerGenerated]
	public Action get_destroyCell() { }

	public Action get_destroyHeader() { }

	internal int get_displayIndex() { }

	public Background get_icon() { }

	internal int get_index() { }

	public Func get_makeCell() { }

	public Func get_makeHeader() { }

	public Length get_maxWidth() { }

	public Length get_minWidth() { }

	public string get_name() { }

	public bool get_optional() { }

	public bool get_resizable() { }

	public bool get_sortable() { }

	public bool get_stretchable() { }

	public string get_title() { }

	public Action get_unbindCell() { }

	public Action get_unbindHeader() { }

	public bool get_visible() { }

	internal int get_visibleIndex() { }

	public Length get_width() { }

	internal float GetMaxWidth(float layoutWidth) { }

	internal float GetMinWidth(float layoutWidth) { }

	internal float GetWidth(float layoutWidth) { }

	private void NotifyChange(ColumnDataType type) { }

	[CompilerGenerated]
	internal void remove_changed(Action value) { }

	[CompilerGenerated]
	internal void remove_resized(Action value) { }

	[CompilerGenerated]
	internal void set_collection(Columns value) { }

	internal void set_desiredWidth(float value) { }

	public void set_makeCell(Func value) { }

	public void set_makeHeader(Func value) { }

	public void set_maxWidth(Length value) { }

	public void set_minWidth(Length value) { }

	public void set_name(string value) { }

	public void set_optional(bool value) { }

	public void set_resizable(bool value) { }

	public void set_sortable(bool value) { }

	public void set_stretchable(bool value) { }

	public void set_title(string value) { }

	public void set_visible(bool value) { }

	public void set_width(Length value) { }

}

