//Type is in global namespace

public class VectorTargetBotPath : AbstractBotPath
{
	public string DebugInfo; //Field offset: 0x40
	private readonly VectorTargetPoint _lastPoint; //Field offset: 0x48
	private readonly Action _endPathCallback; //Field offset: 0x50
	private bool _isComleted; //Field offset: 0x58

	public virtual IPathTargetPoint TargetPoint
	{
		 get { } //Length: 5
	}

	public VectorTargetBotPath(Vector3[] path, Action endPathCallback) { }

	public virtual void Complete() { }

	public virtual void DrawDebugWay(float upCoef) { }

	public virtual void DrawSelectedGizmosWay(float upCoef, Color color) { }

	public virtual IPathTargetPoint get_TargetPoint() { }

	public virtual bool IsSame(Vector3 target, Vector3 ownerPosition) { }

	public virtual bool IsSame(IAICorePointLink target, Vector3 ownerPosition) { }

}

