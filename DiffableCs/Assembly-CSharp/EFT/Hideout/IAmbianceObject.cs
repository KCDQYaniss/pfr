namespace EFT.Hideout;

public interface IAmbianceObject
{

	public EAreaType AreaType
	{
		 get { } //Length: 0
	}

	public EAreaType get_AreaType() { }

	public void Init(AreaTemplate areaTemplate) { }

	public Task PerformInteraction(ELightStatus status) { }

}

