//Type is in global namespace

[ExecuteInEditMode]
public class PlaceAndScreenObject : MonoBehaviour
{
	private List _objectAngles; //Field offset: 0x20
	private GameObject _instance; //Field offset: 0x28
	[SerializeField]
	private Camera _camera; //Field offset: 0x30

	public PlaceAndScreenObject() { }

	public void ClearScene() { }

	public void Init(List screenshotAngles) { }

	public void PlaceObject(GameObject prefab) { }

	public string TakeScreenshot(string filePath, int texWidth, int texHeight) { }

	private void TakeScreenshotInternal(string filePath, int texWidth, int texHeight) { }

}

