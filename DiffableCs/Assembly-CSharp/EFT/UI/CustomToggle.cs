namespace EFT.UI;

public class CustomToggle : Toggle
{
	public Graphic graphicDisabled; //Field offset: 0x128

	public CustomToggle() { }

	protected virtual void Awake() { }

	private void OnValueChanged(bool value) { }

}

