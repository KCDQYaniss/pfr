//Type is in global namespace

[CreateAssetMenu(fileName = "BetterAudioSettings", menuName = "Audio/BetterAudio")]
public class BetterAudioSettings : ScriptableObject
{
	internal class PoolSettings
	{
		public int MaxDeactivationsPerFrame; //Field offset: 0x10
		public int MaxDeactivationsPerGroupPerFrame; //Field offset: 0x14
		public int MaxStopsPerFrame; //Field offset: 0x18
		public float StopFadeSeconds; //Field offset: 0x1C

		public PoolSettings() { }

	}

	private static BetterAudioSettings _instance; //Field offset: 0x0
	public PoolSettings poolSettings; //Field offset: 0x18

	public static BetterAudioSettings Instance
	{
		 get { } //Length: 709
	}

	public BetterAudioSettings() { }

	public static BetterAudioSettings get_Instance() { }

}

