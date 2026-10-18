namespace EFT;

public class ObjectInHands : IPoolComponent
{
	protected WeaponPrefab _weaponPrefab; //Field offset: 0x10
	protected EPointOfView _pointOfView; //Field offset: 0x18
	protected bool _isYourPlayer; //Field offset: 0x1C
	[CompilerGenerated]
	private ProceduralWeaponAnimation <ProceduralWeaponAnimation>k__BackingField; //Field offset: 0x20
	protected ContainerCollectionView ContainerCollectionView; //Field offset: 0x28
	[CompilerGenerated]
	private bool <enabled>k__BackingField; //Field offset: 0x30

	public override bool enabled
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public private ProceduralWeaponAnimation ProceduralWeaponAnimation
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public WeaponPrefab WeaponPrefab
	{
		 get { } //Length: 5
	}

	public ObjectInHands() { }

	public override void AfterGetFromPoolInit(ProceduralWeaponAnimation proceduralWeaponAnimation, ContainerCollectionView containerCollectionView, bool isYourPlayer) { }

	[CompilerGenerated]
	public override bool get_enabled() { }

	[CompilerGenerated]
	public ProceduralWeaponAnimation get_ProceduralWeaponAnimation() { }

	public WeaponPrefab get_WeaponPrefab() { }

	public override void InheritRoleModelData(IPoolComponent roleModel) { }

	public override void OnCreatePoolObject(AssetPoolObject assetPoolObject) { }

	public override void OnCreatePoolObjectInit(WeaponPrefab weaponPrefab) { }

	public override void OnCreatePoolRoleModel(AssetPoolObject assetPoolObject) { }

	public override void OnGetFromPool(AssetPoolObject assetPoolObject) { }

	public override void OnReturnToPool(AssetPoolObject assetPoolObject) { }

	public override void OnWeaponInit() { }

	[CompilerGenerated]
	public override void set_enabled(bool value) { }

	[CompilerGenerated]
	private void set_ProceduralWeaponAnimation(ProceduralWeaponAnimation value) { }

	public override void SetPointOfView(EPointOfView pointOfView) { }

}

