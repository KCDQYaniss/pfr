namespace EFT.AssetsManager;

[DisallowMultipleComponent]
public class AssetPoolObject : MonoBehaviour
{
	private sealed class AssetsPoolObjectComponentPoolPolicy : PooledObjectPolicy
	{

		public AssetsPoolObjectComponentPoolPolicy() { }

		public virtual List Create() { }

		public virtual bool Return(List obj) { }

	}

	internal class ColliderLayer
	{
		public Collider Collider; //Field offset: 0x10
		public int Layer; //Field offset: 0x18
		public bool WasEnabled; //Field offset: 0x1C

		public ColliderLayer() { }

		public void Reset() { }

	}

	private static readonly ObjectPool _assetPoolObjectComponentsPool; //Field offset: 0x0
	public List PoolHistory; //Field offset: 0x20
	public List Colliders; //Field offset: 0x28
	public List Components; //Field offset: 0x30
	public List Renderers; //Field offset: 0x38
	[SerializeField]
	private List _originallyEnabledComponents; //Field offset: 0x40
	[CompilerGenerated]
	private bool <IsStub>k__BackingField; //Field offset: 0x48
	[CanBeNull]
	public ContainerCollectionView ContainerCollectionView; //Field offset: 0x50
	[CompilerGenerated]
	private bool <IsInPool>k__BackingField; //Field offset: 0x58
	protected ResourceTypeInfo ResourceType; //Field offset: 0x60
	private IAssetPool _assetsPoolParent; //Field offset: 0x70
	private bool _isDestroyedByAssetPool; //Field offset: 0x78
	public List RegisteredComponentsToClean; //Field offset: 0x80
	public List RegisteredCollidersToDisable; //Field offset: 0x88

	public private bool IsInPool
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public bool IsStub
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public string Name
	{
		 get { } //Length: 90
	}

	private static AssetPoolObject() { }

	public AssetPoolObject() { }

	private static void ClearChildren(GameObject gameObject, AssetPoolObject parentAssetPoolObject, bool immediate) { }

	private void CollectObjectComponents() { }

	public void CollectOriginallyEnabledComponents() { }

	public void Destroy(AbstractAssetsPool ownerAssetsPool) { }

	private static void DestroyGameObject(GameObject gameObject, bool immediate) { }

	public void DisposeContainerCollectionView() { }

	[CompilerGenerated]
	public bool get_IsInPool() { }

	[CompilerGenerated]
	public bool get_IsStub() { }

	public string get_Name() { }

	public List GetColliders(bool includeNestedAssetPoolObjects) { }

	public override void InheritRoleModelData(TAssetPoolObject roleModel) { }

	public override void Init(ResourceTypeInfo resourceType, bool isStub = false) { }

	public override void OnCreatePoolObject(AbstractAssetsPool assetsPoolParent) { }

	public override void OnCreatePoolRoleModel() { }

	protected override void OnDestroy() { }

	public override void OnGetFromPool() { }

	public void RegisterComponent(IPoolComponent component) { }

	protected override void ReturnToPool() { }

	private static void ReturnToPool(AssetPoolObject assetPoolObject) { }

	public static void ReturnToPool(AssetPoolObject assetPoolObject, bool immediate = true) { }

	public static void ReturnToPool(GameObject gameObject, bool immediate = true) { }

	[CompilerGenerated]
	private void set_IsInPool(bool value) { }

	[CompilerGenerated]
	public void set_IsStub(bool value) { }

	public void SetOriginalComponentsEnabled(bool enabled) { }

	public void StoreCollider(Collider coll) { }

	public void UnregisterComponent(IPoolComponent component) { }

}

