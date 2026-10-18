namespace Audio.AmbientSubsystem;

public class DayTimeAmbientBlender : MonoBehaviour, ISoundBlender, IDisposable, ISeasonDependent, IDayTimeSoundContainerChangeable
{
	[CompilerGenerated]
	private sealed class <BlendDayNightCoroutine>d__23 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public DayTimeAmbientBlender <>4__this; //Field offset: 0x20

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
		public <BlendDayNightCoroutine>d__23(int <>1__state) { }

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
	private AudioSource _outdoorAmbientDaySource; //Field offset: 0x20
	[SerializeField]
	private AudioSource _outdoorAmbientNightSource; //Field offset: 0x28
	[SerializeField]
	private Vector2 _dayTimeRange; //Field offset: 0x30
	[SerializeField]
	private float _dayToNightBlendDuration; //Field offset: 0x38
	[SerializeField]
	private float _nightToDayBlendDuration; //Field offset: 0x3C
	private SeasonAmbientSoundDataSO _ambientSoundData; //Field offset: 0x40
	private AudioMixer _masterMixer; //Field offset: 0x48
	private EDayTime _prevDayTime; //Field offset: 0x50
	private Coroutine _blendCoroutine; //Field offset: 0x58
	private float _transitionEndHour; //Field offset: 0x60
	private Action _unsubscribeOnDestroy; //Field offset: 0x68

	private float CurrentBlendDuration
	{
		private get { } //Length: 68
	}

	private float CurrentBlendStartHour
	{
		private get { } //Length: 68
	}

	private EDayTime CurrentDayTime
	{
		private get { } //Length: 63
	}

	private float TotalHours
	{
		private get { } //Length: 439
	}

	public DayTimeAmbientBlender() { }

	private void BalanceVolume(float blendValue) { }

	[IteratorStateMachine(typeof(<BlendDayNightCoroutine>d__23))]
	private IEnumerator BlendDayNightCoroutine() { }

	private void BlendSoundBySunHeight() { }

	private float CalculateBalance() { }

	private float CalculateTotalHours() { }

	private void ChangeClip(AudioSource source, AudioClip clip) { }

	public override void ChangeSoundContainer(DayTimeAmbientSoundContainer soundContainer) { }

	public override void Dispose() { }

	private void ForceSetVolume() { }

	private float get_CurrentBlendDuration() { }

	private float get_CurrentBlendStartHour() { }

	private EDayTime get_CurrentDayTime() { }

	private float get_TotalHours() { }

	public override void Init() { }

	private bool IsDay(float value) { }

	public override void ManualUpdate(float dt = 0) { }

	private void OnDestroy() { }

	public override void SetSeasonStatus(ESeasonStatus targetSeasonStatus) { }

	private void StopCoroutineIfNotNull(ref Coroutine coroutine) { }

}

