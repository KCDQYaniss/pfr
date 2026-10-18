//Type is in global namespace

public class MotionEffectorParameters : ScriptableObject
{
	public float AccSmooth; //Field offset: 0x18
	public float VelSmooth; //Field offset: 0x1C
	public AnimationCurve Magnitude; //Field offset: 0x20
	public Val[] Vals; //Field offset: 0x28

	public MotionEffectorParameters() { }

}

