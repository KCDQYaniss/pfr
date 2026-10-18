namespace EFT.NextObservedPlayer.Operations;

public class ExamineWeaponHandsOperation : BaseHandsOperation
{

	public ExamineWeaponHandsOperation() { }

	public static ExamineWeaponHandsOperation CreateInstance() { }

	public virtual void FastForward() { }

	private void SetMalfunctionStateForCorrectLook(bool misfireUnknown) { }

	public virtual IHandsOperationResult Start(ExamineWeaponCommandMessage input) { }

}

