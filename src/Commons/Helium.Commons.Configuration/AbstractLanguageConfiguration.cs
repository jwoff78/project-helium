namespace Helium.Commons.Configuration
{
	/* 'using' directive placement (IDE0065) */
	using System;
	using System.Collections.Generic;

	/// <summary>
	/// Part of the Helium Toolchain API. Abstract base class for Language configurations.
	/// </summary>
	public abstract class AbstractLanguageConfiguration : IConfiguration<String, String>
	{
		public String ConfigurationName { get; init; }
		public String DataVersion { get; set; }
		public List<String> LoadedModifications { get; set; }
		public Dictionary<String, String> Configuration { get; set; }

		public abstract IConfiguration<String, String> Deserialize();
		public abstract IConfiguration<String, String> Deserialize(String Filename);
		public abstract void Serialize();
		public abstract void Serialize(out String Serialized);
		public abstract void Serialize(String Filename);
		public abstract void Serialize(String Filename, out String Serialized);
	}
}
