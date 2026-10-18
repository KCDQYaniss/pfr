namespace Cinemachine;

[AddComponentMenu("Cinemachine/CinemachineTargetGroup")]
[DisallowMultipleComponent]
[DocumentationSorting(Level::UserRef (2))]
[ExecuteAlways]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@2.9/manual/CinemachineTargetGroup.html")]
[SaveDuringPlay]
public class CinemachineTargetGroup : MonoBehaviour, ICinemachineTargetGroup
{
	[DocumentationSorting(Level::UserRef (2))]
	internal enum PositionMode
	{
		GroupCenter = 0,
		GroupAverage = 1,
	}

	[DocumentationSorting(Level::UserRef (2))]
	internal enum RotationMode
	{
		Manual = 0,
		GroupAverage = 1,
	}

	[DocumentationSorting(Level::UserRef (2))]
	internal struct Target
	{
		[Tooltip("The target objects.  This object's position and orientation will contribute to the group's average position and orientation, in accordance with its weight")]
		public Transform target; //Field offset: 0x0
		[Tooltip("How much weight to give the target when averaging.  Cannot be negative")]
		public float weight; //Field offset: 0x8
		[Tooltip("The radius of the target, used for calculating the bounding box.  Cannot be negative")]
		public float radius; //Field offset: 0xC

	}

	internal enum UpdateMethod
	{
		Update = 0,
		FixedUpdate = 1,
		LateUpdate = 2,
	}

	[Tooltip("How the group's position is calculated.  Select GroupCenter for the center of the bounding box, and GroupAverage for a weighted average of the positions of the members.")]
	public PositionMode m_PositionMode; //Field offset: 0x20
	[Tooltip("How the group's rotation is calculated.  Select Manual to use the value in the group's transform, and GroupAverage for a weighted average of the orientations of the members.")]
	public RotationMode m_RotationMode; //Field offset: 0x24
	[Tooltip("When to update the group's transform based on the position of the group members")]
	public UpdateMethod m_UpdateMethod; //Field offset: 0x28
	[NoSaveDuringPlay]
	[Tooltip("The target objects, together with their weights and radii, that will contribute to the group's average position, orientation, and size.")]
	public Target[] m_Targets; //Field offset: 0x30
	private float m_MaxWeight; //Field offset: 0x38
	private float m_WeightSum; //Field offset: 0x3C
	private Vector3 m_AveragePos; //Field offset: 0x40
	private Bounds m_BoundingBox; //Field offset: 0x4C
	private BoundingSphere m_BoundingSphere; //Field offset: 0x64
	private int m_LastUpdateFrame; //Field offset: 0x74
	private List m_ValidMembers; //Field offset: 0x78
	private List m_MemberValidity; //Field offset: 0x80

	public private override Bounds BoundingBox
	{
		 get { } //Length: 134
		private set { } //Length: 18
	}

	private bool CachedCountIsValid
	{
		private get { } //Length: 99
	}

	public override bool IsEmpty
	{
		 get { } //Length: 156
	}

	public private override BoundingSphere Sphere
	{
		 get { } //Length: 124
		private set { } //Length: 8
	}

	public override Transform Transform
	{
		 get { } //Length: 78
	}

	public CinemachineTargetGroup() { }

	public void AddMember(Transform t, float weight, float radius) { }

	private Quaternion CalculateAverageOrientation() { }

	private Vector3 CalculateAveragePosition() { }

	private Bounds CalculateBoundingBox() { }

	private BoundingSphere CalculateBoundingSphere() { }

	public void DoUpdate() { }

	public int FindMember(Transform t) { }

	private void FixedUpdate() { }

	public override Bounds get_BoundingBox() { }

	private bool get_CachedCountIsValid() { }

	public override bool get_IsEmpty() { }

	public override BoundingSphere get_Sphere() { }

	public override Transform get_Transform() { }

	public override void GetViewSpaceAngularBounds(Matrix4x4 observer, out Vector2 minAngles, out Vector2 maxAngles, out Vector2 zRange) { }

	public override Bounds GetViewSpaceBoundingBox(Matrix4x4 observer) { }

	public BoundingSphere GetWeightedBoundsForMember(int index) { }

	private bool IndexIsValid(int index) { }

	private void LateUpdate() { }

	private void OnValidate() { }

	public void RemoveMember(Transform t) { }

	private void Reset() { }

	private void set_BoundingBox(Bounds value) { }

	private void set_Sphere(BoundingSphere value) { }

	private void Update() { }

	private void UpdateMemberValidity() { }

	private static BoundingSphere WeightedMemberBoundsForValidMember(ref Target t, Vector3 avgPos, float maxWeight) { }

}

