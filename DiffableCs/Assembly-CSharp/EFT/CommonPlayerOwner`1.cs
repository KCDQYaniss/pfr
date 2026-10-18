namespace EFT;

public abstract class CommonPlayerOwner`1 : GamePlayerOwner
{
	protected TSession Session; //Field offset: 0x0

	protected CommonPlayerOwner`1() { }

	internal static TPlayerOwner Create(Player player, IInputTree inputTree, InsuranceCompany insurance, IEftSession session, GameUI gameUI, GameDateTime gameDateTime, Location location) { }

}

