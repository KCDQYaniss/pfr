namespace EFT;

public sealed class NetworkTransitController : ClientTransitController
{
	private sealed class PendingTransitInit
	{
		public int PlayerRaidId; //Field offset: 0x10
		public Dictionary Points; //Field offset: 0x18
		public Dictionary CompletedQuestMetByPointId; //Field offset: 0x20
		public ushort TransitionCount; //Field offset: 0x28
		public bool EventPlayer; //Field offset: 0x2A

		public PendingTransitInit() { }

		public static PendingTransitInit Copy(TransitInitEvent data) { }

	}

	private readonly Dictionary _completedQuestRequirementMetByPointId; //Field offset: 0xB8
	private PendingTransitInit _pendingInit; //Field offset: 0xC0
	private readonly Action _eventInitUnsubscribe; //Field offset: 0xC8
	private readonly Action _eventUpdateUnsubscribe; //Field offset: 0xD0
	private readonly Action _eventInteractUnsubscribe; //Field offset: 0xD8
	private readonly Action _eventTimersUnsubscribe; //Field offset: 0xE0
	private readonly Action _eventSizeUnsubscribe; //Field offset: 0xE8
	private readonly Action _eventMessagesUnsubscribe; //Field offset: 0xF0
	private byte _localTransitGroupSize; //Field offset: 0xF8

	public NetworkTransitController(TransitGlobalSettings settings, TransitParameters[] parameters) { }

	private void ApplyInit(Player player, Dictionary points, Dictionary completedQuestMetByPointId, ushort transitionCount, bool eventPlayer) { }

	public void ApplyPendingInit() { }

	private void CacheTransitionStatus(int pointId) { }

	private void DisablePointsTrigger() { }

	public virtual void Dispose() { }

	private List GetTransitPoints(Dictionary activePoints, EPlayerSide side) { }

	protected virtual bool HasMetCompletedQuestRequirement(TransitPoint transitPoint, Player player) { }

	private void Init(TransitInitEvent data) { }

	private void Interact(TransitInteractionEvent data) { }

	private static bool IsLocalTransit(int playerRaidId) { }

	private static bool IsTargetPlayer(int playerId, out Player player) { }

	private void ManageAntiLeaveFlag(TransitInteractionEvent data) { }

	private void Message(TransitMessagesEvent data) { }

	private void SetTransitHopPlayersCount(TarkovApplication app) { }

	private void Size(TransitGroupSizeEvent data) { }

	public virtual void Sizes(int pointId, Dictionary sizes) { }

	private void Timer(TransitGroupTimerEvent data) { }

	public virtual void Timers(int pointId, Dictionary timers) { }

	private void Update(TransitUpdateEvent data) { }

}

