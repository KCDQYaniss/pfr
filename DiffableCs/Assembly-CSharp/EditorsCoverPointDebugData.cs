//Type is in global namespace

public class EditorsCoverPointDebugData
{
	public List NearGroups; //Field offset: 0x10
	public List DeleteOnHide; //Field offset: 0x18
	public List DeletOnCantShoot; //Field offset: 0x20
	public List DeletOnBehind; //Field offset: 0x28
	public List Good; //Field offset: 0x30
	public List GoodWithShoot; //Field offset: 0x38
	public CustomNavigationPoint Final; //Field offset: 0x40
	public string FinalString; //Field offset: 0x48
	public ShootToPoint _pointToShoot; //Field offset: 0x50
	public Vector3 StartPoint; //Field offset: 0x58
	public Vector3 BotPos; //Field offset: 0x64

	public EditorsCoverPointDebugData(ShootToPoint pointToShoot, Vector3 startPoint, Vector3 botPos) { }

	public void DebugAll() { }

	public void DebugAllChecked() { }

	public void DebugHide() { }

	public void DebugShoot() { }

	public void Dispose() { }

	public void DrawBehind() { }

	public void DrawGood() { }

	public void DrawHide() { }

	public void DrawShoot() { }

}

