namespace EFT.Interactive;

public class PlayersWithImmuneToSniperFire : MonoBehaviour
{
	protected HashSet playersWithImmune; //Field offset: 0x20

	public PlayersWithImmuneToSniperFire() { }

	public override void AddImmunePlayer(int playerRaidId) { }

	public override bool IsPlayerImmuneForFire(int playerRaidId) { }

	public override bool IsPlayerImmuneForFire(string profileID) { }

	public void RemoveImmunePlayer(int playerRaidId) { }

}

