namespace EFT.UI;

public sealed class UICanvasScaler : UIElement
{
	[SerializeField]
	private CanvasScaler _canvasScaler; //Field offset: 0x70
	private Action _settingsBinding; //Field offset: 0x78

	public UICanvasScaler() { }

	[CompilerGenerated]
	private void <OnEnable>b__2_0(EftDisplaySettings x) { }

	public virtual void Close() { }

	private void OnDisable() { }

	private void OnEnable() { }

	private void Register() { }

	private void Unregister() { }

}

