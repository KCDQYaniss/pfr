namespace EFT;

[Flags]
public enum ResourceType
{
	Ammo = 1,
	Weapon = 2,
	Magazine = 4,
	Item = 8,
	UsablePrefab = 16,
	Player = 32,
	WeaponModItem = 64,
	SynchronizableObject = 128,
	StationaryWeaponMagazine = 256,
	Other = 512,
}

