//Type is in global namespace

[Flags]
public enum ETagStatus
{
	Unaware = 1,
	Aware = 2,
	Combat = 4,
	Solo = 8,
	Coop = 16,
	Bear = 32,
	Usec = 64,
	Scav = 128,
	TargetSolo = 256,
	TargetMultiple = 512,
	Healthy = 1024,
	Injured = 2048,
	BadlyInjured = 4096,
	Dying = 8192,
	Birdeye = 16384,
	Knight = 32768,
	BigPipe = 65536,
	BlackDivision = 131072,
	VSRF = 262144,
	Civilian = 524288,
	GasGrenade = 1048576,
	FlashGrenade = 2097152,
}

