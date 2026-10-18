namespace EFT.AssetsManager;

[DisallowMultipleComponent]
public class PlayerPoolObject : AssetPoolObject
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass14_0
	{
		public EBodyPartColliderType parent; //Field offset: 0x10
		public EBodyPartColliderType child; //Field offset: 0x14

		public <>c__DisplayClass14_0() { }

		internal bool <ConnectRigidbodySleepHierarchy>b__0(PlayerRigidbodySleepHierarchy hierarchy) { }

		internal bool <ConnectRigidbodySleepHierarchy>b__1(PlayerRigidbodySleepHierarchy hierarchy) { }

	}

	public GrounderFBBIK GrounderFbbik; //Field offset: 0x90
	public FullBodyBipedIK FullBodyBipedIk; //Field offset: 0x98
	public HitReaction HitReaction; //Field offset: 0xA0
	public LimbIK[] LimbIks; //Field offset: 0xA8
	public Animator Animator; //Field offset: 0xB0
	public CharacterControllerSpawner CharacterControllerSpawner; //Field offset: 0xB8
	public PlayerBones PlayerBones; //Field offset: 0xC0
	public PlayerOverlapManager PlayerOverlapManager; //Field offset: 0xC8
	public AnimatorDefaultStateCache AnimatorDefaultStateCache; //Field offset: 0xD0
	public RigidbodySpawner[] RigidbodySpawners; //Field offset: 0xD8
	public CharacterJointSpawner[] JointSpawners; //Field offset: 0xE0
	public List PlayerRigidbodySleepHierarchy; //Field offset: 0xE8

	public PlayerPoolObject() { }

	private void CacheData() { }

	private static void ConnectRigidbodySleepHierarchy(List playerRigidbodySleepHierarchy, EBodyPartColliderType parent, EBodyPartColliderType child) { }

	public static List CreatePlayerRigidbodySleepHierarchy(RigidbodySpawner[] rigidbodySpawners) { }

	private void CreateRigidbodiesForRagdoll() { }

	public virtual void OnCreatePoolObject(AbstractAssetsPool assetsPoolParent) { }

	public virtual void OnCreatePoolRoleModel() { }

	public virtual void OnGetFromPool() { }

	protected virtual void ReturnToPool() { }

	protected override void SetupAnimator() { }

}

