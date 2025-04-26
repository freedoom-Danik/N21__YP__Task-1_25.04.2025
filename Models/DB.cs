using N21__YP__Task_1_25._04._2025.Data;

namespace N21__YP__Task_1_25._04._2025.Data
{
    public class DB
    {
        public static AppDbContext CreateContext()
        {
            var context = new AppDbContext();
            context.Database.EnsureCreated();
            return context;
        }
    }
}