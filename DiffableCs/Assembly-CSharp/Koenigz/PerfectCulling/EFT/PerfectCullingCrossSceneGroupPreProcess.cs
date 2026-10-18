namespace Koenigz.PerfectCulling.EFT;

[DisallowMultipleComponent]
[RequireComponent(typeof(PerfectCullingCrossSceneGroup))]
public abstract class PerfectCullingCrossSceneGroupPreProcess : MonoBehaviour
{
	internal enum RenderMode
	{
		TriangleFill = 0,
		Wireframe = 1,
	}


	public PerfectCullingCrossSceneGroup Group
	{
		 get { } //Length: 62
	}

	protected PerfectCullingCrossSceneGroupPreProcess() { }

	public override PerfectCullingBakeGroup[] CollectBakeGroups() { }

	public override BakeBatch[] CreateBakeBatches(PerfectCullingBakeGroup[] inputGroups) { }

	public override SharedOccluder GenerateSharedOccluder() { }

	public PerfectCullingCrossSceneGroup get_Group() { }

	public override BakeBatch[] GetBakeBatches() { }

	public override int GetBakeHash() { }

	public override int GetBakeResolution() { }

	public override RenderMode GetGroupRenderMode() { }

	public override LODGroup[] GetLODGroups() { }

	public override void OnBeginContentCollect() { }

	public override void OnEndContentCollect() { }

	public override PerfectCullingBakeGroup[] PrebakeTransform(BakeBatch batch, ICollection tempObjects, out Mode writeMode) { }

	public override PerfectCullingBakeGroup[] PrepareRuntimeContent() { }

	public override void RemapBatchResult(BakeBatch sourceBatch, SamplingTask task) { }

}

