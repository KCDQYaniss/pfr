//Type is in global namespace

public class MuzzleJet : MuzzleEffect
{
	internal enum EditorType
	{
		CurveDriven = 0,
		Manually = 1,
	}

	internal class Particle
	{
		public float Position; //Field offset: 0x10
		public float Size; //Field offset: 0x14
		public Vector2 RandomShift; //Field offset: 0x18
		public float AxisShift; //Field offset: 0x20

		public Particle() { }

	}

	public const string MeshName = "MuzzleJetCombinedMesh"; //Field offset: 0x0
	private static readonly int _randomVals; //Field offset: 0x0
	private static readonly int _rotMx; //Field offset: 0x4
	private static readonly int _cellShift; //Field offset: 0x8
	public Particle[] Particles; //Field offset: 0x20
	public EditorType Type; //Field offset: 0x28
	public int ParticlesCount; //Field offset: 0x2C
	public Vector3 JetBounds; //Field offset: 0x30
	public AnimationCurve PositionDensity; //Field offset: 0x40
	public AnimationCurve Sizes; //Field offset: 0x48
	public AnimationCurve RandomShiftsX; //Field offset: 0x50
	public AnimationCurve RandomShiftsY; //Field offset: 0x58
	public AnimationCurve AxisShift; //Field offset: 0x60
	public float SizesMult; //Field offset: 0x68
	public float AxisShiftMult; //Field offset: 0x6C
	public float Chance; //Field offset: 0x70
	public Vector2 RandomShiftsMult; //Field offset: 0x74

	private static MuzzleJet() { }

	public MuzzleJet() { }

	private void FillJet(ref int quadNum, Transform patent, Vector2 cellSize, Vector3[] vertices, Vector3[] normals, Vector2[] uv0, Vector2[] uv1, Color32[] colors, Vector4[] tangents) { }

	private void FillParticle(ref int quadNum, Particle particle, Vector3 axis, Vector3 position, Vector2 cellSize, Vector2 posNorm, byte commonRnd, float addLengthRnd, Vector3[] vertices, Vector3[] normals, Vector2[] uv0, Vector2[] uv1, Color32[] colors, Vector4[] tangents) { }

	public static void RandomizeMaterial(Material material, Vector2 cellSize) { }

	public static Transform UpdateOrCreateMesh(MuzzleJet[] muzzleJets, Transform patent, Material material, Vector2 cellSize) { }

}

