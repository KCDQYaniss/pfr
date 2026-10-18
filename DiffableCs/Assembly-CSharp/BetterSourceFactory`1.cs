//Type is in global namespace

public sealed class BetterSourceFactory`1 : IPooledBetterSourceFactory
{
	private readonly AudioGroupPreset _preset; //Field offset: 0x0
	private readonly GameObject _sourcePrefab; //Field offset: 0x0
	private readonly AudioMixerGroup _mixerGroup; //Field offset: 0x0
	private readonly IBetterSourceUpdater _updater; //Field offset: 0x0
	private readonly IBetterSourceCulling _culling; //Field offset: 0x0
	private readonly ISourceReleaseListener _sourceListener; //Field offset: 0x0

	public BetterSourceFactory`1(AudioGroupPreset preset, GameObject sourcePrefab, AudioMixerGroup mixerGroup, IBetterSourceUpdater updater, IBetterSourceCulling culling, ISourceReleaseListener sourceListener = null) { }

	public override T InstantiateNewSource(bool spatialization = false) { }

}

