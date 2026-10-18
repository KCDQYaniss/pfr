namespace EFT;

public class ObservedPlayerLeftStanceController : LeftStanceController
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action <>9__0_0; //Field offset: 0x8
		public static Action <>9__0_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal void <.ctor>b__0_0(bool x) { }

		internal void <.ctor>b__0_1() { }

	}

	private bool _leftStance; //Field offset: 0x40
	private bool _lastAnimValue; //Field offset: 0x41
	private Action _setLeftStanceFromPacket; //Field offset: 0x48
	private bool _blockLeftStance; //Field offset: 0x50
	private bool _wantedLeftStanceFromPacket; //Field offset: 0x51

	public virtual bool LastAnimValue
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public virtual bool LeftStance
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public bool WantedLeftStanceFromPacket
	{
		 get { } //Length: 5
	}

	public ObservedPlayerLeftStanceController(Action setLeftStanceFromPacket, Func canSetAnimatorLeftStanceToCacheValue) { }

	public virtual bool get_LastAnimValue() { }

	public virtual bool get_LeftStance() { }

	public bool get_WantedLeftStanceFromPacket() { }

	protected virtual void set_LastAnimValue(bool value) { }

	protected virtual void set_LeftStance(bool value) { }

	public void SetLeftStanceInAnimatorFromPacket(bool inLeftStance) { }

	public void ToggleBlockLeftStance(bool blockLeftStance) { }

}

