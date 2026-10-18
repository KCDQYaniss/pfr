//Type is in global namespace

public class ChristmasTreePoI : AIPlaceInfoLogic
{
	[CompilerGenerated]
	private sealed class <BotsInKhorovod>d__67 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private BotOwner <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		public ChristmasTreePoI <>4__this; //Field offset: 0x28
		private bool nearOnly; //Field offset: 0x30
		public bool <>3__nearOnly; //Field offset: 0x31
		private Enumerator <>7__wrap1; //Field offset: 0x38

		private override BotOwner System.Collections.Generic.IEnumerator<EFT.BotOwner>.Current
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
		public <BotsInKhorovod>d__67(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.Generic.IEnumerable<EFT.BotOwner>.GetEnumerator() { }

		[DebuggerHidden]
		private override BotOwner System.Collections.Generic.IEnumerator<EFT.BotOwner>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	private const float GRENADE_CHECK_PERIOD = 3; //Field offset: 0x0
	private const int KHOROVOD_BOTS_LIMIT = 6; //Field offset: 0x0
	[SerializeField]
	private List points; //Field offset: 0x20
	[SerializeField]
	private List _khorovodStates; //Field offset: 0x28
	[CompilerGenerated]
	private int <ConnectionGroupId>k__BackingField; //Field offset: 0x30
	private int _currentStateIndex; //Field offset: 0x34
	private float _time; //Field offset: 0x38
	private float _timeFromStartKhorovodState; //Field offset: 0x3C
	private float _nextGrenadeCheck; //Field offset: 0x40
	private List _allPhrases; //Field offset: 0x48
	[Range(0, 1)]
	[SerializeField]
	private float _lookDirectionDelta; //Field offset: 0x50
	[SerializeField]
	private float _phrasesRecalcPeriod; //Field offset: 0x54
	private int _shootingIndex; //Field offset: 0x58
	private float _prevPhraseRecalcTime; //Field offset: 0x5C
	private float _prevShootingSwitchIndexTime; //Field offset: 0x60
	public float shootingTime; //Field offset: 0x64
	[Range(1, 3)]
	public int shootersLimit; //Field offset: 0x68
	public int skipRateMin; //Field offset: 0x6C
	public int skipRateMax; //Field offset: 0x70
	public int skips; //Field offset: 0x74
	public int skipRateRolled; //Field offset: 0x78

	private float BotsVelocity
	{
		private get { } //Length: 31
	}

	public private int ConnectionGroupId
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	private KhorovodState CurrentKhorovodState
	{
		private get { } //Length: 127
	}

	public bool ForcedAutomaticFireMode
	{
		 get { } //Length: 30
	}

	public EInteraction Gesture
	{
		 get { } //Length: 159
	}

	public bool HaveGesture
	{
		 get { } //Length: 30
	}

	public float LookDirectionDelta
	{
		 get { } //Length: 6
	}

	private float LookHeight
	{
		private get { } //Length: 31
	}

	public EPhraseTrigger Phrase
	{
		 get { } //Length: 246
	}

	private float Radius
	{
		private get { } //Length: 31
	}

	public bool RandomGesture
	{
		 get { } //Length: 30
	}

	public bool RandomPhrase
	{
		 get { } //Length: 30
	}

	private float RotationVelocity
	{
		private get { } //Length: 31
	}

	public ChristmasTreePoI() { }

	[IteratorStateMachine(typeof(<BotsInKhorovod>d__67))]
	public IEnumerable BotsInKhorovod(bool nearOnly = true) { }

	private void CheckForDeadBots() { }

	private void CheckGrenades() { }

	private void CheckRollSkips() { }

	private void FixedUpdate() { }

	private float get_BotsVelocity() { }

	[CompilerGenerated]
	public int get_ConnectionGroupId() { }

	private KhorovodState get_CurrentKhorovodState() { }

	public bool get_ForcedAutomaticFireMode() { }

	public EInteraction get_Gesture() { }

	public bool get_HaveGesture() { }

	public float get_LookDirectionDelta() { }

	private float get_LookHeight() { }

	public EPhraseTrigger get_Phrase() { }

	private float get_Radius() { }

	public bool get_RandomGesture() { }

	public bool get_RandomPhrase() { }

	private float get_RotationVelocity() { }

	public Vector3 GetLookPoint() { }

	public float GetMoveVelocity() { }

	public Vector3 GetPoint(BotOwner owner) { }

	public bool HavePhrase(BotOwner owner) { }

	public virtual void Init(AIPlaceInfo aiPlaceInfo, BotsController botsController) { }

	public Vector3 InitialPosition() { }

	private bool IsKhorovodInFight() { }

	public bool IsNear(IPlayer player) { }

	private void OnDestroy() { }

	private void OnDrawGizmosSelected() { }

	private int OwnerIndex(BotOwner owner) { }

	public bool ProcessKhorovodPlace(BotOwner owner) { }

	private void RecalcPhrases() { }

	public void ResetEnemiesIgnoreState(IPlayer player, IPlayer target) { }

	public void ResetEnemiesIgnoreState(IPlayer player) { }

	[CompilerGenerated]
	private void set_ConnectionGroupId(int value) { }

	public bool Shooting(BotOwner owner) { }

	private void UpdateAngles() { }

}

