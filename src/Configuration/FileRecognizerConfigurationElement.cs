using System.Linq;

namespace Johnson.ProfilePhotoRecognizer.JgsmFaculty.Configuration {

	[System.Serializable]
	public sealed class FileRecognizerConfigurationElement : System.Configuration.ConfigurationElement {

		#region .ctor
		public FileRecognizerConfigurationElement() : base() {
		}
		#endregion .ctor


		#region properties
		[System.IO.IODescription( "Specifies the Oits.Configuration.DbMap group." )]
		[System.Configuration.ConfigurationProperty( "groupName", IsRequired = true, IsKey = false )]
		public System.String GroupName {
			get {
				return ( this[ "groupName" ] as System.String );
			}
			set {
				this[ "groupName" ] = value;
			}
		}
		[System.IO.IODescription( "Specifies the Oits.Configuration.DbMap command which matches up the file with a web profile." )]
		[System.Configuration.ConfigurationProperty( "commandName", IsRequired = true, IsKey = false )]
		public System.String CommandName {
			get {
				return ( this[ "commandName" ] as System.String );
			}
			set {
				this[ "commandName" ] = value;
			}
		}
		[System.IO.IODescription( "Specifies the Oits.Configuration.DbMap result mapping." )]
		[System.Configuration.ConfigurationProperty( "resultName", IsRequired = true, IsKey = false )]
		public System.String ResultName {
			get {
				return ( this[ "resultName" ] as System.String );
			}
			set {
				this[ "resultName" ] = value;
			}
		}

		[System.IO.IODescription( "The regular expression for isolataing the NetId from the file name." )]
		[System.Configuration.ConfigurationProperty( "netIdExpression", IsRequired = true, IsKey = false )]
		public System.String NetIdExpression {
			get {
				return ( this[ "netIdExpression" ] as System.String );
			}
			set {
				this[ "netIdExpression" ] = value;
			}
		}

		[System.IO.IODescription( "The directory to where the file should be moved." )]
		[System.Configuration.ConfigurationProperty( "destination", IsRequired = true, IsKey = false )]
		public System.String Destination {
			get {
				return ( this[ "destination" ] as System.String ).TrimToNull();
			}
			set {
				this[ "destination" ] = value.TrimToNull();
			}
		}
		#endregion properties

	}

}