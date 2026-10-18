//Type is in global namespace

[Obsolete]
public class RoadsTerrainAligner : MonoBehaviour
{
	public Texture2D Heightmap; //Field offset: 0x20
	[SerializeField]
	private float _offsetFromMesh; //Field offset: 0x28
	[SerializeField]
	private float _raycastOffset; //Field offset: 0x2C
	[SerializeField]
	private float _raycastDistance; //Field offset: 0x30

	public RoadsTerrainAligner() { }

}

