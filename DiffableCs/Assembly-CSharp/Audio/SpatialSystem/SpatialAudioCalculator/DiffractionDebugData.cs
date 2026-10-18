namespace Audio.SpatialSystem.SpatialAudioCalculator;

public class DiffractionDebugData
{
	public readonly List candidateEdgePoints; //Field offset: 0x10
	public readonly List validationLines; //Field offset: 0x18
	public readonly List searchLines; //Field offset: 0x20
	public Vector3 sourceHitPoint; //Field offset: 0x28
	public Vector3 listenerHitPoint; //Field offset: 0x34
	public Vector3 bestEdgePoint; //Field offset: 0x40
	public bool needsEdgeSearch; //Field offset: 0x4C
	public bool foundPath; //Field offset: 0x4D

	public DiffractionDebugData() { }

}

