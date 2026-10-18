//Type is in global namespace

[Obsolete]
public class Speed
{
	public float Forward; //Field offset: 0x10
	public float Side; //Field offset: 0x14
	public float Backward; //Field offset: 0x18

	public Speed(float forward, float side, float backward) { }

	public static Speed op_Multiply(Speed speed, float multiplier) { }

}

