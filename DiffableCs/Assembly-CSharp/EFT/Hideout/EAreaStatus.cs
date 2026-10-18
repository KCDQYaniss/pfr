namespace EFT.Hideout;

public enum EAreaStatus
{
	NotSet = 0,
	LockedToConstruct = 1,
	ReadyToConstruct = 2,
	Constructing = 3,
	ReadyToInstallConstruct = 4,
	LockedToUpgrade = 5,
	ReadyToUpgrade = 6,
	Upgrading = 7,
	ReadyToInstallUpgrade = 8,
	NoFutureUpgrades = 9,
	AutoUpgrading = 10,
}

