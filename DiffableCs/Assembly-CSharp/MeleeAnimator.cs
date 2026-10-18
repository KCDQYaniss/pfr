//Type is in global namespace

public class MeleeAnimator : ObjectInHandsAnimator
{
	[CompilerGenerated]
	private Action FireEvent; //Field offset: 0x38

	public event Action FireEvent
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public MeleeAnimator() { }

	[CompilerGenerated]
	public void add_FireEvent(Action value) { }

	public void AltFire() { }

	public void Fire() { }

	public void QuickFire() { }

	[CompilerGenerated]
	public void remove_FireEvent(Action value) { }

	public void SetActive(bool active) { }

	public void SetAltFire(bool altFire) { }

	public void SetFire(bool fire) { }

	public void SetFireVar(int fireVarCount) { }

	public void SetIdleVar(float idleVar) { }

}

