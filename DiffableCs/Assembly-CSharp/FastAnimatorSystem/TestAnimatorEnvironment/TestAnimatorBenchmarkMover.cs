namespace FastAnimatorSystem.TestAnimatorEnvironment;

public class TestAnimatorBenchmarkMover : MonoBehaviour
{
	public TestAnimatorSkeleton fastSkeletonPrefab; //Field offset: 0x20
	public TestAnimatorSkeleton origSkeletonPrefab; //Field offset: 0x28
	public float speed; //Field offset: 0x30
	public float deltaTreshhold; //Field offset: 0x34
	public float actualDelta; //Field offset: 0x38
	public int spawnCount; //Field offset: 0x3C
	private int _directX; //Field offset: 0x40
	private int _directY; //Field offset: 0x44
	private int _inert; //Field offset: 0x48
	private int _isJumping; //Field offset: 0x4C
	private List _animators; //Field offset: 0x50
	private List _skeletons; //Field offset: 0x58
	private float _prevDirX; //Field offset: 0x60
	private float _prevDirY; //Field offset: 0x64

	public TestAnimatorBenchmarkMover() { }

	private void CreateAnimators(int count, TestAnimatorSkeleton skeletonPrefab) { }

	private void Update() { }

}

