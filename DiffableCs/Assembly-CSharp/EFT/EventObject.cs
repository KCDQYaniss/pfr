namespace EFT;

public class EventObject : MonoBehaviour
{
	internal enum EInteraction
	{
		Run = 0,
		Repair = 1,
	}

	internal enum EState
	{
		Disable = 0,
		Ready = 1,
		Running = 2,
		Broken = 3,
	}

	[SerializeField]
	private EventObjectTrigger _trigger; //Field offset: 0x20
	[SerializeField]
	private EventObjectInteractive _interactive; //Field offset: 0x28
	[SerializeField]
	private ulong[] _controlledLampGroupIDs; //Field offset: 0x30
	public BallisticCollider ballistics; //Field offset: 0x38
	public int id; //Field offset: 0x40
	[CompilerGenerated]
	private EState <State>k__BackingField; //Field offset: 0x44
	[CompilerGenerated]
	private RunddansController <Controller>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private bool <Handled>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	private Action OnStateChanged; //Field offset: 0x58
	private float _secToBreak; //Field offset: 0x60
	private float _durability; //Field offset: 0x64
	private int _lastHitFrame; //Field offset: 0x68
	private DateTime _dateTime; //Field offset: 0x70
	[CompilerGenerated]
	private Action OnFinish; //Field offset: 0x78

	public event Action OnFinish
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public event Action OnStateChanged
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public RunddansController Controller
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public bool Handled
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public bool InProgress
	{
		 get { } //Length: 211
	}

	private bool IsVulnerable
	{
		private get { } //Length: 22
	}

	public private EState State
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public EventObject() { }

	[CompilerGenerated]
	public void add_OnFinish(Action value) { }

	[CompilerGenerated]
	public void add_OnStateChanged(Action value) { }

	public void ExplosionCheck(IExplosiveItem grenadeItem, in Vector3 grenadePosition) { }

	private void FixedUpdate() { }

	[CompilerGenerated]
	public RunddansController get_Controller() { }

	[CompilerGenerated]
	public bool get_Handled() { }

	public bool get_InProgress() { }

	private bool get_IsVulnerable() { }

	[CompilerGenerated]
	public EState get_State() { }

	private static string GetStateText(EState state) { }

	private void Hit(DamageInfo damageInfo) { }

	private void OnDisable() { }

	private void OnEnable() { }

	[CompilerGenerated]
	public void remove_OnFinish(Action value) { }

	[CompilerGenerated]
	public void remove_OnStateChanged(Action value) { }

	[CompilerGenerated]
	public void set_Controller(RunddansController value) { }

	[CompilerGenerated]
	public void set_Handled(bool value) { }

	[CompilerGenerated]
	private void set_State(EState value) { }

	public void SetState(EState state) { }

	public void SetTime(ICollection points) { }

	public void ShowPanel() { }

	private void TurnLamps(bool state) { }

}

