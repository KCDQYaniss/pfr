//Type is in global namespace

public class CheckPoisitonDataCarePlayers
{
	internal class CheckPlayerCareDist
	{
		private readonly int playerId; //Field offset: 0x10
		private readonly Vector3 playerPosition; //Field offset: 0x14
		private readonly Vector3 spawnPointPosition; //Field offset: 0x20
		private readonly float sDist; //Field offset: 0x2C
		private readonly float distanceSqr; //Field offset: 0x30

		public CheckPlayerCareDist(int playerId, Vector3 playerPosition, Vector3 spawnPointPosition, float sDist, float distanceSqr) { }

		public StringBuilder Debug() { }

	}

	internal class CheckPlayerCarePlayers
	{
		private readonly int playerId; //Field offset: 0x10
		private readonly Vector3 playerPosition; //Field offset: 0x14
		private readonly ISpawnPointCollider spawnPointCollider; //Field offset: 0x20
		private readonly bool contain; //Field offset: 0x28

		public CheckPlayerCarePlayers(int playerId, Vector3 playerPosition, ISpawnPointCollider spawnPointCollider, bool contain) { }

		public StringBuilder Debug() { }

	}

	private string _id; //Field offset: 0x10
	private bool _carePlayersIsNull; //Field offset: 0x18
	private bool _carePlayersIsGood; //Field offset: 0x19
	private CheckPlayerCareDist _checkPlayerCareDist; //Field offset: 0x20
	private CheckPlayerCarePlayers _checkPlayerCarePlayers; //Field offset: 0x28

	public CheckPoisitonDataCarePlayers(string id) { }

	public void CarePlayersIsGood() { }

	public void CarePlayersIsNull() { }

	public void CheckDist(int playerId, Vector3 playerPosition, Vector3 spawnPointPosition, float sDist, float distanceSqr) { }

	public void CheckPlayer(int playerId, Vector3 playerPosition, ISpawnPointCollider spawnPointCollider, bool contain) { }

	public StringBuilder DebugInfo() { }

}

