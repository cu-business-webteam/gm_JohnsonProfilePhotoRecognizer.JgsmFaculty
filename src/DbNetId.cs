using System.Linq;

namespace Johnson.ProfilePhotoRecognizer.JgsmFaculty {

	public sealed class DbNetId {

		#region fields
		private static readonly DbNetId theFilter;
		#endregion fields


		#region .ctor
		static DbNetId() {
			theFilter = new DbNetId();
		}

		public DbNetId() : base() {
		}
		#endregion .ctor


		#region properties
		public System.String NetId {
			get;
			set;
		}
		#endregion properties


		#region static methods
		public static System.Collections.Generic.IEnumerable<System.String> GetNetIdList() {
			System.Collections.Generic.IEnumerable<DbNetId> output = null;
			var recElement = Configuration.FileRecognizerConfigurationSection.GetSection().Recognizer;
			var group = Oits.Configuration.DbMap.DbMapSection.GetSection().Groups[ recElement.GroupName ];
			using ( var cnxn = group.CreateConnection() ) {
				cnxn.Open();
				var cmd = group.Commands[ recElement.CommandName ];
				output = cmd.ExecuteReaderSingleResult<DbNetId>( cnxn, null, theFilter, group.Results[ recElement.ResultName ] );
			}
			return output.Select(
				x => x.NetId
			);
		}
		#endregion static methods

	}

}