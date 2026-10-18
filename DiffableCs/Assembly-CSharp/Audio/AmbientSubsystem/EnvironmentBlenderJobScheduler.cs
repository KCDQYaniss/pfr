namespace Audio.AmbientSubsystem;

public class EnvironmentBlenderJobScheduler : IDisposable
{
	private JobHandle _jobHandle; //Field offset: 0x10
	private NativeArray _outdoorPortalsData; //Field offset: 0x20
	private NativeArray _distances; //Field offset: 0x30
	private NativeArray _calculatedPortalData; //Field offset: 0x40
	private NativeArray _optimalCalculatedPortalData; //Field offset: 0x50
	private NativeArray _indoorRoomsIds; //Field offset: 0x60
	private NativeArray _neighborRoomIDs; //Field offset: 0x70
	private bool _nativeArraysDisposed; //Field offset: 0x80

	public bool IsCompleted
	{
		 get { } //Length: 79
	}

	public PortalCalculatedData OptimalCalculatedData
	{
		 get { } //Length: 116
	}

	public EnvironmentBlenderJobScheduler() { }

	public void Complete() { }

	public override void Dispose() { }

	public bool get_IsCompleted() { }

	public PortalCalculatedData get_OptimalCalculatedData() { }

	public void PrepareData(PortalData[] currentOutPortalsData, short[] currentIndoorRoomsIDs, short[] neighborRoomIDs) { }

	public void Schedule(Vector3 listenerPosition, int currentInRoomID, float listenerHeightWeight, float depthCalculationMult, float connectedRoomPenalty, float neighborRoomPenalty, bool ignoreDistanceRatio, JobHandle jobHandle = null) { }

}

