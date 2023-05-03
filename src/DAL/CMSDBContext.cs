using Microsoft.EntityFrameworkCore;

namespace Draftair.DAL
{
    public class CMSDBContext : DbContext
    {
        public CMSDBContext(DbContextOptions options)
            : base(options) { }
    }
}
