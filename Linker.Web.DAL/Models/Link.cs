using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linker.Web.DAL.Models
{
    public class Link
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public string? Description { get; set; }
    }
}
