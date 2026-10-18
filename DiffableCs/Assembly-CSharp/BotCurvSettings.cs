//Type is in global namespace

public class BotCurvSettings : ScriptableObject
{
	private static BotCurvSettings _instance; //Field offset: 0x0
	public AnimationCurve NightVisionSettings; //Field offset: 0x18
	public AnimationCurve StandartVisionSettings; //Field offset: 0x20
	public AnimationCurve VisionAngCoef; //Field offset: 0x28
	public AnimationCurve AimTime2Dist; //Field offset: 0x30
	public AnimationCurve AimAngCoef; //Field offset: 0x38
	public AnimationCurve AgsAimUp; //Field offset: 0x40
	public AnimationCurve MoveStartCurv; //Field offset: 0x48

	public static BotCurvSettings Instance
	{
		 get { } //Length: 217
	}

	public BotCurvSettings() { }

	public BotCurvSettings Copy() { }

	public static BotCurvSettings get_Instance() { }

}

