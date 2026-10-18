//Type is in global namespace

[Obsolete]
public class AnimatorEventReceiver : MonoBehaviour
{
	[CompilerGenerated]
	private Action OnFire; //Field offset: 0x20
	[CompilerGenerated]
	private Action OnChangeFireMode; //Field offset: 0x28
	[CompilerGenerated]
	private Action OnDelAmmoChamber; //Field offset: 0x30
	[CompilerGenerated]
	private Action OnDelAmmoFromMag; //Field offset: 0x38
	[CompilerGenerated]
	private Action OnShellEject; //Field offset: 0x40
	[CompilerGenerated]
	private Action OnAddAmmoInChamber; //Field offset: 0x48
	[CompilerGenerated]
	private Action OnOnBoltCatch; //Field offset: 0x50
	[CompilerGenerated]
	private Action OnOffBoltCatch; //Field offset: 0x58
	[CompilerGenerated]
	private Action OnMagOut; //Field offset: 0x60
	[CompilerGenerated]
	private Action OnMagIn; //Field offset: 0x68

	public event Action OnAddAmmoInChamber
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public event Action OnChangeFireMode
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public event Action OnDelAmmoChamber
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public event Action OnDelAmmoFromMag
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public event Action OnFire
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public event Action OnMagIn
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public event Action OnMagOut
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public event Action OnOffBoltCatch
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public event Action OnOnBoltCatch
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public event Action OnShellEject
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public AnimatorEventReceiver() { }

	[CompilerGenerated]
	public void add_OnAddAmmoInChamber(Action value) { }

	[CompilerGenerated]
	public void add_OnChangeFireMode(Action value) { }

	[CompilerGenerated]
	public void add_OnDelAmmoChamber(Action value) { }

	[CompilerGenerated]
	public void add_OnDelAmmoFromMag(Action value) { }

	[CompilerGenerated]
	public void add_OnFire(Action value) { }

	[CompilerGenerated]
	public void add_OnMagIn(Action value) { }

	[CompilerGenerated]
	public void add_OnMagOut(Action value) { }

	[CompilerGenerated]
	public void add_OnOffBoltCatch(Action value) { }

	[CompilerGenerated]
	public void add_OnOnBoltCatch(Action value) { }

	[CompilerGenerated]
	public void add_OnShellEject(Action value) { }

	public void AddAmmoInChamber() { }

	public void DelAmmoChamber() { }

	public void DelAmmoFromMag() { }

	public void FiringBullet() { }

	public void MagIn() { }

	public void MagOut() { }

	public void OffBoltCatch() { }

	public void OnBoltCatch() { }

	[CompilerGenerated]
	public void remove_OnAddAmmoInChamber(Action value) { }

	[CompilerGenerated]
	public void remove_OnChangeFireMode(Action value) { }

	[CompilerGenerated]
	public void remove_OnDelAmmoChamber(Action value) { }

	[CompilerGenerated]
	public void remove_OnDelAmmoFromMag(Action value) { }

	[CompilerGenerated]
	public void remove_OnFire(Action value) { }

	[CompilerGenerated]
	public void remove_OnMagIn(Action value) { }

	[CompilerGenerated]
	public void remove_OnMagOut(Action value) { }

	[CompilerGenerated]
	public void remove_OnOffBoltCatch(Action value) { }

	[CompilerGenerated]
	public void remove_OnOnBoltCatch(Action value) { }

	[CompilerGenerated]
	public void remove_OnShellEject(Action value) { }

	public void SetFiremode0() { }

	public void SetFiremode1() { }

	public void ShellEject() { }

}

