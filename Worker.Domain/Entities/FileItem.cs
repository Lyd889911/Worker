using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Worker.Domain.ValueObjects;
using Worker.Shared.BaseEntities;
using Worker.Shared.Enums;

namespace Worker.Domain.Entities
{
    public class FileItem:AggregateRoot
    {
        public string? FileName { get; set; }
        public string? Hash { get; set; }
        public long Size { get; set; }
        public FileAddress? Address { get; set; }
        public FileType Type { get; set; }
        public FileOrigin Origin { get; set; }
    }
}
