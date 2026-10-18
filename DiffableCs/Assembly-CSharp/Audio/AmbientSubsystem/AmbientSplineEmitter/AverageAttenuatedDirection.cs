namespace Audio.AmbientSubsystem.AmbientSplineEmitter;

internal struct AverageAttenuatedDirection
{
	public Vector3 closestPoint; //Field offset: 0x0
	public Vector3 averageDirection; //Field offset: 0xC
	public double closestDistance; //Field offset: 0x18
	public double averageSpread; //Field offset: 0x20
	public bool withinRange; //Field offset: 0x28
	public bool isInside; //Field offset: 0x29

}

