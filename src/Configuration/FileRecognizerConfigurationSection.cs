using System.Linq;

namespace Johnson.ProfilePhotoRecognizer.JgsmFaculty.Configuration {

	[System.Serializable]
	public sealed class FileRecognizerConfigurationSection : System.Configuration.ConfigurationSection {

		#region fields
		public const System.String DefaultSectionName = "johnson.jgsmFaculty.fileRecognizer";
		#endregion fields


		#region .ctor
		public FileRecognizerConfigurationSection() : base() {
		}
		#endregion .ctor


		#region properties
		[System.Configuration.ConfigurationProperty( "recognizer", IsRequired = true, IsDefaultCollection = false, IsKey = false )]
		public FileRecognizerConfigurationElement Recognizer {
			get {
				return (FileRecognizerConfigurationElement)this[ "recognizer" ];
			}
			set {
				this[ "recognizer" ] = value;
			}
		}
		#endregion properties


		#region static methods
		public static FileRecognizerConfigurationSection GetSection() {
			return ( System.Configuration.ConfigurationManager.GetSection( FileRecognizerConfigurationSection.DefaultSectionName ) as FileRecognizerConfigurationSection );
		}
		#endregion static methods

	}

}