//Type is in global namespace

public class EffectorPose : ScriptableObject
{
	[UberDraw("Curve 240;Component 80;Intensity 120;AltIntensity 120", False)]
	public AnimVal[] Pos; //Field offset: 0x18
	[UberDraw("Curve 240;Component 80;Intensity 120;AltIntensity 120", False)]
	public AnimVal[] Rot; //Field offset: 0x20

	public EffectorPose() { }

}

