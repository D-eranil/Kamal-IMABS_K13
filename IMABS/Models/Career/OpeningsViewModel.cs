using CMS.DocumentEngine.Types.IMABS;
using System;

namespace IMABS.Models.Career
{
	public class OpeningsViewModel
	{
        public string OpeningPosition { get; set; }
        public string OpeningLocation { get; set; }
        public DateTime PostedDate { get; set; }
        public string ApplyURL { get; set; }

        public static OpeningsViewModel GetViewModel(Openings openings)
        {
            return openings == null ? null : new OpeningsViewModel
            {
                OpeningPosition = openings.Fields.OpeningPosition,
                OpeningLocation = openings.Fields.OpeningLocation,
                PostedDate = openings.Fields.PostedDate,
                ApplyURL = openings.Fields.ApplyURL
            };
        }
    }
}
