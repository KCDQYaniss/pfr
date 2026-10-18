//Type is in global namespace

public abstract class BotAbstractMeds : BotData
{
	protected List _medsList; //Field offset: 0x18
	protected Action _callback; //Field offset: 0x20
	protected float _nextPosibleUseTime; //Field offset: 0x28
	private bool _using; //Field offset: 0x2C
	private bool _lastIsCanceled; //Field offset: 0x2D

	public bool Using
	{
		 get { } //Length: 17
		 set { } //Length: 36
	}

	protected BotAbstractMeds(BotOwner owner, Action callback) { }

	public override void Activate() { }

	public void CancelCurrent() { }

	public override void Dispose() { }

	public bool get_Using() { }

	private void OnBeingHitAction(DamageInfo arg1, EBodyPart arg2, float arg3) { }

	public void set_Using(bool value) { }

}

