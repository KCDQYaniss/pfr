namespace Audio.AmbientSubsystem;

public class AmbientSoundPlayerGroup : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__3_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <get_IsPlaying>b__3_0(BaseAmbientSoundPlayer x) { }

	}

	[SerializeField]
	private AudioMixerGroup _outputMixerGroup; //Field offset: 0x20
	[SerializeField]
	private List _soundPlayers; //Field offset: 0x28

	public bool IsPlaying
	{
		 get { } //Length: 354
	}

	public AmbientSoundPlayerGroup() { }

	private void Awake() { }

	public bool get_IsPlaying() { }

	public void Play() { }

	private void SetMixerGroup() { }

	private void Start() { }

	public void Stop(bool force = true) { }

	public void Tick(float dt) { }

	private void Validate() { }

}

