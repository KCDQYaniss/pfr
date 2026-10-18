namespace EFT.Interactive;

[Flags]
public enum EDoorState
{
	None = 0,
	Locked = 1,
	Shut = 2,
	Open = 4,
	Interacting = 8,
	Breaching = 16,
	Sealed = 32,
	SealingInteraction = 64,
	UnsealingInteraction = 128,
}

