namespace Audio.SpatialSystem.Data;

public class LocationBakeSettings
{
	private float _maxDistance; //Field offset: 0x10
	[Min(1)]
	[Space]
	[Tooltip("Maximum propagation depth for indoor→indoor room pairs")]
	public int maxDepthIndoorToIndoor; //Field offset: 0x14
	[Min(1)]
	[Tooltip("Maximum propagation depth for indoor→outdoor room pairs")]
	public int maxDepthIndoorToOutdoor; //Field offset: 0x18
	[Min(1)]
	[Tooltip("Maximum propagation depth for outdoor→outdoor room pairs")]
	public int maxDepthOutdoorToOutdoor; //Field offset: 0x1C
	[Min(1)]
	[Tooltip("Maximum distance for outdoor→outdoor room pairs")]
	public int maxDistanceOutdoorToOutdoor; //Field offset: 0x20
	[Min(1)]
	[Tooltip("Maximum distance for indoor→outdoor room pairs")]
	public int maxDistanceIndoorToOutdoor; //Field offset: 0x24
	[Min(1)]
	[Tooltip("Maximum distance for indoor→indoor room pairs")]
	public int maxDistanceIndoorToIndoor; //Field offset: 0x28

	public LocationBakeSettings() { }

	public void Read(BinaryReader reader) { }

	public void Write(BinaryWriter writer) { }

}

