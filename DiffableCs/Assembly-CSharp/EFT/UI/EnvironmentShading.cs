namespace EFT.UI;

public sealed class EnvironmentShading : SerializedMonoBehaviour
{
	private const float STANDARD_TRANSITION = 0.8; //Field offset: 0x0
	[SerializeField]
	private Dictionary _environmentShadings; //Field offset: 0x60
	private bool _currentVisibility; //Field offset: 0x68
	private CanvasGroup _currentShading; //Field offset: 0x70
	private EShadingType _currentShadingType; //Field offset: 0x78

	public EnvironmentShading() { }

	private static void DisableCanvasGroup(CanvasGroup canvasGroup) { }

	public void ResetShading() { }

	public void SetDefaultShading(CanvasGroup canvasGroup) { }

	public void SetShading(EShadingType type, bool force = false) { }

	public void SetShadingVisibility(bool visible, float duration = 0.8) { }

}

