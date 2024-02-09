﻿using NewsApi.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsApi.Core.Entities
{
    public class News : IEntity
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string? Description { get; set; } = string.Empty;
        public string Text { get; set; } = string.Empty;

        //public string Author { get; set; } = string.Empty;
        public int AuthorId { get; set; }

        public int CategoryId { get; set; }

        public int CountOfVisits { get; set; }

        public string ImageName { get; set; } = string.Empty;
        /*public TimeOnly CreationTime { get; set; }
        public DateOnly CreationDate { get; set; }*/
    }
}
