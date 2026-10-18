namespace EFT.Interactive;

public interface ILightSwitcher
{

	public bool Enabled
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public bool get_Enabled() { }

	public void set_Enabled(bool value) { }

	public void Switch(EState switchTo) { }

	public void TurnOff() { }

	public void TurnOn() { }

}

