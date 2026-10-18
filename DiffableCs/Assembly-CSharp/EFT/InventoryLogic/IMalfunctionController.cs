namespace EFT.InventoryLogic;

public interface IMalfunctionController
{

	public event Action ExamineMalfunctionEvent
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	[CompilerGenerated]
	public void add_ExamineMalfunctionEvent(Action value) { }

	public void CallMalfunctionRepaired(Weapon weapon) { }

	public void CallUnknownMalfunctionStartRepair(Weapon weapon) { }

	public void ExamineMalfunction(Weapon weapon, bool clearRest = false) { }

	public void ExamineMalfunctionType(Weapon weapon) { }

	public bool HasKnownMalfType(Weapon weapon) { }

	public bool HasKnownMalfunction(Weapon weapon) { }

	[CompilerGenerated]
	public void remove_ExamineMalfunctionEvent(Action value) { }

}

