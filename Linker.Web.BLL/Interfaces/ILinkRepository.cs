using Linker.Web.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linker.Web.BLL.Interfaces
{
    public interface ILinkRepository
    {
        IEnumerable<Link> GetByFolderId(int id);

    }
}
