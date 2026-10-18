//Type is in global namespace

public interface ITODSky
{

	public TOD_AtmosphereParameters Atmosphere
	{
		 get { } //Length: 0
	}

	public float ClearSky
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public TOD_Time CurrentTime
	{
		 get { } //Length: 0
	}

	public TOD_CycleParameters Cycle
	{
		 get { } //Length: 0
	}

	public float ForceIndoor
	{
		 get { } //Length: 0
	}

	public bool IsDay
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public bool IsNight
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public Light LightObject
	{
		 get { } //Length: 0
	}

	public Vector3 SunDirection
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public float SunVisibility
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public float UpdateInterval
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public TOD_AtmosphereParameters get_Atmosphere() { }

	public float get_ClearSky() { }

	public TOD_Time get_CurrentTime() { }

	public TOD_CycleParameters get_Cycle() { }

	public float get_ForceIndoor() { }

	public bool get_IsDay() { }

	public bool get_IsNight() { }

	public Light get_LightObject() { }

	public Vector3 get_SunDirection() { }

	public float get_SunVisibility() { }

	public float get_UpdateInterval() { }

	public void Initialize() { }

	public Vector3 LightDirectionExtrapolated(float addTime) { }

	public void set_ClearSky(float value) { }

	public void set_IsDay(bool value) { }

	public void set_IsNight(bool value) { }

	public void set_SunDirection(Vector3 value) { }

	public void set_SunVisibility(float value) { }

	public void set_UpdateInterval(float value) { }

}

