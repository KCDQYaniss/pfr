namespace EFT.NextObservedPlayer;

public struct ObservedPlayerAnimatorModel
{
	private bool _jump; //Field offset: 0x0
	private bool _prone; //Field offset: 0x1
	private bool _sprint; //Field offset: 0x2
	private bool _inert; //Field offset: 0x3
	private bool _landing; //Field offset: 0x4
	private bool _proneReload; //Field offset: 0x5
	private bool _vault; //Field offset: 0x6
	private bool _climb; //Field offset: 0x7
	private float _blindFireFloat; //Field offset: 0x8

	public bool IsSprint
	{
		 get { } //Length: 5
	}

	public void Apply(PlayerAnimator animator) { }

	public void EnableClimb(bool value) { }

	public void EnableInert(bool value) { }

	public void EnableJump(bool value) { }

	public void EnableLanding(bool value) { }

	public void EnableProne(bool value) { }

	public void EnableProneReload(bool value) { }

	public void EnableSprint(bool value) { }

	public void EnableVault(bool value) { }

	public bool get_IsSprint() { }

	public void SetBlindFireFloat(float blindFireFloat) { }

}

