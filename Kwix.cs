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

            modelBuilder.Entity<test>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<Tweet>()
                .Property(e => e.text)
                .IsUnicode(false);

            modelBuilder.Entity<Tweet>()
                .Property(e => e.source)
                .IsUnicode(false);

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
                .Property(e => e.screen_name)
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
