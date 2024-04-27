using Microsoft.EntityFrameworkCore;
using GPU.Data;

namespace GPU.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new GPUContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<GPUContext>>()))
            {
                if (context == null || context.GPU == null)
                {
                    throw new ArgumentNullException("Null RazorPagesMovieContext");
                }


                if (context.GPU.Any())
                {
                    return;   // DB has been seeded
                }
                context.GPU.AddRange(
    new GPUDetails
    {
        Brand = "Nvidia",
        Model = "RTX 3080",
        ReleaseYear = 2020,
        MemoryInMB = 10240,
        Price = 699.99M,
        LaunchDate = DateTime.Parse("2020-09-17")
    },

    new GPUDetails
    {
        Brand = "AMD",
        Model = "RX 6800 XT",
        ReleaseYear = 2020,
        MemoryInMB = 16384,
        Price = 649.99M,
        LaunchDate = DateTime.Parse("2020-11-18")
    },

    new GPUDetails
    {
        Brand = "Nvidia",
        Model = "RTX 3090",
        ReleaseYear = 2020,
        MemoryInMB = 24576,
        Price = 1499.99M,
        LaunchDate = DateTime.Parse("2020-09-24")
    },

    new GPUDetails
    {
        Brand = "AMD",
        Model = "RX 6900 XT",
        ReleaseYear = 2020,
        MemoryInMB = 16384,
        Price = 999.99M,
        LaunchDate = DateTime.Parse("2020-12-08")
    },

    new GPUDetails
    {
        Brand = "Nvidia",
        Model = "RTX 3070",
        ReleaseYear = 2020,
        MemoryInMB = 8192,
        Price = 499.99M,
        LaunchDate = DateTime.Parse("2020-10-29")
    },

    new GPUDetails
    {
        Brand = "AMD",
        Model = "RX 6700 XT",
        ReleaseYear = 2021,
        MemoryInMB = 12288,
        Price = 479.99M,
        LaunchDate = DateTime.Parse("2021-03-18")
    }
);
                context.SaveChanges();
            }
        }
    }

}