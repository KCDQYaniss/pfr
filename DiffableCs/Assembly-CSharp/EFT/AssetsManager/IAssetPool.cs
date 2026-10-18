namespace EFT.AssetsManager;

public interface IAssetPool : IDisposable
{

	public int CurrentPoolSize
	{
		 get { } //Length: 0
	}

	public int FuturePoolSize
	{
		 get { } //Length: 0
	}

	public bool IsDisposed
	{
		 get { } //Length: 0
	}

	public bool IsWillBeDestroyedByParent
	{
		 get { } //Length: 0
	}

	public PoolContainerObject ParentObject
	{
		 get { } //Length: 0
	}

	public string PoolShortName
	{
		 get { } //Length: 0
	}

	public ResourceKey ResourceKey
	{
		 get { } //Length: 0
	}

	public ResourceTypeInfo ResourceType
	{
		 get { } //Length: 0
	}

	public int TotalCreatedObjectsCount
	{
		 get { } //Length: 0
	}

	public Task ExpandPool(int objectsCoun, YieldDelegate yield, CancellationToken cancellationToken = null, string reason = "") { }

	public int get_CurrentPoolSize() { }

	public int get_FuturePoolSize() { }

	public bool get_IsDisposed() { }

	public bool get_IsWillBeDestroyedByParent() { }

	public PoolContainerObject get_ParentObject() { }

	public string get_PoolShortName() { }

	public ResourceKey get_ResourceKey() { }

	public ResourceTypeInfo get_ResourceType() { }

	public int get_TotalCreatedObjectsCount() { }

	public GameObject PopOrCreate(bool poolShouldNotBeEmpty = false) { }

	public void Push(AssetPoolObject poolObject) { }

	public void QuickDispose() { }

	public void ReturnPoolObjects() { }

}

