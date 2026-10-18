//Type is in global namespace

public class TransformLinks : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__9_1; //Field offset: 0x8
		public static Func <>9__9_2; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal bool <CacheTransforms>b__9_1(Transform x) { }

		internal CachedTransform <CacheTransforms>b__9_2(Transform t) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass9_0
	{
		public Transform parent; //Field offset: 0x10

		public <>c__DisplayClass9_0() { }

		internal Transform <CacheTransforms>b__0(string x) { }

	}

	internal struct CachedTransform
	{
		public Vector3 Position; //Field offset: 0x0
		public Quaternion Rotation; //Field offset: 0xC
		public Transform Transform; //Field offset: 0x20

		public void Reset() { }

	}

	public Transform[] Transforms; //Field offset: 0x20
	public Transform Self; //Field offset: 0x28
	[SerializeField]
	private CachedTransform[] _cachedTransforms; //Field offset: 0x30

	public TransformLinks() { }

	public void CacheTransforms(Transform parent, IEnumerable cachedBoneNames) { }

	public void GatherIK(Transform[] markers, Transform[] gripReferences, Transform[] elbowBends) { }

	public void GatherUnderbarrelWeaponIK(Transform launcherRoot, Transform[] elbowBends) { }

	public Transform GetCachedTransform(int index) { }

	[CanBeNull]
	public Transform GetTransform(ECharacterWeaponBones bone) { }

	[CanBeNull]
	public Transform GetTransformOutOfRangeSafe(ECharacterWeaponBones bone) { }

	public void ResetPositions() { }

}

