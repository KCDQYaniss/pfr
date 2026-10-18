namespace Audio.AmbientSubsystem.AmbientSplineEmitter;

internal sealed class AverageAttenuatedDirectionJobScheduler
{
	private NativeArray _points; //Field offset: 0x10
	private NativeArray _lineStarts; //Field offset: 0x20
	private NativeArray _lineEnds; //Field offset: 0x30
	private NativeArray _calculatedClosestPoints; //Field offset: 0x40
	private NativeArray _calculatedSqrDistances; //Field offset: 0x50
	private NativeArray _segmentDirections; //Field offset: 0x60
	private NativeArray _segmentWeights; //Field offset: 0x70
	private NativeArray _segmentInRange; //Field offset: 0x80
	private NativeArray _result; //Field offset: 0x90
	private NativeArray _crossingNumber; //Field offset: 0xA0
	private readonly int _resolution; //Field offset: 0xB0
	private readonly float _calculationRadius; //Field offset: 0xB4
	private readonly int _innerLoopBatchCount; //Field offset: 0xB8
	[CompilerGenerated]
	private bool <Disposed>k__BackingField; //Field offset: 0xBC

	public private bool Disposed
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public AverageAttenuatedDirectionJobScheduler(Vector3[] points, Vector3[] lineStarts, Vector3[] lineEnds, NativeArray result, int resolution, float calculationRadius) { }

	public void Dispose() { }

	[CompilerGenerated]
	public bool get_Disposed() { }

	public JobHandle Schedule(JobHandle dependency, Vector3 listenerPos, bool projectToXZ = false) { }

	[CompilerGenerated]
	private void set_Disposed(bool value) { }

}

