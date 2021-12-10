using System;
using System.Collections.Generic;

namespace Movies.Data
{
    public static class Helper
    {
        // protected override void OnModelCreating(ModelBuilder modelBuilder)
        // {
        //     modelBuilder.Entity<MovieActor>()
        //         .HasKey(ma => new { ma.MovieId, ma.ActorId });
        //     modelBuilder.Entity<MovieActor>()
        //         .HasOne(ma => ma.Movie)
        //         .WithMany(m => m.MovieActors)
        //         .HasForeignKey(ma => ma.MovieId);
        //     modelBuilder.Entity<MovieActor>()
        //         .HasOne(ma => ma.Actor)
        //         .WithMany(a => a.MovieActors)
        //         .HasForeignKey(ma => ma.ActorId);
        // }

    }
}