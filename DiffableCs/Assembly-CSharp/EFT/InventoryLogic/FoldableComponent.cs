namespace EFT.InventoryLogic;

public sealed class FoldableComponent : ItemComponent
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass9_0
	{
		public IFoldableComponentTemplate template; //Field offset: 0x10

		public <>c__DisplayClass9_0() { }

		internal bool <.ctor>b__0(Slot x) { }

	}

	[CanBeNull]
	public readonly Slot FoldedSlot; //Field offset: 0x18
	[Diffable]
	public bool Folded; //Field offset: 0x20
	public readonly BindableEvent OnChanged; //Field offset: 0x28
	private readonly IFoldableComponentTemplate _template; //Field offset: 0x30

	public bool CanBeFolded
	{
		 get { } //Length: 52
	}

	public int SizeReduceRight
	{
		 get { } //Length: 78
	}

	public FoldableComponent(Item item, IFoldableComponentTemplate template) { }

	public bool get_CanBeFolded() { }

	public int get_SizeReduceRight() { }

	public void SetFolded(bool value) { }

}

