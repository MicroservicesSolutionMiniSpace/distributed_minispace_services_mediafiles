﻿namespace MiniSpace.Services.Events.Application.DTO
{
    public class PageableDto
    {
        public int Page { get; set; }
        public int Size { get; set; }
        public SortDto Sort { get; set; }
    }
}