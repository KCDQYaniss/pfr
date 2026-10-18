namespace EFT.Interactive;

public class PlayersWithImmuneToSniperFireFlareCollector : PlayersWithImmuneToSniperFire
{
	[CompilerGenerated]
	private sealed class <CooldownBetweenResponseFlare>d__19 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public PlayersWithImmuneToSniperFireFlareCollector <>4__this; //Field offset: 0x20

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <CooldownBetweenResponseFlare>d__19(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[SerializeField]
	private FlareEventType flareTypeForImmune; //Field offset: 0x28
	[SerializeField]
	private SceneFlareLauncher _sceneFlareLauncher; //Field offset: 0x30
	private readonly float SECONDS_BETWEEN_RESPONSE_FLARES; //Field offset: 0x38
	private FireFlareForExitNotification _flareExitNotif; //Field offset: 0x40
	private SniperFlareZoneDisabledNotification _flareExitSucceedNotification; //Field offset: 0x48
	private FireFlareForExitNotification _currentNotification; //Field offset: 0x50
	private bool _flareToNotifSucceedShot; //Field offset: 0x58
	private Player _trackedPlayer; //Field offset: 0x60
	private Coroutine _cooldownBetweenResponseFlareCoroutine; //Field offset: 0x68
	private WaitForSeconds _cooldownBetweenResponseFlareWait; //Field offset: 0x70
	private Action _unsubscribeOnDestroy; //Field offset: 0x78
	private bool _isShowingNotification; //Field offset: 0x80

	public PlayersWithImmuneToSniperFireFlareCollector() { }

	[CompilerGenerated]
	private void <Awake>b__12_0(FlareShootZoneEvent callback) { }

	private void Awake() { }

	[IteratorStateMachine(typeof(<CooldownBetweenResponseFlare>d__19))]
	private IEnumerator CooldownBetweenResponseFlare() { }

	private void OnDestroy() { }

	private void OnFlareShootZoneEvent(FlareShootZoneEvent invokedEvent) { }

	private void OnPlayerDead(Player player, IPlayer lastAggressor, DamageInfo damageInfo, EBodyPart part) { }

	private void PlayerAddedInShotList(FlareShootZoneEvent invokedEvent) { }

	private void ProcessPlayerEnteredZone(FlareShootZoneEvent invokedEvent) { }

	private void ProcessPlayerExitedZone(FlareShootZoneEvent invokedEvent) { }

	public void ProcessReconnectedPlayer(FlareShootZoneEvent invokedEvent) { }

	private void SubscribePlayerDeath(Player player) { }

	private void UnsubscribePlayerDeath() { }

}

