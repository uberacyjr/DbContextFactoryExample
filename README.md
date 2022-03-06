# Db Context Factory Example

Reference: https://docs.microsoft.com/en-us/ef/core/dbcontext-configuration/#dbcontextoptions

## DbContextOptions
The starting point for all DbContext configuration is DbContextOptionsBuilder. There are three ways to get this builder:

 - In AddDbContext and related methods
 - In OnConfiguring
 - Constructed explicitly with new
