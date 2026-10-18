namespace System;

[ClassInterface(ClassInterfaceType::None (0))]
[ComVisible(True)]
public sealed class AppDomainSetup
{
	private string application_base; //Field offset: 0x10
	private string application_name; //Field offset: 0x18
	private string cache_path; //Field offset: 0x20
	private string configuration_file; //Field offset: 0x28
	private string dynamic_base; //Field offset: 0x30
	private string license_file; //Field offset: 0x38
	private string private_bin_path; //Field offset: 0x40
	private string private_bin_path_probe; //Field offset: 0x48
	private string shadow_copy_directories; //Field offset: 0x50
	private string shadow_copy_files; //Field offset: 0x58
	private bool publisher_policy; //Field offset: 0x60
	private bool path_changed; //Field offset: 0x61
	private int loader_optimization; //Field offset: 0x64
	private bool disallow_binding_redirects; //Field offset: 0x68
	private bool disallow_code_downloads; //Field offset: 0x69
	private object _activationArguments; //Field offset: 0x70
	private object domain_initializer; //Field offset: 0x78
	private object application_trust; //Field offset: 0x80
	private string[] domain_initializer_args; //Field offset: 0x88
	private bool disallow_appbase_probe; //Field offset: 0x90
	private byte[] configuration_bytes; //Field offset: 0x98
	private byte[] serialized_non_primitives; //Field offset: 0xA0
	private string manager_assembly; //Field offset: 0xA8
	private string manager_type; //Field offset: 0xB0
	private string[] partial_visible_assemblies; //Field offset: 0xB8
	[CompilerGenerated]
	private string <TargetFrameworkName>k__BackingField; //Field offset: 0xC0

	[MonoLimitation("it needs to be invoked within the created domain")]
	public AppDomainInitializer AppDomainInitializer
	{
		 set { } //Length: 82
	}

	[MonoLimitation("it needs to be used to invoke the initializer within the created domain")]
	public string[] AppDomainInitializerArguments
	{
		 set { } //Length: 82
	}

	public override string ApplicationBase
	{
		 get { } //Length: 11
		 set { } //Length: 82
	}

	public override string ApplicationName
	{
		 get { } //Length: 5
	}

	public override string CachePath
	{
		 set { } //Length: 82
	}

	public override string ConfigurationFile
	{
		 get { } //Length: 271
		 set { } //Length: 82
	}

	public override string DynamicBase
	{
		 get { } //Length: 271
	}

	public override string PrivateBinPath
	{
		 get { } //Length: 5
		 set { } //Length: 92
	}

	public override string ShadowCopyDirectories
	{
		 set { } //Length: 82
	}

	public override string ShadowCopyFiles
	{
		 get { } //Length: 5
		 set { } //Length: 82
	}

	public AppDomainSetup() { }

	internal AppDomainSetup(AppDomainSetup setup) { }

	public override string get_ApplicationBase() { }

	public override string get_ApplicationName() { }

	public override string get_ConfigurationFile() { }

	public override string get_DynamicBase() { }

	public override string get_PrivateBinPath() { }

	public override string get_ShadowCopyFiles() { }

	private static string GetAppBase(string appBase) { }

	internal void SerializeNonPrimitives() { }

	public void set_AppDomainInitializer(AppDomainInitializer value) { }

	public void set_AppDomainInitializerArguments(string[] value) { }

	public override void set_ApplicationBase(string value) { }

	public override void set_CachePath(string value) { }

	public override void set_ConfigurationFile(string value) { }

	public override void set_PrivateBinPath(string value) { }

	public override void set_ShadowCopyDirectories(string value) { }

	public override void set_ShadowCopyFiles(string value) { }

}

