namespace UnityEngine;

[NativeHeader("Modules/Wind/Public/Wind.h")]
public class WindZone : Component
{

	public WindZoneMode mode
	{
		 get { } //Length: 78
	}

	public float windMain
	{
		 get { } //Length: 78
	}

	public float windPulseFrequency
	{
		 get { } //Length: 78
	}

	public float windPulseMagnitude
	{
		 get { } //Length: 78
	}

	public float windTurbulence
	{
		 get { } //Length: 78
	}

	public WindZoneMode get_mode() { }

	public float get_windMain() { }

	public float get_windPulseFrequency() { }

	public float get_windPulseMagnitude() { }

	public float get_windTurbulence() { }

}

