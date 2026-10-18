namespace Cinemachine.Utility;

internal class GaussianWindow1D_Quaternion : GaussianWindow1d
{

	public GaussianWindow1D_Quaternion(float sigma, int maxKernelRadius = 10) { }

	protected virtual Quaternion Compute(int windowPos) { }

}

