namespace Audio.BackendSettings;

public class ClientAudioWeaponSettings
{
	internal class WeaponPlaybackSettings
	{
		public float FireLoopBreakMultiplier; //Field offset: 0x10
		public float BurstFireFadeMultiplier; //Field offset: 0x14
		public float MinRandomPitch; //Field offset: 0x18
		public float MaxRandomPitch; //Field offset: 0x1C
		public float MinClampPitch; //Field offset: 0x20
		public float MaxClampPitch; //Field offset: 0x24
		public float OcclusionThreshold; //Field offset: 0x28
		public bool AdaptiveFadeEnabled; //Field offset: 0x2C
		public float AdaptiveFadeLeadBeatsThreshold; //Field offset: 0x30
		public float AdaptiveFadeMaxMultiplier; //Field offset: 0x34
		public float AdaptiveFadeMaxSeconds; //Field offset: 0x38

		public WeaponPlaybackSettings() { }

		public WeaponPlaybackSettings Copy() { }

	}

	internal class WeaponPoolSettings
	{
		public int DefaultPoolSize; //Field offset: 0x10
		public int MinPoolSize; //Field offset: 0x14
		public int MaxPoolSize; //Field offset: 0x18

		public WeaponPoolSettings() { }

		public WeaponPoolSettings Copy() { }

	}

	public WeaponPlaybackSettings PlaybackSettings; //Field offset: 0x10
	public WeaponPoolSettings PoolSettings; //Field offset: 0x18

	public ClientAudioWeaponSettings() { }

}

