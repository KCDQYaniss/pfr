namespace Koenigz.PerfectCulling.EFT;

public abstract class PerfectCullingCrossSceneContent : MonoBehaviour, IBakedLODDelegate
{
	public const int INVALID_CONTENT_GROUP_ID = -2147483648; //Field offset: 0x0
	[HideInInspector]
	[SerializeField]
	protected int _contentGroupId; //Field offset: 0x20
	[HideInInspector]
	[SerializeField]
	protected int _contentHash; //Field offset: 0x24
	[SerializeField]
	protected PerfectCullingBakeGroup[] _bakeGroups; //Field offset: 0x28
	[SerializeField]
	protected Vector2Int _indexSpan; //Field offset: 0x30
	[CompilerGenerated]
	private PerfectCullingCrossSceneGroup <RuntimeCullingGroup>k__BackingField; //Field offset: 0x38

	public PerfectCullingBakeGroup[] BakeGroups
	{
		 get { } //Length: 5
	}

	public int ContentGroupId
	{
		 get { } //Length: 4
	}

	public int ContentHash
	{
		 get { } //Length: 4
	}

	public Vector2Int IndexSpan
	{
		 get { } //Length: 76
	}

	public PerfectCullingCrossSceneGroup RuntimeCullingGroup
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	protected PerfectCullingCrossSceneContent() { }

	public PerfectCullingBakeGroup[] get_BakeGroups() { }

	public int get_ContentGroupId() { }

	public int get_ContentHash() { }

	public Vector2Int get_IndexSpan() { }

	[CompilerGenerated]
	public PerfectCullingCrossSceneGroup get_RuntimeCullingGroup() { }

	public override void OnBakedLODVisbilityChanged(ScreenDistanceSwitcher bakeLOD, bool isVisible) { }

	[CompilerGenerated]
	public void set_RuntimeCullingGroup(PerfectCullingCrossSceneGroup value) { }

}

