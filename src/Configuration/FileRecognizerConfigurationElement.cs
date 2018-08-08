using System.Linq;

namespace Johnson.ProfilePhotoRecognizer.JgsmFaculty.Configuration {

	[System.Serializable]
	public sealed class FileRecognizerConfigurationElement : System.Configuration.ConfigurationElement {

		#region .ctor
		public FileRecognizerConfigurationElement() : base() {
		}
		#endregion .ctor


		#region properties
		public System.String GroupName {
			get {
				return ( this[ "groupName" ] as System.String );
			}
			set {
				this[ "groupName" ] = value;
			}
		}
		public System.String CommandName {
			get {
				return ( this[ "commandName" ] as System.String );
			}
			set {
				this[ "commandName" ] = value;
			}
		}
		public System.String ResultName {
			get {
				return ( this[ "resultName" ] as System.String );
			}
			set {
				this[ "resultName" ] = value;
			}
		}

		public System.String NetIdExpressionName {
			get {
				return ( this[ "netIdExpressionName" ] as System.String );
			}
			set {
				this[ "netIdExpressionName" ] = value;
			}
		}
		public System.String NetIdExpression {
			get {
				return ( this[ "netIdExpression" ] as System.String );
			}
			set {
				this[ "netIdExpression" ] = value;
			}
		}

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