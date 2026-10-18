namespace EFT.InventoryLogic;

[Flags]
public enum EWeaponModType
{
	mod_mount = 1,
	mod_scope = 2,
	mod_tactical = 4,
	mod_stock = 8,
	mod_magazine = 16,
	mod_barrel = 32,
	mod_handguard = 64,
	mod_muzzle = 128,
	mod_sight_front = 256,
	mod_sight_rear = 512,
	mod_foregrip = 1024,
	mod_reciever = 2048,
	mod_charge = 4096,
	mod_pistol_grip = 8192,
	mod_launcher = 16384,
	mod_bipod = 32768,
	mod_mag_shaft = 65536,
	mod_silencer = 131072,
	mod_tactical_2 = 262144,
	chamber0 = 524288,
	chamber1 = 1048576,
	patron_in_weapon = 2097152,
	mod_gas_block = 4194304,
	mod_equipment = 8388608,
	mod_equipment_000 = 16777216,
	mod_equipment_001 = 33554432,
	mod_nvg = 67108864,
	mod_flashlight = 134217728,
	mod_muzzle_001 = 268435456,
}

