//Type is in global namespace

public class AIPlaceInfoHalloweenCircle : AIPlaceInfoLogic
{
	public Transform CenterPoint; //Field offset: 0x20
	public List CastPoints; //Field offset: 0x28
	public List CoverPoints; //Field offset: 0x30
	public bool AlwaysDraw; //Field offset: 0x38

	public AIPlaceInfoHalloweenCircle() { }

	private void Draw() { }

	public virtual void EditorCheck() { }

	private void FixTransformPoint(Transform castPoint) { }

	private string NameWithParent(Transform go) { }

	private void OnDrawGizmos() { }

	private void OnDrawGizmosSelected() { }

}

