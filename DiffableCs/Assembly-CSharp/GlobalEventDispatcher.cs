//Type is in global namespace

public class GlobalEventDispatcher : Singleton
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action <>9__0_2; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal void <.ctor>b__0_2(int i, WorldInteractiveObject o) { }

	}

	internal sealed class ArtilleryDelegate : MulticastDelegate
	{

		public ArtilleryDelegate(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(string zoneId, Vector3 position, float radius, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(string zoneId, Vector3 position, float radius) { }

	}

	internal sealed class ArtilleryTimerDelegate : MulticastDelegate
	{

		public ArtilleryTimerDelegate(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(Vector3 position, float radius, float delay, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(Vector3 position, float radius, float delay) { }

	}

	internal sealed class BeingHitActionDelegate : MulticastDelegate
	{

		public BeingHitActionDelegate(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(DamageInfo damageInfo, Player victim, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(DamageInfo damageInfo, Player victim) { }

	}

	internal sealed class DeactivatTripwireDelegate : MulticastDelegate
	{

		public DeactivatTripwireDelegate(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(TripwireSynchronizableObject throwWear, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(TripwireSynchronizableObject throwWear) { }

	}

	internal sealed class FlareDelegate : MulticastDelegate
	{

		public FlareDelegate(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(IPlayer player, Vector3 position, AmmoTemplate ammoTemplate, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(IPlayer player, Vector3 position, AmmoTemplate ammoTemplate) { }

	}

	internal sealed class GestusDelegate : MulticastDelegate
	{

		public GestusDelegate(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(BotReceiverGestus data, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(BotReceiverGestus data) { }

	}

	internal sealed class GrenadeExplosive : MulticastDelegate
	{

		public GrenadeExplosive(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(Vector3 position, int playerRaidIDWhoThrew, bool isSmoke, float smokeRadius, float smokeLifeTime, int throwableId, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(Vector3 position, int playerRaidIDWhoThrew, bool isSmoke, float smokeRadius, float smokeLifeTime, int throwableId) { }

	}

	internal sealed class GrenadeThrow : MulticastDelegate
	{

		public GrenadeThrow(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(Grenade grenade, Vector3 position, Vector3 force, float mass, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(Grenade grenade, Vector3 position, Vector3 force, float mass) { }

	}

	internal sealed class HardAimDelegate : MulticastDelegate
	{

		public HardAimDelegate(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(IPlayer player, bool status, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(IPlayer player, bool status) { }

	}

	internal sealed class KillDelegate : MulticastDelegate
	{

		public KillDelegate(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(IPlayer killer, IPlayer target, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(IPlayer killer, IPlayer target) { }

	}

	internal sealed class OnLootSpawnDelegate : MulticastDelegate
	{

		public OnLootSpawnDelegate(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(IList lootPositions, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(IList lootPositions) { }

	}

	internal sealed class PhraseDelegate : MulticastDelegate
	{

		public PhraseDelegate(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(PhraseDelegateInfo info, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(PhraseDelegateInfo info) { }

	}

	internal class PhraseDelegateInfo
	{
		public IPlayer PlayerRequester; //Field offset: 0x10
		public EPhraseTrigger phrase; //Field offset: 0x18
		private bool _canUse; //Field offset: 0x1C
		private bool _isCalculated; //Field offset: 0x1D
		public int UsedTimes; //Field offset: 0x20

		public bool CanUse
		{
			 get { } //Length: 5
		}

		public PhraseDelegateInfo() { }

		public bool CalcChanceByLoyalty() { }

		public bool get_CanUse() { }

	}

	internal sealed class PlantTripwireDelegate : MulticastDelegate
	{

		public PlantTripwireDelegate(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(TripwireSynchronizableObject throwWeap, Vector3 position, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(TripwireSynchronizableObject throwWeap, Vector3 position) { }

	}

	internal sealed class PlayerHealingDelegate : MulticastDelegate
	{

		public PlayerHealingDelegate(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(IPlayer player, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(IPlayer player) { }

	}

	internal sealed class PoseChangedDelegate : MulticastDelegate
	{

		public PoseChangedDelegate(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(IPlayer player, int pose, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(IPlayer player, int pose) { }

	}

	internal sealed class QETiltDelegate : MulticastDelegate
	{

		public QETiltDelegate(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(IPlayer player, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(IPlayer player) { }

	}

	internal sealed class RocketExplosive : MulticastDelegate
	{

		public RocketExplosive(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(Vector3 position, int playerRaidIDWhoThrew, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(Vector3 position, int playerRaidIDWhoThrew) { }

	}

	internal sealed class SoundDelegate : MulticastDelegate
	{

		public SoundDelegate(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(IPlayer player, Vector3 position, float power, AISoundType type, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(IPlayer player, Vector3 position, float power, AISoundType type) { }

	}

	internal sealed class TakeItemDelegate : MulticastDelegate
	{

		public TakeItemDelegate(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(LootItem item, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(LootItem item) { }

	}

	internal sealed class ThrowItemDelegate : MulticastDelegate
	{

		public ThrowItemDelegate(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(LootItem item, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(LootItem item) { }

	}

	internal sealed class WorldInteractiveObjectDelegate : MulticastDelegate
	{

		public WorldInteractiveObjectDelegate(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(string doorId, Vector3 position, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(string doorId, Vector3 position) { }

	}

	[CompilerGenerated]
	private SoundDelegate OnSoundPlayed; //Field offset: 0x10
	[CompilerGenerated]
	private KillDelegate OnKill; //Field offset: 0x18
	[CompilerGenerated]
	private HardAimDelegate OnHardAimDelegate; //Field offset: 0x20
	[CompilerGenerated]
	private GrenadeThrow OnGrenadeThrow; //Field offset: 0x28
	[CompilerGenerated]
	private QETiltDelegate OnQETilt; //Field offset: 0x30
	[CompilerGenerated]
	private GrenadeExplosive OnGrenadeExplosive; //Field offset: 0x38
	[CompilerGenerated]
	private RocketExplosive OnRocketExplosive; //Field offset: 0x40
	[CompilerGenerated]
	private Action OnBodyBotDead; //Field offset: 0x48
	[CompilerGenerated]
	private Action OnTrainCome; //Field offset: 0x50
	[CompilerGenerated]
	private PhraseDelegate OnPhraseSay; //Field offset: 0x58
	[CompilerGenerated]
	private FlareDelegate OnFlareDelegate; //Field offset: 0x60
	[CompilerGenerated]
	private PlantTripwireDelegate OnPlantTripwire; //Field offset: 0x68
	[CompilerGenerated]
	private DeactivatTripwireDelegate OnDeactivateTripwire; //Field offset: 0x70
	[CompilerGenerated]
	private BeingHitActionDelegate OnBeingHit; //Field offset: 0x78
	[CompilerGenerated]
	private GestusDelegate OnGestusShow; //Field offset: 0x80
	[CompilerGenerated]
	private WorldInteractiveObjectDelegate OnInteractObject; //Field offset: 0x88
	[CompilerGenerated]
	private ArtilleryDelegate OnArtilleryStart; //Field offset: 0x90
	[CompilerGenerated]
	private ArtilleryDelegate OnArtilleryEnd; //Field offset: 0x98
	[CompilerGenerated]
	private ArtilleryTimerDelegate OnArtilleryStartWithTimer; //Field offset: 0xA0
	[CompilerGenerated]
	private PoseChangedDelegate OnPoseChanged; //Field offset: 0xA8
	[CompilerGenerated]
	private PlayerHealingDelegate OnPlayerHealing; //Field offset: 0xB0
	[CompilerGenerated]
	private OnLootSpawnDelegate OnLootSpawn; //Field offset: 0xB8
	[CompilerGenerated]
	private Action OnTripwireChangeState; //Field offset: 0xC0
	[CompilerGenerated]
	private Action OnPlayerComeToPlace; //Field offset: 0xC8
	[CompilerGenerated]
	private Action OnEvent; //Field offset: 0xD0
	[CompilerGenerated]
	private Action OnExitActivated; //Field offset: 0xD8
	[CompilerGenerated]
	private Action OnDoorInteracted; //Field offset: 0xE0
	[CompilerGenerated]
	private Action OnStopBotSpawn; //Field offset: 0xE8
	[CompilerGenerated]
	private Action OnApplyLighthouseKeeperFriendlyUsecs; //Field offset: 0xF0
	[CompilerGenerated]
	private Action OnApplyLighthouseKeeperFriendlyZryachiy; //Field offset: 0xF8
	[CompilerGenerated]
	private Action OnApplyTraderServiceBtrSupport; //Field offset: 0x100
	[CompilerGenerated]
	private Action OnStopTraderServiceBtrSupport; //Field offset: 0x108
	[CompilerGenerated]
	private Action OnInterruptTraderServiceBtrSupportByBetrayer; //Field offset: 0x110
	[CompilerGenerated]
	private Action OnTerminalTransitAccessGained; //Field offset: 0x118
	[CompilerGenerated]
	private Action OnBotActivated; //Field offset: 0x120

	public event Action OnApplyLighthouseKeeperFriendlyUsecs
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public event Action OnApplyLighthouseKeeperFriendlyZryachiy
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public event Action OnApplyTraderServiceBtrSupport
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public event ArtilleryDelegate OnArtilleryEnd
	{
		[CompilerGenerated]
		 add { } //Length: 251
		[CompilerGenerated]
		 remove { } //Length: 251
	}

	public event ArtilleryDelegate OnArtilleryStart
	{
		[CompilerGenerated]
		 add { } //Length: 251
		[CompilerGenerated]
		 remove { } //Length: 251
	}

	public event ArtilleryTimerDelegate OnArtilleryStartWithTimer
	{
		[CompilerGenerated]
		 add { } //Length: 251
		[CompilerGenerated]
		 remove { } //Length: 251
	}

	public event BeingHitActionDelegate OnBeingHit
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public event Action OnBodyBotDead
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public event Action OnBotActivated
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public event DeactivatTripwireDelegate OnDeactivateTripwire
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public event Action OnDoorInteracted
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public event Action OnEvent
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public event Action OnExitActivated
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public event FlareDelegate OnFlareDelegate
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public event GestusDelegate OnGestusShow
	{
		[CompilerGenerated]
		 add { } //Length: 251
		[CompilerGenerated]
		 remove { } //Length: 251
	}

	public event GrenadeExplosive OnGrenadeExplosive
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public event GrenadeThrow OnGrenadeThrow
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public event HardAimDelegate OnHardAimDelegate
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public event WorldInteractiveObjectDelegate OnInteractObject
	{
		[CompilerGenerated]
		 add { } //Length: 251
		[CompilerGenerated]
		 remove { } //Length: 251
	}

	public event Action OnInterruptTraderServiceBtrSupportByBetrayer
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public event KillDelegate OnKill
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public event OnLootSpawnDelegate OnLootSpawn
	{
		[CompilerGenerated]
		 add { } //Length: 251
		[CompilerGenerated]
		 remove { } //Length: 251
	}

	public event PhraseDelegate OnPhraseSay
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public event PlantTripwireDelegate OnPlantTripwire
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public event Action OnPlayerComeToPlace
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public event PlayerHealingDelegate OnPlayerHealing
	{
		[CompilerGenerated]
		 add { } //Length: 251
		[CompilerGenerated]
		 remove { } //Length: 251
	}

	public event PoseChangedDelegate OnPoseChanged
	{
		[CompilerGenerated]
		 add { } //Length: 251
		[CompilerGenerated]
		 remove { } //Length: 251
	}

	public event QETiltDelegate OnQETilt
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public event RocketExplosive OnRocketExplosive
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public event SoundDelegate OnSoundPlayed
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public event Action OnStopBotSpawn
	{
		[CompilerGenerated]
		 add { } //Length: 251
		[CompilerGenerated]
		 remove { } //Length: 251
	}

	public event Action OnStopTraderServiceBtrSupport
	{
		[CompilerGenerated]
		 add { } //Length: 251
		[CompilerGenerated]
		 remove { } //Length: 251
	}

	public event Action OnTerminalTransitAccessGained
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public event Action OnTrainCome
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public event Action OnTripwireChangeState
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public GlobalEventDispatcher() { }

	[CompilerGenerated]
	private void <.ctor>b__0_0(FirstShellingExplosionZoneEvent eventArgs) { }

	[CompilerGenerated]
	private void <.ctor>b__0_1(LastShellingExplosionZoneEvent eventArgs) { }

	[CompilerGenerated]
	public void add_OnApplyLighthouseKeeperFriendlyUsecs(Action value) { }

	[CompilerGenerated]
	public void add_OnApplyLighthouseKeeperFriendlyZryachiy(Action value) { }

	[CompilerGenerated]
	public void add_OnApplyTraderServiceBtrSupport(Action value) { }

	[CompilerGenerated]
	public void add_OnArtilleryEnd(ArtilleryDelegate value) { }

	[CompilerGenerated]
	public void add_OnArtilleryStart(ArtilleryDelegate value) { }

	[CompilerGenerated]
	public void add_OnArtilleryStartWithTimer(ArtilleryTimerDelegate value) { }

	[CompilerGenerated]
	public void add_OnBeingHit(BeingHitActionDelegate value) { }

	[CompilerGenerated]
	public void add_OnBodyBotDead(Action value) { }

	[CompilerGenerated]
	public void add_OnBotActivated(Action value) { }

	[CompilerGenerated]
	public void add_OnDeactivateTripwire(DeactivatTripwireDelegate value) { }

	[CompilerGenerated]
	public void add_OnDoorInteracted(Action value) { }

	[CompilerGenerated]
	public void add_OnEvent(Action value) { }

	[CompilerGenerated]
	public void add_OnExitActivated(Action value) { }

	[CompilerGenerated]
	public void add_OnFlareDelegate(FlareDelegate value) { }

	[CompilerGenerated]
	public void add_OnGestusShow(GestusDelegate value) { }

	[CompilerGenerated]
	public void add_OnGrenadeExplosive(GrenadeExplosive value) { }

	[CompilerGenerated]
	public void add_OnGrenadeThrow(GrenadeThrow value) { }

	[CompilerGenerated]
	public void add_OnHardAimDelegate(HardAimDelegate value) { }

	[CompilerGenerated]
	public void add_OnInteractObject(WorldInteractiveObjectDelegate value) { }

	[CompilerGenerated]
	public void add_OnInterruptTraderServiceBtrSupportByBetrayer(Action value) { }

	[CompilerGenerated]
	public void add_OnKill(KillDelegate value) { }

	[CompilerGenerated]
	public void add_OnLootSpawn(OnLootSpawnDelegate value) { }

	[CompilerGenerated]
	public void add_OnPhraseSay(PhraseDelegate value) { }

	[CompilerGenerated]
	public void add_OnPlantTripwire(PlantTripwireDelegate value) { }

	[CompilerGenerated]
	public void add_OnPlayerComeToPlace(Action value) { }

	[CompilerGenerated]
	public void add_OnPlayerHealing(PlayerHealingDelegate value) { }

	[CompilerGenerated]
	public void add_OnPoseChanged(PoseChangedDelegate value) { }

	[CompilerGenerated]
	public void add_OnQETilt(QETiltDelegate value) { }

	[CompilerGenerated]
	public void add_OnRocketExplosive(RocketExplosive value) { }

	[CompilerGenerated]
	public void add_OnSoundPlayed(SoundDelegate value) { }

	[CompilerGenerated]
	public void add_OnStopBotSpawn(Action value) { }

	[CompilerGenerated]
	public void add_OnStopTraderServiceBtrSupport(Action value) { }

	[CompilerGenerated]
	public void add_OnTerminalTransitAccessGained(Action value) { }

	[CompilerGenerated]
	public void add_OnTrainCome(Action value) { }

	[CompilerGenerated]
	public void add_OnTripwireChangeState(Action value) { }

	public void AnyEvent(string eventId) { }

	public void ApplyLighthouseKeeperFriendlyUsecs(Player player) { }

	public void ApplyLighthouseKeeperFriendlyZryachiy(Player player) { }

	public void ApplyOnTerminalTransitAccessGained(Player player) { }

	public void ApplyTraderServiceBtrSupport(List players) { }

	public void ArtilleryStart(Vector3 position, float radius, float delay) { }

	public void BeingHitAction(DamageInfo damageInfo, Player victim) { }

	public void BotActivated(BotOwner owner) { }

	public void DeactivateTripwire(TripwireSynchronizableObject throwWeap) { }

	public void DeadBodySound(Vector3 pos) { }

	public void ExitActivated(int eventId) { }

	public void GrenadeExplosion(Vector3 position, int playerRaidIDWhoThrew, bool isSmoke, float smokeRadius, float smokeLifeTime, int throwableId) { }

	public void HardAim(IPlayer player, bool val) { }

	public void InteractObject(string id, Vector3 pos) { }

	public void InterruptTraderServiceBtrSupportByBetrayer(Player player) { }

	public void Kill(IPlayer killer, IPlayer target) { }

	public void PlantTripwire(TripwireSynchronizableObject throwWeap, Vector3 position) { }

	public void PlayerComeToPlace(string zone) { }

	public void PlayerHealing(IPlayer player) { }

	public void PlaySound(IPlayer person, Vector3 position, float power, AISoundType type) { }

	public void PoseChanged(Player player, int poseToInt) { }

	public void QETilt(IPlayer player) { }

	[CompilerGenerated]
	public void remove_OnApplyLighthouseKeeperFriendlyUsecs(Action value) { }

	[CompilerGenerated]
	public void remove_OnApplyLighthouseKeeperFriendlyZryachiy(Action value) { }

	[CompilerGenerated]
	public void remove_OnApplyTraderServiceBtrSupport(Action value) { }

	[CompilerGenerated]
	public void remove_OnArtilleryEnd(ArtilleryDelegate value) { }

	[CompilerGenerated]
	public void remove_OnArtilleryStart(ArtilleryDelegate value) { }

	[CompilerGenerated]
	public void remove_OnArtilleryStartWithTimer(ArtilleryTimerDelegate value) { }

	[CompilerGenerated]
	public void remove_OnBeingHit(BeingHitActionDelegate value) { }

	[CompilerGenerated]
	public void remove_OnBodyBotDead(Action value) { }

	[CompilerGenerated]
	public void remove_OnBotActivated(Action value) { }

	[CompilerGenerated]
	public void remove_OnDeactivateTripwire(DeactivatTripwireDelegate value) { }

	[CompilerGenerated]
	public void remove_OnDoorInteracted(Action value) { }

	[CompilerGenerated]
	public void remove_OnEvent(Action value) { }

	[CompilerGenerated]
	public void remove_OnExitActivated(Action value) { }

	[CompilerGenerated]
	public void remove_OnFlareDelegate(FlareDelegate value) { }

	[CompilerGenerated]
	public void remove_OnGestusShow(GestusDelegate value) { }

	[CompilerGenerated]
	public void remove_OnGrenadeExplosive(GrenadeExplosive value) { }

	[CompilerGenerated]
	public void remove_OnGrenadeThrow(GrenadeThrow value) { }

	[CompilerGenerated]
	public void remove_OnHardAimDelegate(HardAimDelegate value) { }

	[CompilerGenerated]
	public void remove_OnInteractObject(WorldInteractiveObjectDelegate value) { }

	[CompilerGenerated]
	public void remove_OnInterruptTraderServiceBtrSupportByBetrayer(Action value) { }

	[CompilerGenerated]
	public void remove_OnKill(KillDelegate value) { }

	[CompilerGenerated]
	public void remove_OnLootSpawn(OnLootSpawnDelegate value) { }

	[CompilerGenerated]
	public void remove_OnPhraseSay(PhraseDelegate value) { }

	[CompilerGenerated]
	public void remove_OnPlantTripwire(PlantTripwireDelegate value) { }

	[CompilerGenerated]
	public void remove_OnPlayerComeToPlace(Action value) { }

	[CompilerGenerated]
	public void remove_OnPlayerHealing(PlayerHealingDelegate value) { }

	[CompilerGenerated]
	public void remove_OnPoseChanged(PoseChangedDelegate value) { }

	[CompilerGenerated]
	public void remove_OnQETilt(QETiltDelegate value) { }

	[CompilerGenerated]
	public void remove_OnRocketExplosive(RocketExplosive value) { }

	[CompilerGenerated]
	public void remove_OnSoundPlayed(SoundDelegate value) { }

	[CompilerGenerated]
	public void remove_OnStopBotSpawn(Action value) { }

	[CompilerGenerated]
	public void remove_OnStopTraderServiceBtrSupport(Action value) { }

	[CompilerGenerated]
	public void remove_OnTerminalTransitAccessGained(Action value) { }

	[CompilerGenerated]
	public void remove_OnTrainCome(Action value) { }

	[CompilerGenerated]
	public void remove_OnTripwireChangeState(Action value) { }

	public void RocketExplosion(Vector3 position, int playerRaidIDWhoThrew) { }

	public void SayPhrase(IPlayer player, EPhraseTrigger event) { }

	public void ShowGesture(Player player, EInteraction gesture) { }

	public void SpawnLoot(List spawnedLootPositions) { }

	public void Stop() { }

	public void StopBotSpawn() { }

	public void StopTraderServiceBtrSupport() { }

	public void SuccessFlare(Player player, Vector3 position, AmmoTemplate ammoTemplate) { }

	public void ThrowGrenade(Grenade grenade, Vector3 position, Vector3 force, float mass) { }

	public void TrainCome(ETravelState val) { }

	public void TripwireChangeState(TripwireSynchronizableObject tripwireSynchronizableObject) { }

}

