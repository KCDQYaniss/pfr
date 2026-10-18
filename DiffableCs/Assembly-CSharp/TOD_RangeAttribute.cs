//Type is in global namespace

public class TOD_RangeAttribute : PropertyAttribute
{
	public float min; //Field offset: 0x18
	public float max; //Field offset: 0x1C

	public TOD_RangeAttribute(float min, float max) { }

}

