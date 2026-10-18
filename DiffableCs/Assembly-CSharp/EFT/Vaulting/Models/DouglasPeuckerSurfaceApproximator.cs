namespace EFT.Vaulting.Models;

public class DouglasPeuckerSurfaceApproximator : ISurfaceApproximatorModel, ISurfaceApproximatorModelDebug
{
	private readonly List _pointIndexsToKeep; //Field offset: 0x10
	private readonly List _resultPoints; //Field offset: 0x18
	[CompilerGenerated]
	private float <Tolerance>k__BackingField; //Field offset: 0x20

	public override List ResultPoints
	{
		 get { } //Length: 5
	}

	public override float Tolerance
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		 set { } //Length: 6
	}

	public DouglasPeuckerSurfaceApproximator() { }

	public override List Approximate(List points) { }

	private List DouglasPeuckerReduction(List points) { }

	private void DouglasPeuckerReduction(List points, int firstPoint, int lastPoint, float tolerance, List pointIndexsToKeep) { }

	public override List get_ResultPoints() { }

	[CompilerGenerated]
	public override float get_Tolerance() { }

	private float PerpendicularDistance(Vector3 a, Vector3 b, Vector3 c) { }

	[CompilerGenerated]
	public override void set_Tolerance(float value) { }

}

