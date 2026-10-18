//Type is in global namespace

public class ExternalTerrainCollider : MonoBehaviour
{
	public Terrain Terrain; //Field offset: 0x20
	[Range(2, 2048)]
	public int GridX; //Field offset: 0x28
	[Range(2, 2048)]
	public int GridY; //Field offset: 0x2C

	public ExternalTerrainCollider() { }

}

