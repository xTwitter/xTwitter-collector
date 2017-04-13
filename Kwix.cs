namespace xTwitter_collector
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Kwix : DbContext
    {
        public Kwix()
            : base("name=Kwix1")
        {
        }

        public virtual DbSet<Relation> Relation { get; set; }
        public virtual DbSet<test> test { get; set; }
        public virtual DbSet<Tweet> Tweet { get; set; }
        public virtual DbSet<User> User { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<test>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<Tweet>()
                .Property(e => e.text)
                .IsUnicode(false);

            modelBuilder.Entity<Tweet>()
                .Property(e => e.agent)
                .IsUnicode(false);

            modelBuilder.Entity<Tweet>()
                .Property(e => e.created_at)
                .IsFixedLength();

            modelBuilder.Entity<Tweet>()
                .Property(e => e.media_info)
                .IsUnicode(false);

            modelBuilder.Entity<Tweet>()
                .HasMany(e => e.Relation)
                .WithOptional(e => e.Tweet)
                .HasForeignKey(e => e.retweeted_tweet_id);

            modelBuilder.Entity<Tweet>()
                .HasMany(e => e.Relation1)
                .WithOptional(e => e.Tweet1)
                .HasForeignKey(e => e.tweet_id);

            modelBuilder.Entity<User>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.nick)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.created_at)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Relation)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.user_id);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Relation1)
                .WithOptional(e => e.User1)
                .HasForeignKey(e => e.mentioned_user_id);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Relation2)
                .WithOptional(e => e.User2)
                .HasForeignKey(e => e.followed_user_id);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Tweet)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.user_id);
        }
    }
}