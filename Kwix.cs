namespace xTwitter_collector
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Kwix : DbContext
    {
        public Kwix()
            : base("name=Kwix")
        {
        }

        public virtual DbSet<ApiToken> ApiToken { get; set; }
        public virtual DbSet<Relation> Relation { get; set; }
        public virtual DbSet<TaskQueue> TaskQueue { get; set; }
        public virtual DbSet<test> test { get; set; }
        public virtual DbSet<Tweet> Tweet { get; set; }
        public virtual DbSet<User> User { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ApiToken>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<ApiToken>()
                .Property(e => e.consumer_key)
                .IsUnicode(false);

            modelBuilder.Entity<ApiToken>()
                .Property(e => e.consumer_secret)
                .IsUnicode(false);

            modelBuilder.Entity<ApiToken>()
                .Property(e => e.access_token)
                .IsUnicode(false);

            modelBuilder.Entity<ApiToken>()
                .Property(e => e.access_token_secret)
                .IsUnicode(false);

            modelBuilder.Entity<Relation>()
                .Property(e => e.id)
                .HasPrecision(20, 0);

            modelBuilder.Entity<Relation>()
                .Property(e => e.user_id)
                .HasPrecision(20, 0);

            modelBuilder.Entity<Relation>()
                .Property(e => e.mentioned_user_id)
                .HasPrecision(20, 0);

            modelBuilder.Entity<Relation>()
                .Property(e => e.tweet_id)
                .HasPrecision(20, 0);

            modelBuilder.Entity<Relation>()
                .Property(e => e.retweeted_tweet_id)
                .HasPrecision(20, 0);

            modelBuilder.Entity<Relation>()
                .Property(e => e.followed_user_id)
                .HasPrecision(20, 0);

            modelBuilder.Entity<TaskQueue>()
                .Property(e => e.id)
                .HasPrecision(20, 0);

            modelBuilder.Entity<test>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<Tweet>()
                .Property(e => e.id)
                .HasPrecision(20, 0);

            modelBuilder.Entity<Tweet>()
                .Property(e => e.user_id)
                .HasPrecision(20, 0);

            modelBuilder.Entity<Tweet>()
                .Property(e => e.text)
                .IsUnicode(false);

            modelBuilder.Entity<Tweet>()
                .Property(e => e.source)
                .IsUnicode(false);

            modelBuilder.Entity<Tweet>()
                .Property(e => e.media_info)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.id)
                .HasPrecision(20, 0);

            modelBuilder.Entity<User>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.screen_name)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.description)
                .IsUnicode(false);
        }
    }
}
