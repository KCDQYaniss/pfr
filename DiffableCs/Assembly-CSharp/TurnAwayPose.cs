//Type is in global namespace

public class TurnAwayPose : ScriptableObject
{
	[Header("Order: Intensity FP, Intensity TP")]
	[UberDraw("Curve 240;Component 40;Intensity 90;Intensity1 90;AltIntensity 90;AltIntensity1 90", False)]
	public AnimVal[] Pos; //Field offset: 0x18
	[UberDraw("Curve 240;Component 40;Intensity 90;Intensity1 90;AltIntensity 90;AltIntensity1 90", False)]
	public AnimVal[] Rot; //Field offset: 0x20

	public TurnAwayPose() { }

}

