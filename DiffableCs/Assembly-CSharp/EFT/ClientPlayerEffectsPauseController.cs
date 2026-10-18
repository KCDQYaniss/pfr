namespace EFT;

public class ClientPlayerEffectsPauseController : PlayerEffectsPauseController
{
	private static ClientPlayerEffectsPauseController _instance; //Field offset: 0x0
	private EPhysicalCondition _pausedPhysicalConditions; //Field offset: 0x10

	public static ClientPlayerEffectsPauseController Instance
	{
		 get { } //Length: 183
	}

	public ClientPlayerEffectsPauseController() { }

	public static ClientPlayerEffectsPauseController get_Instance() { }

	public void PauseEffects() { }

	public void UnpauseEffects() { }

}

