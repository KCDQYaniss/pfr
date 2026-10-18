//Type is in global namespace

public class ParticleForceFieldsDemo : MonoBehaviour
{
	[Header("Overview")]
	public CustomTextMeshProUGUI FPSText; //Field offset: 0x20
	public CustomTextMeshProUGUI particleCountText; //Field offset: 0x28
	public Toggle postProcessingToggle; //Field offset: 0x30
	public MonoBehaviour postProcessing; //Field offset: 0x38
	[Header("Particle System Settings")]
	public ParticleSystem particleSystem; //Field offset: 0x40
	private MainModule particleSystemMainModule; //Field offset: 0x48
	private EmissionModule particleSystemEmissionModule; //Field offset: 0x50
	public CustomTextMeshProUGUI maxParticlesText; //Field offset: 0x58
	public CustomTextMeshProUGUI particlesPerSecondText; //Field offset: 0x60
	public Slider maxParticlesSlider; //Field offset: 0x68
	public Slider particlesPerSecondSlider; //Field offset: 0x70
	[Header("Attraction Particle Force Field Settings")]
	public AttractionParticleForceField attractionParticleForceField; //Field offset: 0x78
	public CustomTextMeshProUGUI attractionParticleForceFieldRadiusText; //Field offset: 0x80
	public CustomTextMeshProUGUI attractionParticleForceFieldMaxForceText; //Field offset: 0x88
	public CustomTextMeshProUGUI attractionParticleForceFieldArrivalRadiusText; //Field offset: 0x90
	public CustomTextMeshProUGUI attractionParticleForceFieldArrivedRadiusText; //Field offset: 0x98
	public CustomTextMeshProUGUI attractionParticleForceFieldPositionTextX; //Field offset: 0xA0
	public CustomTextMeshProUGUI attractionParticleForceFieldPositionTextY; //Field offset: 0xA8
	public CustomTextMeshProUGUI attractionParticleForceFieldPositionTextZ; //Field offset: 0xB0
	public Slider attractionParticleForceFieldRadiusSlider; //Field offset: 0xB8
	public Slider attractionParticleForceFieldMaxForceSlider; //Field offset: 0xC0
	public Slider attractionParticleForceFieldArrivalRadiusSlider; //Field offset: 0xC8
	public Slider attractionParticleForceFieldArrivedRadiusSlider; //Field offset: 0xD0
	public Slider attractionParticleForceFieldPositionSliderX; //Field offset: 0xD8
	public Slider attractionParticleForceFieldPositionSliderY; //Field offset: 0xE0
	public Slider attractionParticleForceFieldPositionSliderZ; //Field offset: 0xE8
	[Header("Vortex Particle Force Field Settings")]
	public VortexParticleForceField vortexParticleForceField; //Field offset: 0xF0
	public CustomTextMeshProUGUI vortexParticleForceFieldRadiusText; //Field offset: 0xF8
	public CustomTextMeshProUGUI vortexParticleForceFieldMaxForceText; //Field offset: 0x100
	public CustomTextMeshProUGUI vortexParticleForceFieldRotationTextX; //Field offset: 0x108
	public CustomTextMeshProUGUI vortexParticleForceFieldRotationTextY; //Field offset: 0x110
	public CustomTextMeshProUGUI vortexParticleForceFieldRotationTextZ; //Field offset: 0x118
	public CustomTextMeshProUGUI vortexParticleForceFieldPositionTextX; //Field offset: 0x120
	public CustomTextMeshProUGUI vortexParticleForceFieldPositionTextY; //Field offset: 0x128
	public CustomTextMeshProUGUI vortexParticleForceFieldPositionTextZ; //Field offset: 0x130
	public Slider vortexParticleForceFieldRadiusSlider; //Field offset: 0x138
	public Slider vortexParticleForceFieldMaxForceSlider; //Field offset: 0x140
	public Slider vortexParticleForceFieldRotationSliderX; //Field offset: 0x148
	public Slider vortexParticleForceFieldRotationSliderY; //Field offset: 0x150
	public Slider vortexParticleForceFieldRotationSliderZ; //Field offset: 0x158
	public Slider vortexParticleForceFieldPositionSliderX; //Field offset: 0x160
	public Slider vortexParticleForceFieldPositionSliderY; //Field offset: 0x168
	public Slider vortexParticleForceFieldPositionSliderZ; //Field offset: 0x170

	public ParticleForceFieldsDemo() { }

	public void ReloadScene() { }

	public void SetAttractionParticleForceFieldArrivalRadius(float value) { }

	public void SetAttractionParticleForceFieldArrivedRadius(float value) { }

	public void SetAttractionParticleForceFieldMaxForce(float value) { }

	public void SetAttractionParticleForceFieldPositionX(float value) { }

	public void SetAttractionParticleForceFieldPositionY(float value) { }

	public void SetAttractionParticleForceFieldPositionZ(float value) { }

	public void SetAttractionParticleForceFieldRadius(float value) { }

	public void SetMaxParticles(float value) { }

	public void SetParticleEmissionPerSecond(float value) { }

	public void SetVortexParticleForceFieldMaxForce(float value) { }

	public void SetVortexParticleForceFieldPositionX(float value) { }

	public void SetVortexParticleForceFieldPositionY(float value) { }

	public void SetVortexParticleForceFieldPositionZ(float value) { }

	public void SetVortexParticleForceFieldRadius(float value) { }

	public void SetVortexParticleForceFieldRotationX(float value) { }

	public void SetVortexParticleForceFieldRotationY(float value) { }

	public void SetVortexParticleForceFieldRotationZ(float value) { }

	private void Start() { }

	private void Update() { }

}

