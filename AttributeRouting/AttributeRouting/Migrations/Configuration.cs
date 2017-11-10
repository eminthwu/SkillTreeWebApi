namespace AttributeRouting.Migrations
{
    using AttributeRouting.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<AttributeRouting.Models.BookAPIContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(AttributeRouting.Models.BookAPIContext context)
        {
            context.Authors.AddOrUpdate(new Author[] {
                new Author() { AuthorId = 1, Name = "Chris Anderson" },
                new Author() { AuthorId = 2, Name = "Cole Nussbaumer Knaflic" },
                new Author() { AuthorId = 3, Name = "Jeff Patton " },
                new Author() { AuthorId = 4, Name = "John MacCormick" }
             });

            context.Books.AddOrUpdate(new Book[] {
            new Book() { BookId = 1,  Title= "TED TALKS 說話的力量", Genre = "溝通說話",
                PublishDate = new DateTime(2016, 06, 27), AuthorId = 1, Description =
                "你可以用言語來改變自己，也改變世界 TED唯一官方版演講指南（限量精裝版）", Price = 320 },
        new Book() { BookId = 2, Title = "尾理論", Genre = "經濟學",
            PublishDate = new DateTime(2009, 04, 30), AuthorId = 2, Description =
            "打破80/20法則，獲利無限延伸 (最新增訂版)", Price = 450 },
        new Book() { BookId = 3, Title = "Google必修的圖表簡報術", Genre = "演講/簡報",
            PublishDate = new DateTime(2016, 03, 26), AuthorId = 2, Description =
            "Google總監首度公開絕活，教你做對圖表、說對話，所有人都聽你的！", Price = 420 },
        new Book() { BookId = 4, Title = "使用者故事對照", Genre = "軟體工程",
            PublishDate = new DateTime(2016, 05, 10), AuthorId = 3, Description =
            "User Story Mapping", Price = 580 },
        new Book() { BookId = 5, Title = "改變世界的九大演算法", Genre = "觀念/趨勢",
            PublishDate = new DateTime(2014, 08, 07), AuthorId = 4, Description =
            "讓今日電腦無所不能的最強概念", Price = 360}
    });
        }
    }
}
