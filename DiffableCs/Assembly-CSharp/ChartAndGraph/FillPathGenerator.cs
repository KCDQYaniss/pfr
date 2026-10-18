namespace ChartAndGraph;

public class FillPathGenerator : SmoothPathGenerator
{
	public bool WithTop; //Field offset: 0x50
	public bool MatchLine; //Field offset: 0x51
	private float mGraphBottom; //Field offset: 0x54
	private float mGraphTop; //Field offset: 0x58
	private bool StretchFill; //Field offset: 0x5C
	private List mTmpTringle; //Field offset: 0x60
	private List mTmpUv; //Field offset: 0x68
	private List mVertices; //Field offset: 0x70
	private bool mHasParent; //Field offset: 0x78
	private int mParentJointSmoothing; //Field offset: 0x7C
	private float mParentJointSize; //Field offset: 0x80

	protected virtual float JointSizeLink
	{
		 get { } //Length: 27
	}

	protected virtual int JointSmoothingLink
	{
		 get { } //Length: 20
	}

	public FillPathGenerator() { }

	private void AddTringles(List tringles, int from, int to) { }

	public virtual void Generator(Vector3[] path, float thickness, bool closed) { }

	protected virtual float get_JointSizeLink() { }

	protected virtual int get_JointSmoothingLink() { }

	public void SetGraphBounds(float bottom, float top) { }

	public void SetLineSmoothing(bool hasParent, int jointSmoothing, float jointSize) { }

	public void SetStrechFill(bool strech) { }

	private int WriteVector(Vector3 position, float thickness, float u) { }

}

