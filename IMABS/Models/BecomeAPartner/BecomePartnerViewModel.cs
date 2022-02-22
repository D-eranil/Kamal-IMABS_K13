using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CMS.DocumentEngine.Types.IMABS;

namespace IMABS.Models.BecomeAPartner
{
	public class BecomePartnerViewModel
	{
        public string Title { get; set; }
        public string ApplyTitle { get; set; }
        public string ApplyDescription { get; set; }
        public string ApplyRules { get; set; }
        public string ApplyNotesTitle { get; set; }
        public string ApplyNotesRules { get; set; }

        public static BecomePartnerViewModel GetViewModel(BecomePartner becomePartner)
        {
            return becomePartner == null ? null : new BecomePartnerViewModel
            {
                Title = becomePartner.Fields.Title,
                ApplyTitle = becomePartner.Fields.ApplyTitle,
                ApplyDescription = becomePartner.Fields.ApplyDescription,
                ApplyRules = becomePartner.Fields.ApplyRules,
                ApplyNotesTitle = becomePartner.Fields.ApplyNotesTitle,
                ApplyNotesRules = becomePartner.Fields.ApplyNotesRules
            };
        }
    }
}
