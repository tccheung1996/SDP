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
    
    public partial class registrationevent
    {
        public int RegistrationEventId { get; set; }
        public int RegistrationId { get; set; }
        public string EventId { get; set; }
        public Nullable<short> BibNumber { get; set; }
        public Nullable<int> RaceTime { get; set; }
        public int runnerID { get; set; }
    
        public virtual @event @event { get; set; }
        public virtual @event event1 { get; set; }
        public virtual registration registration { get; set; }
        public virtual registration registration1 { get; set; }
    }
}