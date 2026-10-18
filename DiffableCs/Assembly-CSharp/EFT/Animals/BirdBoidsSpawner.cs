namespace EFT.Animals;

public class BirdBoidsSpawner : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <SpawnBirds>d__20 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public BirdBoidsSpawner <>4__this; //Field offset: 0x20
		public int count; //Field offset: 0x28
		private int <currentCount>5__2; //Field offset: 0x2C

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <SpawnBirds>d__20(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[Header("Spawn")]
	[SerializeField]
	private GameObject[] _birdsPrefabs; //Field offset: 0x20
	[SerializeField]
	private int _count; //Field offset: 0x28
	[SerializeField]
	private float _spawnDelay; //Field offset: 0x2C
	[SerializeField]
	private float _spawnRadius; //Field offset: 0x30
	[Header("Boids:")]
	[Header("Behaviour")]
	public float BaseSpeed; //Field offset: 0x34
	public float CohesionRadius; //Field offset: 0x38
	public float SeparationMaxSqrDistance; //Field offset: 0x3C
	public int MinBoidsForCohesion; //Field offset: 0x40
	public int MaxBoidsForCohesion; //Field offset: 0x44
	[Header("Update")]
	public float CalculationVelocityInterval; //Field offset: 0x48
	public float UpdateDirectionInterval; //Field offset: 0x4C
	[Header("Mults")]
	public float VelocityMult; //Field offset: 0x50
	public float SeparationMult; //Field offset: 0x54
	public float CohesionMult; //Field offset: 0x58
	public float AlignmentMult; //Field offset: 0x5C
	[Header("Swarm Center")]
	public float SwarmSqrRadius; //Field offset: 0x60
	[HideInInspector]
	public Transform TransformCache; //Field offset: 0x68

	public BirdBoidsSpawner() { }

	private void Awake() { }

	public void Spawn() { }

	public void Spawn(int count) { }

	[IteratorStateMachine(typeof(<SpawnBirds>d__20))]
	private IEnumerator SpawnBirds(int count) { }

}

