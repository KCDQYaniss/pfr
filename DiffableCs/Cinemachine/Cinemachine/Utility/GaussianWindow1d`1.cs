namespace Cinemachine.Utility;

internal abstract class GaussianWindow1d`1
{
	protected T[] mData; //Field offset: 0x0
	protected float[] mKernel; //Field offset: 0x0
	protected int mCurrentPos; //Field offset: 0x0
	[CompilerGenerated]
	private float <Sigma>k__BackingField; //Field offset: 0x0

	public int BufferLength
	{
		 get { } //Length: 26
	}

	public int KernelSize
	{
		 get { } //Length: 26
	}

	public private float Sigma
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		private set { } //Length: 6
	}

	public GaussianWindow1d`1(float sigma, int maxKernelRadius = 10) { }

	public void AddValue(T v) { }

	protected abstract T Compute(int windowPos) { }

	public T Filter(T v) { }

	private void GenerateKernel(float sigma, int maxKernelRadius) { }

	public int get_BufferLength() { }

	public int get_KernelSize() { }

	[CompilerGenerated]
	public float get_Sigma() { }

	public T GetBufferValue(int index) { }

	public bool IsEmpty() { }

	public void Reset() { }

	[CompilerGenerated]
	private void set_Sigma(float value) { }

	public void SetBufferValue(int index, T value) { }

	public T Value() { }

}

