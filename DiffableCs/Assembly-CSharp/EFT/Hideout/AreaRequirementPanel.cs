namespace EFT.Hideout;

public sealed class AreaRequirementPanel : AreaPanel, IRequirementPanel, IUIView, IDisposable
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action <>9__4_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal void <Show>b__4_0(AreaPanel arg) { }

	}

	[SerializeField]
	private Color _fulfilledColor; //Field offset: 0x100
	[SerializeField]
	private Color _failedColor; //Field offset: 0x110
	[SerializeField]
	private RequirementFulfilledStatus _fulfilledStatus; //Field offset: 0x120
	private AreaRequirement _requirement; //Field offset: 0x128

	public AreaRequirementPanel() { }

	[CompilerGenerated]
	private void <Show>b__4_1() { }

	public virtual void Close() { }

	protected virtual void SetInfo() { }

	public override void Show(ItemUiContext itemUiContext, InventoryController inventoryController, Requirement requirement, EAreaType areaType, bool ignoreFulfillment) { }

}

