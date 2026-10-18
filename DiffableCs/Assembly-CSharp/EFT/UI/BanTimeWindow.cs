namespace EFT.UI;

public sealed class BanTimeWindow : DialogWindow
{
	[SerializeField]
	private SelectSlider _selectSlider; //Field offset: 0xD8
	private Action _acceptBanAction; //Field offset: 0xE0

	public BanTimeWindow() { }

	[CompilerGenerated]
	private void <Awake>b__2_0() { }

	protected virtual void Awake() { }

	public DialogWindowContext Show(string[] notches, Action acceptAction) { }

}

