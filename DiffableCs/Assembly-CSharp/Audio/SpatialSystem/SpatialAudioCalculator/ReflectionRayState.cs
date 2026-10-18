namespace Audio.SpatialSystem.SpatialAudioCalculator;

public struct ReflectionRayState
{
	public bool isActive; //Field offset: 0x0
	public Vector3 currentOrigin; //Field offset: 0x4
	public Vector3 currentDirection; //Field offset: 0x10
	public float distanceTraveled; //Field offset: 0x1C
	public float remainingDistance; //Field offset: 0x20
	public int reflectionCount; //Field offset: 0x24
	public float currentEnergy; //Field offset: 0x28
	public int raySegmentCommandIndex; //Field offset: 0x2C
	public int listenerCheckSphereCommandIndex; //Field offset: 0x30

}

