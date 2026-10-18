namespace EFT.Weather;

public interface IWeatherCurve
{

	public float Cloudiness
	{
		 get { } //Length: 0
	}

	public float CurrentNormalizedTimeValue
	{
		 get { } //Length: 0
	}

	public float Fog
	{
		 get { } //Length: 0
	}

	public float LightningThunderProbability
	{
		 get { } //Length: 0
	}

	public float Rain
	{
		 get { } //Length: 0
	}

	public float Temperature
	{
		 get { } //Length: 0
	}

	public Vector2 TopWind
	{
		 get { } //Length: 0
	}

	public Vector2 Wind
	{
		 get { } //Length: 0
	}

	public float get_Cloudiness() { }

	public float get_CurrentNormalizedTimeValue() { }

	public float get_Fog() { }

	public float get_LightningThunderProbability() { }

	public float get_Rain() { }

	public float get_Temperature() { }

	public Vector2 get_TopWind() { }

	public Vector2 get_Wind() { }

}

