//------------------------------------------------------------------------------
// <auto-generated>
//    這個程式碼是由範本產生。
//
//    對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//    如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace SDP_project
{
    using System;
    using System.Collections.Generic;
    
    public partial class registration
    {
        public registration()
        {
            this.registrationevent = new HashSet<registrationevent>();
            this.registrationevent1 = new HashSet<registrationevent>();
            this.sponsorship = new HashSet<sponsorship>();
            this.sponsorship1 = new HashSet<sponsorship>();
        }
    
        public int RegistrationId { get; set; }
        public int RunnerId { get; set; }
        public System.DateTime RegistrationDateTime { get; set; }
        public string RaceKitOptionId { get; set; }
        public sbyte RegistrationStatusId { get; set; }
        public decimal Cost { get; set; }
        public int CharityId { get; set; }
        public decimal SponsorshipTarget { get; set; }
    
        public virtual charity charity { get; set; }
        public virtual charity charity1 { get; set; }
        public virtual racekitoption racekitoption { get; set; }
        public virtual racekitoption racekitoption1 { get; set; }
        public virtual runner runner { get; set; }
        public virtual registrationstatus registrationstatus { get; set; }
        public virtual runner runner1 { get; set; }
        public virtual registrationstatus registrationstatus1 { get; set; }
        public virtual ICollection<registrationevent> registrationevent { get; set; }
        public virtual ICollection<registrationevent> registrationevent1 { get; set; }
        public virtual ICollection<sponsorship> sponsorship { get; set; }
        public virtual ICollection<sponsorship> sponsorship1 { get; set; }
    }
}