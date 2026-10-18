//Type is in global namespace

[DefaultMember("Item")]
public class GripBlender : IWeaponGripPose
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__6_0; //Field offset: 0x8
		public static Func <>9__6_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal Quaternion <.ctor>b__6_0(Transform x) { }

		internal Quaternion <.ctor>b__6_1(Transform x) { }

	}

	public Quaternion[][] Fingers; //Field offset: 0x10
	private Transform _grip1Transform; //Field offset: 0x18
	private Transform _grip2Transform; //Field offset: 0x20
	private float _blendValue; //Field offset: 0x28
	public ValueBlender Blender; //Field offset: 0x30

	public override bool IsAlternative
	{
		 get { } //Length: 3
	}

	public override bool IsCached
	{
		 get { } //Length: 3
	}

	public override Quaternion Item
	{
		 get { } //Length: 358
		 set { } //Length: 62
	}

	public override Vector3 Position
	{
		 get { } //Length: 583
	}

	public override Quaternion Rotation
	{
		 get { } //Length: 597
	}

	public GripBlender(GripPose pose1, GripPose pose2, float blendSpeed, float blendDefault) { }

	public override bool get_IsAlternative() { }

	public override bool get_IsCached() { }

	public override Quaternion get_Item(int index) { }

	public override Vector3 get_Position() { }

	public override Quaternion get_Rotation() { }

	public override void set_Item(int index, Quaternion value) { }

	public void Update() { }

}

