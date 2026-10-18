namespace Audio.SpatialSystem;

public static class SoundOcclusionVolumeDependentChecker
{
	private static RaycastHit _lastHit; //Field offset: 0x0
	private static float _prevConnectionAudibility; //Field offset: 0x2C
	private static float _cachedAudibility; //Field offset: 0x30

	private static Player ListenerPlayer
	{
		private get { } //Length: 71
	}

	public static void CalculateGunshotsOcclusion(Vector3 gunPosition, out float volume, ref float lowerFrequency) { }

	private static void CheckVolumesByHorizontalPlane(RelationParameters connection, ref float lowerFrequency, ref float occlusionEffect, ref float volume, bool isSourcesInDifferentVolume, float originalDistance, float maxDistance) { }

	private static void CheckVolumesByVerticalPlane(RelationParameters connection, ref float lowerFrequency, Vector3 listenerPosition, Vector3 soundPosition, ref float occlusionEffect, ref float volume, float distance, bool isSourcesInDifferentVolume) { }

	private static Player get_ListenerPlayer() { }

	public static AudioMixerGroup GetGunshotsOcclusionGroup(Player player, out float volume) { }

	public static bool OcclusionTest(Vector3 origin, Vector3 destination, float distance) { }

	private static bool OcclusionTest(Vector3 origin, Vector3 destination, float distance, int mask) { }

	public static void VolumeDependentOcclusion(Vector3 soundPosition, ref float propagationEffect, ref float lowerFrequency, ref float volume, float maxDistance = 50) { }

	public static AudioMixerGroup VolumeDependentOcclusion(Vector3 soundPosition, ref float volume, float distance) { }

	public static AudioMixerGroup VolumeDependentOcclusion(Vector3 soundPosition, ref float volume, float distance, Player sourcePlayer, EnvironmentType sourceEnvironment) { }

	public static AudioMixerGroup VolumeDependentOcclusion(Vector3 soundPosition, ref float volume, float distance, IPlayer sourcePlayer, EnvironmentType sourceEnvironment, int mask) { }

}

