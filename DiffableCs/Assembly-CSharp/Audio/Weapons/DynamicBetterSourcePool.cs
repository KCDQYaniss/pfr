namespace Audio.Weapons;

public sealed class DynamicBetterSourcePool : IBetterSourceCustomPool, IDisposable
{
	private readonly List _sources; //Field offset: 0x10
	private readonly AudioSourceGroupType _targetGroupType; //Field offset: 0x18
	private readonly IAudioSourceFactory _factory; //Field offset: 0x20
	private readonly IOcclusionService _occlusionService; //Field offset: 0x28
	private readonly int _maxPoolSize; //Field offset: 0x30
	private readonly int _minPoolSize; //Field offset: 0x34
	private int _currentIndex; //Field offset: 0x38
	private bool _isDisposed; //Field offset: 0x3C
	private readonly bool _isFirstPerson; //Field offset: 0x3D

	public override int PoolSize
	{
		 get { } //Length: 65
	}

	public DynamicBetterSourcePool(AudioSourceGroupType sourceGroupType, WeaponPoolSettings poolSettings, IAudioSourceFactory factory, IOcclusionService occlusionService, bool isFirstPerson) { }

	public override BetterSource Borrow() { }

	public override void Dispose() { }

	public override int get_PoolSize() { }

	private static void PrepareBorrowedSource(BetterSource source) { }

	public override void ProcessOcclusion(BetterSource source) { }

	public override void RegisterOcclusionPlayer(IObserverToPlayerBridge playerBridge) { }

	public override void Release(bool softStop = true) { }

	private void ReleaseSource(BetterSource source, double dspTime, bool softStop) { }

	public override void Resize(int newSize) { }

	public override void TrackPosition(Transform parent) { }

}

