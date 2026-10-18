namespace EFT.HealthSystem;

public interface IBaseHealthController
{

	public ValueStruct Energy
	{
		 get { } //Length: 0
	}

	public ValueStruct Hydration
	{
		 get { } //Length: 0
	}

	public ValueStruct Poison
	{
		 get { } //Length: 0
	}

	public ValueStruct Temperature
	{
		 get { } //Length: 0
	}

	public ValueStruct get_Energy() { }

	public ValueStruct get_Hydration() { }

	public ValueStruct get_Poison() { }

	public ValueStruct get_Temperature() { }

	public ValueStruct GetBodyPartHealth(EBodyPart bodyPart, bool rounded = false) { }

}

