namespace Audio.AmbientSubsystem;

public class EnvironmentSoundBlendSystem : MonoBehaviour, ISoundBlender, IDisposable
{
	[CompilerGenerated]
	private sealed class <InOutBlendCoroutine>d__40 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public EnvironmentSoundBlendSystem <>4__this; //Field offset: 0x20
		public CancellationToken cancellationToken; //Field offset: 0x28
		private bool <isEnteredNow>5__2; //Field offset: 0x30
		private PortalCalculatedData <optimalData>5__3; //Field offset: 0x34

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
		public <InOutBlendCoroutine>d__40(int <>1__state) { }

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

	private const int INVALID_PORTAL_ID = 0; //Field offset: 0x0
	private const float MAX_MIXER_PARAM_VALUE = 1; //Field offset: 0x0
	private const float MIN_MIXER_PARAM_VALUE = 0; //Field offset: 0x0
	private const float MAX_LOWPASS_FREQ = 22000; //Field offset: 0x0
	[SerializeField]
	private AmbientSoundBlender[] _ambientSoundBlenders; //Field offset: 0x20
	[Range(0, 2)]
	[SerializeField]
	private float _listenerHeightWeight; //Field offset: 0x28
	[SerializeField]
	private float _depthCalculationMult; //Field offset: 0x2C
	[Range(0, 2)]
	[SerializeField]
	private float _connectedRoomPenalty; //Field offset: 0x30
	[Range(0, 1)]
	[SerializeField]
	private float _neighborRoomPenalty; //Field offset: 0x34
	[SerializeField]
	private bool _ignoreDistanceRatio; //Field offset: 0x38
	private readonly EnvironmentBlenderJobScheduler _jobScheduler; //Field offset: 0x40
	private Coroutine _blendCoroutine; //Field offset: 0x48
	private Transform _listenerTransform; //Field offset: 0x50
	private Vector3 _prevListenerPos; //Field offset: 0x58
	private Action _unsubscribeOnDestroy; //Field offset: 0x68
	private EAudioRoomTypeMask _currentRoomType; //Field offset: 0x70
	private float _prevOutdoorFilterValue; //Field offset: 0x74
	private int _currentOutdoorRoomID; //Field offset: 0x78
	private int _currentIndoorRoomID; //Field offset: 0x7C
	private int _prevOutdoorRoomID; //Field offset: 0x80
	private PortalData[] _currentOutPortalsData; //Field offset: 0x88
	private short[] _currentIndoorRoomsIDs; //Field offset: 0x90
	private short[] _currentNeighborRoomIDs; //Field offset: 0x98
	private readonly List _neighborBuffer; //Field offset: 0xA0
	private bool _isDataUpdated; //Field offset: 0xA8
	private CancellationTokenSource _cancellationTokenSource; //Field offset: 0xB0
	private float _targetValue; //Field offset: 0xB8
	private float _targetOutdoorLowpassFreq; //Field offset: 0xBC
	private bool _disposed; //Field offset: 0xC0

	public EnvironmentSoundBlendSystem() { }

	private void CalculateAndApplyMixerParameters(in PortalCalculatedData optimalPortalData, float maxOutdoorVolume, float maxOutdoorFreq, float dt) { }

	public override void Dispose() { }

	public override void Init() { }

	[IteratorStateMachine(typeof(<InOutBlendCoroutine>d__40))]
	private IEnumerator InOutBlendCoroutine(CancellationToken cancellationToken) { }

	private bool IsListenerPositionIdentical() { }

	private static bool IsNeighborListUnchanged(List buffer, short[] current) { }

	public override void ManualUpdate(float dt = 0) { }

	private void OnDestroy() { }

	private void OnPlayerRoomChanged(MyPlayerRoomChangedEvent roomChangedEvent) { }

	private void OnPlayerRoomChanged(ISpatialAudioRoom room, EAudioRoomTypeMask roomType, int outdoorRoomID) { }

	private void OnPlayerRoomChangedToIndoor(ISpatialAudioRoom newRoom) { }

	private void OnPlayerRoomChangedToOutdoor() { }

	private void OnPortalStateChanged(AudioPortalStateChangedEvent stateEvent) { }

	private void SetIndoorMixerParams(float value, float targetBlendDuration = 0.5, bool force = true) { }

	private void SetInitialRoom() { }

	private void SetInitialVolume() { }

	private void SetOutdoorMixerParams(float value, float maxOutdoorVolume, float lowpassFreq, float targetBlendDuration = 0.5, bool force = true) { }

	private void SetOutPortalsData() { }

	private void StopCoroutineIfNotNull(ref Coroutine coroutine) { }

	private bool UpdateNeighborRoomData(int roomID) { }

	private void UpdatePortalsData(int portalID) { }

}

