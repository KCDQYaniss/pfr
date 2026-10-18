namespace EFT.Interactive;

public class CommonTransportee : MonoBehaviour, IPlatformTransportee
{
	private Transform _parentTransform; //Field offset: 0x20
	[CompilerGenerated]
	private MovingPlatform <Platform>k__BackingField; //Field offset: 0x28

	public Transform ParentTransform
	{
		 get { } //Length: 280
		 set { } //Length: 82
	}

	public MovingPlatform Platform
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public CommonTransportee() { }

	public override void Board(MovingPlatform platform) { }

	public Transform get_ParentTransform() { }

	[CompilerGenerated]
	public MovingPlatform get_Platform() { }

	public override void GetOff(MovingPlatform platform) { }

	public void set_ParentTransform(Transform value) { }

	[CompilerGenerated]
	public void set_Platform(MovingPlatform value) { }

}

