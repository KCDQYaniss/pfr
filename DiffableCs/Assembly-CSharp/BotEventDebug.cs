//Type is in global namespace

public class BotEventDebug : MonoBehaviour
{
	public float Power; //Field offset: 0x20
	public float ArtilleryDuration; //Field offset: 0x24
	public bool CanBeUsed; //Field offset: 0x28
	public GroupPoint Selected; //Field offset: 0x30
	private Vector3 _offset1; //Field offset: 0x38
	private Vector3 _offset2; //Field offset: 0x44

	public BotEventDebug() { }

	public void ArtilleryStart() { }

	public void DoTest() { }

	private void DrawRecurciev(GroupPoint selected, HashSet drawed, int deep, int maxDeep) { }

	public void DrawRecursieveConnects(int maxDeep) { }

	public void FindClosestsPoint() { }

	public void OnDrawGizmosSelected() { }

	public void PlaySound() { }

}

