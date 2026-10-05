using Microsoft.EntityFrameworkCore;

public class Multi_step_form_projectContext(DbContextOptions<Multi_step_form_projectContext> options) : DbContext(options)
{
    public DbSet<Multi_step_form_project.Modules.Subscriber> Subscriber { get; set; } = default!;
}
