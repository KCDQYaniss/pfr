namespace Koenigz.PerfectCulling.EFT;

[RequireComponent(typeof(PerfectCullingLightGroupPreProcess))]
public sealed class LightVolumeSettings : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass8_0
	{
		public CullingObject light; //Field offset: 0x10

		public <>c__DisplayClass8_0() { }

		internal bool <GetLightSettings>b__0(LightSettings x) { }

	}

	internal sealed class LightSettings
	{
		public CullingObject LightObject; //Field offset: 0x10
		public Vector3 Offset; //Field offset: 0x18
		public Quaternion Rotation; //Field offset: 0x24
		public LightMeshQuality MeshQuality; //Field offset: 0x34
		public float RangeModifier; //Field offset: 0x38
		public float CollisionMargin; //Field offset: 0x3C
		public float SpotAngleModifier; //Field offset: 0x40
		public LayerMask RaycastMask; //Field offset: 0x44
		public SerializedMesh SerializedLightVolumeMesh; //Field offset: 0x48

		public LightSettings() { }

	}

	internal sealed class SerializedMesh
	{
		public Vector3[] Vertices; //Field offset: 0x10
		public int[] Triangles; //Field offset: 0x18

		public SerializedMesh() { }

		public Mesh CreateMesh() { }

	}

	public const int DEFAULT_VOLUME_MESH_RAYCAST_MASK = 264192; //Field offset: 0x0
	[SerializeField]
	private LayerMask _raycastMask; //Field offset: 0x20
	[SerializeField]
	private List _lightParameters; //Field offset: 0x28

	public IReadOnlyCollection LightBakeParameters
	{
		 get { } //Length: 5
	}

	public LightVolumeSettings() { }

	public static LightVolumeSettings Get(CullingObject cullingObject) { }

	public IReadOnlyCollection get_LightBakeParameters() { }

	public LightSettings GetLightSettings(CullingObject light) { }

}

