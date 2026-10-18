namespace Audio.Data;

public class AudioLibrary : ScriptableObject
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__7_0; //Field offset: 0x8
		public static Func <>9__7_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal string <TryGetClip>b__7_0(AudioConfig x) { }

		internal AudioConfig <TryGetClip>b__7_1(AudioConfig x) { }

	}

	internal class AudioConfig
	{
		public string key; //Field offset: 0x10
		public AudioClip clip; //Field offset: 0x18
		public float volume; //Field offset: 0x20

		public AudioConfig() { }

		public void LoadAudioData() { }

		public void UnloadAudioData() { }

	}

	[SerializeField]
	private AudioConfig[] _data; //Field offset: 0x18
	[SerializeField]
	private bool _preloadAudioData; //Field offset: 0x20
	private Dictionary _clipsByKey; //Field offset: 0x28
	private int _loadRefs; //Field offset: 0x30

	public AudioLibrary() { }

	public void LoadAudioData() { }

	private void OnDestroy() { }

	private void OnEnable() { }

	public bool TryGetClip(string key, out AudioConfig config) { }

	public void UnloadAudioData() { }

}

