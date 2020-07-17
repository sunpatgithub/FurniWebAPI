using System;
using System.Collections.Generic;

namespace Furni.Domain.Models
{
    public partial class MobileWizardSteps
    {
        public int WizardId { get; set; }
        public int UserTypeId { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string ButtonText { get; set; }
        public string IconImg { get; set; }
        public string RedirectionType { get; set; }
        public bool IsActive { get; set; }
    }
}
