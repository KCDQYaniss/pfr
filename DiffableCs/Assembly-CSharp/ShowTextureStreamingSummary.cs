//Type is in global namespace

public class ShowTextureStreamingSummary : MonoBehaviour
{
	public float X; //Field offset: 0x20
	public float Y; //Field offset: 0x24
	public int MemoryBudgetPercentThreshold; //Field offset: 0x28
	public int TextureStreamingPercentThreshold; //Field offset: 0x2C
	private ulong HighestDesiredTextureMemory; //Field offset: 0x30
	private Rect TextRect; //Field offset: 0x38

	public ShowTextureStreamingSummary() { }

	public string HumanReadableSize(ulong size) { }

	public void OnGUI() { }

	private void ShowText(string text) { }

	public void Start() { }

}

