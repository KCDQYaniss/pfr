//Type is in global namespace

public class DebugMinePlanter : MonoBehaviour
{
	private IBotGame _botGame; //Field offset: 0x20
	public int MassPlantCount; //Field offset: 0x28
	public float MassPlantRad; //Field offset: 0x2C
	private Dictionary _plantedInfos; //Field offset: 0x30

	public DebugMinePlanter() { }

	public void Awake() { }

	public void Clear() { }

	public void DoPlant() { }

	public void MassRndPlant() { }

	private void OnAddMine(TripwireSynchronizableObject objmine, PlantedMineAIInfo aimineinfo) { }

	private void OnDrawGizmos() { }

	private void OnRemoveMine(TripwireSynchronizableObject objmine, PlantedMineAIInfo aimineinfo) { }

	private void PlantAt(Vector3 pos) { }

	private void Update() { }

}

