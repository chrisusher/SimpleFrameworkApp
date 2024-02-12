using System;
using System.ComponentModel.DataAnnotations;

namespace SimpleFrameworkApp.Services.Tables
{
    public class VersionHistory
    {
        [Key]
        public int VersionId { get; set; }
        
        public DateTime ReleaseDate { get; set; }
        
        public string ReleaseName { get; set; }
    }
}