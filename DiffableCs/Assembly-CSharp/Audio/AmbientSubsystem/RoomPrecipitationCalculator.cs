namespace Audio.AmbientSubsystem;

public class RoomPrecipitationCalculator : IDisposable
{
	private readonly Transform _listenerTransform; //Field offset: 0x10
	private Bounds _roomBounds; //Field offset: 0x18
	private RoomAmbientData _ambientData; //Field offset: 0x30

	private Vector3 ListenerPos
	{
		private get { } //Length: 389
	}

	public RoomPrecipitationCalculator() { }

	public float CalculateNormalizedVolumeByRange() { }

	public override void Dispose() { }

	private Vector3 get_ListenerPos() { }

	public void UpdateRoom(ISpatialAudioRoom room) { }

}

