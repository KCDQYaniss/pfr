namespace Cutscene;

public class LipSyncPlayer : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <Play_Coroutine>d__54 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public LipSyncPlayer <>4__this; //Field offset: 0x20
		public float startTime; //Field offset: 0x28
		private float <duration>5__2; //Field offset: 0x2C
		private double <audioTime>5__3; //Field offset: 0x30

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
		public <Play_Coroutine>d__54(int <>1__state) { }

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

	[CompilerGenerated]
	private static Action TestOnStartPlay; //Field offset: 0x0
	private SkinnedMeshRenderer skinnedMeshRenderer; //Field offset: 0x20
	private BakedData bakedData; //Field offset: 0x28
	private CurveData[] curves; //Field offset: 0x30
	private List blendShapes; //Field offset: 0x38
	[SerializeField]
	private float minVolume; //Field offset: 0x40
	[SerializeField]
	private float maxVolume; //Field offset: 0x44
	[SerializeField]
	private float smoothness; //Field offset: 0x48
	[SerializeField]
	private float timeOffset; //Field offset: 0x4C
	[SerializeField]
	private float playVolume; //Field offset: 0x50
	private AudioClip clip; //Field offset: 0x58
	private AudioSource audioSource; //Field offset: 0x60
	private Animator animator; //Field offset: 0x68
	private bool isAllowPlaySound; //Field offset: 0x70
	private float volume; //Field offset: 0x74
	private float openCloseVelocity; //Field offset: 0x78
	private bool isSettingsCorrect; //Field offset: 0x7C
	private float prevNormalizedTime; //Field offset: 0x80
	private float precessDeltaTime; //Field offset: 0x84
	private float currentPlayTime; //Field offset: 0x88
	private Dictionary paramsHashed; //Field offset: 0x90
	private Action currentPlayStartCallback; //Field offset: 0x98
	private Action currentPlayingCallback; //Field offset: 0xA0
	private Coroutine playingCoroutine; //Field offset: 0xA8
	private LipSyncInfo lastInfo; //Field offset: 0xB0
	[CompilerGenerated]
	private Action OnStartPlay; //Field offset: 0xC8
	[CompilerGenerated]
	private Action OnStopPlay; //Field offset: 0xD0
	[CompilerGenerated]
	private bool <IsPlaying>k__BackingField; //Field offset: 0xD8

	public event Action OnStartPlay
	{
		[CompilerGenerated]
		 add { } //Length: 251
		[CompilerGenerated]
		 remove { } //Length: 251
	}

	public event Action OnStopPlay
	{
		[CompilerGenerated]
		 add { } //Length: 251
		[CompilerGenerated]
		 remove { } //Length: 251
	}

	public static event Action TestOnStartPlay
	{
		[CompilerGenerated]
		 add { } //Length: 293
		[CompilerGenerated]
		 remove { } //Length: 293
	}

	public bool IsAllowPlaySound
	{
		 get { } //Length: 5
		 set { } //Length: 116
	}

	public private bool IsPlaying
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public LipSyncPlayer() { }

	[CompilerGenerated]
	public void add_OnStartPlay(Action value) { }

	[CompilerGenerated]
	public void add_OnStopPlay(Action value) { }

	[CompilerGenerated]
	public static void add_TestOnStartPlay(Action value) { }

	public void ApplyBakeFrame(LipSyncInfo info) { }

	private void ApplyCurves(float normalizedTime) { }

	public void ApplySettings(GameObject source, GameObject target) { }

	private void AutoPlay(AnimationTrack data, Action onStart, Action onFinish) { }

	public void ContinueDetachedPlay() { }

	public bool get_IsAllowPlaySound() { }

	[CompilerGenerated]
	public bool get_IsPlaying() { }

	private int GetHashedAnimatorParam(string param) { }

	public static LipSyncPlayer GetPlayer(GameObject target) { }

	private void LateUpdate() { }

	private void OnApplyBlendShapes() { }

	public static void Play(AnimationTrack data, GameObject target, Action onStart, Action onFinish) { }

	[IteratorStateMachine(typeof(<Play_Coroutine>d__54))]
	private IEnumerator Play_Coroutine(float startTime) { }

	private void PlayAudioSource() { }

	[CompilerGenerated]
	public void remove_OnStartPlay(Action value) { }

	[CompilerGenerated]
	public void remove_OnStopPlay(Action value) { }

	[CompilerGenerated]
	public static void remove_TestOnStartPlay(Action value) { }

	private void ResetBlendShapes() { }

	private void ResetCurves() { }

	public void set_IsAllowPlaySound(bool value) { }

	[CompilerGenerated]
	private void set_IsPlaying(bool value) { }

	private float SmoothDamp(float value, float target, ref float velocity) { }

	public void StartPlay(BakedData bakedData) { }

	private void StopAudioSource() { }

	public bool StopPlay() { }

	public void UpdatePlay(float normalizedTime) { }

	private void UpdateVolume() { }

	private void UpdateVowels() { }

}

