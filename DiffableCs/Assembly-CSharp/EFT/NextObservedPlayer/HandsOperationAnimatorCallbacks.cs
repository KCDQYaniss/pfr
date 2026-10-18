namespace EFT.NextObservedPlayer;

public class HandsOperationAnimatorCallbacks
{
	public Action OnWeapIn; //Field offset: 0x10
	public Action OnWeapOut; //Field offset: 0x18
	public Action OnFiringBullet; //Field offset: 0x20
	public Action OnFireEnd; //Field offset: 0x28
	public Action OnModChanged; //Field offset: 0x30
	public Action OnCook; //Field offset: 0x38
	public Action OnFoldOff; //Field offset: 0x40
	public Action OnFoldOn; //Field offset: 0x48
	public Action OnMagIn; //Field offset: 0x50
	public Action OnMagOut; //Field offset: 0x58
	public Action OnMagHide; //Field offset: 0x60
	public Action OnMagShow; //Field offset: 0x68
	public Action ShowAmmo; //Field offset: 0x70
	public Action MalfunctionOff; //Field offset: 0x78
	public Action Disarm; //Field offset: 0x80
	public Action AddAmmoInChamber; //Field offset: 0x88
	public Action AddAmmoInMag; //Field offset: 0x90
	public Action RemoveShell; //Field offset: 0x98
	public Action RemoveAmmoFromChamber; //Field offset: 0xA0
	public Action ShellEject; //Field offset: 0xA8
	public Action LauncherAppeared; //Field offset: 0xB0
	public Action LauncherDissapeared; //Field offset: 0xB8
	public Action DryFireSound; //Field offset: 0xC0

	public HandsOperationAnimatorCallbacks() { }

	public void Reset() { }

}

