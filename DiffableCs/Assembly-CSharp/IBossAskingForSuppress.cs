//Type is in global namespace

public interface IBossAskingForSuppress
{

	public void ReportEnemy(IPlayer enemy, Vector3 enemypos, EEnemyPartVisibleType visibleType) { }

	public void SetWantSuppress() { }

	public bool WantSuppress() { }

}

