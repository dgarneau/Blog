﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Moonglade.Data.Entities;

namespace Moonglade.Data.PostgreSql.Configurations;


internal class PingbackConfiguration : IEntityTypeConfiguration<PingbackEntity>
{
    public void Configure(EntityTypeBuilder<PingbackEntity> builder)
    {
        builder.Property(e => e.Id).ValueGeneratedNever();
        builder.Property(e => e.PingTimeUtc).HasColumnType("timestamp");
        builder.Property(e => e.TargetPostTitle).HasMaxLength(128);
        builder.Property(e => e.SourceIp).HasMaxLength(64);
        builder.Property(e => e.SourceTitle).HasMaxLength(256);
        builder.Property(e => e.SourceUrl).HasMaxLength(256);
        builder.Property(e => e.Domain).HasMaxLength(256);
    }
}