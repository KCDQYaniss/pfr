namespace EFT.NextObservedPlayer;

public class ObservedPlayerArmorInfoController
{
	[CompilerGenerated]
	private readonly Dictionary <ObservedPlayerArmors>k__BackingField; //Field offset: 0x10

	public Dictionary ObservedPlayerArmors
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public ObservedPlayerArmorInfoController() { }

	private void ApplyChangeArmorCommand(ArmorFullChangeInfoCommandMessage armorInfoCommandMessage) { }

	private void ApplyChangeArmorDurabilityCommand(ArmorDurabilityChangedCommandMessage armorDurabilityChangedCommandMessage) { }

	public void Execute(ICommandMessage command) { }

	[CompilerGenerated]
	public Dictionary get_ObservedPlayerArmors() { }

	public void Initialize(ObservedPlayerSpawnMessage spawnMessage) { }

}

