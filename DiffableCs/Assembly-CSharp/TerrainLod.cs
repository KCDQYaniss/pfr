//Type is in global namespace

[ExecuteInEditMode]
public class TerrainLod : MonoBehaviour
{
	[SerializeField]
	private Terrain _terrain; //Field offset: 0x20
	[SerializeField]
	private GameObject _terrainLod; //Field offset: 0x28
	private bool _disableTerrainDraw; //Field offset: 0x30
	private bool _disableTerrainTreesDraw; //Field offset: 0x31
	private bool _isVisible; //Field offset: 0x32

	public bool TerrainIsVisible
	{
		 get { } //Length: 5
		 set { } //Length: 300
	}

	public TerrainLod() { }

	public void DestroyLod() { }

	public bool get_TerrainIsVisible() { }

	public void set_TerrainIsVisible(bool value) { }

	public void SetSettings(bool disableTerrainDraw, bool disableTerrainTreesDraw) { }

}

