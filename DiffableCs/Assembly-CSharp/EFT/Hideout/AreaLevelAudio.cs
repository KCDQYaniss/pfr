namespace EFT.Hideout;

[RequireComponent(typeof(AudioArray))]
public sealed class AreaLevelAudio : MonoBehaviour
{
	[CompilerGenerated]
	private struct <LevelChanged>d__18 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public AreaLevelAudio <>4__this; //Field offset: 0x28
		public bool silent; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private RelatedSounds _soundsData; //Field offset: 0x20
	private EAreaStatus _areaStatus; //Field offset: 0x28
	private EAreaStatus _previousAreaStatus; //Field offset: 0x2C
	private ELightStatus _lightStatus; //Field offset: 0x30
	private ELightStatus _previousLightStatus; //Field offset: 0x34
	private AudioSequence _workingAudioSequence; //Field offset: 0x38
	private AudioArray _audioArray; //Field offset: 0x40

	public EAreaStatus AreaStatus
	{
		 get { } //Length: 4
		 set { } //Length: 14
	}

	private AudioArray AudioArray
	{
		private get { } //Length: 396
	}

	public ELightStatus LightStatus
	{
		 get { } //Length: 4
		 set { } //Length: 12
	}

	public AreaLevelAudio() { }

	public EAreaStatus get_AreaStatus() { }

	private AudioArray get_AudioArray() { }

	public ELightStatus get_LightStatus() { }

	public void Init(RelatedSounds soundsData, ELightStatus lightStatus = 0, EAreaStatus areaStatus = 0) { }

	[AsyncStateMachine(typeof(<LevelChanged>d__18))]
	public void LevelChanged(bool silent) { }

	public void Pause() { }

	public void PlayOneShot(AudioClip sound, bool volumetric) { }

	public void PlayOneShot(EAreaActivityType soundType, bool volumetric) { }

	private void ResetStates() { }

	public void Resume() { }

	public void Select() { }

	public void set_AreaStatus(EAreaStatus value) { }

	public void set_LightStatus(ELightStatus value) { }

	private void UpdateStatus(ELightStatus lightStatus, EAreaStatus areaStatus) { }

}

