//Type is in global namespace

public class WeaponTestController : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <AutoChangeBool>d__42 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public WeaponTestController <>4__this; //Field offset: 0x20
		public string name; //Field offset: 0x28
		public float time; //Field offset: 0x30

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <AutoChangeBool>d__42(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	public Animator Animator; //Field offset: 0x20
	public bool Active; //Field offset: 0x28
	public float AmmoInChamber; //Field offset: 0x2C
	public float AmmoInMag; //Field offset: 0x30
	public bool MagInWeapon; //Field offset: 0x34
	public bool Inventory; //Field offset: 0x35
	public float Idle; //Field offset: 0x38
	public bool Fire; //Field offset: 0x3C
	public int FireModes; //Field offset: 0x40
	private float FireMode; //Field offset: 0x44
	private int MagTypeOld; //Field offset: 0x48
	public int MagTypes; //Field offset: 0x4C
	private int MagTypeNew; //Field offset: 0x50
	private bool inv; //Field offset: 0x54
	public float IdleTime; //Field offset: 0x58
	public float IdleTimeMax; //Field offset: 0x5C
	public float IdleRandomValue; //Field offset: 0x60
	public float IdleRandomMin; //Field offset: 0x64
	public float IdleRandomMax; //Field offset: 0x68
	public List AltFireVars; //Field offset: 0x70
	public int CurrentAltFire; //Field offset: 0x78
	protected Dictionary LayerIntDict; //Field offset: 0x80

	public WeaponTestController() { }

	public void AddAmmoInChamber() { }

	public void AddAmmoInMag() { }

	public void Arm() { }

	[IteratorStateMachine(typeof(<AutoChangeBool>d__42))]
	private IEnumerator AutoChangeBool(string name, float time) { }

	public void DelAmmoChamber() { }

	public void DelAmmoFromMag() { }

	public void Disarm() { }

	public void FiremodeSwitch() { }

	public void FiringBullet() { }

	public void MagIn() { }

	public void MagOut() { }

	public void MagSwapEnd() { }

	public void MisfireOff() { }

	private int NameToAnimLayer(string name) { }

	public void NullShell() { }

	public void OffBoltCatch() { }

	public void OnBoltCatch() { }

	private void OnEnable() { }

	public void RemoveShell() { }

	public void ShellEject() { }

	private void Start() { }

	private void Update() { }

}

