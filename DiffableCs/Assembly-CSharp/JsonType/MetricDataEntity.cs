namespace JsonType;

public class MetricDataEntity
{
	public double date; //Field offset: 0x10
	public int placed; //Field offset: 0x18
	public int sold; //Field offset: 0x1C
	public int expired; //Field offset: 0x20

	public DateTime DateTime
	{
		 get { } //Length: 93
	}

	public MetricDataEntity() { }

	public DateTime get_DateTime() { }

}

