namespace EFT.Hideout;

public sealed class LightLevel : SerializedMonoBehaviour
{
	[SerializeField]
	private List _lightSwitchers; //Field offset: 0x60

	public bool Enabled
	{
		 set { } //Length: 370
	}

	public LightLevel() { }

	public void set_Enabled(bool value) { }

}

