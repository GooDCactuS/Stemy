using System.IO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.TagHelpers;

namespace ASP.NET_Project.Models
{
    public class UserPictureModel
    {
        public string Description { get; set; }
        public byte[] Picture { get; set; }

        public string FilePath { get; set; }
    }
}