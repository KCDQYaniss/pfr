namespace Systems.Effects;

[BurstCompile]
public sealed class FastBoundingSearch : IDisposable
{
	[BurstCompile(FloatMode = FloatMode::Fast (3), FloatPrecision = FloatPrecision::Low (3), OptimizeFor = OptimizeFor::Performance (1))]
	private struct CompactJob : IJob
	{
		public int BlockCount; //Field offset: 0x0
		[NativeDisableUnsafePtrRestriction]
		[NoAlias]
		[ReadOnly]
		public byte* BlockMasks; //Field offset: 0x8
		[NativeDisableUnsafePtrRestriction]
		[WriteOnly]
		public int* Hits; //Field offset: 0x10
		[NativeDisableUnsafePtrRestriction]
		[WriteOnly]
		public int* HitCount; //Field offset: 0x18

		public override void Execute() { }

	}

	[BurstCompile(FloatMode = FloatMode::Fast (3), FloatPrecision = FloatPrecision::Low (3), OptimizeFor = OptimizeFor::Performance (1))]
	private struct ParallelMaskRawJob : IJobParallelFor
	{
		public float Px; //Field offset: 0x0
		public float Py; //Field offset: 0x4
		public float Pz; //Field offset: 0x8
		public int XorMask; //Field offset: 0xC
		[NativeDisableUnsafePtrRestriction]
		[NoAlias]
		[ReadOnly]
		public float4* MinX; //Field offset: 0x10
		[NativeDisableUnsafePtrRestriction]
		[NoAlias]
		[ReadOnly]
		public float4* MinY; //Field offset: 0x18
		[NativeDisableUnsafePtrRestriction]
		[NoAlias]
		[ReadOnly]
		public float4* MinZ; //Field offset: 0x20
		[NativeDisableUnsafePtrRestriction]
		[NoAlias]
		[ReadOnly]
		public float4* MaxX; //Field offset: 0x28
		[NativeDisableUnsafePtrRestriction]
		[NoAlias]
		[ReadOnly]
		public float4* MaxY; //Field offset: 0x30
		[NativeDisableUnsafePtrRestriction]
		[NoAlias]
		[ReadOnly]
		public float4* MaxZ; //Field offset: 0x38
		[NativeDisableUnsafePtrRestriction]
		[NoAlias]
		[WriteOnly]
		public byte* BlockMasks; //Field offset: 0x40

		public override void Execute(int i) { }

	}

	public struct PtrBlock
	{
		[NativeDisableUnsafePtrRestriction]
		public float4* MinX; //Field offset: 0x0
		[NativeDisableUnsafePtrRestriction]
		public float4* MinY; //Field offset: 0x8
		[NativeDisableUnsafePtrRestriction]
		public float4* MinZ; //Field offset: 0x10
		[NativeDisableUnsafePtrRestriction]
		public float4* MaxX; //Field offset: 0x18
		[NativeDisableUnsafePtrRestriction]
		public float4* MaxY; //Field offset: 0x20
		[NativeDisableUnsafePtrRestriction]
		public float4* MaxZ; //Field offset: 0x28

		public void Copy(int dst, int src) { }

		public void Set(int index, float valMin, float valMax) { }

		public void Set(int index, float3 min, float3 max) { }

	}

	[BurstCompile(FloatMode = FloatMode::Fast (3), FloatPrecision = FloatPrecision::Low (3), OptimizeFor = OptimizeFor::Performance (1))]
	private struct SingleQueryRawJob : IJob
	{
		public float Px; //Field offset: 0x0
		public float Py; //Field offset: 0x4
		public float Pz; //Field offset: 0x8
		public int BlockCount; //Field offset: 0xC
		public int XorMask; //Field offset: 0x10
		[NativeDisableUnsafePtrRestriction]
		[NoAlias]
		[ReadOnly]
		public float4* MinX; //Field offset: 0x18
		[NativeDisableUnsafePtrRestriction]
		[NoAlias]
		[ReadOnly]
		public float4* MinY; //Field offset: 0x20
		[NativeDisableUnsafePtrRestriction]
		[NoAlias]
		[ReadOnly]
		public float4* MinZ; //Field offset: 0x28
		[NativeDisableUnsafePtrRestriction]
		[NoAlias]
		[ReadOnly]
		public float4* MaxX; //Field offset: 0x30
		[NativeDisableUnsafePtrRestriction]
		[NoAlias]
		[ReadOnly]
		public float4* MaxY; //Field offset: 0x38
		[NativeDisableUnsafePtrRestriction]
		[NoAlias]
		[ReadOnly]
		public float4* MaxZ; //Field offset: 0x40
		[NativeDisableUnsafePtrRestriction]
		[WriteOnly]
		public int* Hits; //Field offset: 0x48
		[NativeDisableUnsafePtrRestriction]
		[WriteOnly]
		public int* HitCount; //Field offset: 0x50

		public override void Execute() { }

	}

	public const int PARALLEL_MIN = 8196; //Field offset: 0x0
	public const int PARALLEL_BATCH_SIZE = 32; //Field offset: 0x0
	private readonly int _capacity; //Field offset: 0x10
	private readonly int _blockCapacity; //Field offset: 0x14
	private int _count; //Field offset: 0x18
	private readonly int _xorMask; //Field offset: 0x1C
	private readonly float4 _padValMin; //Field offset: 0x20
	private readonly float4 _padValMax; //Field offset: 0x30
	private NativeArray _minX; //Field offset: 0x40
	private NativeArray _minY; //Field offset: 0x50
	private NativeArray _minZ; //Field offset: 0x60
	private NativeArray _maxX; //Field offset: 0x70
	private NativeArray _maxY; //Field offset: 0x80
	private NativeArray _maxZ; //Field offset: 0x90
	private NativeArray _hits; //Field offset: 0xA0
	private NativeArray _hitCount1; //Field offset: 0xB0
	private NativeArray _blockMasks; //Field offset: 0xC0

	public int Capacity
	{
		 get { } //Length: 164
	}

	public int Count
	{
		 get { } //Length: 4
	}

	public NativeArray Hits
	{
		 get { } //Length: 14
	}

	public int HitsCount
	{
		 get { } //Length: 10
	}

	public FastBoundingSearch(int capacity, bool inverseLogic = false, Allocator allocator = 4) { }

	public int Add(in float3 min, in float3 max) { }

	public void Clear() { }

	public void CopyTo(FastBoundingSearch dst) { }

	private SingleQueryRawJob CreateQueryRawJob(float3 point) { }

	public override void Dispose() { }

	public NativeSlice Find(float3 point) { }

	public int get_Capacity() { }

	public int get_Count() { }

	public NativeArray get_Hits() { }

	public int get_HitsCount() { }

	private PtrBlock GetPtrBlock() { }

	public NativeSlice GetResults() { }

	public bool RemoveAt(int index) { }

	public static bool ResizeIfNeeded(FastBoundingSearch search, int requiredCapacity, out FastBoundingSearch outSearch) { }

	public JobHandle ScheduleFind(float3 point, JobHandle dep = null) { }

}

