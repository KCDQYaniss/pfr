namespace GPUInstancer;

public class GPUInstancerGUIInfo : MonoBehaviour
{
	private static List singlesList; //Field offset: 0x0
	public bool showRenderedAmount; //Field offset: 0x20
	public bool showPrototypesSeparate; //Field offset: 0x21
	public bool showPrefabManagers; //Field offset: 0x22
	public bool showDetailManagers; //Field offset: 0x23
	public bool showTreeManagers; //Field offset: 0x24

	private static GPUInstancerGUIInfo() { }

	public GPUInstancerGUIInfo() { }

	private static void DebugOnManagerGUI(string name, List runtimeDataList, bool showRenderedAmount, int startPos, int enabledCount) { }

	private static string GetRenderedAmountsGUITextFromArgs(List runtimeData, bool isShadow = false) { }

	private void OnDisable() { }

	private void OnGUI() { }

}

