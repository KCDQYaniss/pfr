namespace EFT.Interactive;

public class InventoryRequirements : ExfiltrationRequirement
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass3_0
	{
		public InventoryRequirements <>4__this; //Field offset: 0x10
		public ExfiltrationPoint point; //Field offset: 0x18
		public Player player; //Field offset: 0x20
		public Action addHandler; //Field offset: 0x28
		public Action removeHandler; //Field offset: 0x30

		public <>c__DisplayClass3_0() { }

		internal void <Enter>b__0(AddItemEventArgs args) { }

		internal void <Enter>b__1(RemoveItemEventArgs args) { }

		internal void <Enter>b__2() { }

	}

	private readonly Dictionary _presenceUnsubcribes; //Field offset: 0x30

	public InventoryRequirements() { }

	public bool AddOperationAffectRequirement(AddItemEventArgs args) { }

	public virtual void Enter(Player player, ExfiltrationPoint point) { }

	public virtual void Exit(Player player, ExfiltrationPoint point) { }

	public virtual void OnDestroy() { }

	public bool RemoveOperationAffectRequirement(RemoveItemEventArgs args) { }

}

