//Type is in global namespace

[DefaultMember("Item")]
public class GripPose : MonoBehaviour, IWeaponGripPose
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__19_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal Quaternion <CacheAndDestroy>b__19_0(Transform x) { }

	}

	internal enum EGripType
	{
		Common = 0,
		Alternative = 1,
		UnderbarrelWeapon = 2,
	}

	internal enum EHand
	{
		Left = 0,
		Right = 1,
	}

	[EnumBitMask(typeof(EDoorState))]
	public EDoorState DoorState; //Field offset: 0x20
	public EHand Hand; //Field offset: 0x24
	public EGripType GripType; //Field offset: 0x28
	public Transform[] FingerTransforms; //Field offset: 0x30
	public Quaternion[] Fingers; //Field offset: 0x38
	public bool DontCache; //Field offset: 0x40
	[SerializeField]
	private bool _cached; //Field offset: 0x41

	public override bool IsAlternative
	{
		 get { } //Length: 8
	}

	public override bool IsCached
	{
		 get { } //Length: 5
	}

	public override Quaternion Item
	{
		 get { } //Length: 211
		 set { } //Length: 62
	}

	public override Vector3 Position
	{
		 get { } //Length: 204
		 set { } //Length: 190
	}

	public override Quaternion Rotation
	{
		 get { } //Length: 192
	}

	public GripPose() { }

	public override void Awake() { }

	public override void CacheAndDestroy() { }

	public override bool get_IsAlternative() { }

	public override bool get_IsCached() { }

	public override Quaternion get_Item(int index) { }

	public override Vector3 get_Position() { }

	public override Quaternion get_Rotation() { }

	public override void set_Item(int index, Quaternion value) { }

	public void set_Position(Vector3 value) { }

}

