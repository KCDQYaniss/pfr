//Type is in global namespace

public class BetterSpring
{
	private const float Epsilon = 0.0001; //Field offset: 0x0
	private Vector3 _pPos; //Field offset: 0x10
	private Vector3 _pVel; //Field offset: 0x1C
	[SerializeField]
	private Vector3 _equilibriumPos; //Field offset: 0x28
	[SerializeField]
	public float _angularFrequency; //Field offset: 0x34
	[SerializeField]
	public float _dampingRatio; //Field offset: 0x38
	private float _za; //Field offset: 0x3C
	private float _zb; //Field offset: 0x40
	private float _z1; //Field offset: 0x44
	private float _z2; //Field offset: 0x48
	private float _omegaZeta; //Field offset: 0x4C
	private float _alpha; //Field offset: 0x50

	public Vector3 EquilibriumPos
	{
		 get { } //Length: 19
		 set { } //Length: 16
	}

	public Vector3 Value
	{
		 get { } //Length: 19
	}

	public BetterSpring() { }

	public void ApplyPosition(Vector3 position) { }

	public void ApplyVelocity(Vector3 val) { }

	public void ApplyVelocity(int comp, float val) { }

	[ContextMenu("Runtime update")]
	public void Cache() { }

	public Vector3 get_EquilibriumPos() { }

	public Vector3 get_Value() { }

	public void Process(float deltaTime) { }

	public void set_EquilibriumPos(Vector3 value) { }

}

