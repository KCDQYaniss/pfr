namespace EFT.Hideout;

public sealed class ChangeLightButton : ComplementaryButton
{
	[SerializeField]
	private ChangeLightPanel _changeLightPanel; //Field offset: 0x138
	[SerializeField]
	private Image _trigger; //Field offset: 0x140

	public ChangeLightButton() { }

	[CompilerGenerated]
	private void <Show>b__2_0() { }

	[CompilerGenerated]
	private void <Show>b__2_1(bool arg) { }

	[CompilerGenerated]
	private void <Show>b__2_2(PointerEventData arg) { }

	[CompilerGenerated]
	private void <Show>b__2_3() { }

	private void ButtonSelectedHandler(Sprite sprite) { }

	public virtual void Close() { }

	private void CloseChangeLightPanel() { }

	public virtual void SetSelectedStatus(bool selected) { }

	public void Show() { }

}

