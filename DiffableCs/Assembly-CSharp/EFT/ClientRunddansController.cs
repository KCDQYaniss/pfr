namespace EFT;

public class ClientRunddansController : RunddansController
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass11_0
	{
		public Player player; //Field offset: 0x10
		public ClientRunddansController <>4__this; //Field offset: 0x18
		public int objectId; //Field offset: 0x20

		public <>c__DisplayClass11_0() { }

		internal void <Repair>b__0(bool successful) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass8_0
	{
		public ClientRunddansController <>4__this; //Field offset: 0x10
		public Player player; //Field offset: 0x18
		public int objectId; //Field offset: 0x20
		public GamePlayerOwner owner; //Field offset: 0x28

		public <>c__DisplayClass8_0() { }

		internal void <GetAvailableInteraction>b__0() { }

		internal void <GetAvailableInteraction>b__1() { }

	}

	private const string FILL_THE_TANK = "Generator/FillTheTank"; //Field offset: 0x0
	private const string REPAIR = "Generator/Repair"; //Field offset: 0x0
	private const string NO_ITEM = "Generator/NoRequiredItem"; //Field offset: 0x0
	private const string IDLE_REQUIRED = "Generator/NeedIdle"; //Field offset: 0x0
	private const string NON_INTERACTIVE = "Generator/NonInteractive"; //Field offset: 0x0
	private const string REPAIRING = "Repairing generator {0:F1}"; //Field offset: 0x0
	private AvailableInteractionState _availableInteractionState; //Field offset: 0x40

	public ClientRunddansController(RunddansGlobalSettings settings, Location location) { }

	private void FillTheTank(Player player, int objectId) { }

	public AvailableInteractionState GetAvailableInteraction(GamePlayerOwner owner, int objectId) { }

	protected float GetRepairTime(Player player, out bool hasMultiTool) { }

	protected void IdleRequiredNotification() { }

	protected void NonInteractiveNotification() { }

	protected void NoRequiredItemNotification() { }

	protected virtual void OnTriggerStateChanged(EState state) { }

	private void Repair(GamePlayerOwner owner, int objectId) { }

	private AvailableInteractionState TryGetCachedInteractionAction(string name, Action action) { }

	protected bool TryRemoveConsumableItem(Item item) { }

}

