﻿using Furion.DatabaseAccessor;
using Microsoft.EntityFrameworkCore;

namespace furionfenceng.EntityFramework.Core;

[AppDbContext("furionfenceng", DbProvider.Sqlite)]
public class DefaultDbContext : AppDbContext<DefaultDbContext>
{
    public DefaultDbContext(DbContextOptions<DefaultDbContext> options) : base(options)
    {
    }
}
