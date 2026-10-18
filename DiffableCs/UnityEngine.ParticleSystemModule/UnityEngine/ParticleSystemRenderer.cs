namespace UnityEngine;

[NativeHeader("Modules/ParticleSystem/ScriptBindings/ParticleSystemRendererScriptBindings.h")]
[NativeHeader("ParticleSystemScriptingClasses.h")]
[NativeHeader("Modules/ParticleSystem/ParticleSystemRenderer.h")]
[RequireComponent(typeof(Transform))]
public sealed class ParticleSystemRenderer : Renderer
{

	public Mesh mesh
	{
		[FreeFunction(Name = "ParticleSystemRendererScriptBindings::GetMesh", HasExplicitThis = True)]
		 get { } //Length: 78
	}

	public ParticleSystemRenderMode renderMode
	{
		 get { } //Length: 78
	}

	[FreeFunction(Name = "ParticleSystemRendererScriptBindings::GetMesh", HasExplicitThis = True)]
	public Mesh get_mesh() { }

	public ParticleSystemRenderMode get_renderMode() { }

	[FreeFunction(Name = "ParticleSystemRendererScriptBindings::GetMeshes", HasExplicitThis = True)]
	[RequiredByNativeCode]
	public int GetMeshes(out Mesh[] meshes) { }

}

