namespace EFT.VolumePropagation;

public interface IVolumePropagationSystem : IDisposable
{

	public event Action OnCollisionTick
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public event Action OnSourceExpired
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public int ActiveSourceCount
	{
		 get { } //Length: 0
	}

	public IEnumerable ActiveSources
	{
		 get { } //Length: 0
	}

	[CompilerGenerated]
	public void add_OnCollisionTick(Action value) { }

	[CompilerGenerated]
	public void add_OnSourceExpired(Action value) { }

	public void ApplyDelta(VolumetricSystemSourceDeltaPacket packet) { }

	public void ApplyInitialState(VolumeInitialStateMessage message) { }

	public void ApplyRemove(VolumetricSystemSourceRemovePacket packet) { }

	public void ApplySpawn(VolumetricSystemSourceSpawnPacket packet) { }

	public bool Contains(int sourceId) { }

	public void EnumerateSnapshot(List destination) { }

	public void FreezeSource(int sourceId) { }

	public int get_ActiveSourceCount() { }

	public IEnumerable get_ActiveSources() { }

	public int RegisterSource(IVolumeSourceSettings sourceSettings, Vector3 position) { }

	[CompilerGenerated]
	public void remove_OnCollisionTick(Action value) { }

	[CompilerGenerated]
	public void remove_OnSourceExpired(Action value) { }

	public void RemoveSource(int sourceId) { }

	public void Tick(float dt) { }

	public bool TryGetSource(int sourceId, out IVolumePropagationSourceReadOnly source) { }

}

