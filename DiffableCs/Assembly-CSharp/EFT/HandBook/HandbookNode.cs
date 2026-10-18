namespace EFT.HandBook;

public sealed class HandbookNode : IHandbookNode, IEnumerable, IEnumerable, ICloneable
{
	[CompilerGenerated]
	private Action OnCountUpdated; //Field offset: 0x10
	[CompilerGenerated]
	private Action OnNewStatusUpdated; //Field offset: 0x18
	[CompilerGenerated]
	private Action OnHasNewCompletableUpdated; //Field offset: 0x20
	[CompilerGenerated]
	private HandbookNode <Parent>k__BackingField; //Field offset: 0x28
	public bool IsDummy; //Field offset: 0x30
	public int OriginalDepth; //Field offset: 0x34
	public Dictionary OriginalChildrenDict; //Field offset: 0x38
	public int Depth; //Field offset: 0x40
	public Dictionary ChildrenDict; //Field offset: 0x48
	public int Count; //Field offset: 0x50
	public HandbookData Data; //Field offset: 0x58
	public string[] Category; //Field offset: 0x60
	private Color32 _defaultTextColor; //Field offset: 0x68
	private bool _isNew; //Field offset: 0x6C
	private bool _newCompletable; //Field offset: 0x6D

	public event Action OnCountUpdated
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public event Action OnHasNewCompletableUpdated
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public event Action OnNewStatusUpdated
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public Color BackgroundColor
	{
		 get { } //Length: 75
	}

	public override ValueCollection Children
	{
		 get { } //Length: 73
	}

	public override string Id
	{
		 get { } //Length: 27
	}

	public bool New
	{
		 get { } //Length: 5
		 set { } //Length: 28
	}

	public bool NewCompletable
	{
		 get { } //Length: 5
		 set { } //Length: 28
	}

	public ValueCollection OriginalChildren
	{
		 get { } //Length: 73
	}

	public override HandbookNode Parent
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public Color32 TextColor
	{
		 get { } //Length: 1348
	}

	public HandbookNode TopParent
	{
		 get { } //Length: 153
	}

	public HandbookNode() { }

	[CompilerGenerated]
	public void add_OnCountUpdated(Action value) { }

	[CompilerGenerated]
	public void add_OnHasNewCompletableUpdated(Action value) { }

	[CompilerGenerated]
	public void add_OnNewStatusUpdated(Action value) { }

	public void AddNodeInitial(HandbookNode node) { }

	public void CacheParentsAndDepth(bool setChildCount = true) { }

	public bool CanShowNodeView(EViewListType viewListType) { }

	public void ChangeChildrenCount(int count, bool call = true) { }

	public override object Clone() { }

	public void CountUpdatedCall() { }

	public HandbookNode CreateDummy(bool keepChildren = false) { }

	public bool EmbeddedNodeContains(string id) { }

	public Color get_BackgroundColor() { }

	public override ValueCollection get_Children() { }

	public override string get_Id() { }

	public bool get_New() { }

	public bool get_NewCompletable() { }

	public ValueCollection get_OriginalChildren() { }

	[CompilerGenerated]
	public override HandbookNode get_Parent() { }

	public Color32 get_TextColor() { }

	public HandbookNode get_TopParent() { }

	public override IEnumerator GetEnumerator() { }

	private string GetIcon() { }

	private string GetOtherIcon() { }

	public void InsertChildren(HandbookNode node, bool force = false) { }

	private string LowerIcon() { }

	public bool RecursiveCheck(Func predicate) { }

	[CompilerGenerated]
	public void remove_OnCountUpdated(Action value) { }

	[CompilerGenerated]
	public void remove_OnHasNewCompletableUpdated(Action value) { }

	[CompilerGenerated]
	public void remove_OnNewStatusUpdated(Action value) { }

	public bool RemoveChildren(HandbookNode node) { }

	public void ReplaceChildren(HandbookNode node) { }

	public void set_New(bool value) { }

	public void set_NewCompletable(bool value) { }

	[CompilerGenerated]
	public void set_Parent(HandbookNode value) { }

	public void SetChildrenCount(int count) { }

	public void SetNewCompletableStatusRecursively() { }

	public void SetViewedStatus() { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	public virtual string ToString() { }

	public override bool TryGetChildById(string id, out HandbookNode child) { }

	public void UpdateViewedStatusRecursively() { }

}

