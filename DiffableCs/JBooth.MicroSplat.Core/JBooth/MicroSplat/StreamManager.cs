namespace JBooth.MicroSplat;

public class StreamManager : MonoBehaviour
{
	internal class SRPBuffers : UpdateBuffer
	{
		public CustomRenderTexture buffer0; //Field offset: 0x20
		public CustomRenderTexture buffer1; //Field offset: 0x28
		public CustomRenderTexture currentBuffer; //Field offset: 0x30

		public SRPBuffers() { }

		public virtual void BlitA() { }

		public virtual void BlitB() { }

		public virtual void Disable() { }

		public virtual RenderTexture GetCurrent() { }

		public virtual void Init(int w, int h) { }

	}

	internal class StandardBuffers : UpdateBuffer
	{
		public RenderTexture buffer0; //Field offset: 0x20
		public RenderTexture buffer1; //Field offset: 0x28
		public RenderTexture currentBuffer; //Field offset: 0x30

		public StandardBuffers() { }

		public virtual void BlitA() { }

		public virtual void BlitB() { }

		public virtual void Disable() { }

		public virtual RenderTexture GetCurrent() { }

		public virtual void Init(int w, int h) { }

	}

	internal class UpdateBuffer
	{
		public Material updateMat; //Field offset: 0x10
		public int width; //Field offset: 0x18
		public int height; //Field offset: 0x1C

		public UpdateBuffer() { }

		public override void BlitA() { }

		public override void BlitB() { }

		public override void Disable() { }

		public override RenderTexture GetCurrent() { }

		public override void Init(int w, int h) { }

	}

	private MicroSplatObject msObject; //Field offset: 0x20
	private bool onBuffer0; //Field offset: 0x28
	public UpdateBuffer updateBuffer; //Field offset: 0x30
	private Vector4[] spawnBuffer; //Field offset: 0x38
	private Vector4[] colliderBuffer; //Field offset: 0x40
	public Vector2 evaporation; //Field offset: 0x48
	public Vector2 strength; //Field offset: 0x50
	public Vector2 speed; //Field offset: 0x58
	public Vector2 resistance; //Field offset: 0x60
	public float wetnessEvaporation; //Field offset: 0x68
	public float burnEvaporation; //Field offset: 0x6C
	private List emitters; //Field offset: 0x70
	private List colliders; //Field offset: 0x78
	private double timeSinceWetnessEvap; //Field offset: 0x80
	private double timeSinceBurnEvap; //Field offset: 0x88
	private double timeSinceEvapX; //Field offset: 0x90
	private double timeSinceEvapY; //Field offset: 0x98
	private Vector2 evapAmount; //Field offset: 0xA0

	public StreamManager() { }

	private void Awake() { }

	private void OnDisable() { }

	private void OnEnable() { }

	public void Register(StreamEmitter e) { }

	public void Register(StreamCollider e) { }

	public void Unregister(StreamEmitter e) { }

	public void Unregister(StreamCollider e) { }

	private void Update() { }

	private static Vector2 WorldToTerrain(MicroSplatObject ter, Vector3 point, int width, int height) { }

}

