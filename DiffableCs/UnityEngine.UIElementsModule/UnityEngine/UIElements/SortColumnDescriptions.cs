namespace UnityEngine.UIElements;

[DefaultMember("Item")]
public class SortColumnDescriptions : ICollection, IEnumerable, IEnumerable
{
	public class UxmlObjectFactory`1 : UxmlObjectFactory
	{

		public UxmlObjectFactory`1() { }

	}

	public class UxmlObjectTraits`1 : UxmlObjectTraits
	{
		private readonly UxmlObjectListAttributeDescription m_SortColumnDescriptions; //Field offset: 0x0

		public UxmlObjectTraits`1() { }

		public virtual void Init(ref T obj, IUxmlAttributes bag, CreationContext cc) { }

	}

	[SerializeField]
	private readonly IList m_Descriptions; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action changed; //Field offset: 0x18

	internal event Action changed
	{
		[CompilerGenerated]
		internal add { } //Length: 235
		[CompilerGenerated]
		internal remove { } //Length: 235
	}

	public override int Count
	{
		 get { } //Length: 75
	}

	public override bool IsReadOnly
	{
		 get { } //Length: 78
	}

	public SortColumnDescriptions() { }

	public override void Add(SortColumnDescription item) { }

	[CompilerGenerated]
	internal void add_changed(Action value) { }

	public override void Clear() { }

	public override bool Contains(SortColumnDescription item) { }

	public override void CopyTo(SortColumnDescription[] array, int arrayIndex) { }

	public override int get_Count() { }

	public override bool get_IsReadOnly() { }

	public override IEnumerator GetEnumerator() { }

	public void Insert(int index, SortColumnDescription desc) { }

	private void OnDescriptionChanged(SortColumnDescription desc) { }

	public override bool Remove(SortColumnDescription desc) { }

	[CompilerGenerated]
	internal void remove_changed(Action value) { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

