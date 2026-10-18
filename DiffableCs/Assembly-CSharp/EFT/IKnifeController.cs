namespace EFT;

public interface IKnifeController : IWeaponController, IHandsController, ICompassController
{

	public Action ComboPlanning
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public KnifeComponent Knife
	{
		 get { } //Length: 0
	}

	public Action OnAttackEnd
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public void BrakeCombo() { }

	public void ContinueCombo() { }

	public void ExamineWeapon() { }

	public Action get_ComboPlanning() { }

	public KnifeComponent get_Knife() { }

	public Action get_OnAttackEnd() { }

	public bool MakeAlternativeKick() { }

	public bool MakeKnifeKick() { }

	public void set_ComboPlanning(Action value) { }

	public void set_OnAttackEnd(Action value) { }

	public void SetBotParameters() { }

}

