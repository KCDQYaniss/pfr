namespace EFT.Hideout;

public sealed class CustomPrefabPanel : AbstractPanel
{
	private UIElement _instantiatedPanelPrefab; //Field offset: 0xA8

	public CustomPrefabPanel() { }

	public virtual void Close() { }

	public virtual void SetInfo() { }

	public virtual Task ShowContents() { }

}

