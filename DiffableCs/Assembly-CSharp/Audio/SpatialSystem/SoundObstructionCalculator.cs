namespace Audio.SpatialSystem;

public abstract class SoundObstructionCalculator : AbstractSpatialAudioCalculator
{
	[IsReadOnly]
	internal struct SoundRay
	{
		[CompilerGenerated]
		private readonly Vector3 <StartPoint>k__BackingField; //Field offset: 0x0
		[CompilerGenerated]
		private readonly Vector3 <EndPoint>k__BackingField; //Field offset: 0xC
		[CompilerGenerated]
		private readonly float <Distance>k__BackingField; //Field offset: 0x18

		public float Distance
		{
			[CompilerGenerated]
			 get { } //Length: 6
		}

		public Vector3 EndPoint
		{
			[CompilerGenerated]
			 get { } //Length: 19
		}

		public Vector3 StartPoint
		{
			[CompilerGenerated]
			 get { } //Length: 18
		}

		public SoundRay(Vector3 startPoint, Vector3 endPoint) { }

		[CompilerGenerated]
		public float get_Distance() { }

		[CompilerGenerated]
		public Vector3 get_EndPoint() { }

		[CompilerGenerated]
		public Vector3 get_StartPoint() { }

	}

	protected const int MAX_RAYS_COUNT = 11; //Field offset: 0x0
	protected const int MAX_HITS_COUNT = 5; //Field offset: 0x0
	protected readonly HashSet DebugRaysInfo; //Field offset: 0x20

	protected static int OcclusionMask
	{
		 get { } //Length: 7
	}

	protected SoundObstructionCalculator(SpatialAudioSystem audioSystem) { }

	protected static Vector3 CalculatePoint(Vector3 soundPos, Vector3 listenerPos, float offset, bool positive) { }

	protected void DrawDebugRays(float duration = 0.5) { }

	protected static int get_OcclusionMask() { }

}

