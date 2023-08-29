namespace Berger.Extensions.Audit
{
    public interface IAuditable
    {
        #region Properties
        public DateTime? DeletedOn { get; }
        public DateTime? ModifiedOn { get; }
        public DateTime CreatedOn { get; }
        #endregion
    }
}