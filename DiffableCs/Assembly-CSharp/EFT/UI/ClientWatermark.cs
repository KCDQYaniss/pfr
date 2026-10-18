namespace EFT.UI;

public sealed class ClientWatermark : UIElement
{
	private const float MOVEMENT_DELAY = 4; //Field offset: 0x0
	[SerializeField]
	private TextMeshProUGUI _label; //Field offset: 0x70
	private Profile _profile; //Field offset: 0x78
	private Coroutine _watermarkCoroutine; //Field offset: 0x80

	public ClientWatermark() { }

	private static Vector2 GetRandomScreenPoint(int screenHeight, int screenWidth, int rectHeight, int rectWidth) { }

	public void Show(Profile profile) { }

	private void StartRandomWatermarkPlacement() { }

	public void Stop() { }

}

