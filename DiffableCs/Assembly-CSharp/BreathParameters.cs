//Type is in global namespace

[CreateAssetMenu]
public class BreathParameters : ScriptableObject
{
	public AnimationCurve AmplitudeCurve; //Field offset: 0x18
	public AnimationCurve Delay; //Field offset: 0x20
	public AnimationCurve Hardness; //Field offset: 0x28

	public BreathParameters() { }

}

