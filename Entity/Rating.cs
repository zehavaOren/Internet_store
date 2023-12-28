using System;
using System.Collections.Generic;

namespace Entity
{
    public partial class Rating
    {
        public int RatingId { get; set; }
        public string Host { get; set; } = null!;
        public string Method { get; set; } = null!;
        public string Path { get; set; } = null!;
        public string Referer { get; set; } = null!;
        public string UserAgent { get; set; } = null!;
        public DateTime? RecordDate { get; set; } = null!;
    }
}
