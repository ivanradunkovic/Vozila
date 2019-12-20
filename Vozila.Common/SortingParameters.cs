namespace Vozila.Common
{
    public class SortingParameters : ISortingParameters
    {

        /// <param Name="sortOrder">Sort order.</param>
        /// <param Name="sortField">Sort field.</param>
        
        public SortingParameters(string sortField, string sortOrder)
        {
            this.SortOrder = sortOrder;
            this.SortField = sortField;
        }

        public string SortOrder { get; set; }


        public string SortField { get; set; }

    }
}