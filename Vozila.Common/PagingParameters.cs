using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vozila.Common
{
    public class PagingParameters : IPagingParameters
    {
        /// <param Name="pageNumber">Page number.</param>
        /// <param Name="pageSize">Page size.</param>
        public PagingParameters(int pageNumber, int pageSize)
        {
            this.PageNumber = pageNumber;
            this.PageSize = pageSize;
        }

        public int PageNumber { get; set; }

        public int PageSize { get; set; }
    }
}