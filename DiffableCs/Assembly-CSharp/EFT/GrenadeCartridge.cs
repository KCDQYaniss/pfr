namespace EFT;

public class GrenadeCartridge : Throwable
{
	internal sealed class GrenadeCartridgeBlowUp : MulticastDelegate
	{

		public GrenadeCartridgeBlowUp(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(Player player, Ammo grenade, Item weapon, Vector3 position, GrenadeCartridge grenadeCartridge, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(Player player, Ammo grenade, Item weapon, Vector3 position, GrenadeCartridge grenadeCartridge) { }

	}

	private const float INITIAL_SPEED = 76; //Field offset: 0x0
	private Player _player; //Field offset: 0x80
	private Ammo _grenadeAmmo; //Field offset: 0x88
	private Item _weapon; //Field offset: 0x90
	[CompilerGenerated]
	private GrenadeCartridgeBlowUp BlowUpEvent; //Field offset: 0x98
	private bool _canBlowUp; //Field offset: 0xA0
	private WeaponSounds _soundsPrefab; //Field offset: 0xA8

	public event GrenadeCartridgeBlowUp BlowUpEvent
	{
		[CompilerGenerated]
		 add { } //Length: 251
		[CompilerGenerated]
		 remove { } //Length: 251
	}

	public virtual bool HasNetData
	{
		 get { } //Length: 3
	}

	public virtual int Id
	{
		 get { } //Length: 106
	}

	public GrenadeCartridge() { }

	[CompilerGenerated]
	public void add_BlowUpEvent(GrenadeCartridgeBlowUp value) { }

	private void Awake() { }

	private void BlowUp() { }

	public virtual bool get_HasNetData() { }

	public virtual int get_Id() { }

	public void Init(Player player, Ammo grenadeCartridgeAmmo, Item weapon) { }

	public void Launch() { }

	private void OnCollisionEnter(Collision collision) { }

	[CompilerGenerated]
	public void remove_BlowUpEvent(GrenadeCartridgeBlowUp value) { }

	private void Update() { }

}

