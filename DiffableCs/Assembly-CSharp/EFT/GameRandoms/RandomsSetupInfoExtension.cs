namespace EFT.GameRandoms;

[Extension]
public static class RandomsSetupInfoExtension
{

	[Extension]
	public static void Deserialize(RandomsSetupInfo setupInfo, NetworkReader reader) { }

	[Extension]
	public static void Serialize(RandomsSetupInfo setupInfo, NetworkWriter writer) { }

}

