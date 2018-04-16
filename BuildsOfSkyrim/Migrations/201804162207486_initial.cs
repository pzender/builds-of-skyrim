namespace BuildsOfSkyrim.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Builds",
                c => new
                    {
                        BuildID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        StatHealth = c.Single(nullable: false),
                        StatMagicka = c.Single(nullable: false),
                        StatStamina = c.Single(nullable: false),
                        Description = c.String(),
                        ImgLink = c.String(),
                        Race_TraitID = c.Int(),
                        StandingStone_TraitID = c.Int(),
                    })
                .PrimaryKey(t => t.BuildID)
                .ForeignKey("dbo.CharacterTraits", t => t.Race_TraitID)
                .ForeignKey("dbo.CharacterTraits", t => t.StandingStone_TraitID)
                .Index(t => t.Race_TraitID)
                .Index(t => t.StandingStone_TraitID);
            
            CreateTable(
                "dbo.CharacterTraits",
                c => new
                    {
                        TraitID = c.Int(nullable: false, identity: true),
                        ModSet = c.String(),
                        Name = c.String(),
                        Description = c.String(),
                        TraitType = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TraitID);
            
            CreateTable(
                "dbo.Skills",
                c => new
                    {
                        SkillID = c.Int(nullable: false, identity: true),
                        Value = c.Int(nullable: false),
                        Name = c.String(),
                        ModSet = c.String(),
                        Build_BuildID = c.Int(),
                    })
                .PrimaryKey(t => t.SkillID)
                .ForeignKey("dbo.PerkTrees", t => t.SkillID)
                .ForeignKey("dbo.Builds", t => t.Build_BuildID)
                .Index(t => t.SkillID)
                .Index(t => t.Build_BuildID);
            
            CreateTable(
                "dbo.PerkTrees",
                c => new
                    {
                        TreeID = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.TreeID);
            
            CreateTable(
                "dbo.Connections",
                c => new
                    {
                        ConnectionID = c.Int(nullable: false, identity: true),
                        End_PerkID = c.Int(),
                        Start_PerkID = c.Int(),
                        PerkTree_TreeID = c.Int(),
                    })
                .PrimaryKey(t => t.ConnectionID)
                .ForeignKey("dbo.Perks", t => t.End_PerkID)
                .ForeignKey("dbo.Perks", t => t.Start_PerkID)
                .ForeignKey("dbo.PerkTrees", t => t.PerkTree_TreeID)
                .Index(t => t.End_PerkID)
                .Index(t => t.Start_PerkID)
                .Index(t => t.PerkTree_TreeID);
            
            CreateTable(
                "dbo.Perks",
                c => new
                    {
                        PerkID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        GraphX = c.Int(nullable: false),
                        GraphY = c.Int(nullable: false),
                        SkillLevelRequired = c.Int(nullable: false),
                        PerkTree_TreeID = c.Int(),
                        Skill_SkillID = c.Int(),
                    })
                .PrimaryKey(t => t.PerkID)
                .ForeignKey("dbo.PerkTrees", t => t.PerkTree_TreeID)
                .ForeignKey("dbo.Skills", t => t.Skill_SkillID)
                .Index(t => t.PerkTree_TreeID)
                .Index(t => t.Skill_SkillID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Builds", "StandingStone_TraitID", "dbo.CharacterTraits");
            DropForeignKey("dbo.Skills", "Build_BuildID", "dbo.Builds");
            DropForeignKey("dbo.Perks", "Skill_SkillID", "dbo.Skills");
            DropForeignKey("dbo.Skills", "SkillID", "dbo.PerkTrees");
            DropForeignKey("dbo.Perks", "PerkTree_TreeID", "dbo.PerkTrees");
            DropForeignKey("dbo.Connections", "PerkTree_TreeID", "dbo.PerkTrees");
            DropForeignKey("dbo.Connections", "Start_PerkID", "dbo.Perks");
            DropForeignKey("dbo.Connections", "End_PerkID", "dbo.Perks");
            DropForeignKey("dbo.Builds", "Race_TraitID", "dbo.CharacterTraits");
            DropIndex("dbo.Perks", new[] { "Skill_SkillID" });
            DropIndex("dbo.Perks", new[] { "PerkTree_TreeID" });
            DropIndex("dbo.Connections", new[] { "PerkTree_TreeID" });
            DropIndex("dbo.Connections", new[] { "Start_PerkID" });
            DropIndex("dbo.Connections", new[] { "End_PerkID" });
            DropIndex("dbo.Skills", new[] { "Build_BuildID" });
            DropIndex("dbo.Skills", new[] { "SkillID" });
            DropIndex("dbo.Builds", new[] { "StandingStone_TraitID" });
            DropIndex("dbo.Builds", new[] { "Race_TraitID" });
            DropTable("dbo.Perks");
            DropTable("dbo.Connections");
            DropTable("dbo.PerkTrees");
            DropTable("dbo.Skills");
            DropTable("dbo.CharacterTraits");
            DropTable("dbo.Builds");
        }
    }
}
