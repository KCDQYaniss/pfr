namespace EFT;

public abstract class RunddansController : EventObjectController, IDisposable
{
	protected const string FROZEN_BUFF = "Buffs_Frostbite"; //Field offset: 0x0
	public readonly Dictionary Objects; //Field offset: 0x10
	protected readonly FlameDamageTrigger[] Flames; //Field offset: 0x18
	protected readonly RunddansGlobalSettings settings; //Field offset: 0x20
	protected readonly Location location; //Field offset: 0x28
	protected Random Random; //Field offset: 0x30
	protected readonly CancellationTokenSource _cts; //Field offset: 0x38

	public float GetDurability
	{
		 get { } //Length: 97
	}

	public bool GetKnifeCritToBreak
	{
		 get { } //Length: 95
	}

	public float GetSecToBreak
	{
		 get { } //Length: 97
	}

	public float GrenadeDistanceSqr
	{
		 get { } //Length: 32
	}

	public float InteractionDistanceSqr
	{
		 get { } //Length: 32
	}

	protected RunddansController(RunddansGlobalSettings settings, Location location) { }

	[CompilerGenerated]
	private bool <TryGetConsumableItem>b__29_0(Item i) { }

	protected bool CheckBonfires(Player player) { }

	private static void DisableEventObjects() { }

	public override void Dispose() { }

	public static bool Exist(out T runddansController) { }

	public float get_GetDurability() { }

	public bool get_GetKnifeCritToBreak() { }

	public float get_GetSecToBreak() { }

	public float get_GrenadeDistanceSqr() { }

	public float get_InteractionDistanceSqr() { }

	public virtual InteractWithEventObjectPacket GetInteractPacket(int objectId, EInteraction interaction) { }

	protected void HandleEventObjects() { }

	private void InitEventObjects() { }

	public virtual void InteractWithEventObject(Player player, InteractWithEventObjectPacket packet) { }

	public bool IsNonExitLocation() { }

	public bool IsValid(Player player, out T transitController, out Transit info) { }

	protected override void OnTriggerStateChanged(EState state) { }

	protected void SetState(int objectId, EState state) { }

	private void TimerSubscription(bool flag) { }

	public static void ToggleEventEnvironment(bool isOn) { }

	public bool TryGetAirplaneId(out int id) { }

	protected bool TryGetConsumableItem(Player player, out Item item) { }

}

