namespace Koenigz.PerfectCulling;

public class PerfectCullingExcludeVolume : MonoBehaviour, IResizableByHandle
{
	private static readonly Bounds UniformBounds; //Field offset: 0x0
	[SerializeField]
	public Vector3 volumeSize; //Field offset: 0x20
	[SerializeField]
	public PerfectCullingBakingBehaviour[] restrictToBehaviours; //Field offset: 0x30

	public override Vector3 HandleSized
	{
		 get { } //Length: 81
		 set { } //Length: 551
	}

	public Bounds volumeExcludeBounds
	{
		 get { } //Length: 274
		 set { } //Length: 284
	}

	private static PerfectCullingExcludeVolume() { }

	public PerfectCullingExcludeVolume() { }

	public override Vector3 get_HandleSized() { }

	public Bounds get_volumeExcludeBounds() { }

	public bool IsPositionActive(PerfectCullingBakingBehaviour bakingBehaviour, Vector3 pos) { }

	public override void set_HandleSized(Vector3 value) { }

	public void set_volumeExcludeBounds(Bounds value) { }

}

