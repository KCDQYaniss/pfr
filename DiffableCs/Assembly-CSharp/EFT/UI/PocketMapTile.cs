namespace EFT.UI;

public sealed class PocketMapTile : MonoBehaviour
{
	[SerializeField]
	private RawImage _image; //Field offset: 0x20
	private List _tileScaleVariants; //Field offset: 0x28
	private List _scales; //Field offset: 0x30
	private int _currentTileScaleVariant; //Field offset: 0x38
	private int _tileX; //Field offset: 0x3C
	private int _tileY; //Field offset: 0x40
	private Rect _screenRect; //Field offset: 0x44
	private IPocketMapBundleLoader _bundleLoader; //Field offset: 0x58

	public PocketMapTile() { }

	private void BundleLoaded(PocketMapConfig config) { }

	public void CheckForUpdate() { }

	public int GetCurrentTileScaleVariant() { }

	private int GetCurrentVariant() { }

	public RawImage GetImage() { }

	public void Init(List tileScaleVariants, Vector2 size, string objName, int x, int y, IPocketMapBundleLoader bundleLoader) { }

	private void LoadImage() { }

	private void OnDestroy() { }

	public void UnloadImage() { }

}

