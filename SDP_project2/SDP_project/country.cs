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
    
    public partial class country
    {
        public country()
        {
            this.marathon = new HashSet<marathon>();
            this.marathon1 = new HashSet<marathon>();
            this.runner = new HashSet<runner>();
            this.runner1 = new HashSet<runner>();
            this.volunteer = new HashSet<volunteer>();
            this.volunteer1 = new HashSet<volunteer>();
        }
    
        public string CountryCode { get; set; }
        public string CountryName { get; set; }
        public string CountryFlag { get; set; }
    
        public virtual ICollection<marathon> marathon { get; set; }
        public virtual ICollection<marathon> marathon1 { get; set; }
        public virtual ICollection<runner> runner { get; set; }
        public virtual ICollection<runner> runner1 { get; set; }
        public virtual ICollection<volunteer> volunteer { get; set; }
        public virtual ICollection<volunteer> volunteer1 { get; set; }
    }
}
