using System.Linq;

namespace Johnson.ProfilePhotoRecognizer.JgsmFaculty {

	public sealed class JgsmFacultyRecognizer : IFileRecognizer {

		#region fields
		private System.Collections.Generic.IEnumerable<System.String> myNetIdList;
		#endregion fields


		#region .ctor
		public JgsmFacultyRecognizer() : base() {
		}
		#endregion .ctor


		#region methods
		public System.String IsRecognized( System.String fileSpecification ) {
			fileSpecification = fileSpecification.TrimToNull();
			if ( System.String.IsNullOrEmpty( fileSpecification ) ) {
				throw new System.ArgumentNullException( "fileSpecification" );
			}

			if ( null == myNetIdList ) {
				System.Threading.Interlocked.CompareExchange<System.Collections.Generic.IEnumerable<System.String>>( ref myNetIdList, DbNetId.GetNetIdList(), null );
			}

			var fileName = System.IO.Path.GetFileName( fileSpecification );
			var fileNameWithoutExtension = System.IO.Path.GetFileNameWithoutExtension( fileName );
			var section = Configuration.FileRecognizerConfigurationSection.GetSection();
			var element = section.Recognizer;
			var expression = element.NetIdExpression;
			var expressionName = element.NetIdExpressionName;

			return System.Text.RegularExpressions.Regex.IsMatch( fileNameWithoutExtension, expression, System.Text.RegularExpressions.RegexOptions.Singleline | System.Text.RegularExpressions.RegexOptions.IgnoreCase )
				? System.IO.Path.Combine( element.Destination, fileName )
				: null
			;
		}
		#endregion methods

	}

}