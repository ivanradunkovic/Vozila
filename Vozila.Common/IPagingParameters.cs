﻿namespace Vozila.Common
{
    public interface IPagingParameters
    {
        int PageNumber { get; set; }

        int PageSize { get; set; }
    }
}