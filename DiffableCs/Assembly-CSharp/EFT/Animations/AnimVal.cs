namespace EFT.Animations;

public class AnimVal
{
	public AnimationCurve Curve; //Field offset: 0x10
	public float TimeShift; //Field offset: 0x18
	[UberDraw("To 160;Component 100;Intensity 100", False)]
	public Val[] Vals; //Field offset: 0x20

	public AnimVal() { }

}

