namespace CommonAssets.Scripts.Audio;

public class AudioTapesCollection : ScriptableObject
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass3_0
	{
		public string clipName; //Field offset: 0x10

		public <>c__DisplayClass3_0() { }

		internal bool <GetAudioClip>b__0(AudioClip clip) { }

	}

	private static AudioTapesCollection _instance; //Field offset: 0x0
	[SerializeField]
	private List _clips; //Field offset: 0x18

	public AudioTapesCollection() { }

	public static AudioClip GetAudioClip(string clipName) { }

	public static void Load() { }

}

