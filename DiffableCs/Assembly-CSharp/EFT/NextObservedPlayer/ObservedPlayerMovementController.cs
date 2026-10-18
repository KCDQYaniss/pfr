namespace EFT.NextObservedPlayer;

public sealed class ObservedPlayerMovementController
{
	[CompilerGenerated]
	private ObservedPlayerMovementModel <Model>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly ObservedPlayerStateContext <ObservedPlayerStateContext>k__BackingField; //Field offset: 0xB0
	[CompilerGenerated]
	private readonly ObservedVaultingParameters <ObservedVaultingParameters>k__BackingField; //Field offset: 0xB8

	public private ObservedPlayerMovementModel Model
	{
		[CompilerGenerated]
		 get { } //Length: 112
		[CompilerGenerated]
		private set { } //Length: 109
	}

	public ObservedPlayerStateContext ObservedPlayerStateContext
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public ObservedVaultingParameters ObservedVaultingParameters
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public ObservedPlayerMovementController(IPlayerStateContainerBehaviour[] playerStates, ObservedPlayerStateContext context, ObservedPlayerMovementModel model) { }

	public void Apply(ObservedPlayerMovementModel nextModel) { }

	public void Execute(ICommandMessage command) { }

	[CompilerGenerated]
	public ObservedPlayerMovementModel get_Model() { }

	[CompilerGenerated]
	public ObservedPlayerStateContext get_ObservedPlayerStateContext() { }

	[CompilerGenerated]
	public ObservedVaultingParameters get_ObservedVaultingParameters() { }

	public void ManualUpdate() { }

	[CompilerGenerated]
	private void set_Model(ObservedPlayerMovementModel value) { }

	private void SpecificExecute(PhysicalParametersCommandMessage physicalParametersCommandMessage) { }

	private void SpecificExecute(DoorUnlockInteractionMessage doorInteractionMessage) { }

	private void SpecificExecute(DoorBreachInteractionMessage doorBreachInteractionMessage) { }

}

