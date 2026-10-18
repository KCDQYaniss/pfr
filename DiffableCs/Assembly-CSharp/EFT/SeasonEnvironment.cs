namespace EFT;

public class SeasonEnvironment : MonoBehaviour
{
	public ESeason[] EnabledOnSeasons; //Field offset: 0x20

	public SeasonEnvironment() { }

	public bool IsMatch(ESeason season) { }

}

