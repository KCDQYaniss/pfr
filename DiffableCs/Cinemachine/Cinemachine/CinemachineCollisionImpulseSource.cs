namespace Cinemachine;

[DocumentationSorting(Level::UserRef (2))]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@2.9/manual/CinemachineCollisionImpulseSource.html")]
[SaveDuringPlay]
public class CinemachineCollisionImpulseSource : CinemachineImpulseSource
{
	[Header("Trigger Object Filter")]
	[Tooltip("Only collisions with objects on these layers will generate Impulse events")]
	public LayerMask m_LayerMask; //Field offset: 0x38
	[TagField]
	[Tooltip("No Impulse evemts will be generated for collisions with objects having these tags")]
	public string m_IgnoreTag; //Field offset: 0x40
	[Header("How To Generate The Impulse")]
	[Tooltip("If checked, signal direction will be affected by the direction of impact")]
	public bool m_UseImpactDirection; //Field offset: 0x48
	[Tooltip("If checked, signal amplitude will be multiplied by the mass of the impacting object")]
	public bool m_ScaleImpactWithMass; //Field offset: 0x49
	[Tooltip("If checked, signal amplitude will be multiplied by the speed of the impacting object")]
	public bool m_ScaleImpactWithSpeed; //Field offset: 0x4A
	private Rigidbody mRigidBody; //Field offset: 0x50
	private Rigidbody2D mRigidBody2D; //Field offset: 0x58

	public CinemachineCollisionImpulseSource() { }

	private void GenerateImpactEvent(Collider other, Vector3 vel) { }

	private void GenerateImpactEvent2D(Collider2D other2d, Vector3 vel) { }

	private float GetMassAndVelocity(Collider other, ref Vector3 vel) { }

	private float GetMassAndVelocity2D(Collider2D other2d, ref Vector3 vel) { }

	private void OnCollisionEnter(Collision c) { }

	private void OnCollisionEnter2D(Collision2D c) { }

	private void OnEnable() { }

	private void OnTriggerEnter(Collider c) { }

	private void OnTriggerEnter2D(Collider2D c) { }

	private void Start() { }

}

