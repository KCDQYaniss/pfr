namespace UnityEngine.UIElements;

public struct CreationContext : IEquatable
{
	public static readonly CreationContext Default; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private VisualElement <target>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private VisualTreeAsset <visualTreeAsset>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Dictionary <slotInsertionPoints>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private List <attributeOverrides>k__BackingField; //Field offset: 0x18

	internal List attributeOverrides
	{
		[CompilerGenerated]
		[IsReadOnly]
		internal get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private Dictionary slotInsertionPoints
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private VisualElement target
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private VisualTreeAsset visualTreeAsset
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	private static CreationContext() { }

	internal CreationContext(Dictionary slotInsertionPoints, VisualTreeAsset vta, VisualElement target) { }

	internal CreationContext(Dictionary slotInsertionPoints, List attributeOverrides, VisualTreeAsset vta, VisualElement target) { }

	public virtual bool Equals(object obj) { }

	public override bool Equals(CreationContext other) { }

	[CompilerGenerated]
	[IsReadOnly]
	internal List get_attributeOverrides() { }

	[CompilerGenerated]
	[IsReadOnly]
	public Dictionary get_slotInsertionPoints() { }

	[CompilerGenerated]
	[IsReadOnly]
	public VisualElement get_target() { }

	[CompilerGenerated]
	[IsReadOnly]
	public VisualTreeAsset get_visualTreeAsset() { }

	public virtual int GetHashCode() { }

	[CompilerGenerated]
	private void set_attributeOverrides(List value) { }

	[CompilerGenerated]
	private void set_slotInsertionPoints(Dictionary value) { }

	[CompilerGenerated]
	private void set_target(VisualElement value) { }

	[CompilerGenerated]
	private void set_visualTreeAsset(VisualTreeAsset value) { }

}

