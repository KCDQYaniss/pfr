//Type is in global namespace

public interface IClosePoint : IPositionPoint
{

	public bool IsSameMeaning(IClosePoint p1, float sDist, out IClosePoint worst) { }

}

