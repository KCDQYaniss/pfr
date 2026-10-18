//Type is in global namespace

public class AnimationSnatcher : MonoBehaviour
{
	internal class HierarchySnatcherPair : SnatcherPair
	{
		public string Name; //Field offset: 0x40
		public bool ProcessOnlyChildren; //Field offset: 0x48
		public bool foldOut; //Field offset: 0x49
		public bool _isCopyHierarchy; //Field offset: 0x4A
		public string SearchPrefix; //Field offset: 0x50
		private bool _isDuplicating; //Field offset: 0x58
		public List ChildrenPairs; //Field offset: 0x60

		public bool IsCopyHierarchy
		{
			 get { } //Length: 5
			 set { } //Length: 17
		}

		public virtual bool IsDuplicating
		{
			 get { } //Length: 5
			 set { } //Length: 368
		}

		public HierarchySnatcherPair(Transform source, Transform destination) { }

		private void EnableHierarchyDuplication(bool enabled) { }

		public bool get_IsCopyHierarchy() { }

		public virtual bool get_IsDuplicating() { }

		private List getAllChildTransforms(Transform source) { }

		public virtual void Process(EPointOfView pointOfView) { }

		public void set_IsCopyHierarchy(bool value) { }

		public virtual void set_IsDuplicating(bool value) { }

		public virtual void SetWeight(float xz, float y, float r) { }

	}

	internal class SnatcherPair
	{
		internal enum ECopyMode
		{
			Local = 0,
			World = 1,
		}

		public Transform Source; //Field offset: 0x10
		public Transform Destination; //Field offset: 0x18
		[CompilerGenerated]
		private bool <IsDuplicating>k__BackingField; //Field offset: 0x20
		public ECopyMode CopyMode; //Field offset: 0x24
		public EPointOfView PointOfView; //Field offset: 0x28
		public bool RespectPointOfView; //Field offset: 0x2C
		public float PositionXZWeight; //Field offset: 0x30
		public float PositionYWeight; //Field offset: 0x34
		public float RotationWeight; //Field offset: 0x38

		public override bool IsDuplicating
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			 set { } //Length: 4
		}

		public SnatcherPair(Transform source, Transform destination) { }

		private void Duplicate(Transform source, Transform destination) { }

		[CompilerGenerated]
		public override bool get_IsDuplicating() { }

		public override void Process(EPointOfView pointOfView) { }

		public Vector3 SeparateLerp(Vector3 v1, Vector3 v2, float weightXZ, float weightY) { }

		[CompilerGenerated]
		public override void set_IsDuplicating(bool value) { }

		public override void SetWeight(float xz, float y, float r) { }

	}

	public const string PALM_LEFT_TRANSFORM = "Base HumanLPalm"; //Field offset: 0x0
	public const string PALM_RIGHT_TRANSFORM = "Base HumanRPalm"; //Field offset: 0x0
	public const string WEAPON_ROOT_TRANSFORM = "Weapon_root"; //Field offset: 0x0
	public const string RIBCAGE_TRANSFORM_NAME = "Base HumanRibcage"; //Field offset: 0x0
	public const string LEFT_ARM = "Base HumanLCollarbone"; //Field offset: 0x0
	public const string RIGHT_ARM = "Base HumanRCollarbone"; //Field offset: 0x0
	public List MainPairs; //Field offset: 0x20
	public List LeftHandPost; //Field offset: 0x28
	public List RightHandPost; //Field offset: 0x30
	public Transform First; //Field offset: 0x38
	public Transform Third; //Field offset: 0x40
	public List Ignore; //Field offset: 0x48
	private EPointOfView _pointOfView; //Field offset: 0x50

	public AnimationSnatcher() { }

	public void InitHands(Transform HandsContainerTransform, Transform bodyTransform) { }

	internal void MainUpdate() { }

	internal void PostUpdate() { }

	public void Reset(Transform from, Transform to, EPointOfView pointOfView) { }

	public void SetPalmSnatchingWeight(float left, float right) { }

	public void SetPointOfView(EPointOfView pointOfView) { }

	public void SetWeaponSnatchingPreferences(ECopyMode mode, bool respect) { }

	public void SetWeaponSnatchingWeights(float xz, float y, float r) { }

	private void Start() { }

	public Transform[] TransformToArray(Transform parent) { }

	public void UpdateWeaponRoot(Transform HandsContainerTransform, Transform bodyTransform) { }

}

