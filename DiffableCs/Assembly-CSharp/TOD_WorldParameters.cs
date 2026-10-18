//Type is in global namespace

public class TOD_WorldParameters
{
	[Range(-90, 90)]
	[Tooltip("Latitude of the current location in degrees.")]
	public float Latitude; //Field offset: 0x10
	[Range(-180, 180)]
	[Tooltip("Longitude of the current location in degrees.")]
	public float Longitude; //Field offset: 0x14
	[Range(-14, 14)]
	[Tooltip("UTC/GMT time zone of the current location in hours.")]
	public float UTC; //Field offset: 0x18

	public TOD_WorldParameters() { }

}

