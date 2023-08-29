namespace Berger.Extensions.Audit
{
    public class Audit
    {
        #region Methods
        public void SetModelId(Guid id)
        {
            this.ModelID = id;
        }
        public void SetElementId(Guid id)
        {
            this.ElementID = id;
        }
        public void SetSessionId(Guid id)
        {
            this.SessionID = id;
        }
        public void SetIp(string ip)
        {
            this.IpAddress = ip;
        }
        public void SetTable(string table)
        {
            this.Table = table;
        }
        public void SetAuditType(AuditType auditType)
        {
            this.AuditType = auditType;
        }
        #endregion

        #region Properties
        public Guid ModelID { get; set; }
        public Guid? ElementID { get; set; }
        public Guid? SessionID { get; set; }
        public AuditType AuditType { get; set; }
        public string Table { get; set; } = string.Empty;
        public string IpAddress { get; set; } = string.Empty;
        public Dictionary<string, object> Keys { get; set; } = new Dictionary<string, object>();        // Keys
        public Dictionary<string, object> Old { get; set; } = new Dictionary<string, object>();         // New
        public Dictionary<string, object> New { get; set; } = new Dictionary<string, object>();         // Old
        public List<string> Temporary { get; set; } = new List<string>();                               // Temporary
        public decimal? Latitude { get; set; }
        public decimal? Longitude { get; set; }
        public bool Confirmation => Temporary.Any();                                                     // TemporaryConfirmation
        #endregion
    }
}