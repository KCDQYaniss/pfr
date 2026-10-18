namespace Koenigz.PerfectCulling.EFT;

public sealed class LightParameters
{
	public Vector3 lightPosition; //Field offset: 0x10
	public Vector3 lightPositionOffset; //Field offset: 0x1C
	public float range; //Field offset: 0x28
	public float angle; //Field offset: 0x2C
	public Vector3 dir; //Field offset: 0x30
	public LayerMask raycastMask; //Field offset: 0x3C
	public LightMeshQuality bakeMeshQuality; //Field offset: 0x40
	public LightType lightType; //Field offset: 0x44
	public bool hitBackFaces; //Field offset: 0x48
	public bool applyRandomColor; //Field offset: 0x49
	public float raycastOffset; //Field offset: 0x4C
	public float rangeModifier; //Field offset: 0x50

	public LightParameters() { }

}

