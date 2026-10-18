namespace Koenigz.PerfectCulling.EFT;

public sealed class MultisceneSharedOccluder : MonoBehaviour
{
	[SerializeField]
	[Tooltip("Culling type.\n\nSharedOccluder\n-> not culled\n-> occludes in other scenes\n\nSharedOccludeeOccluder\n-> culled in volume\n-> occludes in other scenes\n\nOccludee\n-> culled in volume\n-> doesnt occlude in other scenes")]
	private EOccludeMode _occludeMode; //Field offset: 0x20
	[SerializeField]
	[Tooltip("Which LOD to select when generating multiscene shared occluder")]
	private ESharedOccluderLODMode _LODMode; //Field offset: 0x24
	[SerializeField]
	[Tooltip("Shadow culling mode on runtime")]
	private EShadowMode _shadowMode; //Field offset: 0x28
	[SerializeField]
	[Tooltip("How to treat transprent materials when generating shared occluder")]
	private ETransparencyMode _transparencyMode; //Field offset: 0x2C

	public EOccludeMode OccludeMode
	{
		 get { } //Length: 4
	}

	public EShadowMode ShadowMode
	{
		 get { } //Length: 4
	}

	public ESharedOccluderLODMode SharedOccluderLODMode
	{
		 get { } //Length: 4
	}

	public ETransparencyMode TransparencyMode
	{
		 get { } //Length: 4
	}

	public MultisceneSharedOccluder() { }

	public EOccludeMode get_OccludeMode() { }

	public EShadowMode get_ShadowMode() { }

	public ESharedOccluderLODMode get_SharedOccluderLODMode() { }

	public ETransparencyMode get_TransparencyMode() { }

}

