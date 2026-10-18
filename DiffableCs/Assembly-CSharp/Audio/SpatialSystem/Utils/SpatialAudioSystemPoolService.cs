namespace Audio.SpatialSystem.Utils;

public class SpatialAudioSystemPoolService
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__2_0; //Field offset: 0x8
		public static Action <>9__2_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal PendingReturn <.ctor>b__2_0() { }

		internal void <.ctor>b__2_1(PendingReturn pr) { }

	}

	[CompilerGenerated]
	private sealed class <>c__14`1
	{
		public static readonly <>c__14 <>9; //Field offset: 0x0
		public static Action <>9__14_3; //Field offset: 0x0

		private static <>c__14`1() { }

		public <>c__14`1() { }

		internal void <RegisterPool>b__14_3(object obj) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass10_0`1
	{
		public PoolInfo info; //Field offset: 0x0

		public <>c__DisplayClass10_0`1() { }

		internal TCalculator <WithdrawCalculator>b__0() { }

		internal void <WithdrawCalculator>b__1(TCalculator calc) { }

		internal void <WithdrawCalculator>b__2(TCalculator calc) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass14_0`1
	{
		public Func creator; //Field offset: 0x0
		public Action resetter; //Field offset: 0x0
		public Action disposer; //Field offset: 0x0

		public <>c__DisplayClass14_0`1() { }

		internal object <RegisterPool>b__0() { }

		internal void <RegisterPool>b__1(object obj) { }

		internal void <RegisterPool>b__2(object obj) { }

	}

	private sealed class PendingReturn
	{
		public object Calculator; //Field offset: 0x10
		public PoolInfo Info; //Field offset: 0x18

		public PendingReturn() { }

		public void Clear() { }

		public void Initialize(object calculator, PoolInfo info) { }

		public bool TryFinalize() { }

	}

	private sealed class PoolInfo
	{
		public int size; //Field offset: 0x10
		public Func creator; //Field offset: 0x18
		public Action resetter; //Field offset: 0x20
		public Action disposer; //Field offset: 0x28
		public Action returner; //Field offset: 0x30

		public PoolInfo() { }

	}

	private readonly Dictionary _poolInfos; //Field offset: 0x10
	private readonly Queue _pendingReturns; //Field offset: 0x18
	private readonly ObjectPool _pendingReturnPool; //Field offset: 0x20
	private readonly SpatialAudioSystem _audioSystem; //Field offset: 0x28
	private readonly SpatialAudioPoolsConfig _poolsConfig; //Field offset: 0x30
	private readonly AudioOcclusionSettings _occlusionSettings; //Field offset: 0x38

	public SpatialAudioSystemPoolService(SpatialAudioSystem audioSystem, SpatialAudioPoolsConfig config, AudioOcclusionSettings occlusionSettings) { }

	private SpatialAudioOcclusionCombinedCalculator CreateCombinedCalculator() { }

	private ParallelSoundPropagationCalculator CreatePropagationCalculator() { }

	private TransmissionCalculator CreateTransmissionCalculator() { }

	private void DisposeCombinedCalculator(TCalculator calculator) { }

	public void DisposePools() { }

	private void DisposePropagationCalculator(TCalculator calculator) { }

	private void DisposeTransmissionCalculator(TCalculator calculator) { }

	public void PreCreatePools() { }

	private void RegisterPool(int size, Func creator, Action resetter, Action disposer) { }

	private void ResetCombinedCalculator(TCalculator calculator) { }

	private void ResetPropagationCalculator(TCalculator calculator) { }

	private void ResetTransmissionCalculator(TCalculator calculator) { }

	public void ReturnCalculator(TCalculator calculator) { }

	public void UpdatePendingCalculators(int maxPerFrame = 1) { }

	public TCalculator WithdrawCalculator() { }

}

