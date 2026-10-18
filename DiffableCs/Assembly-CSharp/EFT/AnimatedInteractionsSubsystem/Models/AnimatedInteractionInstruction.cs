namespace EFT.AnimatedInteractionsSubsystem.Models;

public struct AnimatedInteractionInstruction
{
	public EInteraction Interaction; //Field offset: 0x0
	public bool IsOperation; //Field offset: 0x1
	public bool Forced; //Field offset: 0x2
	public bool ResetQueue; //Field offset: 0x3
	public bool PlayImmediately; //Field offset: 0x4
	public bool DenySchedule; //Field offset: 0x5

}

