namespace Berger.Extensions.Audit
{
    public class Auditable : IAuditable
    {
        #region Properties
        public DateTime? DeletedOn { get; }
        public DateTime? ModifiedOn { get; }
        public DateTime CreatedOn { get; }
        #endregion
    }
}